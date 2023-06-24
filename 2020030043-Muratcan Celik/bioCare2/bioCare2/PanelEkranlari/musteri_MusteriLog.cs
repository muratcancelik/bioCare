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

namespace bioCare2.PanelEkranlari
{
    public partial class musteri_MusteriLog : UserControl
    {
        public musteri_MusteriLog()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnection = new MySqlConnection("user=root; password=6i!302uF; port=3306; server=localhost; database=eva");
        MySqlDataAdapter adapter;
        DataSet dset;
        private void musteri_MusteriLog_Load(object sender, EventArgs e)
        {
           
                adapter = new MySqlDataAdapter("Select * from musteriLog_goster", sqlConnection);
                dset = new DataSet();
                sqlConnection.Open();
                adapter.Fill(dset, "musteriLog_goster");
                dataGridView1.DataSource = dset.Tables["musteriLog_goster"]; ;
                sqlConnection.Close();
            
        }
    }
}
