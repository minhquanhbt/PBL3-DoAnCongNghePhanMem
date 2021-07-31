using ĐoAnCongNghePhanMem.BLL;
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
    public partial class Login : Form
    {
        public delegate void MyDel(string MSSV);
        public MyDel d { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LoginBLL.Instance.CheckTK(txbTK.Text, txbMK.Text))
            {
                if (LoginBLL.Instance.CheckLoaiTK(txbTK.Text, txbMK.Text))
                {
                    this.Hide();
                    this.ShowInTaskbar = false;
                    TableGV f = new TableGV(txbTK.Text, txbMK.Text);
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    this.ShowInTaskbar = false;
                    TableSV f = new TableSV(txbTK.Text, txbMK.Text);
                    f.ShowDialog();
                    this.Close();
                }
            }
            else MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbMK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
