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
    public partial class TableGV : Form
    {
        private TKB2 tkb;
        string matKhau;
        string ten;
        public TableGV(string ms, string mk)
        {
            InitializeComponent();
            matKhau = mk;
            ten = ms;
            setCBB();
            show(ms);
        }
        private void setCBB()
        {
            cbbLop.Items.Add("IDLop");
            cbbLop.Items.Add("TenLop");
            cbbLop.Items.Add("TietBD");
            cbbLop.Items.Add("TietKT");
            cbbLop.Items.Add("Thu");
            cbbLop.SelectedIndex = 0;
        }
        public TableGV()
        {
            InitializeComponent();
        }
        private void show(string ms)
        {
            tkb = GVBLL.Instance.getTKB(ms);
            dtgvGV.DataSource = tkb.Mon;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dtgvGV.SelectedRows.Count == 1)
            {
                int idlh = tkb.Mon[dtgvGV.SelectedRows[0].Index].getID();
                ListSV f = new ListSV(idlh);
                f.Show();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtgvGV.SelectedRows.Count == 1)
                {
                    if (tkb.Mon[dtgvGV.SelectedRows[0].Index].getType() == true)
                    {
                        int idlh = tkb.Mon[dtgvGV.SelectedRows[0].Index].getID();
                        AddForm f = new AddForm(idlh, tkb.MaTKB, tkb);
                        f.d += new AddForm.MyDel(show);
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("không thể chỉnh sửa LHP!");
                    }
                }
                else
                {
                    MessageBox.Show("chọn 1 đối tượng!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Editing");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                DataGridViewSelectedRowCollection data = dtgvGV.SelectedRows;
                List<int> IDLHDel = new List<int>();
                foreach (DataGridViewRow i in data)
                {
                    if (tkb.Mon[i.Index].getType() == true)
                    {
                        IDLHDel.Add(tkb.Mon[i.Index].getID());
                    }
                    else
                    {
                        check = false;
                        MessageBox.Show("Không thể xóa Lớp Học Phần!");
                    }
                }
                if (check)
                {
                    if (MessageBox.Show("Dữ liệu sẽ bị xóa, bạn chắc chắn xóa ?", "Cảnh Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        if (!GVBLL.Instance.DelLH_BLL(IDLHDel))
                        {
                            MessageBox.Show("Could not find selected SV");
                        }
                        show(tkb.MaTKB);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't not deleted!");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbLop.SelectedItem == null)
                {
                    MessageBox.Show("chon muc tieu sap xep");
                }
                else
                {
                    switch (cbbLop.SelectedItem.ToString())
                    {
                        case "IDLop":
                            dtgvGV.DataSource = GVBLL.Instance.SortLHP(tkb.MaTKB, LHPView2.cIDLop);
                            break;
                        case "TenLop":
                            dtgvGV.DataSource = GVBLL.Instance.SortLHP(tkb.MaTKB, LHPView2.cTenLop);
                            break;
                        case "TietBD":
                            dtgvGV.DataSource = GVBLL.Instance.SortLHP(tkb.MaTKB, LHPView2.cTietBD);
                            break;
                        case "TietKT":
                            dtgvGV.DataSource = GVBLL.Instance.SortLHP(tkb.MaTKB, LHPView2.cTietKT);
                            break;
                        case "Thu":
                            dtgvGV.DataSource = GVBLL.Instance.SortLHP(tkb.MaTKB, LHPView2.cThu);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Sorting");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm(-1, tkb.MaTKB,tkb);
            f.d += new AddForm.MyDel(show);
            f.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePass f = new ChangePass(matKhau, ten);
            f.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string txt = txtSearch.Text;
                int ID;
                bool check = false;
                if (int.TryParse(txt, out ID) == true)
                {
                    //tim theo IDLop
                    dtgvGV.DataSource = GVBLL.Instance.SearchLHP_ID(Convert.ToInt32(txt));
                    check = true;
                }
                else
                {
                    //Tim theo Thu
                    if (txt.Contains("Thu"))
                    {
                        dtgvGV.DataSource = GVBLL.Instance.SearchLHP_Thu(txt);
                        check = true;
                    }
                    //tim theo Ten LHP
                    if (check == false)
                    {
                        dtgvGV.DataSource = GVBLL.Instance.SearchLHP_Ten(txt);
                        check = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could Not Find");
            }
        }
    }
}
