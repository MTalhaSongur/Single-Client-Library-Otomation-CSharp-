using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kutuphane_Otomasyon
{
    public partial class AnaEkran : Form
    {
        DataTable dt;
        VeriTabani_Baglanti conn = new VeriTabani_Baglanti();
      
        
        public AnaEkran()
        {
            InitializeComponent();
            BListele();
            KitapAlimTeslim();
        }
        void BListele()
        {
            conn.con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT KisiAdi, KitapAdi, AlimTarihi, TeslimTarihi FROM KitapTeslim", conn.con);            
            dt = new DataTable();
            da.Fill(dt);
            DGBildirim.DataSource = dt.DefaultView;
            conn.con.Close();

        }
        public void KitapAlimTeslim()
        {
            conn.con.Close();
            conn.con.Open();
            SqlCommand komutsil = new SqlCommand("DELETE FROM KitapTeslim", conn.con);
            komutsil.ExecuteNonQuery();
            string teslimkontrol;
            SqlCommand komutal = new SqlCommand("SELECT * FROM KitapAlim", conn.con);
            SqlDataReader oku = komutal.ExecuteReader();
          
            if (oku.HasRows)
            {
                while (oku.Read())
                {
                    teslimkontrol = oku.GetValue(4).ToString();
                    TimeSpan ts = Convert.ToDateTime(teslimkontrol) - Convert.ToDateTime(oku.GetValue(3).ToString());
                    int gunAl = ts.Days;
                    if (gunAl < 7)
                    {
                        SqlCommand Teslimkomut = new SqlCommand("INSERT INTO KitapTeslim(KisiAdi, KitapAdi, AlimTarihi, TeslimTarihi) VALUES (@kisiadi,@kitapadi,@alimtarihi,@teslimtarihi)", conn.con);
                        Teslimkomut.Parameters.AddWithValue("kisiadi",oku.GetValue(2).ToString());
                        Teslimkomut.Parameters.AddWithValue("kitapadi", oku.GetValue(1).ToString());
                        Teslimkomut.Parameters.AddWithValue("alimtarihi", oku.GetValue(3).ToString());
                        Teslimkomut.Parameters.AddWithValue("teslimtarihi", oku.GetValue(4).ToString());
                        try
                        {
                            Teslimkomut.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Bildirimler yüklenirken bir sorun oluştu...");
                           
                        }
                    }
                }
            }
            conn.con.Close();
        }
  
       
        private void BTKisiler_Click(object sender, EventArgs e)
        {
           
            FKisiler fkisiler = new FKisiler();
            fkisiler.MdiParent = this;
            fkisiler.Dock = DockStyle.Fill;
            fkisiler.Show();
            fkisiler.Location = new Point(0,0);
            
        }

        private void BTKitaplar_Click(object sender, EventArgs e)
        {
          
            FKitaplar fkitaplar = new FKitaplar();
            fkitaplar.MdiParent = this;
            fkitaplar.Dock = DockStyle.Fill;
            fkitaplar.Show();
            fkitaplar.Location = new Point(0,0);
        }

        private void BTKitapAlim_Click(object sender, EventArgs e)
        {
           
            FKitapAlim fkitapalim = new FKitapAlim();
            fkitapalim.MdiParent = this;
            fkitapalim.Dock = DockStyle.Fill;
            fkitapalim.Show();
            fkitapalim.Location = new Point(0,0);
        }

        private void BTCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BListele();
            KitapAlimTeslim();
            
        }

      
        private void label1_MouseEnter(object sender, EventArgs e)
        {
           
            label1.Text = "1 haftadan az kalmış teslimler burada görünür.";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "*";
        }

      
    }
}
