
using ĐoAnCongNghePhanMem.DAO;
using ĐoAnCongNghePhanMem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCongNghePhanMem.BLL
{
    class GVBLL
    {
        private static GVBLL _Instance;
        public static GVBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new GVBLL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private static TKB2 tkbgv=new TKB2();
        public GVBLL()
        {
        }
        public bool ExecuteDB_BLLPass(PASS s)
        {
            //Edit
                return doAnDAO.Instance.EditPass(s);
        }
        public TKB2 getTKB(string MSGV)
        {
            if (MSGV != null)
            {
                tkbgv = doAnDAO.Instance.GetTKB_DAL(MSGV);
                return tkbgv;
            }
            else throw new ArgumentNullException();
        }
        public List<LHPView2> SearchLHP_ID(int ID)
        {
            List<LHPView2> data = new List<LHPView2>();
            foreach(LHPView2 i in tkbgv.Mon)
            {
                if (i.getID() == ID) data.Add(i);
            }
            return data;
        }
        public List<LHPView2> SearchLHP_Thu(string thu)
        {
            List<LHPView2> data = new List<LHPView2>();
            foreach (LHPView2 i in tkbgv.Mon)
            {
                if (i.Thu == thu) data.Add(i);
            }
            return data;
        }
        public List<LHPView2> SearchLHP_Ten(string ten)
        {
            List<LHPView2> data = new List<LHPView2>();
            foreach (LHPView2 i in tkbgv.Mon)
            {
                if (i.Ten.Contains(ten)) data.Add(i);
            }
            return data;
        }
        public bool ExecuteDB_BLL(LHP2 s, string ID)
        {
            bool Mode = true;
            List<LHP2> data = doAnDAO.Instance.GetAllLHP_DAL();
            foreach (LHP2 r in data)
            {
                if (r.ID == s.ID) Mode = false;
            }
            //Add
            if (Mode)
            {
                doAnDAO.Instance.reset(data.Count);
                if ((doAnDAO.Instance.AddLH_DAL(s) == false) || (doAnDAO.Instance.AddTKBGV_DAL(ID, data.Count + 1) == false))
                    return false;
                else return true;
            }
            //Edit
            else
            {
                return doAnDAO.Instance.EditLH_DAL(s);
            }
            //return false;
        }
        public delegate bool Compare(SV o1, SV o2);
        public List<SV> SortSV(int ID, Compare cmp)
        {
            List<SV> l = GetListSVByIDLop_BLL(ID);
            return SortSV_BLL(l,cmp);
        }
        private List<SV> SortSV_BLL(List<SV> list, Compare cmp)
        {
            if (list.Count <= 1) return list;
            int pivotPosition = list.Count / 2;
            SV pivotValue = list[pivotPosition];
            list.RemoveAt(pivotPosition);
            List<SV> smaller = new List<SV>();
            List<SV> greater = new List<SV>();
            foreach (SV item in list)
            {
                if (cmp(item, pivotValue))
                {
                    greater.Add(item);
                }
                else
                {
                    smaller.Add(item);
                }
            }
            List<SV> sorted = SortSV_BLL(smaller, cmp);
            sorted.Add(pivotValue);
            sorted.AddRange(SortSV_BLL(greater, cmp));
            return sorted;
        }

        public bool DelLH_BLL(List<int> IDDel)
        {
            try
            {
                foreach (int s in IDDel)
                {
                    doAnDAO.Instance.DelLH_DAL(s);
                    doAnDAO.Instance.DelLHinTKBGV_DAL(s);
                    doAnDAO.Instance.DelLHinTKBSV_DAL(s);
                }
                doAnDAO.Instance.reset(doAnDAO.Instance.GetAllLHP_DAL().Count);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<SV> GetListSVByIDLop_BLL(int ID)
        {
            List<SV> data = new List<SV>();
            List<string> MSSVs = doAnDAO.Instance.GetListMSSVByIDLHP_DAL(ID);
            //Lay du lieu ra
            foreach (string i in MSSVs)
            {
                data.Add(doAnDAO.Instance.GetSVByIDTKB_DAL(i));
            }
            return data;
        }
        public delegate bool Cmp(LHPView2 o1, LHPView2 o2);
        public List<LHPView2> SortLHP(string ms, Cmp cmp)
        {
            List<LHPView2> list = getTKB(ms).Mon;
            return SortLHP_BLL(list, cmp);
        }
        private List<LHPView2> SortLHP_BLL(List<LHPView2> list, Cmp cmp)
        {
            if (list.Count <= 1) return list;
            int pivotPosition = list.Count / 2;
            LHPView2 pivotValue = list[pivotPosition];
            list.RemoveAt(pivotPosition);
            List<LHPView2> smaller = new List<LHPView2>();
            List<LHPView2> greater = new List<LHPView2>();
            foreach (LHPView2 item in list)
            {
                if (cmp(item, pivotValue))
                {
                    greater.Add(item);
                }
                else
                {
                    smaller.Add(item);
                }
            }
            List<LHPView2> sorted = SortLHP_BLL(smaller, cmp);
            sorted.Add(pivotValue);
            sorted.AddRange(SortLHP_BLL(greater, cmp));
            return sorted;
        }
        public List<SV> SearchSV_MSSV(int ID, string mssv)
        {
            List<SV> data = GetListSVByIDLop_BLL(ID);
            List<SV> result = new List<SV>();
            foreach(SV i in data)
            {
                if (i.getMSSV().Contains(mssv)) result.Add(i);
            }
            return result;
        }
        public List<SV> SearchSV_Ten(int ID, string ten)
        {
            List<SV> data = GetListSVByIDLop_BLL(ID);
            List<SV> result = new List<SV>();
            foreach (SV i in data)
            {
                if (i.Ten.Contains(ten)) result.Add(i);
            }
            return result;
        }
    }
}
