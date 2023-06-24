using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bioCare2.Formlar
{
    public partial class musteri_MusteriEkle : Form
    {
        MySqlConnection sqlConnection = new MySqlConnection("user=root; password=6i!302uF; port=3306; server=localhost; database=eva");
        MySqlCommand command;

        public musteri_MusteriEkle()
        {
            InitializeComponent();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                command = new MySqlCommand();
                sqlConnection.Open();
                command.Connection = sqlConnection;
                command.CommandText = "insert into Musteri(m_Id,m_Ad,m_Soyad,m_TcKimlik,m_Adres,m_Eposta,m_Telno) values (" + txt_MusteriNo.Text + ",'" + txt_MusteriAd.Text + "','" + txt_MusteriSoyad.Text + "','" + txt_Tc.Text + "','" + txt_Adres.Text + "','" + txt_Eposta.Text + "','" + txt_Tel.Text + "')";
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Musteri Eklendi.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            txt_Adres.Text = "";
            txt_Eposta.Text = "";
            txt_MusteriAd.Text = "";
            txt_MusteriNo.Text = "";
            txt_MusteriSoyad.Text = "";
            txt_Tc.Text = "";
            txt_Tel.Text = "";
        }
    }
}
