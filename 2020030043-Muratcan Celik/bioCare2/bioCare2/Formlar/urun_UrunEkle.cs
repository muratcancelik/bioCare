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
    public partial class urun_UrunEkle : Form
    {
        MySqlConnection sqlConnection = new MySqlConnection("user=root; password=6i!302uF; port=3306; server=localhost; database=eva");
        MySqlCommand command;
        DataTable DataTable;
        public urun_UrunEkle()
        {
            InitializeComponent();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        private void btn_MarkaEkle_Click(object sender, EventArgs e)
        {
            satis_MarkaEkle sma = new satis_MarkaEkle();
           
                sma.Show();
            
        }
        satis_KategoriEkle satis_KategoriEkle = new satis_KategoriEkle();
        private void btn_KategoriEkle_Click(object sender, EventArgs e)
        {
            satis_KategoriEkle.Show();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            sqlConnection.Open();
            command.Connection = sqlConnection;
            command.CommandText = "call urun_ekleme(" + txt_UrunNo.Text + ",'" + txt_UrunAd.Text + "'," + cmb_Marka.SelectedValue.ToString() + ",'" + txt_UrunAciklama.Text + "'," + cmb_Kategori.SelectedValue.ToString() + "," + txt_Stok.Text + "," + cmb_Fiyat.SelectedValue.ToString() + ")";
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Urun Eklendi.");
        }

        private void urun_UrunEkle_Load(object sender, EventArgs e)
        {
            MarkaGetir();
            KategoriGetir();
            FiyatGetir();
        }
        void MarkaGetir()
        {
            command = new MySqlCommand("select * from Marka", sqlConnection);
            sqlConnection.Open();
            DataTable = new DataTable();
            DataTable.Load(command.ExecuteReader());
            cmb_Marka.DataSource = DataTable;
            cmb_Marka.DisplayMember = "marka_ad";
            cmb_Marka.ValueMember = "marka_id";
            sqlConnection.Close();
        }

        void KategoriGetir()
        {
            command = new MySqlCommand("select * from Kategori", sqlConnection);
            sqlConnection.Open();
            DataTable = new DataTable();
            DataTable.Load(command.ExecuteReader());
            cmb_Kategori.DataSource = DataTable;
            cmb_Kategori.DisplayMember = "k_Ad";
            cmb_Kategori.ValueMember = "k_Id";
            sqlConnection.Close();
        }
        void FiyatGetir()
        {
            command = new MySqlCommand("select * from Fiyat", sqlConnection);
            sqlConnection.Open();
            DataTable = new DataTable();
            DataTable.Load(command.ExecuteReader());
            cmb_Fiyat.DataSource = DataTable;
            cmb_Fiyat.DisplayMember = "f_Fiyat";
            cmb_Fiyat.ValueMember = "f_Id";
            sqlConnection.Close();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            txt_UrunAd.Text = "";
            txt_UrunAciklama.Text = "";
            txt_UrunNo.Text = "";
            txt_Stok.Text = "";
            cmb_Fiyat.Text = "";
            cmb_Kategori.Text = "";
            cmb_Marka.Text = "";
        }
    }
}
