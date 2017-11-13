using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text;

namespace PrintCG_24062016
{
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://10.0.10.2/Loi/soft/download/printcg//");
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Credentials = new NetworkCredential("test", "abc@1234");

            FtpWebResponse response = request.GetResponse() as FtpWebResponse;
            Stream responseStream = response.GetResponseStream();

            List<string> files = new List<string>();
            StreamReader reader = new StreamReader(responseStream);

            while (!reader.EndOfStream)
            {
                Application.DoEvents();
                files.Add(reader.ReadLine());
            }
            reader.Close();
            lstfile.DataSource = files;

            responseStream.Close();
            response.Close();
            checktxt();

        }
        private void checktxt()
        {
            WebClient request = new WebClient();
            string url = "ftp://10.0.10.2/Loi/soft/download/printcg//update.txt";
            request.Credentials = new NetworkCredential("test", "abc@1234");
            string line;

            try
            {
                byte[] newFileData = request.DownloadData(url);
                string fileString = System.Text.Encoding.UTF8.GetString(newFileData);
                txtserver.Text = fileString;

                StreamReader sr = new StreamReader(@"update.txt");
                line = sr.ReadLine();
                txtclient.Text = line;
               
            }
            catch (WebException e)
            {
                // Do something such as log error, but this is based on OP's original code
                // so for now we do nothing.
            }
        }
    }
}
