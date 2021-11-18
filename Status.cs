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
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-99KSBNG;Initial Catalog=CargoMan;Integrated Security=True");
        string username = Login.kullaniciadi;


        public void kargolari_listele(string username)
        {
            string listele = "Select Kargolar.kargo_id,Musteriler.musteri_id,Musteriler.musteri_adi,Kargolar.kargo_durum " +
                "From Kargolar,Musteriler,Kargocular " +
                "Where Musteriler.musteri_id=Kargolar.musteri_id AND Kargolar.kargocu_id=Kargocular.kargocu_id AND Kargocular.kullanici_adi='" +username+"'";

            SqlCommand komut = new SqlCommand(listele, baglan);
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            adap.Fill(dt);
            dataGridView1.DataSource = dt;

            baglan.Close();

        }

        public void kargo_sil(int id)
        {
            string sil = "Delete From Kargolar Where kargo_id = @kargoid";

            SqlCommand komut = new SqlCommand(sil,baglan);
            baglan.Open();

            komut.Parameters.AddWithValue("@kargoid", id);
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            kargolari_listele(username);
        }

        private void toAddButton_Click(object sender, EventArgs e)
        {
            EklemeEkrani gecis = new EklemeEkrani(Map.konumx,Map.konumy,EklemeEkrani.ad,EklemeEkrani.durum);
            gecis.ShowDialog();
        }

        private void toMapButton_Click(object sender, EventArgs e)
        {
            Map gecis = new Map();
            gecis.Show();
            this.Hide();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                kargo_sil(id);
                kargolari_listele(username);
                MessageBox.Show("The selected cargo has been deleted.", "Message");
            }
        }

        int i = 0;
        private void Guncelbutton_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string kayitguncelle = ("Update Kargolar Set kargo_durum=@kargodurum Where kargo_id=@id"); 
            
            SqlCommand komutguncel = new SqlCommand(kayitguncelle,baglan);

            komutguncel.Parameters.AddWithValue("@kargodurum",statusBox.Text);
            komutguncel.Parameters.AddWithValue("@id",dataGridView1.Rows[i].Cells[0].Value);
            komutguncel.ExecuteNonQuery();

            MessageBox.Show("The delivery status has been successfully changed.","Message");
            baglan.Close();
            kargolari_listele(username);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            statusBox.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Login gecis = new Login();
            gecis.Show();
            this.Hide();
        }

        public CargoManDataSet CargoManDataSet
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
    }
}
