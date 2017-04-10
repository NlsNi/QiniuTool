namespace QiniuTool
{
    partial class SettingWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAK = new System.Windows.Forms.TextBox();
            this.textBoxSK = new System.Windows.Forms.TextBox();
            this.comboBoxBuckets = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "AK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "SK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bucket";
            // 
            // textBoxAK
            // 
            this.textBoxAK.Location = new System.Drawing.Point(74, 15);
            this.textBoxAK.Name = "textBoxAK";
            this.textBoxAK.Size = new System.Drawing.Size(121, 21);
            this.textBoxAK.TabIndex = 3;
            // 
            // textBoxSK
            // 
            this.textBoxSK.Location = new System.Drawing.Point(74, 45);
            this.textBoxSK.Name = "textBoxSK";
            this.textBoxSK.Size = new System.Drawing.Size(121, 21);
            this.textBoxSK.TabIndex = 4;
            this.textBoxSK.TextChanged += new System.EventHandler(this.textBoxSK_TextChanged);
            // 
            // comboBoxBuckets
            // 
            this.comboBoxBuckets.FormattingEnabled = true;
            this.comboBoxBuckets.Location = new System.Drawing.Point(74, 75);
            this.comboBoxBuckets.Name = "comboBoxBuckets";
            this.comboBoxBuckets.Size = new System.Drawing.Size(121, 20);
            this.comboBoxBuckets.TabIndex = 5;
            
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(74, 102);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "保存配置";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 137);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxBuckets);
            this.Controls.Add(this.textBoxSK);
            this.Controls.Add(this.textBoxAK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SettingWindow";
            this.Text = "设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAK;
        private System.Windows.Forms.TextBox textBoxSK;
        private System.Windows.Forms.ComboBox comboBoxBuckets;
        private System.Windows.Forms.Button buttonSave;
    }
}