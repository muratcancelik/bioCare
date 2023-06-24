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
    public partial class personel_PersonelEkle : Form
    {
        MySqlConnection sqlConnection = new MySqlConnection("user=root; password=6i!302uF; port=3306; server=localhost; database=eva");
        MySqlCommand command;
        DataTable DataTable;

        public personel_PersonelEkle()
        {
            InitializeComponent();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_DepartmanEkle_Click(object sender, EventArgs e)
        {
            personel_DepartmanEkle personel_DepartmanEkle = new personel_DepartmanEkle();
            personel_DepartmanEkle.Show();
        }

        private void personel_PersonelEkle_Load(object sender, EventArgs e)
        {
            DepartmanGetir();
            MaasGetir();
        }

         void DepartmanGetir()
        {
            command = new MySqlCommand("select * from Departman", sqlConnection);
            sqlConnection.Open();
            DataTable = new DataTable();
            DataTable.Load(command.ExecuteReader());
            cmb_Departman.DataSource = DataTable;
            cmb_Departman.DisplayMember = "d_Ad";
            cmb_Departman.ValueMember = "d_Id";
            sqlConnection.Close();
        }
        void MaasGetir()
        {
            command = new MySqlCommand("select * from Maas", sqlConnection);
            sqlConnection.Open();
            DataTable = new DataTable();
            DataTable.Load(command.ExecuteReader());
            cmb_Maas.DataSource = DataTable;
            cmb_Maas.DisplayMember = "m_Maas";
            cmb_Maas.ValueMember = "m_Id";
            sqlConnection.Close();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
                command = new MySqlCommand();
                sqlConnection.Open();
                command.Connection = sqlConnection;
                command.CommandText = "call personel_ekleme(" + txt_PersonelNo.Text + ",'" + txt_PersonelAd.Text + "','" + txt_PersonelSoyad.Text + "','" + txt_Tc.Text + "','" + txt_Tel.Text + "'," + cmb_Departman.SelectedValue.ToString() + "," + cmb_Maas.SelectedValue.ToString() + ")";    
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Personel Eklendi.");
            
            
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            txt_PersonelAd.Text = "";
            txt_PersonelNo.Text = "";
            txt_PersonelSoyad.Text = "";
            txt_Tc.Text = "";
            txt_Tel.Text= "";
            cmb_Departman.Text = "";
            cmb_Maas.Text = "";
               
        }
    }
}
