using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace MatchingHelper
{
    public partial class FormMain : KryptonForm
    {
        // 每段落内, 编号行的索引
        private const int NUM_INDEX_IN_SECTION = 0;
        // 相似度按钮调节步长
        private const int TRACE_STEP = 10;

        private FormWriting frmWrite = new FormWriting();
        private List<string[]> sections;
        private string[] sourceNums, targetNums;
        private string error_WorkForNewTxt;

        public FormMain()
        {
            InitializeComponent();
        }

        #region Events

        private void krbtnOpenFile_Click(object sender, EventArgs e)
        {
            string currFileName = this.openFileDialog1.FileName;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.krtxtFileName.Text = this.openFileDialog1.FileName;
                this.tsslStatus.Text = string.Format("已选文档: {0}", this.openFileDialog1.SafeFileName);
                // 每次新选文档之後，清空当前分析结果（以免造成“文不对题”的现象）
                if (currFileName != this.openFileDialog1.FileName)
                {
                    GridClear();
                }
            }
        }

        private void krtraceDegree_ValueChanged(object sender, EventArgs e)
        {
            this.krlblDegree.Text = string.Format("{0}%", this.krtraceDegree.Value);
        }

        private void krbtnMatching_Click(object sender, EventArgs e)
        {
            KryptonButton krbtn = sender as KryptonButton;

            if (!string.IsNullOrEmpty(this.krtxtFileName.Text))
            {
                GridClear();

                krbtn.Enabled = false;
                this.krtraceDegree.Enabled = false;
                this.krbtnMinus.Enabled = false;
                this.krbtnPlus.Enabled = false;
                this.krbtnNewTXT.Enabled = false;
                this.krbtnOpenFile.Enabled = false;

                this.tsslStatus.Text = "正在分析..";
                this.pictureBox1.Visible = this.pictureBox2.Visible = true;
                this.backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                this.tsslStatus.Text = string.Format("已点击[{0}]按钮. 因尚未选择文档, 操作无效.", krbtn.Text);
            }
        }

        private void krbtnNewTXT_Click(object sender, EventArgs e)
        {
            if (this.krdgvResult.Rows.Count > 0)
            {
                // 以选择的文档的文件名最为基础默认生成一个新文件名
                string currFileNameWithExt = this.openFileDialog1.SafeFileName;
                string currFileName = currFileNameWithExt.Substring(0, currFileNameWithExt.Length - 4); // 后缀.txt的长度为4
                this.saveFileDialog1.FileName = currFileName + "(2)";   // 默认新文件名为当前文件名尾部加字符“(2)”.
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.tsslStatus.Text = "正在生成新文档..";
                    frmWrite.Show();
                    this.backgroundWorker2.RunWorkerAsync();
                }
            }
            else
            {
                KryptonButton krbtn = sender as KryptonButton;
                this.tsslStatus.Text = string.Format("已点击[{0}]按钮. 因无分析数据, 操作无效.", krbtn.Text);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Exit();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            this.sections = null;
            this.sourceNums = null;
            this.targetNums = null;

            // 自动检测当前合适的编码方案
            Queue encodingNames = GetEncodingNames();
            Encoding enc = DetectEncoding(this.krtxtFileName.Text, encodingNames);
            if (enc == null)
            {
                this.tsslStatus.Text = "Error：文本内容无法识别。建议：将该文档用Windows记事本(Notepad)打开，然后直接保存。再来重试。";
            }
            else
            {
                this.sections = ReadTXT(this.krtxtFileName.Text, enc);
                Match();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MatchResultShow();
            this.pictureBox1.Visible = this.pictureBox2.Visible = false;
            this.krbtnOpenFile.Enabled = true;
            this.krbtnMatching.Enabled = true;
            this.krtraceDegree.Enabled = true;
            this.krbtnMinus.Enabled = true;
            this.krbtnPlus.Enabled = true;
            this.krbtnNewTXT.Enabled = true;
            if (!this.tsslStatus.Text.StartsWith("Error"))
            {
                this.tsslStatus.Text = "分析完毕.";
            }
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            NewTXT(this.saveFileDialog1.FileName);
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            frmWrite.Hide();
            if (string.IsNullOrEmpty(this.error_WorkForNewTxt))
            {
                FormWritingDone frmWDone = new FormWritingDone();
                frmWDone.Show();
                this.tsslStatus.Text = "生成新档成功.";
            }
            else
            {
                this.tsslStatus.Text = "生成新档失败.";
                MessageBox.Show(this.error_WorkForNewTxt, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void krbtnMinus_Click(object sender, EventArgs e)
        {
            int newDegree = krtraceDegree.Value - TRACE_STEP;
            krtraceDegree.Value = newDegree > krtraceDegree.Minimum
                ? newDegree
                : krtraceDegree.Minimum;
        }

        private void krbtnPlus_Click(object sender, EventArgs e)
        {
            int newDegree = krtraceDegree.Value + TRACE_STEP;
            krtraceDegree.Value = newDegree < krtraceDegree.Maximum
                ? newDegree
                : krtraceDegree.Maximum;
        }

        #endregion

        #region Methods

        private void GridClear()
        {
            if (this.krdgvResult.DataSource != null)
            {
                DataTable dtCurr = (DataTable)this.krdgvResult.DataSource;
                dtCurr.Rows.Clear();
                this.krdgvResult.DataSource = dtCurr;
            }
        }

        private void NewTXT(string filePath)
        {
            try
            {
                this.error_WorkForNewTxt = string.Empty;
                List<string> numsWritten = new List<string>();

                using (StreamWriter sw = new StreamWriter(filePath, append: false, encoding: Encoding.UTF8))
                {
                    // 将有匹配的的编号段落写在文档的前面
                    // 因为源编号数组与目标编号数组为平行数组, 所以只需要循环源编号数组
                    for (int i = 0; i < this.krdgvResult.Rows.Count; i++)
                    {
                        DataGridViewRow row = this.krdgvResult.Rows[i];
                        string currSourceNum = row.Cells[0].Value.ToString();
                        string currTargetNum = row.Cells[1].Value.ToString();

                        if (numsWritten.Contains(currSourceNum))
                        {
                            continue;
                        }

                        // 将查询到的当前编号的段落先写入文档
                        string[] sourceSection =
                            this.sections.Single(p => Convert.ToString(p.GetValue(NUM_INDEX_IN_SECTION)) == currSourceNum);
                        foreach (var line in sourceSection)
                        {
                            sw.WriteLine(line);
                        }

                        numsWritten.Add(currSourceNum);

                        // 然后再紧接著写入与该源编号匹配的目标编号的段落
                        string[] targetNumArray = currTargetNum.Split(',');
                        foreach (var targetNum in targetNumArray)
                        {
                            // 如果当前目标编号已经被写过， 则跳过。
                            if (numsWritten.Contains(targetNum.TrimStart()))
                            {
                                continue;
                            }

                            string[] targetSection = this.sections.Single(p => p.GetValue(NUM_INDEX_IN_SECTION).ToString() == targetNum.TrimStart());
                            foreach (var line in targetSection)
                            {
                                sw.WriteLine(line);
                            }

                            numsWritten.Add(targetNum.TrimStart());
                        }
                    }

                    // 然后写入剩下的没有相似匹配的段落
                    foreach (var section in this.sections)
                    {
                        if (!numsWritten.Contains(section[NUM_INDEX_IN_SECTION]))
                        {
                            foreach (var line in section)
                            {
                                sw.WriteLine(line);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.error_WorkForNewTxt = ex.Message;
            }
        }

        private List<string[]> ReadTXT(string fileName, Encoding enc)
        {
            using (StreamReader sr = new StreamReader(fileName, enc))
            {
                /*
                 每段落为7行.
                 第1行: 编号.
                 第2行: 标题.
                 第3行: 空行(标题译文)
                 第4行: 正文
                 第5行: 空行(正文译文)
                 第6行: 空行
                 第7行: 空行
                */

                // 段落内行号上限
                const int MAX_LINE_NUMBER_IN_SECTION = 7;
                // 允许的连续空行数上限
                const int MAX_EMPTY_LINE_COUNT = 3;

                // 文档分成各段落存储于一个字符串数组列表
                List<string[]> sections = new List<string[]>();
                // 每段保存为一个字符串数组, 每行即是一个元素
                string[] section = new string[MAX_LINE_NUMBER_IN_SECTION];
                // 读取的行
                string line;
                // 内部行索引
                int lineIndexInSection = 0;
                // 连续空行数
                int emptyLineCount = 0;


                while (true)
                {
                    line = sr.ReadLine();

                    emptyLineCount = string.IsNullOrEmpty(line)
                        ? emptyLineCount + 1
                        : 0;    // 连续空行数归零

                    if (emptyLineCount > MAX_EMPTY_LINE_COUNT)
                    {
                        // 标准文档中上一段落末行与下一段落首行间隔为3行.
                        // 所以如果读取到空字符行, 连续出现3次以上, 则可以判断文档已结束.
                        break;
                    }

                    section[lineIndexInSection] = line;
                    lineIndexInSection++;

                    // 当行内索引达到上限时, 归零.
                    // 同时意味著段落结束, 将当前段落添加进列表中
                    if (lineIndexInSection == MAX_LINE_NUMBER_IN_SECTION)
                    {
                        lineIndexInSection = 0;
                        sections.Add(section);
                        // 每次新实例化一个段落数组用于下一段的读取操作.
                        // 否则, 最终每段落数组因引用相同, 导致所有数据一样.
                        section = new string[MAX_LINE_NUMBER_IN_SECTION];
                    }
                }

                return sections;
            }
        }

        private void Match()
        {
            if (this.sections.Count == 0)
            {
                return;
            }
            else
            {
                this.sourceNums = new string[this.sections.Count];
                this.targetNums = new string[this.sections.Count];
            }

            LevenshteinDistance ld = new LevenshteinDistance();
            string sectionNum, sectionContent;
            int index = 0;
            foreach (var section in sections)
            {
                sectionNum = section[0];
                sectionContent = section[3];

                sourceNums[index] = sectionNum;
                foreach (var item in sections)
                {
                    if (item[0] == sectionNum)  // 跳过本身
                    {
                        continue;
                    }

                    decimal similarityDegree = ld.LevenshteinDistancePercent(sectionContent, item[3]) * 100;
                    if (similarityDegree >= this.krtraceDegree.Value)
                    {
                        targetNums[index] = string.IsNullOrEmpty(targetNums[index])
                            ? item[0]
                            : targetNums[index] + ", " + item[0];
                    }
                }
                index++;
            }
        }

        private void MatchResultShow()
        {
            DataTable tblResult = new DataTable();
            const string colName1 = "SourceNum",
                         colName2 = "TargetNum";
            tblResult.Columns.Add(colName1, typeof(string));
            tblResult.Columns.Add(colName2, typeof(string));

            if (this.sourceNums != null && this.targetNums != null)
            {
                for (int i = 0; i < this.sourceNums.Length; i++)
                {
                    if (string.IsNullOrEmpty(this.targetNums[i]))
                    {
                        continue;
                    }
                    DataRow newRow = tblResult.NewRow();
                    newRow[colName1] = sourceNums[i];
                    newRow[colName2] = targetNums[i];   // 平行数组

                    tblResult.Rows.Add(newRow);
                }
            }

            if (tblResult.Rows.Count == 0)
            {
                DataRow newRow = tblResult.NewRow();
                newRow[colName1] = "None";
                newRow[colName2] = "None";
                tblResult.Rows.Add(newRow);
            }
            this.krdgvResult.DataSource = tblResult;
        }

        private Queue GetEncodingNames()
        {
            Queue q = new Queue();
            q.Enqueue("GB2312");
            q.Enqueue("GBK");
            q.Enqueue("UTF-8");
            q.Enqueue("UTF-16");

            return q;
        }

        /// <summary>
        /// 利用异常回退机制侦测出最合适的编码
        /// </summary>
        /// <param name="fileName">待读取的文件</param>
        /// <param name="encodingNames">编码队列集合</param>
        /// <returns>返回侦测到的最适合的编码</returns>
        private Encoding DetectEncoding(string fileName, Queue encodingNames)
        {
            // 队列的机制使得该方法可以递归实现自动检测
            string encodingName = encodingNames.Dequeue().ToString();
            Encoding enc = Encoding.GetEncoding(encodingName, new EncoderExceptionFallback(), new DecoderExceptionFallback());
            using (StreamReader sr = new StreamReader(fileName, enc))
            {
                try
                {
                    sr.ReadToEnd();
                    // 如果未出现异常， 则表明已侦测到匹配的编码。
                    return enc;
                }
                catch (DecoderFallbackException)
                {
                    // 递归调用, 通过编码队列是否还有元素做为跳出条件
                    if (encodingNames.Count > 0)
                    {
                        return DetectEncoding(fileName, encodingNames);
                    }
                    else
                    {
                        // 如果内置的编码方案都不匹配， 返回null表明没侦测到编码。
                        return null;
                    }
                }
            }
        }

        private void Exit()
        {
            this.pictureBox1.Visible = this.pictureBox2.Visible = false;
            FormExit frmExit = new FormExit();
            frmExit.ShowDialog();
        }

        #endregion
    }
}