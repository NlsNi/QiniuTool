﻿namespace QiniuTool
{
    partial class QiniuGui
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonWatch = new System.Windows.Forms.Button();
            this.textBoxWatch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonPic = new System.Windows.Forms.Button();
            this.textBoxPic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonUrl = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBucket = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBucket);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonUpload);
            this.groupBox1.Controls.Add(this.buttonWatch);
            this.groupBox1.Controls.Add(this.textBoxWatch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.buttonPic);
            this.groupBox1.Controls.Add(this.textBoxPic);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单文件上传";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(287, 21);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(51, 96);
            this.buttonUpload.TabIndex = 6;
            this.buttonUpload.Text = "上传";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonWatch
            // 
            this.buttonWatch.Location = new System.Drawing.Point(232, 57);
            this.buttonWatch.Name = "buttonWatch";
            this.buttonWatch.Size = new System.Drawing.Size(49, 23);
            this.buttonWatch.TabIndex = 5;
            this.buttonWatch.Text = "浏览";
            this.buttonWatch.UseVisualStyleBackColor = true;
            this.buttonWatch.Click += new System.EventHandler(this.buttonWatch_Click);
            // 
            // textBoxWatch
            // 
            this.textBoxWatch.Location = new System.Drawing.Point(65, 58);
            this.textBoxWatch.Name = "textBoxWatch";
            this.textBoxWatch.Size = new System.Drawing.Size(159, 21);
            this.textBoxWatch.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "监测路径";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(8, 153);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(330, 200);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.DoubleClick += new System.EventHandler(this.buttonPic_Click);
            // 
            // buttonPic
            // 
            this.buttonPic.Location = new System.Drawing.Point(232, 21);
            this.buttonPic.Name = "buttonPic";
            this.buttonPic.Size = new System.Drawing.Size(49, 23);
            this.buttonPic.TabIndex = 2;
            this.buttonPic.Text = "浏览";
            this.buttonPic.UseVisualStyleBackColor = true;
            this.buttonPic.Click += new System.EventHandler(this.buttonPic_Click);
            // 
            // textBoxPic
            // 
            this.textBoxPic.Location = new System.Drawing.Point(65, 22);
            this.textBoxPic.Name = "textBoxPic";
            this.textBoxPic.Size = new System.Drawing.Size(159, 21);
            this.textBoxPic.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图片路径";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 374);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(687, 22);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(20, 17);
            this.toolStripStatusLabel1.Text = "   ";
            // 
            // buttonUrl
            // 
            this.buttonUrl.Location = new System.Drawing.Point(244, 104);
            this.buttonUrl.Name = "buttonUrl";
            this.buttonUrl.Size = new System.Drawing.Size(49, 23);
            this.buttonUrl.TabIndex = 6;
            this.buttonUrl.Text = "复制";
            this.buttonUrl.UseVisualStyleBackColor = true;
            this.buttonUrl.Click += new System.EventHandler(this.buttonUrl_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(77, 105);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(159, 21);
            this.textBoxUrl.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "外链地址";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(362, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 358);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图片列表";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 20);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(301, 332);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bucket";
            // 
            // textBoxBucket
            // 
            this.textBoxBucket.Location = new System.Drawing.Point(65, 126);
            this.textBoxBucket.Name = "textBoxBucket";
            this.textBoxBucket.Size = new System.Drawing.Size(159, 21);
            this.textBoxBucket.TabIndex = 8;
            // 
            // QiniuGui
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonUrl);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox1);
            this.Name = "QiniuGui";
            this.Text = "七牛上传工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox textBoxPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPic;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonUrl;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonWatch;
        private System.Windows.Forms.TextBox textBoxWatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBucket;
        private System.Windows.Forms.Label label4;
    }
}

