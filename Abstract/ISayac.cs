namespace MONEYBANK_PROJECT.Abstract
{
    public interface ISayac
    {
        int VipMusteriSayisi { get; set; }

        int BireyselNumaraSayisi { get; set; }

        int GiseNumaraSayisi { get; set; }
        void GisedenIsiBitenNumarayiAl(INumara numara);
    }
}