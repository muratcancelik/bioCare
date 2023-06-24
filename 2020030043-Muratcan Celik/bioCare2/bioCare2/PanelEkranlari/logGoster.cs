using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bioCare2.PanelEkranlari;
namespace bioCare2.PanelEkranlari
{
    public partial class logGoster : UserControl
    {
        public logGoster()
        {
            InitializeComponent();
        }

        

        private void menuGoster(Control c)
        {
            c.Dock = DockStyle.Fill;
            panel7.Controls.Clear();
            panel7.Controls.Add(c);
        }

        private void btn_MusteriLog_Click(object sender, EventArgs e)
        {
            musteri_MusteriLog musteri_MusteriLog = new musteri_MusteriLog();
            menuGoster(musteri_MusteriLog);
        }

        private void btn_UrunLog_Click(object sender, EventArgs e)
        {
            urun_UrunLog urun_UrunLog = new urun_UrunLog();
            menuGoster(urun_UrunLog);
        }

        private void btn_SatisLog_Click(object sender, EventArgs e)
        {
            satis_SatisLog satis_SatisLog = new satis_SatisLog();
            menuGoster(satis_SatisLog);
        }
    }
}
