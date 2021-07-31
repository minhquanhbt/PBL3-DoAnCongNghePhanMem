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
    public partial class AddForm : Form
    {
        private int IDLH;
        private string IDTKB;
        TKB2 tkb;
        public string[] Tiet = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        public string[] Thu = { "Thu Hai", "Thu Ba", "Thu Tu", "Thu Nam", "Thu Sau", "Thu Bay", "Chu Nhat" };
        public delegate void MyDel(string ms);
        public MyDel d { get; set; }
        public AddForm(int st, string id, TKB2 t)
        {
            InitializeComponent();
            IDLH = st;
            IDTKB = id;
            tkb = t;
            SetCBB();
            setGUI();

        }
        private void setGUI()
        {
            if (IDLH == -1)
            {
                this.Text = "AddLH";
                IDLHen.Text = "0";
            }
            else
            {
                this.Text = "EditLH";
                LHPView2 tmp = new LHPView2();
                foreach (LHPView2 i in tkb.Mon)
                {
                    if (i.getID() == IDLH)
                    {
                        tmp = i;
                        break;
                    }
                }
                IDLHen.Text = tmp.getID().ToString();
                cbbTietBD.SelectedIndex = tmp.TietBD - 1;
                cbbTietKT.SelectedIndex = tmp.TietKT - 1;
                for (int i = 0; i < cbbThu.Items.Count; i++)
                    if ((cbbThu.Items[i]).ToString() == tmp.Thu)
                    {
                        cbbThu.SelectedIndex = i;
                        break;
                    }
            }
        }
        public void SetCBB()
        {
            cbbTietBD.Items.AddRange(Tiet);
            cbbTietBD.SelectedIndex = 0;
            cbbTietKT.Items.AddRange(Tiet);
            cbbTietKT.SelectedIndex = 1;
            cbbThu.Items.AddRange(Thu);
            cbbThu.SelectedIndex = 0;
        }


        private bool check()
        {
            bool check = true;
            if ((Convert.ToInt32(cbbTietBD.SelectedItem) > Convert.ToInt32(cbbTietKT.SelectedItem)))
            {
                MessageBox.Show("Giờ hẹn không hợp lý");
                return false;
            }
            else
            {
                foreach (LHPView2 i in tkb.Mon)
                {
                    if (cbbThu.SelectedItem.ToString() == i.Thu)
                    {
                        if ((Convert.ToInt32(cbbTietBD.SelectedItem) <= i.TietKT) && (Convert.ToInt32(cbbTietBD.SelectedItem) >= i.TietBD))
                        {
                            check = false;
                        }
                        if ((Convert.ToInt32(cbbTietKT.SelectedItem) <= i.TietKT) && (Convert.ToInt32(cbbTietKT.SelectedItem) >= i.TietBD))
                        {
                            check = false;
                        }
                        if ((Convert.ToInt32(cbbTietBD.SelectedItem) <= i.TietBD) && (Convert.ToInt32(cbbTietKT.SelectedItem) >= i.TietKT))
                        {
                            check = false;
                        }
                    }
                }
                if (!check) MessageBox.Show("Đã có giờ học khác trùng khung giờ này");
                return check;
            }
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Những dữ liệu đã nhập sẽ mất, bạn chắc chắn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void OKButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (check())
                {
                    LHP2 i = new LHP2();
                    if (IDLHen.Text != "0")
                    {
                        i.ID = Convert.ToInt32(IDLHen.Text);
                    }
                    i.Ten = "Lich Hen";
                    i.TietBD = Convert.ToInt32(cbbTietBD.SelectedItem);
                    i.TietKT = Convert.ToInt32(cbbTietKT.SelectedItem);
                    i.Thu = cbbThu.SelectedItem.ToString();
                    i.Type = false;
                    if (!GVBLL.Instance.ExecuteDB_BLL(i, IDTKB))
                    {
                        throw new Exception("Error");
                    }
                    d(IDTKB);
                    this.Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error during updating");
            }

        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
