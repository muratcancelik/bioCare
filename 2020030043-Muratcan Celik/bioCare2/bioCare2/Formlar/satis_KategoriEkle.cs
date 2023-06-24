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
    public partial class satis_KategoriEkle : Form
    {
        MySqlConnection sqlConnection = new MySqlConnection("user=root; password=6i!302uF; port=3306; server=localhost; database=eva");
        MySqlCommand command;
        

        public satis_KategoriEkle()
        {
            InitializeComponent();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            sqlConnection.Open();
            command.Connection = sqlConnection;
            command.CommandText = "insert into Kategori(k_Id,k_Ad) values(" + txt_KategoriNo.Text + ",'" + txt_KategoriAd.Text + "')";
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kategori Eklendi.");
        }
    }
}
