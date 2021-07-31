
namespace ĐoAnCongNghePhanMem.FrontEnd
{
    partial class ListSV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSortSV = new System.Windows.Forms.Button();
            this.cbbSV = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtgvSv = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSortSV);
            this.groupBox1.Controls.Add(this.cbbSV);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.dtgvSv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(780, 377);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách SV";
            // 
            // btnSortSV
            // 
            this.btnSortSV.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSortSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortSV.ForeColor = System.Drawing.Color.SlateGray;
            this.btnSortSV.Location = new System.Drawing.Point(260, 26);
            this.btnSortSV.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSortSV.Name = "btnSortSV";
            this.btnSortSV.Size = new System.Drawing.Size(88, 29);
            this.btnSortSV.TabIndex = 8;
            this.btnSortSV.Text = "Sort";
            this.btnSortSV.UseVisualStyleBackColor = false;
            this.btnSortSV.Click += new System.EventHandler(this.btnSortSV_Click);
            // 
            // cbbSV
            // 
            this.cbbSV.FormattingEnabled = true;
            this.cbbSV.Location = new System.Drawing.Point(15, 26);
            this.cbbSV.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbbSV.Name = "cbbSV";
            this.cbbSV.Size = new System.Drawing.Size(229, 26);
            this.cbbSV.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.AliceBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SlateGray;
            this.btnExit.Location = new System.Drawing.Point(332, 330);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // dtgvSv
            // 
            this.dtgvSv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvSv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvSv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvSv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvSv.Location = new System.Drawing.Point(15, 67);
            this.dtgvSv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvSv.Name = "dtgvSv";
            this.dtgvSv.RowHeadersWidth = 62;
            this.dtgvSv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSv.Size = new System.Drawing.Size(752, 249);
            this.dtgvSv.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(416, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(259, 24);
            this.txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.SlateGray;
            this.btnSearch.Location = new System.Drawing.Point(679, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 29);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ListSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(799, 397);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListSV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSortSV;
        private System.Windows.Forms.ComboBox cbbSV;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dtgvSv;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}