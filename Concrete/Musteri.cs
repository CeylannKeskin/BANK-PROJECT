using MONEYBANK_PROJECT.Abstract;
using MONEYBANK_PROJECT.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONEYBANK_PROJECT.Concrete
{
    internal class Musteri : IMusteri
    {
        public string TC { get; set; }

        public IslemTipi IslemTipi { get; set; }

        public INumara Numara { get; set; }

        IslemTipi IMusteri.IslemTipi { get; set; }

        public event HaberTipi NumaratorBenGeldim;
        public event HaberTipi GiseBenGeldim;

        public void KontrolEt(INumara numara)
        {
            if (numara == Numara)
            {
                GiseBenGeldim(this);
            }
        }

        public void NumaraAl()
        {
            if (TC != null)
                NumaratorBenGeldim(this);
        }
    }
}
