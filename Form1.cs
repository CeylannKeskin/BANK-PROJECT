using MONEYBANK_PROJECT.Abstract;
using MONEYBANK_PROJECT.Concrete;
using MONEYBANK_PROJECT.Enum;

namespace MONEYBANK_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static IBanka banka;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbIslem.Items.Add(IslemTipi.Gise);
            cmbIslem.Items.Add(IslemTipi.Bireysel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            banka = new Bank();
            banka.MesaiBaslat(3);
        }

        private void btnSiraAl_Click(object sender, EventArgs e)
        {
            IMusteri musteri = new Musteri();
            musteri.IslemTipi = (IslemTipi)cmbIslem.SelectedItem;
            musteri.TC = txtTc.Text;
            musteri.NumaratorBenGeldim += banka.Numarator.NumaraUret;//numarator ben geldim eventi tetiklendiginde numarator icerisindeki numara uret metodu cagrillacak.
            foreach (var gise in banka.Giseler)
            {
                musteri.GiseBenGeldim += gise.Kontrol;
            }
            musteri.NumaraAl();
            banka.Kuyruk.NumaraAtadim += musteri.KontrolEt;
            ListeleriYukle();
        }

        private void ListeleriYukle()
        {
            lstBireysel.DataSource = null;
            lstVip.DataSource = null;
            lstGise.DataSource = null;
            lstVip.DataSource = banka.Kuyruk.VipNumaraListesi;
            lstBireysel.DataSource = banka.Kuyruk.BireyselNumaraListesi;
            lstGise.DataSource = banka.Kuyruk.GiseNumaraListesi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giseolustur(banka.Giseler);
        }

        private void giseolustur(List<IGise> giseler)
        {
            for (int i = 0; i < giseler.Count; i++)
            {
                Button btn = new Button();
                btn.Text = "Müsait";
                btn.Width = 50;
                btn.Height = 50;
                btn.Click += new EventHandler(musait);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void musait(object? sender, EventArgs e)
        {
            banka.Giseler[0].IslemYap();
        }
    }
}