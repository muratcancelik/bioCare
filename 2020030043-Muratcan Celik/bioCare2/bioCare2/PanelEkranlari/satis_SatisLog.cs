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
    public partial class satis_SatisLog : UserControl
    {
        public satis_SatisLog()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnection = new MySqlConnection("user=root; password=6i!302uF; port=3306; server=localhost; database=eva");
        MySqlDataAdapter adapter;
        DataSet dset;

        private void satis_SatisLog_Load(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("Select * from satisLogGoster", sqlConnection);
            dset = new DataSet();
            sqlConnection.Open();
            adapter.Fill(dset, "satisLogGoster");
            dataGridView1.DataSource = dset.Tables["satisLogGoster"]; ;
            sqlConnection.Close();
        }
    }
}
