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
using Qiniu.RPC;
using Qiniu.RSF;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace QiniuTool
{
    public partial class QiniuGui : Form
    {        
        public QiniuGui()
        {
            InitializeComponent();
            Qiniu.Conf.Config.ACCESS_KEY = "AK";
            Qiniu.Conf.Config.SECRET_KEY = "SK";
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

            string uploadTime = string.Format("{0:yyyy-MM-dd HH:mm:ss}",DateTime.Now);
            string hashValue = ret.Hash;
            string downloadUrl = url;
            string localPath = filepath;

            MySqlConnection conn;
            //注意连接字符串加 Allow User Variables=True;
            string connectString =  "server=127.0.0.1;uid=root;" +
                                    "pwd=*********;database=qiniu;Allow User Variables=True;";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connectString;
                conn.Open();
                string sqlInsert = "INSERT INTO pictures(Bucket,HashValue,UploadTime,DownloadUrl,LocalPath,Description)" +
                                "values(@Bucket,@HashValue,@UploadTime,@DownloadUrl,@LocalPath,@Description)";
                MySqlCommand cmd = new MySqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("@Bucket",bucket);
                cmd.Parameters.AddWithValue("@HashValue", hashValue);
                cmd.Parameters.AddWithValue("@UploadTime", uploadTime);
                cmd.Parameters.AddWithValue("@DownloadUrl", downloadUrl);
                cmd.Parameters.AddWithValue("@LocalPath", localPath);
                //cmd.Parameters.AddWithValue("@Description", Description);
                cmd.ExecuteNonQuery();
                string sqlQuery = "SELECT * FROM pictures ";
                MySqlDataAdapter adapterQuery = new MySqlDataAdapter(sqlQuery,conn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapterQuery);
                DataSet ds = new DataSet();
                adapterQuery.Fill(ds,"pictures");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "pictures";

            }
            catch(Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message + "数据库操作失败，请检查设置";
            }
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string localPath = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if (File.Exists(localPath))
            {
                pictureBox1.Image = Image.FromFile(localPath);
                this.textBoxUrl.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }

        }
    }
}
