using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_directory
{
    public partial class Form1 : Form
    {
        void NewFoder(string directoryPath)
        {            
            DirectoryInfo directory = new DirectoryInfo(directoryPath);
            if (!directory.Exists)
            {
                directory.Create();
            }
            tbxLink.Text = directoryPath;
        }
        void ImagePaste(string FilePath)
        {
            try
            {
                Image IMG = Clipboard.GetImage();
                if (IMG != null)
                {
                    IMG.Save(FilePath);
                    tbxLink.Text = FilePath;
                }
                else
                {
                    MessageBox.Show("not Image");
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            
        }
        void CopyAll(string sourcePath, string targetPath)
        {
            try
            {
                // To copy all the files in one directory to another directory.
                if (System.IO.Directory.Exists(sourcePath))
                {
                    string[] files = System.IO.Directory.GetFiles(sourcePath);
                    string fileName = "";
                    // Use Path class to manipulate file and directory paths.
                    string destFile = System.IO.Path.Combine(targetPath, fileName);
                    // Copy the files and overwrite destination files if they already exist.
                    foreach (string s in files)
                    {
                        // Use static Path methods to extract only the file name from the path.
                        fileName = System.IO.Path.GetFileName(s);
                        destFile = System.IO.Path.Combine(targetPath, fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                    MessageBox.Show("Successfully Copied");
                }
                else
                {
                    MessageBox.Show("Source path does not exist!");
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }
        //
        void SaveConfig()
        {
            string pathRoot = @"Config.txt";
            // Create a file to write to.
            string createText =
                tbxPath.Text + Environment.NewLine +
                tbxNameFile.Text + Environment.NewLine +
                tbxSourcePath.Text + Environment.NewLine;
            File.WriteAllText(pathRoot, createText);
        }
        void load()
        {
            string pathRoot = @"Config.txt";
            if (File.Exists(pathRoot))
            {
                // Open the file to read from.
                string[] readText = File.ReadAllLines(pathRoot);
                tbxPath.Text = readText[0];
                tbxNameFile.Text = readText[1];
                tbxSourcePath.Text = readText[2];
            }            
        }
        public Form1()
        {
            InitializeComponent();
            load();
        }

        private void btnAddFoder_Click(object sender, EventArgs e)
        {
            NewFoder(tbxPath.Text);           
        }

        private void btnIMG_Click(object sender, EventArgs e)
        {
            ImagePaste(tbxPath.Text + @"\" + tbxNameFile.Text);             
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            NewFoder(tbxPath.Text);
            string FilePath = tbxPath.Text + @"\" + tbxNameFile.Text;
            ImagePaste(FilePath);
            tbxLink.Text = tbxPath.Text;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Process.Start(tbxLink.Text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            
            string sourcePath = tbxSourcePath.Text;
            string targetPath = tbxLink.Text;
            CopyAll(sourcePath, targetPath);            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveConfig();
        }
    }
}
