using MONEYBANK_PROJECT.Abstract;
using MONEYBANK_PROJECT.Concrete;
using System.Runtime.Intrinsics.X86;

namespace MONEYBANK_PROJECT
{
    public class Kuyruk : IKuyruk
    {
        public Kuyruk()
        {
            VipNumaraListesi = new List<INumara>();
            BireyselNumaraListesi = new List<INumara>();
            GiseNumaraListesi = new List<INumara>();
            sayac = 0;
        }

        public List<INumara> VipNumaraListesi { get; set; }

        public List<INumara> BireyselNumaraListesi { get; set; }

        public List<INumara> GiseNumaraListesi { get; set; }

        public int sayac { get; set; }

        public event NumaraHaberTipi NumaraAtadim;

        public void GiseyeNumaraGonder(object sender)
        {
            IGise gise = sender as Gise;
            if (VipNumaraListesi.Count > 0)
            {
                gise.islemYapilanNumara = VipNumaraListesi[0];
                VipNumaraListesi.RemoveAt(0);
            }
            else if ((GiseNumaraListesi.Count > 0 && sayac < 3)|| BireyselNumaraListesi.Count == 0)
            {
                gise.islemYapilanNumara = GiseNumaraListesi[0];
                GiseNumaraListesi.RemoveAt(0);
            }
            else if (BireyselNumaraListesi.Count > 0)
            {
                gise.islemYapilanNumara = BireyselNumaraListesi[0];
                BireyselNumaraListesi.RemoveAt(0);
                sayac = 0;
            }
            else
            {
                MessageBox.Show("Bekleyen müşteri kalmadı");
                Environment.Exit(0);
            }
            NumaraAtadim(gise.islemYapilanNumara);
        }

        public void NumaratordenNumaraAl(INumara numara)
        {
            if(numara is VipNumarasi)
            {
                VipNumaraListesi.Add(numara);
            }
            else if(numara is BireyselNumara)
            {
                BireyselNumaraListesi.Add(numara);
            }
            else if (numara is GiseNumarasi)
            {
                GiseNumaraListesi.Add(numara);
            }
        }
    }
}