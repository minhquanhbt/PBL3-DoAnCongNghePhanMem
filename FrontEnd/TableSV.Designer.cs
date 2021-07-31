
namespace ĐoAnCongNghePhanMem.FrontEnd
{
    partial class TableSV
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgvLichSV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnHuyDK = new System.Windows.Forms.Button();
            this.btnDK = new System.Windows.Forms.Button();
            this.btnChonGV = new System.Windows.Forms.Button();
            this.dtgvLopSV = new System.Windows.Forms.DataGridView();
            this.cbbGV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopSV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1078, 538);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Ivory;
            this.tabPage1.Controls.Add(this.dtgvLichSV);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1070, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lịch học";
            // 
            // dtgvLichSV
            // 
            this.dtgvLichSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLichSV.Location = new System.Drawing.Point(12, 14);
            this.dtgvLichSV.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvLichSV.Name = "dtgvLichSV";
            this.dtgvLichSV.RowHeadersWidth = 62;
            this.dtgvLichSV.RowTemplate.Height = 31;
            this.dtgvLichSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLichSV.Size = new System.Drawing.Size(1039, 462);
            this.dtgvLichSV.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Ivory;
            this.tabPage2.Controls.Add(this.btnHuyDK);
            this.tabPage2.Controls.Add(this.btnDK);
            this.tabPage2.Controls.Add(this.btnChonGV);
            this.tabPage2.Controls.Add(this.dtgvLopSV);
            this.tabPage2.Controls.Add(this.cbbGV);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1070, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đăng ký";
            // 
            // btnHuyDK
            // 
            this.btnHuyDK.BackColor = System.Drawing.Color.AliceBlue;
            this.btnHuyDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDK.ForeColor = System.Drawing.Color.SlateGray;
            this.btnHuyDK.Location = new System.Drawing.Point(869, 432);
            this.btnHuyDK.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyDK.Name = "btnHuyDK";
            this.btnHuyDK.Size = new System.Drawing.Size(182, 47);
            this.btnHuyDK.TabIndex = 7;
            this.btnHuyDK.Text = "Hủy Đăng Ký";
            this.btnHuyDK.UseVisualStyleBackColor = false;
            this.btnHuyDK.Click += new System.EventHandler(this.btnHuyDK_Click);
            // 
            // btnDK
            // 
            this.btnDK.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDK.ForeColor = System.Drawing.Color.SlateGray;
            this.btnDK.Location = new System.Drawing.Point(14, 432);
            this.btnDK.Margin = new System.Windows.Forms.Padding(2);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(182, 47);
            this.btnDK.TabIndex = 6;
            this.btnDK.Text = "Đăng Ký";
            this.btnDK.UseVisualStyleBackColor = false;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // btnChonGV
            // 
            this.btnChonGV.BackColor = System.Drawing.Color.AliceBlue;
            this.btnChonGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonGV.ForeColor = System.Drawing.Color.SlateGray;
            this.btnChonGV.Location = new System.Drawing.Point(518, 14);
            this.btnChonGV.Margin = new System.Windows.Forms.Padding(2);
            this.btnChonGV.Name = "btnChonGV";
            this.btnChonGV.Size = new System.Drawing.Size(121, 43);
            this.btnChonGV.TabIndex = 5;
            this.btnChonGV.Text = "OK";
            this.btnChonGV.UseVisualStyleBackColor = false;
            this.btnChonGV.Click += new System.EventHandler(this.btnChonGV_Click);
            // 
            // dtgvLopSV
            // 
            this.dtgvLopSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLopSV.Location = new System.Drawing.Point(13, 73);
            this.dtgvLopSV.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvLopSV.Name = "dtgvLopSV";
            this.dtgvLopSV.RowHeadersWidth = 62;
            this.dtgvLopSV.RowTemplate.Height = 31;
            this.dtgvLopSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLopSV.Size = new System.Drawing.Size(1036, 339);
            this.dtgvLopSV.TabIndex = 2;
            // 
            // cbbGV
            // 
            this.cbbGV.FormattingEnabled = true;
            this.cbbGV.Location = new System.Drawing.Point(125, 14);
            this.cbbGV.Margin = new System.Windows.Forms.Padding(2);
            this.cbbGV.Name = "cbbGV";
            this.cbbGV.Size = new System.Drawing.Size(356, 33);
            this.cbbGV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giáo viên";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.SlateGray;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Lavender;
            this.linkLabel1.Location = new System.Drawing.Point(6, 542);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(150, 25);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đổi mật khẩu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.SlateGray;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Lavender;
            this.linkLabel2.Location = new System.Drawing.Point(966, 542);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(119, 25);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Đăng xuất";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // TableSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1106, 590);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.linkLabel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TableSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableSV";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgvLichSV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgvLopSV;
        private System.Windows.Forms.ComboBox cbbGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuyDK;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Button btnChonGV;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}