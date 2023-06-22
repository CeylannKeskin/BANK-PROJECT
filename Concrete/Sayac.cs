using MONEYBANK_PROJECT.Abstract;
using MONEYBANK_PROJECT.Concrete;

namespace MONEYBANK_PROJECT
{
    public class Sayac : ISayac
    {
        public Sayac()
        {
            VipMusteriSayisi = 0;
            BireyselNumaraSayisi = 0;
            GiseNumaraSayisi = 0;
        }
        public int VipMusteriSayisi { get; set; }

        public int BireyselNumaraSayisi { get; set; }

        public int GiseNumaraSayisi { get; set; }
        public int BireyselMusteriSayisi { get; private set; }
        public int GiseMusteriSayisi { get; private set; }

        public void GisedenIsiBitenNumarayiAl(INumara numara)
        {
            if(numara is VipNumarasi)
            {
                VipMusteriSayisi++;
            }
            else if(numara is BireyselNumara)
            {
                BireyselMusteriSayisi++;
            }
            else if(numara is GiseNumarasi)
            {
                GiseMusteriSayisi++;
            }
        }
    }
}