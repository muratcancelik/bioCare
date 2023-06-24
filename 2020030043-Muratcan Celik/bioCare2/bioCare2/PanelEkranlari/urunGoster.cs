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
    public partial class urunGoster : UserControl
    {
        MySqlConnection sqlConnection = new MySqlConnection("user=root; password=6i!302uF; port=3306; server=localhost; database=eva");
        MySqlDataAdapter adapter;
        MySqlCommand cmd;
        DataSet dset;
        public urunGoster()
        {
            InitializeComponent();
        }

        
        private void btn_UrunEkle_Click(object sender, EventArgs e)
        {
            urun_UrunEkle urun_UrunEkle = new urun_UrunEkle();
            urun_UrunEkle.Show();

        }

        private void urunGoster_Load(object sender, EventArgs e)
        {
            UrunGoster();
        }

        void UrunGoster()
        {
            adapter = new MySqlDataAdapter("select * from kategori_urun", sqlConnection);
            dset = new DataSet();
            sqlConnection.Open();
            adapter.Fill(dset, "kategori_urun");
            dataGridView1.DataSource = dset.Tables["kategori_urun"]; ;
            sqlConnection.Close();
        }
        void KayıtSil(int numara)
        {
            string sql = "DELETE FROM Urun WHERE u_Id=@uid";
            cmd = new MySqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@uid", numara);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btn_UrunSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow secilen in dataGridView1.SelectedRows)
            {
                int numara = Convert.ToInt32(secilen.Cells[0].Value);
                KayıtSil(numara);
            }
            UrunGoster();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            UrunGoster();
        }
    }
}
