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
using System.Xml.Linq;

namespace heliotels
{
    public partial class kayıtOl : Form
    {
        public kayıtOl()
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

                    string tc = textBox1.Text;
                    string password = textBox2.Text;
                    string confirmPassword = textBox3.Text;
                    string name = textBox4.Text;
                    string surname = textBox5.Text;
                    string gender = comboBox1.SelectedItem.ToString();
                    string birthYear = textBox6.Text;
                    string city = textBox7.Text;

                    // Şifre kontrolü
                    if (password != confirmPassword)
                    {
                        MessageBox.Show("Şifreler eşleşmiyor!");
                        return;
                    }

                    string query = "INSERT INTO kullanıcıbilgileri (TC,isim,soyisim,cinsiyet,doğumYılı,şehir,şifre) VALUES (@TC, @Name, @Surname, @Gender, @BirthYear, @City, @Password)";

                    if (textBox1.Text.Equals(""))
                    {
                        MessageBox.Show("Boş alanları doldurunuz!");
                    }
                    else if (textBox2.Text.Equals(""))
                    {
                        MessageBox.Show("Boş alanları doldurunuz!");
                    }
                    else if (textBox4.Text.Equals(""))
                    {
                        MessageBox.Show("Boş alanları doldurunuz!");
                    }
                    else if (textBox5.Text.Equals(""))
                    {
                        MessageBox.Show("Boş alanları doldurunuz!");
                    }
                    else if (comboBox1.SelectedItem.ToString().Equals(""))
                    {
                        MessageBox.Show("Boş alanları doldurunuz!");
                    }
                    else if (textBox6.Text.Equals(""))
                    {
                        MessageBox.Show("Boş alanları doldurunuz!");
                    }
                    else if (textBox7.Text.Equals(""))
                    {
                        MessageBox.Show("Boş alanları doldurunuz!");
                    }
                    else
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                        command.Parameters.AddWithValue("@TC", tc);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Surname", surname);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@BirthYear", birthYear);
                        command.Parameters.AddWithValue("@City", city);

                        int affectedRows = command.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla oluşturuldu!");
                                // Kayıt işlemi başarılı olduğunda yapılacak işlemler...
                                this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt oluşturulamadı!");
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

    }

}
