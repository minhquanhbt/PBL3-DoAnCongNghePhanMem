
using ĐoAnCongNghePhanMem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐoAnCongNghePhanMem.DAO
{
    class doAnDAO
    {
        private static doAnDAO _Instance;
        public static doAnDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new doAnDAO();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        public doAnDAO()
        {

        }
        public TKB2 GetTKB_DAL(string IDTKB)
        {
            TKB2 data = new TKB2();
            string query = string.Format("select * from TKBGV Where IDTKB = '{0}'", IDTKB);
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                if (data.MaTKB == null) data.MaTKB = i[0].ToString();
                data.Mon.Add(GetLHP_DAL(i[1].ToString()));
            }
            return data;
        }
        public LHPView2 GetLHP_DAL(string MaLop)
        {
            LHP2 data = new LHP2();
            string query = string.Format("select * from LHP Where IDLop = {0}", MaLop);
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.ID = Convert.ToInt32(i["IDLop"]);
                data.Ten = i["TenLop"].ToString();
                data.TietBD = Convert.ToInt32(i["TietBD"]);
                data.TietKT = Convert.ToInt32(i["TietKT"]);
                data.Thu = i["Thu"].ToString();
                data.Type = Convert.ToBoolean(i["kieu"]);
            }
            LHPView2 tmp = new LHPView2(data);
            return tmp;
        }
        public List<LHP2> GetAllLHP_DAL()
        {
            List<LHP2> data = new List<LHP2>();
            string query = "select * from LHP";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetLHP(i));
            }
            return data;
        }
        private LHP2 GetLHP(DataRow i)
        {
            return new LHP2
            {
                ID = Convert.ToInt32(i[0]),
                Ten = i[1].ToString(),
                TietBD = Convert.ToInt32(i[2]),
                TietKT = Convert.ToInt32(i[3]),
                Thu = i[4].ToString(),
                Type = Convert.ToBoolean(i[5]),
            };
        }
        public bool EditPass(PASS s)
        {
            string query = string.Format("UPDATE QLTK SET PassWord = '{0}' WHERE UserName = '{1}' and PassWord = '{2}'",s.matKhaumoi, s.ten, s.matKhaucu);
            return DBHelper.Instance.ExecuteDB(query);
        }
        public bool reset(int index)
        {
            string query = string.Format("DBCC CHECKIDENT('dbo.LHP', RESEED, {0})", index);
            return DBHelper.Instance.ExecuteDB(query);
        }
        public bool AddLH_DAL(LHP2 s)
        {
            string query = string.Format("insert into dbo.LHP values ('{0}',{1},{2},'{3}', 1);", s.Ten, s.TietBD, s.TietKT, s.Thu);
            return DBHelper.Instance.ExecuteDB(query);
        }
        public bool AddTKBGV_DAL(string ID, int IDLH)
        {
            string query = string.Format("insert into dbo.TKBGV values ('{0}',{1});", ID, IDLH);
            return DBHelper.Instance.ExecuteDB(query);
        }
        public bool EditLH_DAL(LHP2 s)
        {
            string query = string.Format("UPDATE dbo.LHP SET TenLop = '{0}', TietBD = {1}, TietKT = {2}, Thu = '{3}' WHERE IDLop = {4} ;", s.Ten, s.TietBD, s.TietKT, s.Thu, s.ID);
            return DBHelper.Instance.ExecuteDB(query);
        }
        public bool DelLH_DAL(int ID)
        {
            string query = string.Format("DELETE dbo.LHP Where IDLop = {0}", ID.ToString());
            return DBHelper.Instance.ExecuteDB(query);
        }
        public bool DelLHinTKBGV_DAL(int ID)
        {
            string query = string.Format("DELETE dbo.TKBGV Where IDLop = {0}", ID.ToString());
            return DBHelper.Instance.ExecuteDB(query);
        }
        public bool DelLHinTKBSV_DAL(int ID)
        {
            string query = string.Format("DELETE dbo.TKBSV Where IDLop = {0}", ID.ToString());
            return DBHelper.Instance.ExecuteDB(query);
        }
        public List<string> GetListMSSVByIDLHP_DAL(int IDLHP)
        {
            List<string> data = new List<string>();
            string query = string.Format("select * from TKBSV where IDLop = '{0}'", IDLHP.ToString());
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(i["IDTKB"].ToString());
            }
            return data;
        }
        public SV GetSVByIDTKB_DAL(string IDTKB)
        {
            string query = string.Format("select * from SV where MSSV = '{0}'", IDTKB);
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                return new SV(GetSV_DAL(i));
            }
            return null;
        }
        private SV2 GetSV_DAL(DataRow i)
        {
            return new SV2
            {
                MSSV = i["MSSV"].ToString(),
                Ten = i["Ten"].ToString(),
                NgaySinh = Convert.ToDateTime(i["NgaySinh"]),
                GioiTinh = Convert.ToBoolean(i["GioiTinh"]),
                SDT = (i["SDT"]).ToString()
            };
        }
        public List<QLTK> GetAllTK_DAO()
        {
            List<QLTK> data = new List<QLTK>();
            string query = "select * from QLTK;";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetTK(i));
            }
            return data;
        }

        public QLTK GetTK(DataRow i)
        {
            QLTK l = new QLTK();
            l.UserName = i["UserName"].ToString().Trim();
            l.Password = i["PassWord"].ToString().Trim();
            l.LoaiTK = Convert.ToBoolean(i["LoaiTK"]);
            return l;
        }

        public GV GetGV(DataRow i)
        {
            GV l = new GV();
            l.MGV = i["MGV"].ToString().Trim();
            l.Ten = i["Ten"].ToString().Trim();
            l.SDT = i["SDT"].ToString().Trim();
            l.DiaChi = i["DiaChi"].ToString().Trim();
            return l;
        }

        public List<GV> GetAllGV_DAO()
        {
            List<GV> data = new List<GV>();
            string query = "select * from GV;";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetGV(i));
            }
            return data;
        }

        public LHP GetLHPSV(DataRow i)
        {
            LHP l = new LHP();
            l.ID = Convert.ToInt32(i["IDLop"]);
            l.NameLop = i["TenLop"].ToString().Trim();
            l.NameGV = i["Ten"].ToString().Trim();
            l.Thu = i["Thu"].ToString().Trim();
            l.TietBD = Convert.ToInt32(i["TietBD"]);
            l.TietKT = Convert.ToInt32(i["TietKT"]);
            return l;
        }

        public List<LHP> GetLHPSVbyMSSV_DAO(string s)
        {
            List<LHP> data = new List<LHP>();
            string query = "select LHP.IDLop, LHP.TenLop, LHP.TietBD, LHP.TietKT, LHP.Thu, " +
                "GV.Ten from TKBSV inner join LHP on " +
                "TKBSV.IDLop = LHP.IDLop inner join TKBGV on " +
                "TKBSV.IDLop = TKBGV.IDLop inner join GV on TKBGV.IDTKB = GV.MGV " +
                "where TKBSV.IDTKB = '" + s + "';";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetLHPSV(i));
            }
            return data;
        }

        public LHM GetLHM(DataRow i)
        {
            LHM l = new LHM();
            l.ID = Convert.ToInt32(i["IDLop"]);
            l.NameLop = i["TenLop"].ToString().Trim();
            l.MGV = i["MGV"].ToString().Trim();
            l.NameGV = i["Ten"].ToString().Trim();
            l.Thu = i["Thu"].ToString().Trim();
            l.TietBD = Convert.ToInt32(i["TietBD"]);
            l.TietKT = Convert.ToInt32(i["TietKT"]);
            return l;
        }

        public List<LHM> GetAllLHM_DAO()
        {
            List<LHM> data = new List<LHM>();
            string query = "select LHP.IDLop, LHP.TenLop, LHP.TietBD, LHP.TietKT, LHP.Thu, " +
                "GV.MGV, GV.Ten from LHP inner join TKBGV on " +
                "LHP.IDLop = TKBGV.IDLop inner join GV on TKBGV.IDTKB = GV.MGV " +
                "where LHP.kieu = 1;";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetLHM(i));
            }
            return data;
        }

        public void AddLHM_DAL(string s, string id)
        {
            string query = "insert into TKBSV values ('" + s + "', '" + id + "');";
            DBHelper.Instance.ExecuteDB(query);
        }

        public void DeleteLHM_DAL(string s, string id)
        {
            string query = "delete from TKBSV where (IDTKB = '" + s + "' AND IDLop = '" + id + "');";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}
