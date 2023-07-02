using Indexer.Data.Context;
using Indexer.Data.Entities;
using Indexer.Data.Interfaces.IRepositories;
using Indexer.Forms.Main;
using Indexer.Utilites;
using Indexer.Utilities;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Indexer.Forms.AddRecord
{
    public partial class frmAddRecod : Form
    {
        IndexerContext _db;
        public string _filenameWithSourcePath;
        public string _FileNameWithoutSourcePath;
        public frmAddRecod()
        {
            InitializeComponent();
            _db = new IndexerContext();
        }







        private void frmManageDirRecod_Load(object sender, EventArgs e)
        {
            txtPathToSaveFile.Text = frmMain._CurrentDirectory;
            txtSequentialDirectoryToSave.Text = WorkWithStrings.DeleteTextInString(frmMain._CurrentDirectory, Application.StartupPath);


        }




        async private void btnSave_Click(object sender, EventArgs e)
        {
            //----- correct Filename example----
            //  string Filename = @"d:\WIN10.iso"; 
            //-----
            Cursor = Cursors.WaitCursor;
            addRecordProgressBar.Value = 10;

            if (!File.Exists(_filenameWithSourcePath))
            {
                MessageBox.Show("فایل در مبدا موجود نمیباشد");

                addRecordProgressBar.Value += 0;
                return;
            }
            Guid RowGuid = new Guid();
            RowGuid = Guid.NewGuid();
            addRecordProgressBar.Value += 10;
            //  string FileNameWithGuid = RowGuid + _FileNameWithoutSourcePath;

            string FileNameWithDestinationPath = txtPathToSaveFile.Text + "/" + RowGuid;
            File.Copy(_filenameWithSourcePath, FileNameWithDestinationPath);
            MainTable obj = new MainTable();
            obj.RowGuid = RowGuid;
            obj.FileName = _FileNameWithoutSourcePath;
            addRecordProgressBar.Value += 10;
            obj.StoredFileName = RowGuid.ToString();
            obj.PersianMessage = txtPersianMessageToSearch.Text;
            obj.Attachment = txtAttachments.Text;
            obj.Description = txtdescription.Text;
            addRecordProgressBar.Value += 10;
            obj.EnglishCategory = cbEnglishCategory.Text;
            obj.PersianCategory = cbPersianCategory.Text;
            obj.EnglishMessage = txtEnglishMessageToSearch.Text;
            obj.FileExtension = txtFileExtension.Text;
            obj.FileSize = txtFileSize.Text;
            addRecordProgressBar.Value += 10;
            obj.LastUpdateRecordDate = DateTime.Now;
            obj.CreateRecordDate = DateTime.Now;
            obj.SequentialDirectory = txtSequentialDirectoryToSave.Text;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                addRecordProgressBar.Value += 10;
                IMainTableRepository mainTableRepository = unitOfWork.MainTableRepository;
                bool isExistResult = await mainTableRepository.IsExist<MainTable>(n => n.RowGuid == obj.RowGuid);
                if (!isExistResult)
                {
                    addRecordProgressBar.Value += 10;
                    bool addResult = await mainTableRepository.Add<MainTable>(obj);
                    if (addResult)
                    {
                        addRecordProgressBar.Value += 10;

                        unitOfWork.Save();
                        addRecordProgressBar.Value += 20;
                        Cursor = Cursors.Default;
                        MessageBox.Show("رکورد با موفقیت ثبت شد");
                        this.DialogResult = DialogResult.OK;

                    }
                }
            }





        }




        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "all file|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                //----get FileName . by defult file name is SourcePath+\\+Filename ----
                //----Tip : filename and extension are filename.-----
                _filenameWithSourcePath = ofd.FileName;
                //-----Delete Source Path ------
                string[] temp = ofd.FileName.Split('\\');
                _FileNameWithoutSourcePath = temp[temp.Length - 1];
                //-----
                txtFileName.Text = _FileNameWithoutSourcePath;
                txtFileExtension.Text = Path.GetExtension(_FileNameWithoutSourcePath);

                txtFileSize.Text = WorkWithFile.GetSizeOfFile(_filenameWithSourcePath);

            }
        }

        private void frmAddRecod_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
