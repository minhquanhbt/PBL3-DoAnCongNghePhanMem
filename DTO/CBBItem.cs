using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐoAnCongNghePhanMem.DTO
{
    class CBBItem
    {
        public int Value { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return Text;
        }

        public static explicit operator CBBItem(int v)
        {
            throw new NotImplementedException();
        }
    }
}
