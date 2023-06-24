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
    public partial class personel_DepartmanEkle : Form
    {
        MySqlConnection sqlConnection = new MySqlConnection("user=root; password=6i!302uF; port=3306; server=localhost; database=eva");
        MySqlCommand command;
        


        public personel_DepartmanEkle()
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
            command.CommandText = "insert into Departman(d_Id,d_Ad) values(" + txt_DepartmanNo.Text + ",'" + txt_DepartmanAd.Text +  "')";
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Departman Eklendi.");

        }
    }
}
