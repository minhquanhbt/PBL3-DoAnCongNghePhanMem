using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐoAnCongNghePhanMem.DTO
{
    class SV
    {
        private string MSSV { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public bool GioiTinh { get; set; }
        public SV(SV2 t)
        {
            this.MSSV = t.MSSV;
            this.Ten = t.Ten;
            this.NgaySinh = t.NgaySinh;
            this.SDT = t.SDT;
            this.GioiTinh = t.GioiTinh;
        }
        public string getMSSV()
        {
            return this.MSSV;
        }
        public static bool cMSSV(SV s1, SV s2)
        {
            if (string.Compare(s1.MSSV, s2.MSSV) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool cName(SV s1, SV s2)
        {
            if (string.Compare(s1.Ten, s2.Ten) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool cSDT(SV s1, SV s2)
        {
            if (string.Compare(s1.SDT, s2.SDT) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool cNS(SV s1, SV s2)
        {
            if(DateTime.Compare(s1.NgaySinh,s2.NgaySinh) >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
