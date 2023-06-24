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
    public partial class satis_SatisEkle : Form
    {
        MySqlConnection sqlConnection = new MySqlConnection("user=root; password=6i!302uF; port=3306; server=localhost; database=eva");
        MySqlCommand command;
        DataTable DataTable;

        public satis_SatisEkle()
        {
            InitializeComponent();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            sqlConnection.Open();
            command.Connection = sqlConnection;
            command.CommandText = "call satis_ekleme_islemi(" + txt_SatisNo.Text + "," + cmb_Urun.SelectedValue.ToString() + "," + txt_Adet.Text + "," + cmb_MusteriAd.SelectedValue.ToString() + "," + cmb_PersonelAd.SelectedValue.ToString() + "," + cmb_Fiyat.SelectedValue.ToString() + ",'" + dtp_Tarih.Value.ToShortDateString() + "')";
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Urun Eklendi.");
        }

        private void satis_SatisEkle_Load(object sender, EventArgs e)
        {
            UrunGetir();
            MusteriGetir();
            PersonelGetir();
            FiyatGetir();
        }

        private void UrunGetir()
        {
            command = new MySqlCommand("select * from Urun", sqlConnection);
            sqlConnection.Open();
            DataTable = new DataTable();
            DataTable.Load(command.ExecuteReader());
            cmb_Urun.DataSource = DataTable;
            cmb_Urun.DisplayMember = "u_Ad";
            cmb_Urun.ValueMember = "u_Id";
            sqlConnection.Close();
        }

        private void MusteriGetir()
        {
            command = new MySqlCommand("select * from musteri", sqlConnection);
            sqlConnection.Open();
            DataTable = new DataTable();
            DataTable.Load(command.ExecuteReader());
            cmb_MusteriAd.DataSource = DataTable;
            cmb_MusteriAd.DisplayMember = "m_ad";
            cmb_MusteriAd.ValueMember = "m_Id";
            sqlConnection.Close();
        }
        private void PersonelGetir()
        {
            command = new MySqlCommand("select * from Personel", sqlConnection);
            sqlConnection.Open();
            DataTable = new DataTable();
            DataTable.Load(command.ExecuteReader());
            cmb_PersonelAd.DataSource = DataTable;
            cmb_PersonelAd.DisplayMember = "p_ad";
            cmb_PersonelAd.ValueMember = "p_Id";
            sqlConnection.Close();

        }
        private void FiyatGetir()
        {
            command = new MySqlCommand("select * from fiyat", sqlConnection);
            sqlConnection.Open();
            DataTable = new DataTable();
            DataTable.Load(command.ExecuteReader());
            cmb_Fiyat.DataSource = DataTable;
            cmb_Fiyat.DisplayMember = "f_fiyat";
            cmb_Fiyat.ValueMember = "f_Id";
            sqlConnection.Close();

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            txt_Adet.Text = "";
            txt_SatisNo.Text = "";
            cmb_Fiyat.Text = "";
            cmb_MusteriAd.Text = "";
            cmb_PersonelAd.Text = "";
            cmb_Urun.Text = "";
            dtp_Tarih.Text = "";
            
        }
    }
}
