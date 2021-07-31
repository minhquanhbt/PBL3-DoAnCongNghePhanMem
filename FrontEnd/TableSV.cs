using ĐoAnCongNghePhanMem.BLL;
using ĐoAnCongNghePhanMem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐoAnCongNghePhanMem.FrontEnd
{
    public partial class TableSV : Form
    {
        private string MSSV;
        private string matkhau;
        public TableSV(string m, string mk)
        {
            InitializeComponent();
            MSSV = m;
            matkhau = mk;
            ShowLich();
            ShowLop();
            SetCBBGV();
        }

        public void ShowLich()
        {
            dtgvLichSV.DataSource = SVBLL.Instance.GetLHPSVbyMSSV_BLL(MSSV);
        }

        public void ShowLop()
        {
            dtgvLopSV.DataSource = SVBLL.Instance.GetAllLHM_BLL(MSSV);
            dtgvLopSV.Columns[2].Visible = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                ShowLich();
            }
        }

        public void SetCBBGV()
        {
            cbbGV.Items.Add(new CBBItem
            {
                Value = 0,
                Text = "All"
            });
            cbbGV.Items.AddRange(SVBLL.Instance.GetCBBItemsLSH().ToArray());
            cbbGV.SelectedIndex = 0;
        }

        private void btnChonGV_Click(object sender, EventArgs e)
        {
            int ID = ((CBBItem)cbbGV.SelectedItem).Value;
            dtgvLopSV.DataSource = SVBLL.Instance.GetLHMbyMGV(ID, MSSV);
            dtgvLopSV.Columns[2].Visible = false;
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dtgvLopSV.SelectedRows;
            if (dtgvLopSV.SelectedRows.Count == 1)
            {
                if (SVBLL.Instance.AddLHM_BLL(MSSV, data[0].Cells["ID"].Value.ToString()))
                {
                    ShowLop();
                }
                else
                {
                    MessageBox.Show("Trùng!");
                }
            }
        }

        private void btnHuyDK_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dtgvLopSV.SelectedRows;
            if (dtgvLopSV.SelectedRows.Count == 1)
            {
                if (SVBLL.Instance.DeleteLHM_BLL(MSSV, data[0].Cells["ID"].Value.ToString()))
                {
                    ShowLop();
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePass f = new ChangePass(matkhau, MSSV);
            f.Show();
        }
    }
}
