using Indexer.Data.Context;
using Indexer.Data.Entities;
using Indexer.Data.Interfaces.IRepositories;
using Indexer.Forms.Main;
using Indexer.Utilites;
using Indexer.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Indexer.Forms.UpdateCurrentDirectoryDbRecords
{
    public partial class frmUpdateCurrentDirectoryDbRecords : Form
    {

        public string _SelectedFilePath;
        public string _SelectedFileWithoutParentPath;
        //-----
        public string _Guid;
        public string _PersianMessage;
        public string _EnglishMessage;
        public string _FileName;
        public string _FileExtension;
        public string _FileSize;
        public string _PersianCategory;
        public string _EnglishCategory;
        public string _Description;
        public string _Attachment;
        public string _SequentialDirectory;
        public string _LastUpdateRecordDate;
        //----
        public frmUpdateCurrentDirectoryDbRecords()
        {
            InitializeComponent();

        }



        private void frmManageDirRecod_Load(object sender, EventArgs e)
        {
            txtAttachments.Text = _Attachment;
            txtdescription.Text = _Description;
            txtEnglishMessageToSearch.Text = _EnglishMessage;
            txtFileExtension.Text = _FileExtension;
            txtFileName.Text = _FileName;
            txtFileSize.Text = _FileSize;
            txtPersianMessageToSearch.Text = _PersianMessage;
            txtSequentialDirectoryToSave.Text = _SequentialDirectory;
            cbEnglishCategory.Text = _EnglishCategory;
            cbPersianCategory.Text = _PersianCategory;
            txtPathToSaveFileInDisk.Text = frmMain._CurrentDirectory;



        }





        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "all file|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                //----get FileName . by defult file name is SourcePath+\\+Filename ----
                //----Tip : filename and extension are filename.-----
                _SelectedFilePath = ofd.FileName;
                //-----Delete Source Path ------
                string[] temp = ofd.FileName.Split('\\');
                _SelectedFileWithoutParentPath = temp[temp.Length - 1];
                //-----
                txtFileName.Text = _SelectedFileWithoutParentPath;
                txtFileExtension.Text = Path.GetExtension(_SelectedFilePath);

                txtFileSize.Text = WorkWithFile.GetSizeOfFile(_SelectedFilePath);

            }
        }

        async private void btnUpdate_Click(object sender, EventArgs e)
        {
            //----- correct Filename example----
            //  string Filename = @"d:\WIN10.iso"; 
            //-----
            //------Fill PropertyMap ------------
            progressBar1.Value = 10;
            Cursor = Cursors.WaitCursor;
            List<PropertyMap> mainTablePropertiesToUpdate = new List<PropertyMap> {
                new PropertyMap()
                {

                    PropertyName = "StoredFileName",
                    PropertyValue=_Guid


                } ,

                 new PropertyMap()
                {

                    PropertyName = "LastUpdateRecordDate",
                    PropertyValue= DateTime.Now


            } ,


                    new PropertyMap()
                     {

                    PropertyName = "SequentialDirectory",
                    PropertyValue =txtSequentialDirectoryToSave.Text


            }
                    ,
                    new PropertyMap()
                     {

                    PropertyName = "PersianMessage",
                    PropertyValue =txtPersianMessageToSearch.Text


            }
                      ,
                    new PropertyMap()
                     {

                    PropertyName = "Attachment",
                    PropertyValue =txtAttachments.Text


            }
                     ,
                    new PropertyMap()
                     {

                    PropertyName = "Description",
                    PropertyValue =txtdescription.Text


            }
                     ,
                    new PropertyMap()
                     {

                    PropertyName = "EnglishCategory",
                    PropertyValue =cbEnglishCategory.Text


            }
                    ,
                    new PropertyMap()
                     {

                    PropertyName = "PersianCategory",
                    PropertyValue =cbPersianCategory.Text


            }
                     ,
                    new PropertyMap()
                     {

                    PropertyName = "EnglishMessage",
                    PropertyValue =txtEnglishMessageToSearch.Text


            }



                };
            progressBar1.Value += 10;
            //-----
            ///If the user selects a new file. The following records are updated. Otherwise, they will not change .
            ///
            ///
          
            string oldfileSavedInDisk = frmMain._CurrentDirectory + @"\" + _Guid;
            string fileDestination = Application.StartupPath + txtSequentialDirectoryToSave.Text + @"\" + _Guid;
            if (File.Exists(_SelectedFilePath))
            {
                if (File.Exists(oldfileSavedInDisk))
                    { 
                    
                    File.Delete(oldfileSavedInDisk);
                }
               
                mainTablePropertiesToUpdate.Add(new PropertyMap() { PropertyName = "FileExtension", PropertyValue = txtFileExtension.Text });
                mainTablePropertiesToUpdate.Add(new PropertyMap() { PropertyName = "FileName", PropertyValue = txtFileName.Text });
                mainTablePropertiesToUpdate.Add(new PropertyMap() { PropertyName = "FileSize", PropertyValue = txtFileSize.Text });
                //string DestinationPathWithName = frmMain._CurrentDirectory + @"\" + _Guid;
                File.Copy(_SelectedFilePath, fileDestination, true);

            }
            else if (File.Exists(oldfileSavedInDisk))
            {
                mainTablePropertiesToUpdate.Add(new PropertyMap() { PropertyName = "FileExtension", PropertyValue = txtFileExtension.Text });
                mainTablePropertiesToUpdate.Add(new PropertyMap() { PropertyName = "FileName", PropertyValue = txtFileName.Text });
                mainTablePropertiesToUpdate.Add(new PropertyMap() { PropertyName = "FileSize", PropertyValue = txtFileSize.Text });
                //string DestinationPathWithName = frmMain._CurrentDirectory + @"\" + _Guid;
                File.Copy(oldfileSavedInDisk, fileDestination, true);
                File.Delete(oldfileSavedInDisk);
            }
            progressBar1.Value += 20;
            //-----
            //----Tip---
            //Guid Column Not Change for Update Operation .
            //CreateRecordDate Not Change For Update Operation .
            //-----
            using (UnitOfWork _unitOfWork = new UnitOfWork())
            {

                IMainTableRepository mainTableRepository = _unitOfWork.MainTableRepository;

                Guid guid = Guid.Parse(_Guid);
                progressBar1.Value += 10;
                bool UpdateProductResult = await mainTableRepository.UpdateMany<MainTable>(n => n.RowGuid == guid, mainTablePropertiesToUpdate);
                if (UpdateProductResult)
                {
                    _unitOfWork.Save();
                    progressBar1.Value += 50;
                    Cursor = Cursors.Default;
                    MessageBox.Show("رکورد با موفقیت  بروز شد");
                    this.DialogResult = DialogResult.OK;
                    ////////////////////////////////////////////////////this.DialogResult = DialogResult.OK;
                }


            }
        }

        private void txtSequentialDirectoryToSave_TextChanged(object sender, EventArgs e)
        {
            txtPathToSaveFileInDisk.Text = Application.StartupPath + txtSequentialDirectoryToSave.Text;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }












        //--------------
    }

}
