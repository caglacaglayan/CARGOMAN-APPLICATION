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
    public partial class Signup : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-99KSBNG;Initial Catalog=CargoMan;Integrated Security=True");
        public Signup()
        {
            InitializeComponent();
        }

        public CargoManDataSet CargoManDataSet
        {
            get => default;
            set
            {
            }
        }

        public Login Login
        {
            get => default;
            set
            {
            }
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(baglan.State == ConnectionState.Closed)
                {
                    if (passBox.Text == confirmBox.Text)
                    {
                        baglan.Open();
                        string kayit = "insert into Kargocular (kullanici_adi,sifre)values(@kullaniciadi, @sifre)";
                        SqlCommand komut = new SqlCommand(kayit, baglan);
                        komut.Parameters.AddWithValue("@kullaniciadi", userBox.Text);
                        komut.Parameters.AddWithValue("@sifre", passBox.Text);

                        komut.ExecuteNonQuery();

                        MessageBox.Show("Congratulations! You are successfully signed up! Click OK for Login.", "Message");
                        Login gecis = new Login();
                        gecis.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Passwords don't match!", "Message");
                    }
                }
            }

            catch (Exception hata)
            {
                if(passBox.Text != confirmBox.Text)
                {
                    MessageBox.Show("Passwords don't match!", "Message");
                }
                else
                {
                    MessageBox.Show("Sorry, Username already taken. Please choose another.", "Message");
                }
            }

        }

        private void toLogButton_Click(object sender, EventArgs e)
        {
            Login gecis = new Login();
            gecis.Show();
            this.Hide();
        }
    }
}
