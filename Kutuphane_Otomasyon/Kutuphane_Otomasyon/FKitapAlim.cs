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
    public partial class FKitapAlim : Form
    {
        VeriTabani_Baglanti conn = new VeriTabani_Baglanti();
        object id;
        
        public FKitapAlim()
        {  
            InitializeComponent();
            Listele();
        }
        void Listele()
        {
            conn.con.Open();
            SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM KitapAlim", conn.con);
            DataTable DataT = new DataTable();
            Da.Fill(DataT);
            DGKitapAlim.DataSource = DataT.DefaultView;
            DGKitapAlim.Columns[0].Visible = false;
            conn.con.Close();
        }

        private void BtKitapAOlustur_Click(object sender, EventArgs e)
        {
            conn.KitapAlimEkle(TxKitapAlimEkle.Text.ToString(), TxKisiAlimEkle.Text.ToString(), String.Format(DateTime.Now.ToString("dd.MM.yyyy")), DTPKitapAlimEkle.Value.ToString("dd/MM/yyyy"));
            if (conn.HataKodu != "")
            {
                MessageBox.Show(conn.HataKodu);
                conn.HataKodu = "";
            }
            TxKisiAlimEkle.Clear();
            TxKitapAlimEkle.Clear();
            DTPKitapAlimEkle.ResetText();

          
                Listele();
        

            
        }

        private void BtKitapAGuncelle_Click(object sender, EventArgs e)
        {
            conn.KitapAlimGuncelle(TxKADKisi.Text, DtpKitapD.Text, id);
            if (conn.HataKodu != "")
            {
                MessageBox.Show(conn.HataKodu);
                conn.HataKodu = "";
            }
           
            Listele();
        }

        private void DGKitapAlim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id =DGKitapAlim.CurrentRow.Cells[0].Value.ToString();
            TxKADKitap.Text = DGKitapAlim.CurrentRow.Cells[1].Value.ToString();
            TxKADKisi.Text = DGKitapAlim.CurrentRow.Cells[2].Value.ToString();
            DtpKitapD.Text = DGKitapAlim.CurrentRow.Cells[4].Value.ToString();
        }

        private void BtKitapASil_Click(object sender, EventArgs e)
        {
            conn.KitapAlimSil(id, TxKADKitap.Text);
            if (conn.HataKodu != "")
            {
                MessageBox.Show(conn.HataKodu);
                conn.HataKodu = "";
            }
           
            Listele();
        }

      
       
    }
}
