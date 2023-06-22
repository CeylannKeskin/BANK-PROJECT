using MONEYBANK_PROJECT.Concrete;
using MONEYBANK_PROJECT.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONEYBANK_PROJECT.Abstract
{
    public interface IMusteri
    {
        //NumaratorBenGeldim
        //GiseBenGeldim
        event HaberTipi NumaratorBenGeldim;//Numarator ben geldim eventini haber tipi delege temsil ediyor.

        event HaberTipi GiseBenGeldim;//Baglama yapilmadi,Nesne olusunca baglanicak

        public string TC { get; set; }

        IslemTipi IslemTipi { get; set; }

        INumara Numara { get; set; }

        void NumaraAl();

        void KontrolEt(INumara numara);
    }
}
