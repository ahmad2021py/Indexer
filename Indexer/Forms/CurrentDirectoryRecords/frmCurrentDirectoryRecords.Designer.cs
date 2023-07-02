
namespace Indexer.Forms.CurrentDirectoryRecords
{
    partial class frmCurrentDirectoryRecords
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
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.DGV1ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdateSelectedRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSlectedRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.دریافتفایلرکوردفعلیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بازکردنفایلرکوردفعلیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بررسیوجودفایلرکوردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterToSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTextToSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.عملیاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بازکردندایرکتوریجدولفعلیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.DGV1ContextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.ContextMenuStrip = this.DGV1ContextMenuStrip;
            this.DGV1.Location = new System.Drawing.Point(547, 51);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.Size = new System.Drawing.Size(702, 365);
            this.DGV1.TabIndex = 3;
            this.DGV1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV1_RowHeaderMouseClick);
            // 
            // DGV1ContextMenuStrip
            // 
            this.DGV1ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DGV1ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateSelectedRecord,
            this.DeleteSlectedRecord,
            this.دریافتفایلرکوردفعلیToolStripMenuItem,
            this.بازکردنفایلرکوردفعلیToolStripMenuItem,
            this.بررسیوجودفایلرکوردToolStripMenuItem});
            this.DGV1ContextMenuStrip.Name = "DGV1ContextMenuStrip";
            this.DGV1ContextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV1ContextMenuStrip.Size = new System.Drawing.Size(301, 124);
            // 
            // UpdateSelectedRecord
            // 
            this.UpdateSelectedRecord.Name = "UpdateSelectedRecord";
            this.UpdateSelectedRecord.Size = new System.Drawing.Size(300, 24);
            this.UpdateSelectedRecord.Text = "ویرایش رکورد انتخابی";
            this.UpdateSelectedRecord.Click += new System.EventHandler(this.UpdateSelectedRecord_Click);
            // 
            // DeleteSlectedRecord
            // 
            this.DeleteSlectedRecord.Name = "DeleteSlectedRecord";
            this.DeleteSlectedRecord.Size = new System.Drawing.Size(300, 24);
            this.DeleteSlectedRecord.Text = "حذف رکورد انتخابی";
            this.DeleteSlectedRecord.Click += new System.EventHandler(this.DeleteSlectedRecord_Click);
            // 
            // دریافتفایلرکوردفعلیToolStripMenuItem
            // 
            this.دریافتفایلرکوردفعلیToolStripMenuItem.Name = "دریافتفایلرکوردفعلیToolStripMenuItem";
            this.دریافتفایلرکوردفعلیToolStripMenuItem.Size = new System.Drawing.Size(300, 24);
            this.دریافتفایلرکوردفعلیToolStripMenuItem.Text = "دریافت فایل  رکورد  فعلی";
            this.دریافتفایلرکوردفعلیToolStripMenuItem.Click += new System.EventHandler(this.دریافتفایلرکوردفعلیToolStripMenuItem_Click);
            // 
            // بازکردنفایلرکوردفعلیToolStripMenuItem
            // 
            this.بازکردنفایلرکوردفعلیToolStripMenuItem.Name = "بازکردنفایلرکوردفعلیToolStripMenuItem";
            this.بازکردنفایلرکوردفعلیToolStripMenuItem.Size = new System.Drawing.Size(300, 24);
            this.بازکردنفایلرکوردفعلیToolStripMenuItem.Text = "باز کردن فایل رکورد فعلی (غیرفعال)";
            this.بازکردنفایلرکوردفعلیToolStripMenuItem.Click += new System.EventHandler(this.بازکردنفایلرکوردفعلیToolStripMenuItem_Click);
            // 
            // بررسیوجودفایلرکوردToolStripMenuItem
            // 
            this.بررسیوجودفایلرکوردToolStripMenuItem.Name = "بررسیوجودفایلرکوردToolStripMenuItem";
            this.بررسیوجودفایلرکوردToolStripMenuItem.Size = new System.Drawing.Size(300, 24);
            this.بررسیوجودفایلرکوردToolStripMenuItem.Text = "بررسی وجود فایل رکورد  در دیسک";
            this.بررسیوجودفایلرکوردToolStripMenuItem.Click += new System.EventHandler(this.بررسیوجودفایلرکوردToolStripMenuItem_Click);
            // 
            // cbFilterToSearch
            // 
            this.cbFilterToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterToSearch.FormattingEnabled = true;
            this.cbFilterToSearch.Location = new System.Drawing.Point(84, 30);
            this.cbFilterToSearch.Name = "cbFilterToSearch";
            this.cbFilterToSearch.Size = new System.Drawing.Size(439, 28);
            this.cbFilterToSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(389, 232);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "جستجو و فیلتر";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTextToSearch
            // 
            this.txtTextToSearch.Location = new System.Drawing.Point(84, 92);
            this.txtTextToSearch.Multiline = true;
            this.txtTextToSearch.Name = "txtTextToSearch";
            this.txtTextToSearch.Size = new System.Drawing.Size(439, 121);
            this.txtTextToSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "فیلتر : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عملیاتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // عملیاتToolStripMenuItem
            // 
            this.عملیاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بازکردندایرکتوریجدولفعلیToolStripMenuItem});
            this.عملیاتToolStripMenuItem.Name = "عملیاتToolStripMenuItem";
            this.عملیاتToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.عملیاتToolStripMenuItem.Text = "عملیات";
            // 
            // بازکردندایرکتوریجدولفعلیToolStripMenuItem
            // 
            this.بازکردندایرکتوریجدولفعلیToolStripMenuItem.Name = "بازکردندایرکتوریجدولفعلیToolStripMenuItem";
            this.بازکردندایرکتوریجدولفعلیToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.بازکردندایرکتوریجدولفعلیToolStripMenuItem.Text = "بازکردن دایرکتوری جدول فعلی";
            this.بازکردندایرکتوریجدولفعلیToolStripMenuItem.Click += new System.EventHandler(this.بازکردندایرکتوریجدولفعلیToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 295);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(507, 27);
            this.progressBar1.TabIndex = 7;
            // 
            // frmCurrentDirectoryRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 496);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbFilterToSearch);
            this.Controls.Add(this.txtTextToSearch);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCurrentDirectoryRecords";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "رکورد های دایرکتوری فعلی";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCurrentDirectoryRecords_FormClosed);
            this.Load += new System.EventHandler(this.frmCurrentDirectoryRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.DGV1ContextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.ComboBox cbFilterToSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTextToSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip DGV1ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem UpdateSelectedRecord;
        private System.Windows.Forms.ToolStripMenuItem DeleteSlectedRecord;
        private System.Windows.Forms.ToolStripMenuItem دریافتفایلرکوردفعلیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بازکردنفایلرکوردفعلیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بررسیوجودفایلرکوردToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem عملیاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بازکردندایرکتوریجدولفعلیToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}