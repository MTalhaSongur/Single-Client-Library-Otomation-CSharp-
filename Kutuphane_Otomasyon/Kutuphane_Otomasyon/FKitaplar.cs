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
    public partial class FKitaplar : Form
    {
        VeriTabani_Baglanti conn = new VeriTabani_Baglanti();
        object id;
        public FKitaplar()
        {
            InitializeComponent();
            Listele();
            
        }
        void Listele()
        {
            conn.con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kitaplar", conn.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGKitaplar.DataSource = dt.DefaultView;
            DGKitaplar.Columns[0].Visible = false;
            conn.con.Close();
        }

        private void BtKitapOlustur_Click(object sender, EventArgs e)
        {
            if (TxKitapEkle.Text == "" || CBTurEkle.Text == "")
            {
                MessageBox.Show("Tür veya Ad boş geçilemez.");
            }
            else
            {
                conn.KitapEkle(TxKitapEkle.Text, TxYazarEkle.Text, RtbAcikEkle.Text, CBTurEkle.Text);
                if (conn.HataKodu != "")
                {
                    MessageBox.Show(conn.HataKodu);
                    conn.HataKodu = "";
                }
                TxKitapEkle.Clear();
                TxYazarEkle.Clear();
                CBTurEkle.ResetText();
                RtbAcikEkle.Clear();
                Listele();
            }
          
        }

        private void BtKitapDuzenle_Click(object sender, EventArgs e)
        {
            conn.KitapGuncelle(TxKitapDz.Text,TxYazarDz.Text,RtbAcikDz.Text,CBTurDz.Text,id);
            if (conn.HataKodu != "")
            {
                MessageBox.Show(conn.HataKodu);
                conn.HataKodu = "";
            }
            TxKitapDz.Clear();
            TxYazarDz.Clear();
            CBTurDz.ResetText();
            RtbAcikDz.Clear();
            Listele();
        }

        private void DGKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DGKitaplar.CurrentRow.Cells[0].Value.ToString();
            TxKitapDz.Text = DGKitaplar.CurrentRow.Cells[1].Value.ToString();
            TxYazarDz.Text = DGKitaplar.CurrentRow.Cells[2].Value.ToString();
            RtbAcikDz.Text = DGKitaplar.CurrentRow.Cells[3].Value.ToString();
            CBTurDz.Text = DGKitaplar.CurrentRow.Cells[4].Value.ToString();
        }

        private void BtKitapSil_Click(object sender, EventArgs e)
        {
            conn.KitapSil(id);
            if (conn.HataKodu != "")
            {
                MessageBox.Show(conn.HataKodu);
                conn.HataKodu = "";
            }
            TxKitapDz.Clear();
            TxYazarDz.Clear();
            CBTurDz.ResetText();
            RtbAcikDz.Clear();
            Listele();
        }
    }
}
