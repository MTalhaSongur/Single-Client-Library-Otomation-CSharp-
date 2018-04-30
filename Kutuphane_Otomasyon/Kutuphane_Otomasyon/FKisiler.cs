using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Kutuphane_Otomasyon
{
    public partial class FKisiler : Form
    {
        VeriTabani_Baglanti conn = new VeriTabani_Baglanti();
        object id = 0;
        public FKisiler()
        {
            InitializeComponent();
            Listele();
        }
        void Listele()
        {
            conn.con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kisiler", conn.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGKisiler.DataSource = dt.DefaultView;
            DGKisiler.Columns[0].Visible = false;
            conn.con.Close();

        }
     

        private void DGKisiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DGKisiler.CurrentRow.Cells[0].Value.ToString();
            TxAdSoyadDz.Text = DGKisiler.CurrentRow.Cells[1].Value.ToString();
            TxTcNoDz.Text = DGKisiler.CurrentRow.Cells[2].Value.ToString();
            TxNumaraDz.Text = DGKisiler.CurrentRow.Cells[3].Value.ToString();
            RtbAdresDz.Text = DGKisiler.CurrentRow.Cells[4].Value.ToString();

        }

        private void BtKisiDz_Click(object sender, EventArgs e)
        {
            conn.KisiGuncelle(TxAdSoyadDz.Text, TxTcNoDz.Text, TxNumaraDz.Text, RtbAdresDz.Text, id);
            if (conn.HataKodu != "")
            {
                MessageBox.Show(conn.HataKodu);
                conn.HataKodu = "";
            }
            TxAdSoyadDz.Clear();
            TxNumaraDz.Clear();
            TxTcNoDz.Clear();
            RtbAdresDz.Clear();
            Listele();
        }

        private void BtKisiSil_Click(object sender, EventArgs e)
        {
            conn.KisiSil(id);
            if (conn.HataKodu != "")
            {
                MessageBox.Show(conn.HataKodu);
                conn.HataKodu = "";
            }
            TxAdSoyadDz.Clear();
            TxNumaraDz.Clear();
            TxTcNoDz.Clear();
            RtbAdresDz.Clear();
            Listele();
        }

        private void BtKisiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(TxNumaraEkle.Text);
                Double.Parse(TxTcNoEkle.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Tcno ve numarayı kontrol ediniz.");
                goto HataRakam;
            }
            if (TxNumaraEkle.Text.Length != 11 || TxTcNoEkle.Text.Length != 11)
            {
                MessageBox.Show("Tcno veya numara doğru uzunlukta değil.");
            }
            else
            {
                conn.con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TcNo FROM Kisiler WHERE TcNo = '" + TxTcNoEkle.Text + "'", conn.con);
                DataTable DT = new DataTable();
                da.Fill(DT);
                if (DT.Rows.Count > 0)
                {
                    MessageBox.Show("Bu Tc numarası önceden alınmıştır...");
                }
                else
                {
                    conn.KisiEkle(TxAdSoyadEkle.Text, TxTcNoEkle.Text, TxNumaraEkle.Text, RtbAdresEkle.Text);
                    TxAdSoyadEkle.Clear();
                    TxNumaraEkle.Clear();
                    TxTcNoEkle.Clear();
                    RtbAdresEkle.Clear();
                }
                conn.con.Close();
                if (conn.HataKodu != "")
                {
                    MessageBox.Show(conn.HataKodu);
                    conn.HataKodu = "";
                }
            }
            HataRakam:
            Listele();
        }

   
    }
}
