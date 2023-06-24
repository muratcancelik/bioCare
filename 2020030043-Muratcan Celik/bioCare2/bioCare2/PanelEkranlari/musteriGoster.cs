using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bioCare2.Formlar;
using MySql.Data.MySqlClient;
namespace bioCare2.PanelEkranlari
{
    public partial class musteriGoster : UserControl
    {
        MySqlConnection sqlConnection = new MySqlConnection("user=root; password=6i!302uF; port=3306; server=localhost; database=eva");
        MySqlDataAdapter adapter;
        MySqlCommand cmd;
        DataSet dset;
        public musteriGoster()
        {
            InitializeComponent();
        }

        private void btn_MusteriEkle_Click(object sender, EventArgs e)
        {
            musteri_MusteriEkle musteri_MusteriEkle = new musteri_MusteriEkle();
            musteri_MusteriEkle.Show();
        }

        private void musteriGoster_Load(object sender, EventArgs e)
        {
            MusteriGoster();
        }

        private void btn_MusteriSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow secilen in dataGridView1.SelectedRows)  
            {
                int numara = Convert.ToInt32(secilen.Cells[0].Value);
                KayıtSil(numara);
            }
            MusteriGoster();
        }

        void MusteriGoster()
        {
            adapter = new MySqlDataAdapter("Select * from Musteri", sqlConnection);
            dset = new DataSet();
            sqlConnection.Open();
            adapter.Fill(dset, "musteri");
            dataGridView1.DataSource = dset.Tables["musteri"]; ;
            sqlConnection.Close();
        }

        void KayıtSil(int numara)
        {
            string sql = "DELETE FROM musteri WHERE m_Id=@mid";
            cmd = new MySqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@mid", numara);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            MusteriGoster();
        }
    }
}
