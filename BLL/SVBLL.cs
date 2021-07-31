using ĐoAnCongNghePhanMem.DAO;
using ĐoAnCongNghePhanMem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐoAnCongNghePhanMem.BLL
{
    class SVBLL
    {
        private static SVBLL _Instance;
        public static SVBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SVBLL();
                }
                return _Instance;
            }
            private set { }
        }
        private SVBLL()
        {

        }

        public List<LHP> GetLHPSVbyMSSV_BLL(string s)
        {
            return doAnDAO.Instance.GetLHPSVbyMSSV_DAO(s);
        }

        public List<CBBItem> GetCBBItemsLSH()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (GV i in doAnDAO.Instance.GetAllGV_DAO())
            {
                data.Add(new CBBItem
                {
                    Value = Convert.ToInt32(i.MGV),
                    Text = i.Ten
                });
            }
            return data;
        }

        public string CheckTT(LHM lhm, string s)
        {
            string str = "";
            foreach (LHP i in doAnDAO.Instance.GetLHPSVbyMSSV_DAO(s))
            {
                if (i.ID == lhm.ID)
                {
                    str = "Đã đăng ký";
                    break;
                }
                else str = "Chưa đăng ký";
            }
            return str;
        }

        public List<LHM> GetAllLHM_BLL(string s)
        {
            List<LHM> data = doAnDAO.Instance.GetAllLHM_DAO();
            foreach (LHM i in data)
            {
                i.TinhTrang = CheckTT(i,s);
            }
            return data;
        }

        public List<LHM> GetLHMbyMGV(int ID, string s)
        {
            List<LHM> data = new List<LHM>();
            if (ID == 0) return GetAllLHM_BLL(s);
            foreach (LHM i in doAnDAO.Instance.GetAllLHM_DAO())
            {
                if (Convert.ToInt32(i.MGV) == ID)
                {
                    data.Add(new LHM()
                    {
                        ID = i.ID,
                        NameLop = i.NameLop,
                        MGV = i.MGV,
                        NameGV = i.NameGV,
                        Thu = i.Thu,
                        TietBD = i.TietBD,
                        TietKT = i.TietKT,
                        TinhTrang = CheckTT(i,s),
                    });
                }
            }
            return data;
        }

        private bool check(string s, LHM l)
        {
            bool check = true;
            foreach (LHP i in doAnDAO.Instance.GetLHPSVbyMSSV_DAO(s))
            {
                if (l.Thu == i.Thu)
                {
                    if ((l.TietBD <= i.TietKT) && (l.TietBD >= i.TietBD))
                    {
                        check = false;
                    }
                    if ((l.TietKT <= i.TietKT) && (l.TietKT >= i.TietBD))
                    {
                        check = false;
                    }
                    if ((l.TietBD <= i.TietBD) && (l.TietKT >= i.TietKT))
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        public bool AddLHM_BLL(string s, string data)
        {
            foreach (LHM i in GetAllLHM_BLL(s))
            {
                if (i.TinhTrang == "Chưa đăng ký" && i.ID.ToString() == data)
                {
                    if (check(s, i))
                    {
                        doAnDAO.Instance.AddLHM_DAL(s, data);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool DeleteLHM_BLL(string s, string data)
        {
            try
            {
                doAnDAO.Instance.DeleteLHM_DAL(s,data);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
