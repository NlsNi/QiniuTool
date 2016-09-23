using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Qiniu.Auth;
using Qiniu.IO;
using Qiniu.IO.Resumable;
using Qiniu.RS;


namespace QiniuTool
{
    public partial class QiniuGui : Form
    {
        public QiniuGui()
        {
            InitializeComponent();        
        }

        private void buttonPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            string picPath = null;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                picPath = fileDialog.FileName.ToString();
                textBoxPic.Text = picPath;
            }
            if (picPath != null)
            {
                picPath = picPath.ToLower();
                if (picPath.EndsWith("jpg") | picPath.EndsWith("png") |
                    picPath.EndsWith("bmp") | picPath.EndsWith("gif"))
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = Image.FromFile(picPath);
                }
            }

        }

        private void buttonWatch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            string watchPath = null;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                watchPath = folder.SelectedPath.ToString();
                textBoxWatch.Text = watchPath;
                if (watchPath != null)
                {
                    FileSystemWatcher watcher = new FileSystemWatcher();
                    watcher.Filter = "*.*";
                    watcher.Path = watchPath;
                    watcher.EnableRaisingEvents = true;
                    watcher.IncludeSubdirectories = true;
                    watcher.Created += OnChanged;
                    watcher.Changed += OnChanged;
                    watcher.Renamed += OnChanged;
                }         
            }
               
        }

        private  void OnChanged(object source, FileSystemEventArgs e)
        {
            string filepath = e.FullPath;
            string filename = e.Name;
            upload(filename, filepath);
            
        }

        private void upload(string filename,string filepath)
        {
            //设置AK SK
            Qiniu.Conf.Config.ACCESS_KEY = "ACCESS_KEY";
            Qiniu.Conf.Config.SECRET_KEY = "SECRET_KEY";
            IOClient target = new IOClient();
            PutExtra extra  = new PutExtra();
            string bucket = "bucketname";
            string key = filename;
            PutPolicy put = new PutPolicy(bucket, 3600);
            string upToken = put.Token();
            PutRet ret = target.PutFile(upToken,key,filepath,extra);
            toolStripStatusLabel1.Text = ret.Response.ToString();
            string url= @"http://example.bkt.clouddn.com/" + filename;
            textBoxUrl.Text = url;
        }

        private void buttonUrl_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            string url = textBoxUrl.Text;
            if (url.Length != 0)
            {
                Clipboard.SetText(url);
                toolStripStatusLabel1.Text = "外链地址已复制到剪贴板";
            }

        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            string filepath = textBoxPic.Text;
            string ending = filepath.Split('.')[1];
            string filename = string.Format("{0:yyyyMMdd_HHmmss}",DateTime.Now) + "." + ending;
            upload(filename, filepath);
        }
    }
}
