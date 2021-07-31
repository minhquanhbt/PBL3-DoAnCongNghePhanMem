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
    public partial class ListSV : Form
    {
        private int IDLHP;
        public ListSV(int ID)
        {
            InitializeComponent();
            IDLHP = ID;
            setCBB();
            show();
        }
        public void show()
        {
            dtgvSv.DataSource = GVBLL.Instance.GetListSVByIDLop_BLL(IDLHP);
        }
        private void setCBB()
        {
            cbbSV.Items.Add("MSSV");
            cbbSV.Items.Add("Name");
            cbbSV.Items.Add("Ngay Sinh");
            cbbSV.Items.Add("SDT");
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSortSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbSV.SelectedItem == null)
                {
                    MessageBox.Show("chon muc tieu sap xep");
                }
                else
                {
                    switch (cbbSV.SelectedItem.ToString())
                    {
                        case "MSSV":
                            dtgvSv.DataSource = GVBLL.Instance.SortSV(IDLHP, SV.cMSSV);
                            break;
                        case "Name":
                            dtgvSv.DataSource = GVBLL.Instance.SortSV(IDLHP, SV.cName);
                            break;
                        case "SDT":
                            dtgvSv.DataSource = GVBLL.Instance.SortSV(IDLHP, SV.cSDT);
                            break;
                        case "Ngay Sinh":
                            dtgvSv.DataSource = GVBLL.Instance.SortSV(IDLHP, SV.cNS);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Sorting");
            }
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
                    //tim theo MSSV
                    dtgvSv.DataSource = GVBLL.Instance.SearchSV_MSSV(IDLHP, txt);
                    check = true;

                }
                else
                {
                    //tim theo Ten LHP
                    if (check == false)
                    {
                        dtgvSv.DataSource = GVBLL.Instance.SearchSV_Ten(IDLHP, txt);
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
