using MONEYBANK_PROJECT.Concrete;

namespace MONEYBANK_PROJECT.Abstract
{
    public interface INumarator
    {
        event NumaraHaberTipi NumaraUrettim;

        void NumaraUret(object sender);
        int VipSiraSayaci { get; set; }

        int BireyselSiraSayaci { get; set; }

        int GiseSiraSayaci { get; set; }

    }
}