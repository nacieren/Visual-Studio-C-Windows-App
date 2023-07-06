using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heliotels
{
    public partial class girişYap : Form
    {
        public girişYap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=world;uid=root;password=47574757";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string username = textBox1.Text;
                    string password = textBox2.Text;

                    string query = "SELECT * FROM kullanıcıbilgileri WHERE TC = @Username AND şifre = @Password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();

                                MessageBox.Show("Giriş başarılı!");
                                oteller oteller = new oteller();
                                oteller.Show();
                                this.Hide();

                                // İşlemlere devam et...
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayıtOl kayıtOl = new kayıtOl();
            kayıtOl.Show();
            kayıtOl.Location = new Point(50, 50);
        }
    }
}

