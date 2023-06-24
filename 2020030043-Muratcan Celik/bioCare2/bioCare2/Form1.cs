using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace bioCare2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        MySqlConnection sqlConnection = new MySqlConnection("user=root; password=6i!302uF; port=3306; server=localhost; database=eva");
        MySqlDataReader reader;
        MySqlCommand cmd;

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Giris_Click(object sender, EventArgs e)

        {
            string sorgu = "select * from girisbilgi where gb_kullaniciad ='" + txt_KullaniciAdi.Text+ "' and gb_sifre ='" + txt_Sifre.Text + "'";
            sqlConnection.Open();
            cmd = new MySqlCommand(sorgu, sqlConnection);
            reader = cmd.ExecuteReader();

            String yetki = "";
            if (reader.Read())
            {
                yetki = reader["gb_yetki"].ToString();
                if (yetki != "")
                {
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.yetki_sayfa = yetki;
                    this.Hide();
                    anaSayfa.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Hatali Kullanici Adi veya Hatali Parola Tekrar Deneyiniz");
            }

            sqlConnection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                
            

        }
    }

}
