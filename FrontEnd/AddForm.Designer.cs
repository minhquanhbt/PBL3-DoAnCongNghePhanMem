
namespace ĐoAnCongNghePhanMem.FrontEnd
{
    partial class AddForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbTietKT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTietBD = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.cbbThu = new System.Windows.Forms.ComboBox();
            this.IDLHen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.OKButton);
            this.groupBox1.Controls.Add(this.cbbThu);
            this.groupBox1.Controls.Add(this.IDLHen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 327);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ngày hẹn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbTietKT);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbbTietBD);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(42, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiết";
            // 
            // cbbTietKT
            // 
            this.cbbTietKT.FormattingEnabled = true;
            this.cbbTietKT.Location = new System.Drawing.Point(435, 40);
            this.cbbTietKT.Name = "cbbTietKT";
            this.cbbTietKT.Size = new System.Drawing.Size(219, 32);
            this.cbbTietKT.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "-";
            // 
            // cbbTietBD
            // 
            this.cbbTietBD.FormattingEnabled = true;
            this.cbbTietBD.Location = new System.Drawing.Point(93, 40);
            this.cbbTietBD.Name = "cbbTietBD";
            this.cbbTietBD.Size = new System.Drawing.Size(219, 32);
            this.cbbTietBD.TabIndex = 9;
            // 
            // ExitButton
            // 
            this.ExitButton.ForeColor = System.Drawing.Color.SlateGray;
            this.ExitButton.Location = new System.Drawing.Point(493, 253);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(99, 42);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // OKButton
            // 
            this.OKButton.ForeColor = System.Drawing.Color.SlateGray;
            this.OKButton.Location = new System.Drawing.Point(218, 253);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(99, 42);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click_1);
            // 
            // cbbThu
            // 
            this.cbbThu.FormattingEnabled = true;
            this.cbbThu.Location = new System.Drawing.Point(545, 48);
            this.cbbThu.Name = "cbbThu";
            this.cbbThu.Size = new System.Drawing.Size(219, 32);
            this.cbbThu.TabIndex = 3;
            // 
            // IDLHen
            // 
            this.IDLHen.Location = new System.Drawing.Point(135, 48);
            this.IDLHen.Name = "IDLHen";
            this.IDLHen.ReadOnly = true;
            this.IDLHen.Size = new System.Drawing.Size(219, 29);
            this.IDLHen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày hẹn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID lớp";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(836, 362);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exit);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbTietKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTietBD;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ComboBox cbbThu;
        private System.Windows.Forms.TextBox IDLHen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}