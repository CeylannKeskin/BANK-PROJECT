using MONEYBANK_PROJECT.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONEYBANK_PROJECT.Concrete
{
    public delegate void HaberTipi(object sender);
    public delegate void NumaraHaberTipi(INumara numara);
    /* 1-Delegate tanımlanır.Public delegate void HaberTipi(object)
     * 2-Event tanımlanır. Event HaberTipi NumaratorBenGeldim
     * 3-Eventi metoda bağla=musteri.NumaratorBenGeldim+=banka.numarator.NumaraUret;
     */
    internal class Bank : IBanka
    {
        public Bank()
        {
            Giseler = new List<IGise>();
            MesaiMi = false;
        }
        public List<IGise> Giseler { get; set; }

        public IKuyruk Kuyruk { get; set; }

        public INumarator Numarator { get; set; }

        public ISayac Sayac { get; set; }

        public static bool MesaiMi { get; set; }

        public static IMusteriDatabaseYoneticisi DbMusteri = new Database();

        public void MesaiBaslat(int giseSayisi)
        {
            Kuyruk = new Kuyruk();
            Sayac = new Sayac();
            Numarator = new Numarator();
            if (giseSayisi > 3)
            {
                throw new Exception("Enfazla 3 Gişe Oluşrurabilirsiniz");
            }
            else
            {
                for (int i = 0; i < giseSayisi; i++)
                {
                    IGise gise = new Gise();
                    gise.KuyrukBenMusaitim += Kuyruk.GiseyeNumaraGonder;
                    gise.SayacisimBitti += Sayac.GisedenIsiBitenNumarayiAl;
                    Giseler.Add(gise);
                }
            }
            Numarator.NumaraUrettim += Kuyruk.NumaratordenNumaraAl;
            MesaiMi = true;
        }
        public void MesaiBitir()
        {
            MesaiMi = false;
        }
    }
}
