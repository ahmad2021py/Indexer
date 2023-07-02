using Indexer.Data.Context;
using Indexer.Data.Entities;
using Indexer.Data.Interfaces.IRepositories;
using Indexer.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Indexer.Forms.CurrentDirectoryRecords
{
    public partial class frmCurrentDirectoryRecords
    {


        DataTable DesignAndFillDataTable(List<MainTable> DbMainTablelist)
        {

            DataTable dataTable = new DataTable();
            //-----------Design datatable---------
            //----------- Create a DataTable and add 6 Columns to it---------
            //  DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("Row", typeof(long));
            dataTable.Columns.Add("RowGuid", typeof(Guid));
            dataTable.Columns.Add("PersianMessage", typeof(string));
            dataTable.Columns.Add("EnglishMessage", typeof(string));
            dataTable.Columns.Add("FileName", typeof(string));
            dataTable.Columns.Add("FileExtension", typeof(string));
            dataTable.Columns.Add("FileSize", typeof(string));
            dataTable.Columns.Add("PersianCategory", typeof(string));
            dataTable.Columns.Add("EnglishCategory", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));
            dataTable.Columns.Add("Attachment", typeof(string));
            dataTable.Columns.Add("SequentialDirectory", typeof(string));
            dataTable.Columns.Add("CreateRecordDate", typeof(string));
            dataTable.Columns.Add("LastUpdateRecordDate", typeof(string));
            dataTable.Columns.Add("StoredFileName", typeof(string));


            dataTable.Columns["Row"].Caption = " ردیف ";
            dataTable.Columns["RowGuid"].Caption = " نام فیزیکی_کد گاید";
            dataTable.Columns["PersianMessage"].Caption = " پیغام فارسی";
            dataTable.Columns["EnglishMessage"].Caption = "پیغام انگلیسی";
            dataTable.Columns["FileName"].Caption = "نام فایل";
            dataTable.Columns["FileExtension"].Caption = "پسوند";
            dataTable.Columns["FileSize"].Caption = " اندازه فایل";
            dataTable.Columns["PersianCategory"].Caption = "دسته بندی فارسی";
            dataTable.Columns["EnglishCategory"].Caption = " دسته بندی انگلیسی";
            dataTable.Columns["Description"].Caption = " توضیحات";
            dataTable.Columns["Attachment"].Caption = " پیوست";
            dataTable.Columns["SequentialDirectory"].Caption = " پوشه بندی سلسله مراتبی";
            dataTable.Columns["CreateRecordDate"].Caption = "تاریخ ایجاد رکورد";
            dataTable.Columns["LastUpdateRecordDate"].Caption = "آخرین تاریخ ویرایش";
            dataTable.Columns["StoredFileName"].Caption = "اسم فایل در دیسک";
            //-----

            //--------------An Instanse to Store MildadiDates------------
            List<DateTime> MiladiCreateRecordDate = new List<DateTime>();
            List<DateTime> MiladiLastUpdateRecordDate = new List<DateTime>();
            //-----
            //-------Get MiladiDateTime List and Convert To ShamsiDate--------- 
            foreach (var n in DbMainTablelist)
            {
                MiladiCreateRecordDate.Add((DateTime)n.CreateRecordDate);
                MiladiLastUpdateRecordDate.Add((DateTime)n.LastUpdateRecordDate);
            }


            WorkWithDate workWithDate = new WorkWithDate();
            List<string> ShamsiCreateRecordDate = new List<string>();
            List<string> ShamsiLastUpdateRecordDate = new List<string>();
            foreach (var n in MiladiCreateRecordDate)
            {
                ShamsiCreateRecordDate.Add(workWithDate.MiladiToShamsi(n));
            }

            foreach (var n in MiladiLastUpdateRecordDate)
            {
                ShamsiLastUpdateRecordDate.Add(workWithDate.MiladiToShamsi(n));
            }


            //-----
            //-------------seed data to dataTable---------
            for (int i = 0; i < DbMainTablelist.Count; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["Row"] = DbMainTablelist[i].Row;
                dataRow["SequentialDirectory"] = DbMainTablelist[i].SequentialDirectory;
                dataRow["Attachment"] = DbMainTablelist[i].Attachment;
                dataRow["Description"] = DbMainTablelist[i].Description;
                dataRow["EnglishCategory"] = DbMainTablelist[i].EnglishCategory;
                dataRow["PersianCategory"] = DbMainTablelist[i].PersianCategory;
                dataRow["FileSize"] = DbMainTablelist[i].FileSize;
                dataRow["FileExtension"] = DbMainTablelist[i].FileExtension;
                dataRow["FileName"] = DbMainTablelist[i].FileName;
                dataRow["EnglishMessage"] = DbMainTablelist[i].EnglishMessage;
                dataRow["PersianMessage"] = DbMainTablelist[i].PersianMessage;
                dataRow["RowGuid"] = DbMainTablelist[i].RowGuid;
                dataRow["StoredFileName"] = DbMainTablelist[i].StoredFileName;
                dataRow["CreateRecordDate"] = ShamsiCreateRecordDate[i];
                dataRow["LastUpdateRecordDate"] = ShamsiLastUpdateRecordDate[i];
                dataTable.Rows.Add(dataRow);

            }
            //-----
            return dataTable;

        }










        async void LoadData()
        {
            progressBar1.Value = 10;
            Cursor = Cursors.WaitCursor;
            //---------Get List Of SellInvoice Table Records-----------
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {

                IMainTableRepository mainTableRepository = unitOfWork.MainTableRepository;
                progressBar1.Value += 10;
                IEnumerable<MainTable> EnumerableMainTablelist = await mainTableRepository.GetAll<MainTable>(n => n.SequentialDirectory == _CurrentDirectoryToGetRecords);
                List<MainTable> DbMainTablelist = new List<MainTable>(EnumerableMainTablelist);
                progressBar1.Value += 40;
                //-----

                //-------------Show In DGV1-----------
                DataTable customeDataTable = DesignAndFillDataTable(DbMainTablelist);

                DGV1.DataSource = customeDataTable;
                progressBar1.Value += 20;
                //-----
                //-------------Replace Default Header Text with DataTable Columns Captions----------
                foreach (DataGridViewColumn n in DGV1.Columns)
                {
                    n.HeaderText = customeDataTable.Columns[n.Name].Caption;
                }
                //-----
                //----------Set Optional DGV1 Property----------
                DGV1.ColumnHeadersHeight = 80;
                progressBar1.Value += 20;
                Cursor = Cursors.Default;
                //-----
            }
        }










        void fill_Combo()
        {

            cbFilterToSearch.Items.Add("RowGuid");
            cbFilterToSearch.Items.Add("PersianMessage");
            cbFilterToSearch.Items.Add("EnglishMessage");
            cbFilterToSearch.Items.Add("FileName");
            cbFilterToSearch.Items.Add("FileExtension");
            cbFilterToSearch.Items.Add("FileSize");
            cbFilterToSearch.Items.Add("PersianCategory");
            cbFilterToSearch.Items.Add("EnglishCategory");
            cbFilterToSearch.Items.Add("Description");
            cbFilterToSearch.Items.Add("SequentialDirectory");
            cbFilterToSearch.Items.Add("CreateRecordDate");
            cbFilterToSearch.Items.Add("LastUpdateRecordDate");
            cbFilterToSearch.Items.Add("StoredFileName");
        }







        //---------------
    }
}
