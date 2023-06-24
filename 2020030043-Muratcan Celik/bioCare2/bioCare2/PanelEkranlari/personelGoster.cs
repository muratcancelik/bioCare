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
    public partial class personelGoster : UserControl
    {
        MySqlConnection sqlConnection = new MySqlConnection("user=root; password=6i!302uF; port=3306; server=localhost; database=eva");
        MySqlDataAdapter adapter;
        MySqlCommand cmd;
        DataSet dset;
        public personelGoster()
        {
            InitializeComponent();
        }

        private void btn_PersonelEkle_Click(object sender, EventArgs e)
        {
            personel_PersonelEkle personel_PersonelEkle = new personel_PersonelEkle();
            personel_PersonelEkle.Show();
        }
        public string yetki3;
        private void personelGoster_Load(object sender, EventArgs e)
        {

            PersonelGoster();
            if (yetki3=="personel")
            {
                btn_PersonelSil.Visible = false;
            }

        }
        void PersonelGoster()
        {
            adapter = new MySqlDataAdapter("Select * from personel_departman_maas", sqlConnection);
            dset = new DataSet();
            sqlConnection.Open();
            adapter.Fill(dset, "personel_departman_maas");
            dataGridView1.DataSource = dset.Tables["personel_departman_maas"]; ;
            sqlConnection.Close();
        }
        void KayıtSil(int numara)
        {
            string sql = "DELETE FROM Personel WHERE p_Id=@pid";
            cmd = new MySqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@pid", numara);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }


        private void btn_PersonelSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow secilen in dataGridView1.SelectedRows)
            {
                int numara = Convert.ToInt32(secilen.Cells[0].Value);
                KayıtSil(numara);
            }
            PersonelGoster();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            PersonelGoster();
        }

       
    }
}
