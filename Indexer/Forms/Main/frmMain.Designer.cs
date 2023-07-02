
namespace Indexer.Forms.Main
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRcordToCurrentDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAllRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowCurrentDirectoryRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowRootDir = new System.Windows.Forms.Button();
            this.ExplorerDirectoriesListBox = new System.Windows.Forms.ListBox();
            this.ListBoxDirectoriesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenCurrentDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowCurrentDirectoryFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.HideCurrentDirectoryFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenAppFilesDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenApplicationStartUpDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshCurrentDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.NavigateBack = new System.Windows.Forms.Button();
            this.txtCurrentPath = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.ListBoxDirectoriesContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRcordToCurrentDirectory});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.actionToolStripMenuItem.Text = "عملیات پایگاه داده";
            // 
            // AddRcordToCurrentDirectory
            // 
            this.AddRcordToCurrentDirectory.Name = "AddRcordToCurrentDirectory";
            this.AddRcordToCurrentDirectory.Size = new System.Drawing.Size(297, 26);
            this.AddRcordToCurrentDirectory.Text = "اضافه کردن رکورد به مسیر فعلی";
            this.AddRcordToCurrentDirectory.Click += new System.EventHandler(this.AddRcordToCurrentDirectory_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowAllRecord,
            this.ShowCurrentDirectoryRecords});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.editToolStripMenuItem.Text = "لیست ها";
            // 
            // ShowAllRecord
            // 
            this.ShowAllRecord.Name = "ShowAllRecord";
            this.ShowAllRecord.Size = new System.Drawing.Size(272, 26);
            this.ShowAllRecord.Text = "تمام رکورد ها";
            this.ShowAllRecord.Click += new System.EventHandler(this.ShowAllRecord_Click);
            // 
            // ShowCurrentDirectoryRecords
            // 
            this.ShowCurrentDirectoryRecords.Name = "ShowCurrentDirectoryRecords";
            this.ShowCurrentDirectoryRecords.Size = new System.Drawing.Size(272, 26);
            this.ShowCurrentDirectoryRecords.Text = "لیست رکورد های مسیر فعلی";
            this.ShowCurrentDirectoryRecords.Click += new System.EventHandler(this.ShowCurrentDirectoryRecords_Click);
            // 
            // ShowRootDir
            // 
            this.ShowRootDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRootDir.Location = new System.Drawing.Point(1065, 471);
            this.ShowRootDir.Name = "ShowRootDir";
            this.ShowRootDir.Size = new System.Drawing.Size(111, 47);
            this.ShowRootDir.TabIndex = 3;
            this.ShowRootDir.Text = "پوشه اصلی ";
            this.ShowRootDir.Click += new System.EventHandler(this.ShowRootDir_Click);
            // 
            // ExplorerDirectoriesListBox
            // 
            this.ExplorerDirectoriesListBox.ContextMenuStrip = this.ListBoxDirectoriesContextMenuStrip;
            this.ExplorerDirectoriesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExplorerDirectoriesListBox.FormattingEnabled = true;
            this.ExplorerDirectoriesListBox.ItemHeight = 20;
            this.ExplorerDirectoriesListBox.Location = new System.Drawing.Point(50, 116);
            this.ExplorerDirectoriesListBox.Name = "ExplorerDirectoriesListBox";
            this.ExplorerDirectoriesListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExplorerDirectoriesListBox.Size = new System.Drawing.Size(1143, 344);
            this.ExplorerDirectoriesListBox.TabIndex = 1;
            this.ExplorerDirectoriesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ExplorerDirectoriesListBox_MouseDoubleClick);
            // 
            // ListBoxDirectoriesContextMenuStrip
            // 
            this.ListBoxDirectoriesContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ListBoxDirectoriesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNewFolder,
            this.DeleteSelected,
            this.OpenCurrentDirectory,
            this.ShowCurrentDirectoryFiles,
            this.HideCurrentDirectoryFiles,
            this.OpenAppFilesDirectory,
            this.OpenApplicationStartUpDirectory,
            this.RefreshCurrentDirectory});
            this.ListBoxDirectoriesContextMenuStrip.Name = "ListBoxDirectoriesContextMenuStrip";
            this.ListBoxDirectoriesContextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListBoxDirectoriesContextMenuStrip.Size = new System.Drawing.Size(397, 224);
            // 
            // CreateNewFolder
            // 
            this.CreateNewFolder.Name = "CreateNewFolder";
            this.CreateNewFolder.Size = new System.Drawing.Size(396, 24);
            this.CreateNewFolder.Text = "ایجاد پوشه";
            this.CreateNewFolder.Click += new System.EventHandler(this.CreateNewFolder_Click);
            // 
            // DeleteSelected
            // 
            this.DeleteSelected.Name = "DeleteSelected";
            this.DeleteSelected.Size = new System.Drawing.Size(396, 24);
            this.DeleteSelected.Text = "حذف";
            this.DeleteSelected.Click += new System.EventHandler(this.DeleteSelected_Click);
            // 
            // OpenCurrentDirectory
            // 
            this.OpenCurrentDirectory.Name = "OpenCurrentDirectory";
            this.OpenCurrentDirectory.Size = new System.Drawing.Size(396, 24);
            this.OpenCurrentDirectory.Text = "بازکردن مسیر فعلی";
            this.OpenCurrentDirectory.Click += new System.EventHandler(this.OpenCurrentDirectory_Click);
            // 
            // ShowCurrentDirectoryFiles
            // 
            this.ShowCurrentDirectoryFiles.Name = "ShowCurrentDirectoryFiles";
            this.ShowCurrentDirectoryFiles.Size = new System.Drawing.Size(396, 24);
            this.ShowCurrentDirectoryFiles.Text = "نمایش فایل های مسیر فعلی ( در لیست باکس)";
            this.ShowCurrentDirectoryFiles.Click += new System.EventHandler(this.ShowCurrentDirectoryFiles_Click);
            // 
            // HideCurrentDirectoryFiles
            // 
            this.HideCurrentDirectoryFiles.Name = "HideCurrentDirectoryFiles";
            this.HideCurrentDirectoryFiles.Size = new System.Drawing.Size(396, 24);
            this.HideCurrentDirectoryFiles.Text = "مخفی کردن فایل های مسیر فعلی (در لیست باکس)";
            this.HideCurrentDirectoryFiles.Click += new System.EventHandler(this.HideCurrentDirectoryFiles_Click);
            // 
            // OpenAppFilesDirectory
            // 
            this.OpenAppFilesDirectory.Name = "OpenAppFilesDirectory";
            this.OpenAppFilesDirectory.Size = new System.Drawing.Size(396, 24);
            this.OpenAppFilesDirectory.Text = "باز کردن پوشه AppFiles ";
            this.OpenAppFilesDirectory.Click += new System.EventHandler(this.OpenAppFilesDirectory_Click);
            // 
            // OpenApplicationStartUpDirectory
            // 
            this.OpenApplicationStartUpDirectory.Name = "OpenApplicationStartUpDirectory";
            this.OpenApplicationStartUpDirectory.Size = new System.Drawing.Size(396, 24);
            this.OpenApplicationStartUpDirectory.Text = "باز کردن پوشه استارت اپ برنامه";
            this.OpenApplicationStartUpDirectory.Click += new System.EventHandler(this.OpenApplicationStartUpDirectory_Click);
            // 
            // RefreshCurrentDirectory
            // 
            this.RefreshCurrentDirectory.Name = "RefreshCurrentDirectory";
            this.RefreshCurrentDirectory.Size = new System.Drawing.Size(396, 24);
            this.RefreshCurrentDirectory.Text = "Refresh";
            this.RefreshCurrentDirectory.Click += new System.EventHandler(this.RefreshCurrentDirectory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "مسیر فعلی : ";
            // 
            // NavigateBack
            // 
            this.NavigateBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigateBack.Location = new System.Drawing.Point(913, 471);
            this.NavigateBack.Name = "NavigateBack";
            this.NavigateBack.Size = new System.Drawing.Size(130, 47);
            this.NavigateBack.TabIndex = 2;
            this.NavigateBack.Text = "عقب";
            this.NavigateBack.UseVisualStyleBackColor = true;
            this.NavigateBack.Click += new System.EventHandler(this.NavigateBack_Click);
            // 
            // txtCurrentPath
            // 
            this.txtCurrentPath.Location = new System.Drawing.Point(110, 31);
            this.txtCurrentPath.Multiline = true;
            this.txtCurrentPath.Name = "txtCurrentPath";
            this.txtCurrentPath.ReadOnly = true;
            this.txtCurrentPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCurrentPath.Size = new System.Drawing.Size(1083, 45);
            this.txtCurrentPath.TabIndex = 19;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(110, 84);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1083, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 679);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtCurrentPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NavigateBack);
            this.Controls.Add(this.ExplorerDirectoriesListBox);
            this.Controls.Add(this.ShowRootDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "کاوشگر ایندکسر";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ListBoxDirectoriesContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button ShowRootDir;
        private System.Windows.Forms.ListBox ExplorerDirectoriesListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button NavigateBack;
        private System.Windows.Forms.ToolStripMenuItem ShowAllRecord;
        private System.Windows.Forms.ToolStripMenuItem ShowCurrentDirectoryRecords;
        private System.Windows.Forms.TextBox txtCurrentPath;
        private System.Windows.Forms.ContextMenuStrip ListBoxDirectoriesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CreateNewFolder;
        private System.Windows.Forms.ToolStripMenuItem OpenCurrentDirectory;
        private System.Windows.Forms.ToolStripMenuItem RefreshCurrentDirectory;
        private System.Windows.Forms.ToolStripMenuItem DeleteSelected;
        private System.Windows.Forms.ToolStripMenuItem AddRcordToCurrentDirectory;
        private System.Windows.Forms.ToolStripMenuItem ShowCurrentDirectoryFiles;
        private System.Windows.Forms.ToolStripMenuItem OpenAppFilesDirectory;
        private System.Windows.Forms.ToolStripMenuItem OpenApplicationStartUpDirectory;
        private System.Windows.Forms.ToolStripMenuItem HideCurrentDirectoryFiles;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

