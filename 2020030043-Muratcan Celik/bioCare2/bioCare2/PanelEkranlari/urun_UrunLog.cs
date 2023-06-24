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
    public partial class urun_UrunLog : UserControl
    {
        MySqlConnection sqlConnection = new MySqlConnection("user=root; password=6i!302uF; port=3306; server=localhost; database=eva");
        MySqlDataAdapter adapter;
        DataSet dset;
        public urun_UrunLog()
        {
            InitializeComponent();
        }

        private void urun_UrunLog_Load(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("Select * from urunLogGoster", sqlConnection);
            dset = new DataSet();
            sqlConnection.Open();
            adapter.Fill(dset, "musteriLog_goster");
            dataGridView1.DataSource = dset.Tables["musteriLog_goster"]; ;
            sqlConnection.Close();
        }
    }
}
