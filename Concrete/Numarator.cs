using MONEYBANK_PROJECT.Abstract;
using MONEYBANK_PROJECT.Concrete;
using MONEYBANK_PROJECT.Enum;

namespace MONEYBANK_PROJECT
{
    public class Numarator : INumarator
    {
        public Numarator()
        {
            BireyselSiraSayaci = 1000;
            GiseSiraSayaci = 2000;
            VipSiraSayaci = 3000;
        }
        public int VipSiraSayaci { get; set; }

        public int BireyselSiraSayaci { get; set; }

        public int GiseSiraSayaci { get; set; }

        public event NumaraHaberTipi NumaraUrettim;

        public void NumaraUret(object sender)
        {
            if (Bank.MesaiMi)
            {
                IMusteri musteri = sender as IMusteri;

                bool Vipmi=Bank.DbMusteri.VipMi(musteri.TC);

                INumara numara = null;//gelecek musteri tipi belli olmadigindan null verilir.

                if (Vipmi)
                {
                    numara = new VipNumarasi();
                    numara.SiraNumarasi = VipSiraSayaci;
                    VipSiraSayaci++;
                }
                else if(musteri.IslemTipi==IslemTipi.Bireysel)
                {
                    numara = new BireyselNumara();
                    numara.SiraNumarasi = BireyselSiraSayaci;
                    BireyselSiraSayaci++;
                }
                else if(musteri.IslemTipi==IslemTipi.Gise)
                {
                    numara = new GiseNumarasi();
                    numara.SiraNumarasi = GiseSiraSayaci;
                    GiseSiraSayaci++;
                }
                musteri.Numara = numara;
                NumaraUrettim(numara);
            }
            else
            {
                //hata
            }
        }
    }
}