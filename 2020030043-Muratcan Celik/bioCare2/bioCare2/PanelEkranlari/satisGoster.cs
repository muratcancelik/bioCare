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
using Microsoft.Office.Interop.Excel;

namespace bioCare2.PanelEkranlari
{
    public partial class satisGoster : UserControl
    {
        MySqlConnection sqlConnection = new MySqlConnection("user=root; password=6i!302uF; port=3306; server=localhost; database=eva");
        MySqlDataAdapter adapter;
        MySqlCommand cmd;
        DataSet dset;
        public satisGoster()
        {
            InitializeComponent();
        }

        private void btn_SatisEkle_Click(object sender, EventArgs e)
        {
            satis_SatisEkle satis_SatisEkle = new satis_SatisEkle();
            satis_SatisEkle.Show();

        }

        private void satisGoster_Load(object sender, EventArgs e)
        {
            SatisGoster();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
           
                foreach (DataGridViewRow secilen in dataGridView1.SelectedRows)
                {
                    int numara = Convert.ToInt32(secilen.Cells[0].Value);
                    KayıtSil(numara);
                }
                SatisGoster();
            
        }

        void SatisGoster()
        {
            adapter = new MySqlDataAdapter("select * from satis_urun_musteri_personel", sqlConnection);
            dset = new DataSet();
            sqlConnection.Open();
            adapter.Fill(dset, "satis_urun_musteri_personel");
            dataGridView1.DataSource = dset.Tables["satis_urun_musteri_personel"]; ;
            sqlConnection.Close();
        }

        void KayıtSil(int numara)
        {
            string sql = "DELETE FROM Satis WHERE s_Id=@sid";
            sqlConnection.Open();
            cmd = new MySqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@sid", numara);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            SatisGoster();
        }

        private void btn_Rapor_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                myRange.Value2 = dataGridView1.Columns[i].HeaderText;

            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
                    myRange.Value2 = dataGridView1[i, j].Value;
                }
            }
        }
    }
}
