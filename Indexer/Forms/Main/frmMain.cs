using Indexer.Forms.AddNewDirectory;
using Indexer.Forms.AddRecord;
using Indexer.Forms.AllRecord;
using Indexer.Forms.CurrentDirectoryRecords;
using Indexer.Utilities;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace Indexer.Forms.Main
{
    public partial class frmMain : Form
    {

        public static string _CurrentDirectory;
        public string MainFolder = Application.StartupPath + @"\AppFiles";

        public frmMain()
        {
            InitializeComponent();

        }











        public void ShowRootDir_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            Cursor = Cursors.WaitCursor;
            _CurrentDirectory = MainFolder;
            txtCurrentPath.Text = _CurrentDirectory;
            ShowDirectoryFileAndSubFolderToListBox(_CurrentDirectory, ExplorerDirectoriesListBox);
            progressBar1.Value += 90;
            Cursor = Cursors.Default;
        }

        private void NavigateBack_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            Cursor = Cursors.WaitCursor;
            DirectoryInfo directoryInfo=new DirectoryInfo(_CurrentDirectory);
            if (directoryInfo.Parent == null)
            {
                progressBar1.Value = 0;
                Cursor = Cursors.Default;
                MessageBox.Show("پوشه فعلی والد ندارد");
                return;
            }

            string parent = Directory.GetParent(_CurrentDirectory).FullName;
            progressBar1.Value += 50;
            txtCurrentPath.Text = parent;
            _CurrentDirectory = parent;
            ShowDirectoryFileAndSubFolderToListBox(parent, ExplorerDirectoriesListBox);
            progressBar1.Value += 40;
            Cursor = Cursors.Default;



        }

        













        private void CreateNewFolder_Click(object sender, EventArgs e)
        {
            frmAddNewDirectory AddNewDirectory = new frmAddNewDirectory();
            AddNewDirectory._CurrentPath = _CurrentDirectory;
            if (AddNewDirectory.ShowDialog() == DialogResult.OK)
            {
                AddNewDirectory.Close();
                ShowDirectoryFileAndSubFolderToListBox(_CurrentDirectory, ExplorerDirectoriesListBox);

            }
        }

        private void OpenCurrentDirectory_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", $@"\Open, {_CurrentDirectory}");
        }
















        private void HideCurrentDirectoryFiles_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 20;
            Cursor = Cursors.WaitCursor;
            string[] files = Directory.GetFiles(_CurrentDirectory);
            progressBar1.Value += 20;
            foreach (string item in files)
            {
              FileInfo f = new FileInfo(item);
                    ExplorerDirectoriesListBox.Items.Remove(f.Name);
             
            }
            progressBar1.Value += 60;
            Cursor = Cursors.Default;


        }
       

        void ShowDirectoryFileAndSubFolderToListBox(string path, ListBox listBox)
        {
            listBox.Items.Clear();
            string[] files = Directory.GetFiles(path);
            string[] dirs = Directory.GetDirectories(path);

            foreach (string item2 in dirs)
            {
                FileInfo f = new FileInfo(item2);
                listBox.Items.Add(f.Name);

            }

            foreach (string item in files)
            {
                FileInfo f = new FileInfo(item);

                listBox.Items.Add(f.Name);

            }
        }

        private void ShowCurrentDirectoryFiles_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            Cursor = Cursors.WaitCursor;
            ShowDirectoryFileAndSubFolderToListBox(_CurrentDirectory, ExplorerDirectoriesListBox);
            progressBar1.Value += 90;
            Cursor = Cursors.Default;

        }



        private void OpenAppFilesDirectory_Click(object sender, EventArgs e)
        {

            Process.Start("explorer.exe", $@"\Open, {MainFolder}");
            //  Process.Start("explorer.exe", $"/Select, {str2} ");
        }

        private void OpenApplicationStartUpDirectory_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", $@"\Open, {Application.StartupPath} ");
        }

        private void RefreshCurrentDirectory_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            Cursor = Cursors.WaitCursor;
            ShowDirectoryFileAndSubFolderToListBox(_CurrentDirectory, ExplorerDirectoriesListBox);
            progressBar1.Value += 90;
            Cursor = Cursors.Default;
        }

        private void AddRcordToCurrentDirectory_Click(object sender, EventArgs e)
        {
            frmAddRecod frmAddRecod = new frmAddRecod();
            if (frmAddRecod.ShowDialog() == DialogResult.OK)
            {
                RefreshCurrentDirectory_Click(this , new EventArgs());
                frmAddRecod.Close();


            }
        }

        private void ShowAllRecord_Click(object sender, EventArgs e)
        {
            frmAllRecord frmAllRecord = new frmAllRecord();
            if (frmAllRecord.ShowDialog() == DialogResult.OK)
            {
                RefreshCurrentDirectory_Click(this , new EventArgs());
                frmAllRecord.Close();


            }
        }

        private void ShowCurrentDirectoryRecords_Click(object sender, EventArgs e)
        {
            frmCurrentDirectoryRecords frmCurrentDirectoryRecords = new frmCurrentDirectoryRecords();
            frmCurrentDirectoryRecords._CurrentDirectoryToGetRecords = WorkWithStrings.DeleteTextInString(_CurrentDirectory, Application.StartupPath);

            if (frmCurrentDirectoryRecords.ShowDialog() == DialogResult.OK)
            {
                RefreshCurrentDirectory_Click(this , new EventArgs());
                frmCurrentDirectoryRecords.Close();


            }
        }

        private void ExplorerDirectoriesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ExplorerDirectoriesListBox.SelectedIndex == -1)
            {
                return;
            }
            string SlectedItemtext = ExplorerDirectoriesListBox.Items[ExplorerDirectoriesListBox.SelectedIndex].ToString();


            string selectedDirectory = _CurrentDirectory + @"\" + SlectedItemtext;
            if (!Directory.Exists(selectedDirectory))
            {
                return;
            }

            else
            {
                _CurrentDirectory += @"\" + SlectedItemtext;
                ShowDirectoryFileAndSubFolderToListBox(_CurrentDirectory, ExplorerDirectoriesListBox);
                txtCurrentPath.Text = _CurrentDirectory;
            }


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            _CurrentDirectory = MainFolder;
            txtCurrentPath.Text = _CurrentDirectory;
            ShowDirectoryFileAndSubFolderToListBox(_CurrentDirectory, ExplorerDirectoriesListBox);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            Cursor = Cursors.WaitCursor;
            if (ExplorerDirectoriesListBox.SelectedIndex == -1)
            {
                progressBar1.Value = 0;
                Cursor = Cursors.Default;
                return;
            }
                progressBar1.Value += 10;
                string path = _CurrentDirectory +@"\"+ ExplorerDirectoriesListBox.SelectedItem.ToString();
                progressBar1.Value += 30;
                if (File.Exists(path))
                {
                    File.Delete(path);
                    progressBar1.Value += 50;
                    Cursor = Cursors.Default;

                }
                else if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                    progressBar1.Value += 50;
                    Cursor = Cursors.Default;
                }

                ShowDirectoryFileAndSubFolderToListBox(_CurrentDirectory, ExplorerDirectoriesListBox);


            
        }

        ///



        //-------------
    }
}
