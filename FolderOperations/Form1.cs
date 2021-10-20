using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string kaynak = @"c:\kaynak\";
        string hedef = @"c:\hedef\";

        private void btnFolderCount_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            var directory = new System.IO.DirectoryInfo(kaynak);
            int folderCount = directory.GetDirectories().Length;
            lblStatus.Text= "Total folders: "+folderCount.ToString();
        }

        private void btnFileCount_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            //var directory = new System.IO.DirectoryInfo(kaynak);
            int fCount = Directory.GetFiles(kaynak, "*", SearchOption.AllDirectories).Length;
            lblStatus.Text="Total files: "+fCount.ToString();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lstCheck.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(kaynak);
            DirectoryInfo[] diList = di.GetDirectories();
            foreach (var item in diList)
            {
                string folderName = item.Name;
                int fileCountInFolder = Directory.GetFiles(item.FullName, "*", SearchOption.AllDirectories).Length;
                lstCheck.Items.Add(folderName + " - " + fileCountInFolder+" file(s)");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            DirectoryInfo di = new DirectoryInfo(kaynak);
            DirectoryInfo[] diList = di.GetDirectories();
            foreach (var item in diList)
            {
                int fileCountInFolder = Directory.GetFiles(item.FullName, "*", SearchOption.AllDirectories).Length;
                if (fileCountInFolder >0)
                {
                    string fileName = item.Name.Replace(' ','_').Replace('-','_');
                    var files = item.GetFiles();
                    int count = 1;
                    foreach (var file in files)
                    {
                        string source = file.FullName;
                        string fleName = fileName + count.ToString();
                        File.Copy(source,hedef+"\\"+fileName + count.ToString()+file.Extension);
                        count++;
                    }
                }
            }
            int fileCountInTarget = Directory.GetFiles(hedef, "*", SearchOption.AllDirectories).Length;
            lblStatus.Text = "Totaly " + fileCountInTarget + " file converted.";
        }
    }
}
