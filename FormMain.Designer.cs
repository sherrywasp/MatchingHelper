namespace MatchingHelper
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.krtxtFileName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.krbtnOpenFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.krbtnMatching = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.krdgvResult = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.krtraceDegree = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.krbtnNewTXT = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.krbtnPlus = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.krbtnMinus = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.krlblDegree = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.krdgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(68, 21);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "文本路径:";
            // 
            // krtxtFileName
            // 
            this.krtxtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.krtxtFileName.Location = new System.Drawing.Point(86, 12);
            this.krtxtFileName.Name = "krtxtFileName";
            this.krtxtFileName.ReadOnly = true;
            this.krtxtFileName.Size = new System.Drawing.Size(470, 24);
            this.krtxtFileName.StateCommon.Content.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.krtxtFileName.TabIndex = 1;
            // 
            // krbtnOpenFile
            // 
            this.krbtnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.krbtnOpenFile.Location = new System.Drawing.Point(562, 11);
            this.krbtnOpenFile.Name = "krbtnOpenFile";
            this.krbtnOpenFile.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.krbtnOpenFile.Size = new System.Drawing.Size(60, 25);
            this.krbtnOpenFile.TabIndex = 2;
            this.toolTip1.SetToolTip(this.krbtnOpenFile, "选择待分析的文本。");
            this.krbtnOpenFile.Values.Image = global::MatchingHelper.Properties.Resources.page_find;
            this.krbtnOpenFile.Values.Text = "选择..";
            this.krbtnOpenFile.Click += new System.EventHandler(this.krbtnOpenFile_Click);
            // 
            // krbtnMatching
            // 
            this.krbtnMatching.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.krbtnMatching.Location = new System.Drawing.Point(392, 401);
            this.krbtnMatching.Name = "krbtnMatching";
            this.krbtnMatching.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.krbtnMatching.Size = new System.Drawing.Size(112, 25);
            this.krbtnMatching.TabIndex = 3;
            this.toolTip1.SetToolTip(this.krbtnMatching, "分析文档中各段落文本, \r\n将相似的文本的段落编号\r\n并列于\"分析结果\"表格中。");
            this.krbtnMatching.Values.Image = global::MatchingHelper.Properties.Resources.magnifier;
            this.krbtnMatching.Values.Text = "开始分析";
            this.krbtnMatching.Click += new System.EventHandler(this.krbtnMatching_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(42, 17);
            this.tsslStatus.Text = "Ready.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "文本文档|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "文本文档|*.txt";
            // 
            // krdgvResult
            // 
            this.krdgvResult.AllowUserToAddRows = false;
            this.krdgvResult.AllowUserToDeleteRows = false;
            this.krdgvResult.AllowUserToResizeRows = false;
            this.krdgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.krdgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.krdgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.krdgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.krdgvResult.Location = new System.Drawing.Point(12, 69);
            this.krdgvResult.Name = "krdgvResult";
            this.krdgvResult.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.krdgvResult.ReadOnly = true;
            this.krdgvResult.RowHeadersVisible = false;
            this.krdgvResult.RowTemplate.Height = 23;
            this.krdgvResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.krdgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.krdgvResult.Size = new System.Drawing.Size(610, 325);
            this.krdgvResult.StateCommon.Background.Color1 = System.Drawing.Color.WhiteSmoke;
            this.krdgvResult.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.krdgvResult.StateCommon.Background.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.krdgvResult.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.krdgvResult.StateCommon.HeaderColumn.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.krdgvResult.StateCommon.HeaderColumn.Content.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.krdgvResult.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "SourceNum";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "源编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TargetNum";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "匹配编号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 42);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(88, 21);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "--分析结果--";
            // 
            // krtraceDegree
            // 
            this.krtraceDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.krtraceDegree.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCalendarDay;
            this.krtraceDegree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krtraceDegree.DrawBackground = true;
            this.krtraceDegree.LargeChange = 0;
            this.krtraceDegree.Location = new System.Drawing.Point(138, 399);
            this.krtraceDegree.Maximum = 90;
            this.krtraceDegree.Minimum = 10;
            this.krtraceDegree.Name = "krtraceDegree";
            this.krtraceDegree.Size = new System.Drawing.Size(152, 27);
            this.krtraceDegree.SmallChange = 0;
            this.krtraceDegree.TabIndex = 11;
            this.krtraceDegree.TickFrequency = 10;
            this.toolTip1.SetToolTip(this.krtraceDegree, "设置分析时最低相似比例要求。");
            this.krtraceDegree.Value = 50;
            this.krtraceDegree.ValueChanged += new System.EventHandler(this.krtraceDegree_ValueChanged);
            // 
            // krbtnNewTXT
            // 
            this.krbtnNewTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.krbtnNewTXT.Location = new System.Drawing.Point(510, 401);
            this.krbtnNewTXT.Name = "krbtnNewTXT";
            this.krbtnNewTXT.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.krbtnNewTXT.Size = new System.Drawing.Size(112, 25);
            this.krbtnNewTXT.TabIndex = 15;
            this.toolTip1.SetToolTip(this.krbtnNewTXT, "按照分析结果重新编排文档内容。\r\n(相似的段落按表中编号顺序排列在一起)");
            this.krbtnNewTXT.Values.Image = global::MatchingHelper.Properties.Resources.page_white_text;
            this.krbtnNewTXT.Values.Text = "生成新档";
            this.krbtnNewTXT.Click += new System.EventHandler(this.krbtnNewTXT_Click);
            // 
            // krbtnPlus
            // 
            this.krbtnPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.krbtnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krbtnPlus.Location = new System.Drawing.Point(296, 407);
            this.krbtnPlus.Name = "krbtnPlus";
            this.krbtnPlus.Size = new System.Drawing.Size(16, 16);
            this.krbtnPlus.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.krbtnPlus.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.krbtnPlus.StateCommon.Back.Image = global::MatchingHelper.Properties.Resources.magnifier_zoom_in;
            this.krbtnPlus.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.krbtnPlus.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.krbtnPlus.StateCommon.Border.Width = 0;
            this.krbtnPlus.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbtnPlus.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.krbtnPlus.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.krbtnPlus.TabIndex = 18;
            this.toolTip1.SetToolTip(this.krbtnPlus, "增加10%");
            this.krbtnPlus.Values.Text = "";
            this.krbtnPlus.Click += new System.EventHandler(this.krbtnPlus_Click);
            // 
            // krbtnMinus
            // 
            this.krbtnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.krbtnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krbtnMinus.Location = new System.Drawing.Point(116, 407);
            this.krbtnMinus.Name = "krbtnMinus";
            this.krbtnMinus.Size = new System.Drawing.Size(16, 16);
            this.krbtnMinus.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.krbtnMinus.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.krbtnMinus.StateCommon.Back.Image = global::MatchingHelper.Properties.Resources.magnifier_zoom_out;
            this.krbtnMinus.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.krbtnMinus.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.krbtnMinus.StateCommon.Border.Width = 0;
            this.krbtnMinus.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbtnMinus.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.krbtnMinus.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.krbtnMinus.TabIndex = 18;
            this.toolTip1.SetToolTip(this.krbtnMinus, "减少10%");
            this.krbtnMinus.Values.Text = "";
            this.krbtnMinus.Click += new System.EventHandler(this.krbtnMinus_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 404);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(54, 21);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel3.TabIndex = 12;
            this.kryptonLabel3.Values.Text = "相似度:";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // krlblDegree
            // 
            this.krlblDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.krlblDegree.Location = new System.Drawing.Point(72, 404);
            this.krlblDegree.Name = "krlblDegree";
            this.krlblDegree.Size = new System.Drawing.Size(38, 21);
            this.krlblDegree.StateCommon.ShortText.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.krlblDegree.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.krlblDegree.TabIndex = 12;
            this.krlblDegree.Values.Text = "50%";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.pictureBox2.Image = global::MatchingHelper.Properties.Resources.processing2;
            this.pictureBox2.Location = new System.Drawing.Point(265, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 25);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.pictureBox1.Image = global::MatchingHelper.Properties.Resources.processing;
            this.pictureBox1.Location = new System.Drawing.Point(265, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(634, 452);
            this.Controls.Add(this.krbtnMinus);
            this.Controls.Add(this.krbtnPlus);
            this.Controls.Add(this.krbtnNewTXT);
            this.Controls.Add(this.krlblDegree);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.krtraceDegree);
            this.Controls.Add(this.krbtnMatching);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.krdgvResult);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.krbtnOpenFile);
            this.Controls.Add(this.krtxtFileName);
            this.Controls.Add(this.kryptonLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "专利任务包分析助手 2.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.krdgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox krtxtFileName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton krbtnOpenFile;
        private ComponentFactory.Krypton.Toolkit.KryptonButton krbtnMatching;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView krdgvResult;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar krtraceDegree;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton krbtnNewTXT;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel krlblDegree;
        private ComponentFactory.Krypton.Toolkit.KryptonButton krbtnPlus;
        private ComponentFactory.Krypton.Toolkit.KryptonButton krbtnMinus;

    }
}