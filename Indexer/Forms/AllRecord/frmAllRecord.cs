using Indexer.Data.Context;
using Indexer.Data.Entities;
using Indexer.Data.Interfaces.IRepositories;
using Indexer.Forms.Main;
using Indexer.Forms.UpdateCurrentDirectoryDbRecords;
using Indexer.Utilities;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Indexer.Forms.AllRecord
{
    public partial class frmAllRecord : Form
    {

        public frmAllRecord()
        {
            InitializeComponent();
            setDataGridViewSettings(DGV1);


        }
        string _Guid;
        string _PersianMessage;
        string _EnglishMessage;
        string _FileName;
        string _FileExtension;
        string _FileSize;
        string _PersianCategory;
        string _EnglishCategory;
        string _Description;
        string _Attachment;
        string _SequentialDirectory;
        string _LastUpdateRecordDate;


        void setDataGridViewSettings(DataGridView dataGridView)
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeight = 50;
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            Font font = new Font("Microsoft Sans Serif", 12);

            dataGridViewCellStyle.Font = font;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            dataGridView.ColumnHeadersHeight = 50;
            dataGridView.Dock = DockStyle.Right;
            dataGridView.RowHeadersWidth = 30;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.RowsDefaultCellStyle.Font = font;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Size size = new Size();
            size.Width = 800;
            size.Height = 600;

            dataGridView.Size = size;

        }
        private void frmAllRecord_Load(object sender, EventArgs e)
        {
            LoadData();
            fill_Combo();
        }

        async private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ProgressBar1.Value = 10;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                IMainTableRepository mainTableRepository = unitOfWork.MainTableRepository;
                ProgressBar1.Value += 20;
                if (txtTextToSearch.Text == "")
                {
                
                    var data = await mainTableRepository.GetAll<MainTable>(n => n == n);
                    var table = DesignAndFillDataTable(data.ToList());
                    DGV1.DataSource = table;
                    ProgressBar1.Value += 70;
                    Cursor = Cursors.Default;
                }

                else if (cbFilterToSearch.Text == "Guid")
                {
                  
                    Guid guid = Guid.Parse(txtTextToSearch.Text);
                    var data = await mainTableRepository.GetAll<MainTable>(n => n.RowGuid == guid);
                    var table = DesignAndFillDataTable(data.ToList());
                    DGV1.DataSource = table;
                    ProgressBar1.Value += 70;
                    Cursor = Cursors.Default;
                }
                else if (cbFilterToSearch.Text == "PersianMessage")
                {
                    
                    var data = await mainTableRepository.GetAll<MainTable>(n => n.PersianMessage.Contains(txtTextToSearch.Text.Trim()));
                    var table = DesignAndFillDataTable(data.ToList());
                    DGV1.DataSource = table;
                    ProgressBar1.Value += 70;
                    Cursor = Cursors.Default;

                }
                else if (cbFilterToSearch.Text == "EnglishMessage")
                {
                    var data = await mainTableRepository.GetAll<MainTable>(n => n.EnglishMessage.Contains(txtTextToSearch.Text.Trim()));
                    var table = DesignAndFillDataTable(data.ToList());
                    DGV1.DataSource = table;
                    ProgressBar1.Value += 70;
                    Cursor = Cursors.Default;
                }

                else if (cbFilterToSearch.Text == "FileName")
                {
                    var data = await mainTableRepository.GetAll<MainTable>(n => n.FileName.Contains(txtTextToSearch.Text.Trim()));
                    var table = DesignAndFillDataTable(data.ToList());
                    DGV1.DataSource = table;
                    ProgressBar1.Value += 70;
                    Cursor = Cursors.Default;
                }
                else if (cbFilterToSearch.Text == "FileExtension")
                {
                    var data = await mainTableRepository.GetAll<MainTable>(n => n.FileExtension.Contains(txtTextToSearch.Text.Trim()));
                    var table = DesignAndFillDataTable(data.ToList());
                    DGV1.DataSource = table;
                    ProgressBar1.Value += 70;
                    Cursor = Cursors.Default;
                }
                else if (cbFilterToSearch.Text == "FileSize")
                {
                    var data = await mainTableRepository.GetAll<MainTable>(n => n.FileSize.Contains(txtTextToSearch.Text.Trim()));
                    var table = DesignAndFillDataTable(data.ToList());
                    DGV1.DataSource = table;
                    ProgressBar1.Value += 70;
                    Cursor = Cursors.Default;
                }
                else if (cbFilterToSearch.Text == "PersianCategory")
                {
                    var data = await mainTableRepository.GetAll<MainTable>(n => n.PersianCategory.Contains(txtTextToSearch.Text.Trim()));
                    var table = DesignAndFillDataTable(data.ToList());
                    DGV1.DataSource = table;
                    ProgressBar1.Value += 70;
                    Cursor = Cursors.Default;
                }

                else if (cbFilterToSearch.Text == "EnglishCategory")
                {
                    var data = await mainTableRepository.GetAll<MainTable>(n => n.EnglishCategory.Contains(txtTextToSearch.Text.Trim()));
                    var table = DesignAndFillDataTable(data.ToList());
                    DGV1.DataSource = table;
                    ProgressBar1.Value += 70;
                    Cursor = Cursors.Default;
                }
                else if (cbFilterToSearch.Text == "Description")
                {
                    var data = await mainTableRepository.GetAll<MainTable>(n => n.Description.Contains(txtTextToSearch.Text.Trim()));
                    var table = DesignAndFillDataTable(data.ToList());
                    DGV1.DataSource = table;
                    ProgressBar1.Value += 70;
                    Cursor = Cursors.Default;
                }
                else if (cbFilterToSearch.Text == "Attachment")
                {
                    var data = await mainTableRepository.GetAll<MainTable>(n => n.Attachment.Contains(txtTextToSearch.Text.Trim()));
                    var table = DesignAndFillDataTable(data.ToList());
                    DGV1.DataSource = table;
                    ProgressBar1.Value += 70;
                    Cursor = Cursors.Default;
                }
                else if (cbFilterToSearch.Text == "SequentialDirectory")
                {
                    var data = await mainTableRepository.GetAll<MainTable>(n => n.SequentialDirectory.Contains(txtTextToSearch.Text.Trim()));
                    var table = DesignAndFillDataTable(data.ToList());
                    DGV1.DataSource = table;
                    ProgressBar1.Value += 70;
                    Cursor = Cursors.Default;
                }
                else if (cbFilterToSearch.Text == "CreateRecordDate")
                {

                    MessageBox.Show("هنوز اضافه نکردم");
                }
                else if (cbFilterToSearch.Text == "LastUpdateRecordDate")
                {

                    MessageBox.Show("هنوز اضافه نکردم");
                }
            }
        }

        private void UpdateSelectedRecord_Click(object sender, EventArgs e)
        {

            frmUpdateCurrentDirectoryDbRecords frmUpdateCurrentDirectoryRecords = new frmUpdateCurrentDirectoryDbRecords();
            frmUpdateCurrentDirectoryRecords._Attachment = _Attachment;
            frmUpdateCurrentDirectoryRecords._Description = _Description;
            frmUpdateCurrentDirectoryRecords._EnglishCategory = _EnglishCategory;
            frmUpdateCurrentDirectoryRecords._EnglishMessage = _EnglishMessage;
            frmUpdateCurrentDirectoryRecords._FileExtension = _FileExtension;
            frmUpdateCurrentDirectoryRecords._FileName = _FileName;
            frmUpdateCurrentDirectoryRecords._FileSize = _FileSize;
            frmUpdateCurrentDirectoryRecords._Guid = _Guid;
            frmUpdateCurrentDirectoryRecords._LastUpdateRecordDate = _LastUpdateRecordDate;
            frmUpdateCurrentDirectoryRecords._PersianCategory = _PersianCategory;
            frmUpdateCurrentDirectoryRecords._PersianMessage = _PersianMessage;
            frmUpdateCurrentDirectoryRecords._SequentialDirectory = _SequentialDirectory;
            if (frmUpdateCurrentDirectoryRecords.ShowDialog() == DialogResult.OK)
            {
                this.frmAllRecord_Load(this, new EventArgs());
                frmUpdateCurrentDirectoryRecords.Close();

            }
        }

        private void DGV1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            _Guid = DGV1.Rows[e.RowIndex].Cells["RowGuid"].Value.ToString();
            _PersianMessage = DGV1.Rows[e.RowIndex].Cells["PersianMessage"].Value.ToString();
            _EnglishMessage = DGV1.Rows[e.RowIndex].Cells["EnglishMessage"].Value.ToString();
            _FileName = DGV1.Rows[e.RowIndex].Cells["FileName"].Value.ToString();
            _FileExtension = DGV1.Rows[e.RowIndex].Cells["FileExtension"].Value.ToString();
            _FileSize = DGV1.Rows[e.RowIndex].Cells["FileSize"].Value.ToString();
            _PersianCategory = DGV1.Rows[e.RowIndex].Cells["PersianCategory"].Value.ToString();
            _EnglishCategory = DGV1.Rows[e.RowIndex].Cells["EnglishCategory"].Value.ToString();
            _Description = DGV1.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            _Attachment = DGV1.Rows[e.RowIndex].Cells["Attachment"].Value.ToString();
            _SequentialDirectory = DGV1.Rows[e.RowIndex].Cells["SequentialDirectory"].Value.ToString();
            _LastUpdateRecordDate = DGV1.Rows[e.RowIndex].Cells["LastUpdateRecordDate"].Value.ToString();
        }

        private void دریافتفایلرکوردفعلیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = _FileName;
            sfd.Filter = $"myFileType|*{_FileExtension}";
            Cursor = Cursors.WaitCursor;
            ProgressBar1.Value = 30;
            // sfd.Filter = "All files (*.*) | *.*";
            //sfd.Filter = "type file " + filename[filename.Length - 1] + " |*." ;
            //sfd.FileName = DGV[2, DGV.CurrentRow.Index].Value.ToString();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ProgressBar1.Value += 30;
                string StoredPathWithName = Application.StartupPath+_SequentialDirectory + @"\" + _Guid;
                try
                {
                    File.Copy(StoredPathWithName, sfd.FileName, true);
                    ProgressBar1.Value += 40;
                    Cursor = Cursors.Default;
                }
                
                catch (FileNotFoundException)
                {
                    ProgressBar1.Value = 0;
                    Cursor = Cursors.Default;
                    MessageBox.Show("فایل در مبدا موجود نمیباشد");
                }
            }

        }

        private void بازکردنفایلرکوردفعلیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string StoredPathWithName = frmMain._CurrentPathdirs + @"\" + _Guid;
            //string StoredPathWithNameAndWithExtension = StoredPathWithName + _FileExtension;
            ////----Tip-----

            ////that file is not has a extestion . not opening .not fount .


            ////-----
            ////----Add Extension To Stored File-----
            //FileInfo SourceFilePath =new  FileInfo(StoredPathWithName);
            //Rename(SourceFilePath, StoredPathWithNameAndWithExtension);
            ////-----
            ////----- Open File-------
            //System.Diagnostics.Process.Start($@"{StoredPathWithNameAndWithExtension}");
            ////-----
            ////-----Reset File To Defalt Name (Without Extension)
            //FileInfo StoredPathWithNameWithExtensionFileInfo = new FileInfo(StoredPathWithNameAndWithExtension);
            //Rename(StoredPathWithNameWithExtensionFileInfo, StoredPathWithName);
            ////-----
        }

        private void بررسیوجودفایلرکوردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ProgressBar1.Value = 30;
            string StoredPathWithName = Application.StartupPath+_SequentialDirectory + @"\" + _Guid;
            ProgressBar1.Value += 30;
            if (System.IO.File.Exists(StoredPathWithName))
            {
                ProgressBar1.Value += 40;
                Cursor = Cursors.Default;
                MessageBox.Show("فایل رکورد در دیسک موجود میباشد");
            }
            else
            {
                ProgressBar1.Value += 40;
                Cursor = Cursors.Default;
                MessageBox.Show("فایل رکورد در دیسک موجود نیست");
            }
        }

        async private void DeleteSlectedRecord_Click(object sender, EventArgs e)
        {
            if (WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(_Guid))
            {
                MessageBox.Show("لفا برای حذف ردیف را کامل انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cursor = Cursors.WaitCursor;
            ProgressBar1.Value = 10;



            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                Guid guid = Guid.Parse(_Guid);
                ProgressBar1.Value += 10;
                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {
                    ProgressBar1.Value += 10;
                    IMainTableRepository mainTableRepository = _unitOfWork.MainTableRepository;

                    bool Result = await mainTableRepository.IsExist<MainTable>(n => n.RowGuid == guid);
                    if (!Result)
                    {
                        ProgressBar1.Value = 0;
                        Cursor = Cursors.Default;
                        MessageBox.Show("رکورد با این کد گاید  یافت نشد");
                        return;
                    }

                    ProgressBar1.Value += 20;
                    bool DeleteResult = await mainTableRepository.DeleteByCondition<MainTable>(n => n.RowGuid == guid);
                    if (DeleteResult)
                    {
                        ProgressBar1.Value += 10;
                   

                        string fileToDelete = frmMain._CurrentDirectory + @"\" + guid;
                        FileInfo fileInfo = new FileInfo(fileToDelete);
                        if (fileInfo.Exists)
                        {
                            File.Delete(fileToDelete);
                        }
                        ProgressBar1.Value += 20;
                        _unitOfWork.Save();
                        ProgressBar1.Value += 20;
                        Cursor = Cursors.Default;
                        MessageBox.Show("رکورد با موفقیت حذف شد"); 
                        frmAllRecord_Load(this, new EventArgs());

                    }
                    else
                    {
                        ProgressBar1.Value = 0;
                        Cursor = Cursors.Default;
                        MessageBox.Show("خطایی رخ داده است");
                    }








                }

            }
        }

        private void frmAllRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

























































        //---------------------
    }
}
