using Indexer.Utilites;
using System;
using System.Windows.Forms;

namespace Indexer.Forms.AddNewDirectory
{
    public partial class frmAddNewDirectory : Form
    {
        public frmAddNewDirectory()
        {
            InitializeComponent();
        }

        public string _CurrentPath;

        private void btnOk_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            Cursor = Cursors.WaitCursor;
            string newDir;
            string Result;
            if (_CurrentPath == Application.StartupPath + @"\AppFiles\")
            {
                progressBar1.Value += 10;
                newDir = _CurrentPath + txtNewFolderName.Text.Trim();
                Result = WorkWithDirectory.CreateDirectoryIfMissing(txtNewFolderName.Text.Trim(), newDir);
                progressBar1.Value += 50;
            }
            else
            {
                progressBar1.Value += 10;
                newDir = _CurrentPath + @"\" + txtNewFolderName.Text.Trim();
                Result = WorkWithDirectory.CreateDirectoryIfMissing(txtNewFolderName.Text.Trim(), newDir);
                progressBar1.Value += 60;
            }
            if (Result == "True")
            {
                progressBar1.Value += 20;
                Cursor = Cursors.Default;
                MessageBox.Show("پوشه ایجاد شد");
                this.DialogResult = DialogResult.OK;
            }
            else if (Result == "Folder Is Exist")
            {
                progressBar1.Value = 0;
                Cursor = Cursors.Default;
                MessageBox.Show("پوشه از قبل وجود دارد");
            }
            else if (Result == "Invalid Name")
            {
                progressBar1.Value = 0;
                Cursor = Cursors.Default;
                MessageBox.Show("نام گذاری پوشه نامعتبر است");
            }



        }

























        //---------------
    }
}
