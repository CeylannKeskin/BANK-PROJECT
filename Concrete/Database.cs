using MONEYBANK_PROJECT.Abstract;

namespace MONEYBANK_PROJECT
{
    public class Database : IMusteriDatabaseYoneticisi
    {
        public Database()
        {
            MusteriTcleri = new List<string>() { "1111", "2222", "3333", "4444", "5555" };
        }
        public List<string> MusteriTcleri {  get; set; }

        public bool VipMi(string TC)
        {
            return MusteriTcleri.Contains(TC);
        }
    }
}