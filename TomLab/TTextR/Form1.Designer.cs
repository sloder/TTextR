namespace TTextR
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.opfPath = new System.Windows.Forms.OpenFileDialog();
            this.btSelect = new System.Windows.Forms.Button();
            this.tbExt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFindText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFileNum = new System.Windows.Forms.Label();
            this.btFileCount = new System.Windows.Forms.Button();
            this.btReplace = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbReplaceText = new System.Windows.Forms.TextBox();
            this.cbRE = new System.Windows.Forms.CheckBox();
            this.tbIncludeText = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.cbInclude = new System.Windows.Forms.CheckBox();
            this.lbFilePaths = new System.Windows.Forms.Label();
            this.fbdFloder = new System.Windows.Forms.FolderBrowserDialog();
            this.cbFloder = new System.Windows.Forms.CheckBox();
            this.cbReInclude = new System.Windows.Forms.CheckBox();
            this.pbWait = new System.Windows.Forms.PictureBox();
            this.btAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).BeginInit();
            this.SuspendLayout();
            // 
            // opfPath
            // 
            this.opfPath.Multiselect = true;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(305, 12);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 23);
            this.btSelect.TabIndex = 0;
            this.btSelect.Text = "文件选择";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // tbExt
            // 
            this.tbExt.Location = new System.Drawing.Point(94, 46);
            this.tbExt.Name = "tbExt";
            this.tbExt.Size = new System.Drawing.Size(314, 21);
            this.tbExt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "扩展名过滤";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "查找";
            // 
            // tbFindText
            // 
            this.tbFindText.Location = new System.Drawing.Point(94, 74);
            this.tbFindText.Name = "tbFindText";
            this.tbFindText.Size = new System.Drawing.Size(261, 21);
            this.tbFindText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "文件数:";
            // 
            // lbFileNum
            // 
            this.lbFileNum.AutoSize = true;
            this.lbFileNum.Location = new System.Drawing.Point(76, 195);
            this.lbFileNum.Name = "lbFileNum";
            this.lbFileNum.Size = new System.Drawing.Size(11, 12);
            this.lbFileNum.TabIndex = 6;
            this.lbFileNum.Text = "0";
            // 
            // btFileCount
            // 
            this.btFileCount.Location = new System.Drawing.Point(188, 184);
            this.btFileCount.Name = "btFileCount";
            this.btFileCount.Size = new System.Drawing.Size(67, 23);
            this.btFileCount.TabIndex = 7;
            this.btFileCount.Text = "文件查找";
            this.btFileCount.UseVisualStyleBackColor = true;
            this.btFileCount.Click += new System.EventHandler(this.btFileCount_Click);
            // 
            // btReplace
            // 
            this.btReplace.Location = new System.Drawing.Point(271, 184);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(75, 23);
            this.btReplace.TabIndex = 8;
            this.btReplace.Text = "替换";
            this.btReplace.UseVisualStyleBackColor = true;
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "替换";
            // 
            // tbReplaceText
            // 
            this.tbReplaceText.Location = new System.Drawing.Point(94, 101);
            this.tbReplaceText.Name = "tbReplaceText";
            this.tbReplaceText.Size = new System.Drawing.Size(261, 21);
            this.tbReplaceText.TabIndex = 10;
            // 
            // cbRE
            // 
            this.cbRE.AutoSize = true;
            this.cbRE.Location = new System.Drawing.Point(362, 76);
            this.cbRE.Name = "cbRE";
            this.cbRE.Size = new System.Drawing.Size(84, 16);
            this.cbRE.TabIndex = 11;
            this.cbRE.Text = "正则表达式";
            this.cbRE.UseVisualStyleBackColor = true;
            // 
            // tbIncludeText
            // 
            this.tbIncludeText.Enabled = false;
            this.tbIncludeText.Location = new System.Drawing.Point(94, 129);
            this.tbIncludeText.Multiline = true;
            this.tbIncludeText.Name = "tbIncludeText";
            this.tbIncludeText.Size = new System.Drawing.Size(333, 49);
            this.tbIncludeText.TabIndex = 14;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(-1, 210);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(449, 175);
            this.tbMessage.TabIndex = 15;
            // 
            // cbInclude
            // 
            this.cbInclude.AutoSize = true;
            this.cbInclude.Location = new System.Drawing.Point(43, 140);
            this.cbInclude.Name = "cbInclude";
            this.cbInclude.Size = new System.Drawing.Size(48, 16);
            this.cbInclude.TabIndex = 16;
            this.cbInclude.Text = "包含";
            this.cbInclude.UseVisualStyleBackColor = true;
            this.cbInclude.CheckedChanged += new System.EventHandler(this.cbInclude_CheckedChanged);
            // 
            // lbFilePaths
            // 
            this.lbFilePaths.Location = new System.Drawing.Point(23, 17);
            this.lbFilePaths.Name = "lbFilePaths";
            this.lbFilePaths.Size = new System.Drawing.Size(276, 18);
            this.lbFilePaths.TabIndex = 17;
            // 
            // fbdFloder
            // 
            this.fbdFloder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // cbFloder
            // 
            this.cbFloder.AutoSize = true;
            this.cbFloder.Location = new System.Drawing.Point(386, 17);
            this.cbFloder.Name = "cbFloder";
            this.cbFloder.Size = new System.Drawing.Size(60, 16);
            this.cbFloder.TabIndex = 18;
            this.cbFloder.Text = "文件夹";
            this.cbFloder.UseVisualStyleBackColor = true;
            // 
            // cbReInclude
            // 
            this.cbReInclude.AutoSize = true;
            this.cbReInclude.Enabled = false;
            this.cbReInclude.Location = new System.Drawing.Point(43, 162);
            this.cbReInclude.Name = "cbReInclude";
            this.cbReInclude.Size = new System.Drawing.Size(48, 16);
            this.cbReInclude.TabIndex = 19;
            this.cbReInclude.Text = "正则";
            this.cbReInclude.UseVisualStyleBackColor = true;
            // 
            // pbWait
            // 
            this.pbWait.Image = ((System.Drawing.Image)(resources.GetObject("pbWait.Image")));
            this.pbWait.InitialImage = null;
            this.pbWait.Location = new System.Drawing.Point(201, 73);
            this.pbWait.Name = "pbWait";
            this.pbWait.Size = new System.Drawing.Size(75, 68);
            this.pbWait.TabIndex = 20;
            this.pbWait.TabStop = false;
            this.pbWait.Visible = false;
            // 
            // btAbout
            // 
            this.btAbout.Location = new System.Drawing.Point(409, 184);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(37, 23);
            this.btAbout.TabIndex = 21;
            this.btAbout.Text = "关于";
            this.btAbout.UseVisualStyleBackColor = true;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 388);
            this.Controls.Add(this.btAbout);
            this.Controls.Add(this.pbWait);
            this.Controls.Add(this.cbReInclude);
            this.Controls.Add(this.cbFloder);
            this.Controls.Add(this.lbFilePaths);
            this.Controls.Add(this.cbInclude);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbIncludeText);
            this.Controls.Add(this.cbRE);
            this.Controls.Add(this.tbReplaceText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.btFileCount);
            this.Controls.Add(this.lbFileNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFindText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbExt);
            this.Controls.Add(this.btSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量替换小工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog opfPath;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.TextBox tbExt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFindText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbFileNum;
        private System.Windows.Forms.Button btFileCount;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbReplaceText;
        private System.Windows.Forms.CheckBox cbRE;
        private System.Windows.Forms.TextBox tbIncludeText;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.CheckBox cbInclude;
        private System.Windows.Forms.Label lbFilePaths;
        private System.Windows.Forms.FolderBrowserDialog fbdFloder;
        private System.Windows.Forms.CheckBox cbFloder;
        private System.Windows.Forms.CheckBox cbReInclude;
        private System.Windows.Forms.PictureBox pbWait;
        private System.Windows.Forms.Button btAbout;
    }
}

