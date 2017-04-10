using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QiniuTool
{

   
    public partial class WatermarkWindow : Form
    {
        public WatermarkWindow()
        {
            InitializeComponent();
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            FontFamily[] fontFamily = installedFontCollection.Families;
            foreach (FontFamily font in fontFamily)
            {
                this.comboBoxFont.Items.Add(font.Name);
                this.comboBoxFont.SelectedIndex = 0;
            }
        }
        public delegate void delgateWatermark(string text, Font font, int PosX, int PosY, Color color);
        public event delgateWatermark addWaterMarkEvent;
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string text = this.textBoxWatermark.Text;
            
            int fontSize = Convert.ToInt16(this.textBoxFontSize.Text);
            Font font = new Font(this.comboBoxFont.SelectedItem.ToString(),fontSize);
            int PosX = Convert.ToInt16(this.textBoxXPos.Text);
            int PosY = Convert.ToInt16(this.textBoxYPos.Text);
            Color color = this.buttonColor.BackColor;
            this.addWaterMarkEvent(text, font, PosX, PosY, color);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.buttonColor.BackColor = colorDialog.Color;
            }
        }

       
    }
}
