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
    public partial class ChangePass : Form
    {
        SqlConnection con;
        SqlDataReader read;
        SqlCommand com;

        public ChangePass()
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

        private void goToLogin_Click(object sender, EventArgs e)
        {
            Login gecis = new Login();
            gecis.Show();
            this.Hide();
        }

        private void ChangepassButton_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-99KSBNG;Initial Catalog=CargoMan;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From Kargocular where kullanici_adi='" + userBox.Text + "'And sifre='" + passBox.Text + "'";
            read = com.ExecuteReader();

            if (read.Read())
            {
                if (passBox.Text != newPassBox.Text) {
                    read.Close();
                    string sifreguncelle = ("Update Kargocular Set sifre=@sifre Where kullanici_adi='" + userBox.Text + "'");
                    SqlCommand sifreguncel = new SqlCommand(sifreguncelle, con);
                    sifreguncel.Parameters.AddWithValue("@sifre", newPassBox.Text);

                    sifreguncel.ExecuteNonQuery();
                    MessageBox.Show("The password has been successfully changed.", "Message");
                    
                    Login gecis = new Login();
                    gecis.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error! The passwords are same. Please enter a different new password.", "Message");
                }
                
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!", "Message");
            }

        }

       
    }
}
