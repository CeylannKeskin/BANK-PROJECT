using MONEYBANK_PROJECT.Concrete;

namespace MONEYBANK_PROJECT.Abstract
{
    public interface IGise
    {
        //KuyrukBenMusaitim
        //sayacIsimBitti
        event HaberTipi KuyrukBenMusaitim;
        event NumaraHaberTipi SayacisimBitti;
        INumara islemYapilanNumara { get; set; }
        void IslemYap();
        void Kontrol(object sender);
    }
}