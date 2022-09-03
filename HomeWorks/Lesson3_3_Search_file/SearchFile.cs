using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Lesson3_3_Search_file
{
    public partial class SearchFile : Form
    {
        string file;
        public SearchFile()
        {
            InitializeComponent();
            GetDirectories();
        }
        public void GetDirectories()
        {
            var driverInfos = DriveInfo.GetDrives();
            foreach (var driverInfo in driverInfos)
                if (driverInfo.DriveType != DriveType.CDRom) checkedListBox1.Items.Add(driverInfo.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = DateTime.Now;
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                foreach (var item in checkedListBox1.CheckedItems)
                {

                    if (SearchFiles(item.ToString(), textBox1.Text))
                    {
                        listBox1.Items.Add(file);
                        break;
                    }
                }
            }
            var y = DateTime.Now;
            MessageBox.Show($"{(y - x).TotalSeconds:N} seconds");
        }

        private bool SearchFiles(string directory, string filename)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            if (!directoryInfo.Exists)
            {
                return false;
            }
            FileInfo[] files = null;

            try
            {
                files = directoryInfo.GetFiles(filename);
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
            catch { }
            if (files == null || files.Length == 0)
            {
                var subdirs = directoryInfo.GetDirectories();
                if (subdirs.Length == 0)
                {
                    return false;
                }
                else
                {
                    foreach (DirectoryInfo dir in subdirs)
                    {
                        if (dir.Attributes.Equals(FileAttributes.Hidden | FileAttributes.System | FileAttributes.Directory))
                        {
                            continue;
                        }
                        if (SearchFiles(dir.FullName, filename))
                        {
                            return true;
                        }

                    }

                }
                return false;
            }
            else
            {
                file = files[0].FullName;
                return true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                using (FileStream stream = new FileStream(listBox1.SelectedItems[0].ToString(), FileMode.Open))
                {
                    StreamReader reader = new StreamReader(stream);
                    txt_content.Text = reader.ReadToEnd();
                }
            }
        }

        private void btn_archivator_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveArchive = new SaveFileDialog()
            {
                Filter = "Zip files (*.zip)|*.zip|All files (*.*)|*.*",
                DefaultExt = ",zip",
                InitialDirectory = "."
            };
            if (file!=null && SaveArchive.ShowDialog() == DialogResult.OK)
            {
            var fstream = File.OpenRead(file);
            var compressor = new GZipStream(new FileStream(SaveArchive.FileName, FileMode.Create),
                CompressionMode.Compress);
            var x = File.ReadAllBytes(file);
            compressor.Write(x, 0, x.Length);
            compressor.Close();
            fstream.Close();
            }

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
