using ĐoAnCongNghePhanMem.DAO;
using ĐoAnCongNghePhanMem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐoAnCongNghePhanMem.BLL
{
    class LoginBLL
    {
        private static LoginBLL _Instance;
        public static LoginBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new LoginBLL();
                }
                return _Instance;
            }
            private set { }
        }
        private LoginBLL()
        {

        }
        public bool CheckTK(string un, string pw)
        {
            foreach (QLTK i in doAnDAO.Instance.GetAllTK_DAO())
            {
                if (i.UserName == un && i.Password == pw)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckLoaiTK(string un, string pw)
        {
            foreach (QLTK i in doAnDAO.Instance.GetAllTK_DAO())
            {
                if (i.UserName == un && i.Password == pw && i.LoaiTK == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
