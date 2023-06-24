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

namespace bioCare2
{
    public partial class AnaSayfa : Form
    {
        int panelGenislik;
        bool gecis;

        public AnaSayfa()
        {
            InitializeComponent();
            
            
            
        }

        public string yetki_sayfa;
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            gecis = false;
            panelGenislik = panelAnaMenu.Width;
            gecis = true;
            
            label_Yetki.Text = yetki_sayfa;
            if (label_Yetki.Text == "personel")
            {
                btn_Log.Visible = false;
            }

        }
        private void belirtec(Control btn)
        {
            panelBelirtec.Top = btn.Top;
            panelBelirtec.Height = btn.Height;
        }

        private void menuGoster(Control c)
        {
            c.Dock = DockStyle.Fill;
            panel_MenuGoster.Controls.Clear();
            panel_MenuGoster.Controls.Add(c);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gecis)
            {
                panelAnaMenu.Width = panelAnaMenu.Width + 10;
                if (panelAnaMenu.Width > panelGenislik)
                {
                    timer1.Stop();
                    gecis = false;
                    this.Refresh();
                }
            }
            else
            {
                panelAnaMenu.Width = panelAnaMenu.Width - 10;
                if (panelAnaMenu.Width <= 67)
                {
                    timer1.Stop();
                    gecis = true;
                    this.Refresh();
                }
            }
        }

        

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_Urun_Click(object sender, EventArgs e)
        {
            belirtec(btn_Urun);
            urunGoster urunGoster = new urunGoster();
            menuGoster(urunGoster);
        }

        private void btn_Personel_Click(object sender, EventArgs e)
        {
            belirtec(btn_Personel);
            personelGoster personelGoster = new personelGoster();
            personelGoster.yetki3 = yetki_sayfa;
            menuGoster(personelGoster);
            
        }

        private void btn_Musteri_Click(object sender, EventArgs e)
        {
            belirtec(btn_Musteri);
            musteriGoster musteriGoster = new musteriGoster();
            menuGoster(musteriGoster) ;
        }

        private void btn_Satis_Click(object sender, EventArgs e)
        {
            belirtec(btn_Satis);
            satisGoster satisGoster = new satisGoster();
            menuGoster(satisGoster);
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            belirtec(btn_Log);
            logGoster logGoster = new logGoster();
            menuGoster(logGoster);
        }
        
    }
}
