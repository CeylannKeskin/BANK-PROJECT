using MONEYBANK_PROJECT.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONEYBANK_PROJECT.Concrete
{
    public class VipNumarasi : INumara
    {
        public int SiraNumarasi { get; set; }

        public override string ToString()
        {
            return SiraNumarasi.ToString();
        }
    }
}
