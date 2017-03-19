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
using System.IO;
using System.Security.Cryptography;

using MySql.Data;
using MySql.Data.MySqlClient;

using Qiniu.Common;
using Qiniu.RS;
using Qiniu.RS.Model;
using Qiniu.Http;
using Qiniu.Util;
using Qiniu.IO;
using Qiniu.IO.Model;

namespace QiniuTool
{
    public partial class QiniuGui : Form
    {
        private static Mac mac = null;
        public QiniuGui()
        {
            InitializeComponent();
            
        }

        private void QiniuGui_Load(object sender, EventArgs e)
        {
            //获取所有Buckets
            var appSettings = ConfigurationManager.AppSettings;
            string AK = appSettings["AK"];
            string SK = appSettings["SK"];
            mac = new Mac(AK,SK);
            BucketManager bucketManger = new BucketManager(mac);
            BucketsResult bucketResult = bucketManger.Buckets();
            for (int i = 0; i < bucketResult.Result.Count; i++)
            {
                comboBoxBuckets.Items.Add(bucketResult.Result[i]);
            }
        }

        private void buttonExplore_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            string picPath = null;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                picPath = fileDialog.FileName.ToString();
                this.textBoxPath.Text = picPath;
            }
            if (!String.IsNullOrEmpty(picPath))
            {
                picPath =picPath.ToLower();
                if (picPath.EndsWith("jpg") || picPath.EndsWith("png") ||
                    picPath.EndsWith("bmp") || picPath.EndsWith("gif"))
                {
                    this.pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    this.pictureBox.Image = Image.FromFile(picPath);
                }
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            string url = this.textBoxUrl.Text;
            if(!String.IsNullOrEmpty(url))
            {
                Clipboard.SetText(url);
                this.toolStripStatusLabel.Text = "外链地址已复制到剪贴板";
            }

        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {

            string filepath = this.textBoxPath.Text;
            if (String.IsNullOrEmpty(filepath))
            {
                MessageBox.Show("未选择要上传的文件");
                this.textBoxPath.Focus();
                return;
            }
            else
            {
                //如果hash值在数据库中存在，证明已经上传过该文件
                string hash = GetMD5Hash(filepath);
                using (MySqlConnection connection = new MySqlConnection())
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["qiniu"].ConnectionString;
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    string sqlQuery = "SELECT COUNT(id) FROM pictures WHERE HashValue = " + "'" + hash + "'";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                    Object result = cmd.ExecuteScalar();
                    if (Convert.ToInt32(result) != 0)
                    {
                        this.toolStripStatusLabel.Text = "已上传过该文件";
                    }
                    else
                    {
                        string ending = filepath.Split('.')[1];
                        string filename = String.Format("{0:yyyymmdd_hhmmss}", DateTime.Now) + "." + ending;
                        this.Upload(filename, filepath);
                        this.ShowAllPictures();
                    }
                }  
            }
        }

        private string GetMD5Hash(string filepath)
        {
            StringBuilder builder = new StringBuilder();
            using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                MD5 md5 = MD5.Create();
                byte[] data = md5.ComputeHash(fs);
                for (int i = 0; i < data.Length;i++ )
                {
                    builder.Append(data[i].ToString("x2"));
                }
            }   
            return builder.ToString();
        }
        
        private void Upload(string filename,string filepath)
        {
            string bucket;
            if (this.comboBoxBuckets.SelectedIndex ==-1)
            {
                bucket = ConfigurationManager.AppSettings["defaultbucket"];
            }
            else
	        {
                bucket = this.comboBoxBuckets.SelectedItem.ToString();
	        }
            PutPolicy putPolicy = new PutPolicy();
            putPolicy.Scope = bucket;
            putPolicy.SetExpires(3600);
            string jsonStr = putPolicy.ToJsonString();
            string token = Auth.CreateUploadToken(mac, jsonStr);
            BucketManager bucketManager = new BucketManager(mac);
            string domain = bucketManager.Domains(bucket).Result[0];
            FormUploader formUploader = new FormUploader();
            HttpResult result = formUploader.UploadFile(filepath,filename,token);
            if(result.RefCode ==200)
            {
                this.toolStripStatusLabel.Text = "上传成功";
                #region UpdateDatabase

                string uploadTime = String.Format("{0:yyyy-mm-dd hh:mm:ss}", DateTime.Now);
                string hashValue = GetMD5Hash(filepath);
                string downloadUrl = "http://" + domain + "/"+ filename;
                this.textBoxUrl.Text = downloadUrl;
                string localPath = filepath;
                
                string connectionString = ConfigurationManager.ConnectionStrings["qiniu"].ConnectionString;
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlInsert = "INSERT INTO pictures(Bucket,HashValue,UploadTime,DownloadUrl,LocalPath,Description)" +
                                    "values(@Bucket,@HashValue,@UploadTime,@DownloadUrl,@LocalPath,@Description)";
                        MySqlCommand cmd = new MySqlCommand(sqlInsert, connection);
                        cmd.Parameters.AddWithValue("@Bucket", bucket);
                        cmd.Parameters.AddWithValue("@HashValue", hashValue);
                        cmd.Parameters.AddWithValue("@UploadTime", uploadTime);
                        cmd.Parameters.AddWithValue("@DownloadUrl", downloadUrl);
                        cmd.Parameters.AddWithValue("@LocalPath", localPath);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    this.toolStripStatusLabel.Text = ex.Message + "数据库操作失败，请检查设置";
                }
                #endregion
            }
        }

        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowAllPictures();
        }
        private void ShowAllPictures()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["qiniu"].ConnectionString;
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM pictures";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery,connection);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet,"pictures");
                this.dataGridView.DataSource = dataSet;
                this.dataGridView.DataMember = "pictures";
            }
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string localPath = this.dataGridView.CurrentRow.Cells[5].Value.ToString();
            if (File.Exists(localPath))
            {
                this.pictureBox.Image = Image.FromFile(localPath);
                this.textBoxUrl.Text = this.dataGridView.CurrentRow.Cells[4].Value.ToString();
            }
        }
    }
}
