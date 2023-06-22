using MONEYBANK_PROJECT.Abstract;
using MONEYBANK_PROJECT.Concrete;

namespace MONEYBANK_PROJECT
{
    public class Gise : IGise
    {
        public INumara islemYapilanNumara { get; set; }

        public event HaberTipi KuyrukBenMusaitim;
        public event NumaraHaberTipi SayacisimBitti;

        public void IslemYap()
        {
            //İslemleri yaptı
            SayacisimBitti(islemYapilanNumara);
            KuyrukBenMusaitim(this);
        }

        public void Kontrol(object sender)
        {
            IMusteri musteri = sender as IMusteri;
            if (musteri.Numara==islemYapilanNumara)
            {
                IslemYap();
            }
        }
    }
}