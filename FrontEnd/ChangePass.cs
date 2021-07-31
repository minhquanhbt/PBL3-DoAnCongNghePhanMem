using DoAnCongNghePhanMem.BLL;
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
    public partial class ChangePass : Form
    {
        string name;
        public ChangePass(string matKhau, string ten)
        {
            InitializeComponent();
            txbTK.Text = matKhau;
            name = ten;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == null) || (textBox2.Text == null))
            {
                MessageBox.Show("Khong duoc bo trong!");
            }
            else if(textBox1.Text != textBox2.Text)
            {
                MessageBox.Show("nhap sai!");
            }
            else
            {
                PASS i = new PASS();
                i.matKhaucu = txbTK.Text;
                i.matKhaumoi = textBox2.Text;
                i.ten = name;
                if (!GVBLL.Instance.ExecuteDB_BLLPass(i))
                {
                    throw new Exception("Error");
                }
                //BLL_QLSV.Instance.ExecuteDB_BLL(i);
                MessageBox.Show("Thanh cong!");
                this.Dispose();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
