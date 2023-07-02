
namespace Indexer.Forms.AddRecord
{
    partial class frmAddRecod
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
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPathToSaveFile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.txtFileExtension = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.acctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtPersianMessageToSearch = new System.Windows.Forms.TextBox();
            this.txtEnglishMessageToSearch = new System.Windows.Forms.TextBox();
            this.txtAttachments = new System.Windows.Forms.TextBox();
            this.cbPersianCategory = new System.Windows.Forms.ComboBox();
            this.cbEnglishCategory = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSequentialDirectoryToSave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addRecordProgressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1129, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "نام فایل : ";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(1116, 21);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(90, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "انتخاب فایل";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1129, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "پسوند فایل : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPathToSaveFile);
            this.groupBox1.Location = new System.Drawing.Point(45, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1242, 98);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مسیر جهت ذخیره در برنامه";
            // 
            // txtPathToSaveFile
            // 
            this.txtPathToSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToSaveFile.Location = new System.Drawing.Point(6, 37);
            this.txtPathToSaveFile.Multiline = true;
            this.txtPathToSaveFile.Name = "txtPathToSaveFile";
            this.txtPathToSaveFile.ReadOnly = true;
            this.txtPathToSaveFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPathToSaveFile.Size = new System.Drawing.Size(1054, 55);
            this.txtPathToSaveFile.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFileSize);
            this.groupBox2.Controls.Add(this.txtFileExtension);
            this.groupBox2.Controls.Add(this.txtFileName);
            this.groupBox2.Controls.Add(this.btnSelectFile);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(45, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1245, 224);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مشخصات فایل";
            // 
            // txtFileSize
            // 
            this.txtFileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileSize.Location = new System.Drawing.Point(843, 175);
            this.txtFileSize.Multiline = true;
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.ReadOnly = true;
            this.txtFileSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFileSize.Size = new System.Drawing.Size(250, 33);
            this.txtFileSize.TabIndex = 12;
            // 
            // txtFileExtension
            // 
            this.txtFileExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileExtension.Location = new System.Drawing.Point(843, 107);
            this.txtFileExtension.Multiline = true;
            this.txtFileExtension.Name = "txtFileExtension";
            this.txtFileExtension.ReadOnly = true;
            this.txtFileExtension.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFileExtension.Size = new System.Drawing.Size(250, 33);
            this.txtFileExtension.TabIndex = 12;
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(6, 58);
            this.txtFileName.Multiline = true;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFileName.Size = new System.Drawing.Size(1087, 40);
            this.txtFileName.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1129, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "اندازه فایل : ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acctionToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 52);
            // 
            // acctionToolStripMenuItem
            // 
            this.acctionToolStripMenuItem.Name = "acctionToolStripMenuItem";
            this.acctionToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.acctionToolStripMenuItem.Text = "Action";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1066, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "پیغام فارسی برای جستجو : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1094, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "توضیحات : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1060, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "پیغام انگلیسی برای جستجو : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1069, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "دسته بندی به انگلیسی : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1103, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "پیوست ها :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1075, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "دسته بندی به فارسی : ";
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(6, 177);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(1054, 86);
            this.txtdescription.TabIndex = 3;
            // 
            // txtPersianMessageToSearch
            // 
            this.txtPersianMessageToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersianMessageToSearch.Location = new System.Drawing.Point(6, 269);
            this.txtPersianMessageToSearch.Multiline = true;
            this.txtPersianMessageToSearch.Name = "txtPersianMessageToSearch";
            this.txtPersianMessageToSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPersianMessageToSearch.Size = new System.Drawing.Size(1054, 91);
            this.txtPersianMessageToSearch.TabIndex = 4;
            // 
            // txtEnglishMessageToSearch
            // 
            this.txtEnglishMessageToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglishMessageToSearch.Location = new System.Drawing.Point(3, 380);
            this.txtEnglishMessageToSearch.Multiline = true;
            this.txtEnglishMessageToSearch.Name = "txtEnglishMessageToSearch";
            this.txtEnglishMessageToSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnglishMessageToSearch.Size = new System.Drawing.Size(1057, 91);
            this.txtEnglishMessageToSearch.TabIndex = 5;
            // 
            // txtAttachments
            // 
            this.txtAttachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttachments.Location = new System.Drawing.Point(6, 493);
            this.txtAttachments.Multiline = true;
            this.txtAttachments.Name = "txtAttachments";
            this.txtAttachments.Size = new System.Drawing.Size(1057, 86);
            this.txtAttachments.TabIndex = 6;
            // 
            // cbPersianCategory
            // 
            this.cbPersianCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPersianCategory.FormattingEnabled = true;
            this.cbPersianCategory.Location = new System.Drawing.Point(386, 18);
            this.cbPersianCategory.Name = "cbPersianCategory";
            this.cbPersianCategory.Size = new System.Drawing.Size(674, 28);
            this.cbPersianCategory.TabIndex = 1;
            // 
            // cbEnglishCategory
            // 
            this.cbEnglishCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnglishCategory.FormattingEnabled = true;
            this.cbEnglishCategory.Location = new System.Drawing.Point(386, 72);
            this.cbEnglishCategory.Name = "cbEnglishCategory";
            this.cbEnglishCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbEnglishCategory.Size = new System.Drawing.Size(674, 28);
            this.cbEnglishCategory.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbEnglishCategory);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.cbPersianCategory);
            this.groupBox3.Controls.Add(this.txtSequentialDirectoryToSave);
            this.groupBox3.Controls.Add(this.txtAttachments);
            this.groupBox3.Controls.Add(this.txtEnglishMessageToSearch);
            this.groupBox3.Controls.Add(this.txtPersianMessageToSearch);
            this.groupBox3.Controls.Add(this.txtdescription);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(45, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(1245, 746);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اطلاعات تکمیلی";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 705);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSequentialDirectoryToSave
            // 
            this.txtSequentialDirectoryToSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSequentialDirectoryToSave.Location = new System.Drawing.Point(6, 602);
            this.txtSequentialDirectoryToSave.Multiline = true;
            this.txtSequentialDirectoryToSave.Name = "txtSequentialDirectoryToSave";
            this.txtSequentialDirectoryToSave.ReadOnly = true;
            this.txtSequentialDirectoryToSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSequentialDirectoryToSave.Size = new System.Drawing.Size(1057, 86);
            this.txtSequentialDirectoryToSave.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1069, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "پوشه بندی سسله مراتبی : ";
            // 
            // addRecordProgressBar
            // 
            this.addRecordProgressBar.Location = new System.Drawing.Point(45, 1173);
            this.addRecordProgressBar.Name = "addRecordProgressBar";
            this.addRecordProgressBar.Size = new System.Drawing.Size(1245, 23);
            this.addRecordProgressBar.TabIndex = 8;
            // 
            // frmAddRecod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(80, 80);
            this.ClientSize = new System.Drawing.Size(1368, 495);
            this.Controls.Add(this.addRecordProgressBar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddRecod";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ذخیره رکورد جدید";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddRecod_FormClosed);
            this.Load += new System.EventHandler(this.frmManageDirRecod_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPathToSaveFile;
        private System.Windows.Forms.TextBox txtFileExtension;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtPersianMessageToSearch;
        private System.Windows.Forms.TextBox txtEnglishMessageToSearch;
        private System.Windows.Forms.TextBox txtAttachments;
        private System.Windows.Forms.ComboBox cbPersianCategory;
        private System.Windows.Forms.ComboBox cbEnglishCategory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSequentialDirectoryToSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ProgressBar addRecordProgressBar;
    }
}