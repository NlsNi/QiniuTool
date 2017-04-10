using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Xml;

using Qiniu.Common;
using Qiniu.RS;
using Qiniu.RS.Model;
using Qiniu.Http;
using Qiniu.Util;
using Qiniu.IO;
using Qiniu.IO.Model;
using System.Reflection;

namespace QiniuTool
{
    public partial class SettingWindow : Form
    {
        public SettingWindow()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            string AK = this.textBoxAK.Text;
            string SK = this.textBoxSK.Text;
            string defaultbucket = this.comboBoxBuckets.SelectedItem.ToString();
            ConfigXmlDocument xmlDoc = new ConfigXmlDocument();
            string currentPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            // App.config所在路径
            string configPath = currentPath.Substring(0, currentPath.Length - 10) + "App.config";
            xmlDoc.Load(configPath);
            XmlElement xmlElementAK = (XmlElement)xmlDoc.SelectSingleNode("//appSettings/add[1]");
            XmlElement xmlElementSK = (XmlElement)xmlDoc.SelectSingleNode("//appSettings/add[2]");
            XmlElement xmlElementDefaultBucket = (XmlElement)xmlDoc.SelectSingleNode("//appSettings/add[last()]");
            xmlElementAK.SetAttribute("value", AK);
            xmlElementSK.SetAttribute("value",SK);
            xmlElementDefaultBucket.SetAttribute("value",defaultbucket);
            xmlDoc.Save(configPath);

        }

        private void comboBoxBuckets_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxSK_TextChanged(object sender, EventArgs e)
        {
            string AK = this.textBoxAK.Text;
            string SK = this.textBoxSK.Text;
            if (String.IsNullOrEmpty(AK) || String.IsNullOrEmpty(SK))
            {
                MessageBox.Show("请设置AK和SK");
                this.textBoxAK.Focus();
            }
            else
            {
                Mac mac = new Mac(AK, SK);
                BucketManager bucketManger = new BucketManager(mac);
                BucketsResult bucketResult = bucketManger.Buckets();
                if (bucketResult.Code == 200)
                {
                    for (int i = 0; i < bucketResult.Result.Count; i++)
                    {
                        comboBoxBuckets.Items.Add(bucketResult.Result[i]);
                    }
                    this.comboBoxBuckets.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("认证失败，请重新设置AK和SK");
                    this.textBoxAK.Focus();
                }
            }
        }




    }
}
