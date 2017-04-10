namespace QiniuTool
{
    partial class WatermarkWindow
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
            this.textBoxWatermark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFontSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonColor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxYPos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxXPos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxWatermark
            // 
            this.textBoxWatermark.Location = new System.Drawing.Point(50, 10);
            this.textBoxWatermark.Name = "textBoxWatermark";
            this.textBoxWatermark.Size = new System.Drawing.Size(122, 21);
            this.textBoxWatermark.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "内容";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "字号";
            // 
            // textBoxFontSize
            // 
            this.textBoxFontSize.Location = new System.Drawing.Point(50, 70);
            this.textBoxFontSize.Name = "textBoxFontSize";
            this.textBoxFontSize.Size = new System.Drawing.Size(122, 21);
            this.textBoxFontSize.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "字体";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "颜色";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxFont);
            this.panel1.Controls.Add(this.buttonColor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxWatermark);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxFontSize);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 136);
            this.panel1.TabIndex = 6;
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(50, 99);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 6;
            this.buttonColor.Text = "选择";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxYPos);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxXPos);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(208, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 100);
            this.panel2.TabIndex = 7;
            // 
            // textBoxYPos
            // 
            this.textBoxYPos.Location = new System.Drawing.Point(37, 54);
            this.textBoxYPos.Name = "textBoxYPos";
            this.textBoxYPos.Size = new System.Drawing.Size(38, 21);
            this.textBoxYPos.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Y";
            // 
            // textBoxXPos
            // 
            this.textBoxXPos.Location = new System.Drawing.Point(37, 15);
            this.textBoxXPos.Name = "textBoxXPos";
            this.textBoxXPos.Size = new System.Drawing.Size(38, 21);
            this.textBoxXPos.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "X";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(208, 125);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 8;
            this.buttonGenerate.Text = "添加水印";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(51, 44);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFont.TabIndex = 7;
            // 
            // WatermarkWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 168);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "WatermarkWindow";
            this.Text = "水印";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWatermark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFontSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxYPos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxXPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ComboBox comboBoxFont;
    }
}