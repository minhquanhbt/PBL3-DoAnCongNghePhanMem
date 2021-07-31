using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐoAnCongNghePhanMem.DTO
{
    public class LHPView2
    {
        private int ID { get; set; }
        public string Ten { get; set; }
        public int TietBD { get; set; }
        public int TietKT { get; set; }
        public string Thu { get; set; }
        public static string[] cmpThu = new string[] { "Thu Hai", "Thu Ba", "Thu Tu", "Thu Nam", "Thu Sau", "Thu Bay", "Chu Nhat" };
        private bool Type { get; set; }
        public string kieu { get; set; }
        public LHPView2()
        {
            ID = 0;
            Ten = "";
            TietBD = 1;
            TietKT = 2;
            Thu = cmpThu[0];
            Type = true;
            if (Type == false)
            {
                kieu = "Lớp Học Phần";
            }
            else kieu = "Lịch Hẹn";
        }
        public LHPView2(LHP2 s)
        {
            ID = s.ID;
            Ten = s.Ten;
            TietBD = s.TietBD;
            TietKT = s.TietKT;
            Thu = s.Thu;
            Type = s.Type;
            if (Type == false)
            {
                kieu = "Lớp Học Phần";
            }
            else kieu = "Lịch Hẹn";
        }
        public int getID()
        {
            return this.ID;
        }
        public bool getType()
        {
            return this.Type;
        }
        public static bool cIDLop(LHPView2 s1, LHPView2 s2)
        {
            return s1.ID>s2.ID;
        }
        public static bool cTenLop(LHPView2 s1, LHPView2 s2)
        {
            if (string.Compare(s1.Ten, s2.Ten) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool cTietBD(LHPView2 s1, LHPView2 s2)
        {
            return s1.TietBD > s2.TietBD;
        }
        public static bool cTietKT(LHPView2 s1, LHPView2 s2)
        {
            return s1.TietKT > s2.TietKT;
        }
        public static bool cThu(LHPView2 s1, LHPView2 s2)
        {
            int ID1 = 0, ID2 = 0;
            for (int i = 0;i<cmpThu.Length;i++)
            {
                if (s1.Thu == cmpThu[i])
                {
                    ID1 = i;
                }
                if (s2.Thu == cmpThu[i])
                {
                    ID2 = i;
                }
            }
            return ID1 > ID2;
        }
    }
}
