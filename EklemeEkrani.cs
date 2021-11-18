using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CARGOMAN
{
    public partial class EklemeEkrani : Form
    {
        public static string ad, durum;
        public EklemeEkrani(float a, float b, string x, string y)
        {
            InitializeComponent();
            konumxBox.Text = Convert.ToString(a);
            konumyBox.Text = Convert.ToString(b);
            musteriadiBox.Text = x;
            durumBox.Text = y;
        }

        public CargoManDataSet CargoManDataSet
        {
            get => default;
            set
            {
            }
        }

        public Status Status
        {
            get => default;
            set
            {
            }
        }

        public Map Map
        {
            get => default;
            set
            {
            }
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-99KSBNG;Initial Catalog=CargoMan;Integrated Security=True");


        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kayit = "insert into Musteriler (musteri_adi,musteri_lokasyon_x,musteri_lokasyon_y)values(@musteriadi,@musterilokasyonx,@musterilokasyony)";
                    string kayit2 = "insert into Kargolar (musteri_id,kargocu_id,kargo_durum)values(@musteriid,@kargocuid,@kargodurum)";

                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@musteriadi", musteriadiBox.Text);
                    float x = Convert.ToSingle(konumxBox.Text);
                    float y = Convert.ToSingle(konumxBox.Text);
                    komut.Parameters.AddWithValue("@musterilokasyonx",x);
                    komut.Parameters.AddWithValue("@musterilokasyony",y);

                    komut.ExecuteNonQuery();

                    string kargocuidsi = "Select kargocu_id From Kargocular Where kullanici_adi='" + Login.kullaniciadi + "'";
                    SqlCommand cmd = new SqlCommand(kargocuidsi, baglan);
                    int kargocuid = Convert.ToInt32(cmd.ExecuteScalar());

                    string musteriidsi = "Select musteri_id From Musteriler Where musteri_adi='" + musteriadiBox.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(musteriidsi, baglan);
                    int musteriid = Convert.ToInt32(cmd2.ExecuteScalar());

                    SqlCommand komut2 = new SqlCommand(kayit2, baglan);
                    
                    komut2.Parameters.AddWithValue("@kargocuid", kargocuid);
                    komut2.Parameters.AddWithValue("@musteriid", musteriid);
                    komut2.Parameters.AddWithValue("@kargodurum", durumBox.Text);

                    komut2.ExecuteNonQuery();

                    MessageBox.Show("The cargo successfully added!", "Message");
                    this.Hide();
                }
            }
            catch(Exception hata) {

                MessageBox.Show("Error! "+hata);
            }

        }

        private void ChsLocbutton_Click(object sender, EventArgs e)
        {
            ad = musteriadiBox.Text;
            durum = durumBox.Text;

            Map gecis = new Map();
            gecis.Show();
            this.Hide(); 
        }
    }
}
