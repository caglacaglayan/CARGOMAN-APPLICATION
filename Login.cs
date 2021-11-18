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
    public partial class Login : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public static string kullaniciadi;

        public Login()
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

        public Signup Signup
        {
            get => default;
            set
            {
            }
        }

        public ChangePass ChangePass
        {
            get => default;
            set
            {
            }
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            kullaniciadi = userBox.Text;

            con = new SqlConnection("Data Source=DESKTOP-99KSBNG;Initial Catalog=CargoMan;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From Kargocular where kullanici_adi='" + userBox.Text + "'And sifre='" + passBox.Text + "'";
            dr = com.ExecuteReader();
            
            if (dr.Read())
            {
                Status gecis = new Status();
                gecis.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!", "Message");
            }
        }

        private void toSignButton_Click(object sender, EventArgs e)
        {
            Signup gecis = new Signup();
            gecis.Show();
            this.Hide();
        }

        private void toChangebutton_Click(object sender, EventArgs e)
        {
            ChangePass gecis = new ChangePass();
            gecis.Show();
            this.Hide();
        }
    }
}
