using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐoAnCongNghePhanMem.DTO
{
    public class TKB2
    {
        public string MaTKB { get; set; }
        public List<LHPView2> Mon;
        public TKB2()
        {
            Mon = new List<LHPView2>();
        }
    }
}
