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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace heliotels
{
    public partial class krediKartı : Form
    {
        public krediKartı()
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

                    string numara = textBox1.Text;
                    string isimSoyisim = textBox2.Text;
                    string sonKullanma = comboBox1.Text + comboBox2.Text;
                    string CVV = textBox3.Text;

                    string query = "INSERT INTO kredikartları (kartNumarası,kullanıcıID,isimSoyisim,sonKullanma, CVV) VALUES (@kartNumarası, @kullanıcıID,@isimSoyisim, @sonKullanma, @CVV)";

                    if (textBox1.Text.Equals(""))
                    {
                        MessageBox.Show("Boş alanları doldurunuz!");
                    }
                    else if (textBox2.Text.Equals(""))
                    {
                        MessageBox.Show("Boş alanları doldurunuz!");
                    }
                    else if (textBox3.Text.Equals(""))
                    {
                        MessageBox.Show("Boş alanları doldurunuz!");
                    }
                    else
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@kartNumarası", numara);
                            command.Parameters.AddWithValue("@kullanıcıID", "3");
                            command.Parameters.AddWithValue("@isimSoyisim", isimSoyisim);
                            command.Parameters.AddWithValue("@sonKullanma", sonKullanma);
                            command.Parameters.AddWithValue("@CVV", CVV);


                            int affectedRows = command.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Kredi kartı bilgileriniz başarıyla kaydedildi ve ödeme işleminiz gerçekleşti");
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
