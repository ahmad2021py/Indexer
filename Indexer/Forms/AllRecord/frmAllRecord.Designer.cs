
namespace Indexer.Forms.AllRecord
{
    partial class frmAllRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.DGV1ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdateSelectedRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSlectedRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.دریافتفایلرکوردفعلیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بازکردنفایلرکوردفعلیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بررسیوجودفایلرکوردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbFilterToSearch = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTextToSearch = new System.Windows.Forms.TextBox();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.DGV1ContextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV1.ColumnHeadersHeight = 50;
            this.DGV1.ContextMenuStrip = this.DGV1ContextMenuStrip;
            this.DGV1.Dock = System.Windows.Forms.DockStyle.Right;
            this.DGV1.Location = new System.Drawing.Point(499, 0);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 30;
            this.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.Size = new System.Drawing.Size(931, 560);
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(27, 305);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "جستجو و فیلتر";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbFilterToSearch
            // 
            this.cbFilterToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterToSearch.FormattingEnabled = true;
            this.cbFilterToSearch.Location = new System.Drawing.Point(27, 26);
            this.cbFilterToSearch.Name = "cbFilterToSearch";
            this.cbFilterToSearch.Size = new System.Drawing.Size(388, 28);
            this.cbFilterToSearch.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTextToSearch);
            this.groupBox1.Controls.Add(this.cbFilterToSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 364);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "فیلتر : ";
            // 
            // txtTextToSearch
            // 
            this.txtTextToSearch.Location = new System.Drawing.Point(27, 71);
            this.txtTextToSearch.Multiline = true;
            this.txtTextToSearch.Name = "txtTextToSearch";
            this.txtTextToSearch.Size = new System.Drawing.Size(439, 228);
            this.txtTextToSearch.TabIndex = 1;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(12, 419);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(464, 23);
            this.ProgressBar1.TabIndex = 4;
            // 
            // frmAllRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1430, 560);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV1);
            this.Name = "frmAllRecord";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تمام رکورد ها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAllRecord_FormClosed);
            this.Load += new System.EventHandler(this.frmAllRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.DGV1ContextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbFilterToSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTextToSearch;
        private System.Windows.Forms.ContextMenuStrip DGV1ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem UpdateSelectedRecord;
        private System.Windows.Forms.ToolStripMenuItem DeleteSlectedRecord;
        private System.Windows.Forms.ToolStripMenuItem دریافتفایلرکوردفعلیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بازکردنفایلرکوردفعلیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بررسیوجودفایلرکوردToolStripMenuItem;
        private System.Windows.Forms.ProgressBar ProgressBar1;
    }
}