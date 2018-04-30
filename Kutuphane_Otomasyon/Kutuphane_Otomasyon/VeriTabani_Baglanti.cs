using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Kutuphane_Otomasyon
{
  
    class VeriTabani_Baglanti
    {

        public SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=Kut.Oto_VeriTabani;Trusted_Connection=true");
        public string HataKodu = "";
      
        public void KisiEkle(string adsoyad, string tcno, string numara, string adres)
        {
            con.Close();
            con.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Kisiler(AdSoyad,TcNo,Numara,Adres) VALUES (@adsoyad,@tcno,@numara,@adres)",con);
            komut.Parameters.AddWithValue("adsoyad", adsoyad);
            komut.Parameters.AddWithValue("tcno", tcno);
            komut.Parameters.AddWithValue("numara", numara);
            komut.Parameters.AddWithValue("adres", adres);
            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                HataKodu = "Kişi eklenirken bir hata oluştu...";
            }
            con.Close();
        }
        public void KisiGuncelle(string adsoyad, string tcno, string numara, string adres, object id)
        {

            con.Open();
            SqlCommand komut = new SqlCommand("UPDATE Kisiler SET AdSoyad = @adsoyad, TcNo = @tcno, Numara = @numara, Adres = @adres WHERE ID = @id", con);
            komut.Parameters.AddWithValue("adsoyad", adsoyad);
            komut.Parameters.AddWithValue("tcno", tcno);
            komut.Parameters.AddWithValue("numara", numara);
            komut.Parameters.AddWithValue("adres", adres);
            komut.Parameters.AddWithValue("id",id);
            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                HataKodu = "Kisilerin güncellemesinde bir sorun oluştu...";
                
            }
            con.Close();
        }
        public void KisiSil(object id)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Kisiler WHERE ID = @id", con);
            komut.Parameters.AddWithValue("id",id);
            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {

                HataKodu = "Kişi silme Sırasında bir hata oluştu...";
            }
            con.Close();
        }
        public void KitapEkle(string kitapadi, string kitapyazari, string kitapaciklamasi, string kitapturu)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Kitaplar(KitapAdi, KitapYazari, KitapAciklamasi, KitapTuru) VALUES (@kitapadi,@kitapyazari,@kitapaciklamasi,@kitapturu)", con);
            komut.Parameters.AddWithValue("kitapadi", kitapadi);
            komut.Parameters.AddWithValue("kitapyazari", kitapyazari);
            komut.Parameters.AddWithValue("kitapaciklamasi", kitapaciklamasi);
            komut.Parameters.AddWithValue("kitapturu", kitapturu);
            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                HataKodu ="Kitap eklenirken bir hata olustu";
                
            }
            con.Close();
        }
        public void KitapGuncelle(string kitapadi, string kitapyazari, string kitapaciklamasi, string kitapturu,object id)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("UPDATE Kitaplar SET KitapAdi = @kitapadi, KitapYazari = @kitapyazari, KitapAciklamasi = @kitapaciklama, KitapTuru = @kitapturu WHERE ID = @id", con);
            komut.Parameters.AddWithValue("kitapadi", kitapadi);
            komut.Parameters.AddWithValue("kitapyazari", kitapyazari);
            komut.Parameters.AddWithValue("kitapaciklama", kitapaciklamasi);
            komut.Parameters.AddWithValue("kitapturu",kitapturu);
            komut.Parameters.AddWithValue("id", id);
            
            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                HataKodu = "Kitap guncellenirken bir sorun oluştu...";
                
            }
            con.Close();
        }
        public void KitapSil(object id)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Kitaplar WHERE ID = @id", con);
            komut.Parameters.AddWithValue("id",id);
            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {

                HataKodu = "Kitap silme Sırasında bir hata oluştu...";
            }
            con.Close();
        }
        public void KitapAlimEkle(string kitapadi, string kisiadi,string alimtarihi, string teslimtarihi)
        {
            DataTable DT;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kisiler WHERE AdSoyad= '"+kisiadi+"'",con);
           
            DT = new DataTable();
            da.Fill(DT);
            if (DT.Rows.Count == 0)
            {
               HataKodu = "Bu kullanıcı bulunmamakta...";
            }
            else
            {
                SqlDataAdapter DA = new SqlDataAdapter("SELECT * FROM Kitaplar WHERE KitapAdi='" + kitapadi + "'", con);
                DT = new DataTable();
                DA.Fill(DT);
                if (DT.Rows.Count == 0)
                {
                   HataKodu = "Bu kitap bulunmamakta...";
                }
                else
                {
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM Kitaplar WHERE KitapDurumu = '" + "Alındı" + "' AND KitapAdi = '" + kitapadi + "'", con);
                    DT = new DataTable();
                    Da.Fill(DT);
                    if (DT.Rows.Count > 0)
                    {
                        HataKodu = "Bu kitap zaten alınmış...";
                    }
                    else
                    {
                        SqlCommand komut = new SqlCommand("INSERT INTO KitapAlim(KitapAdi, KisiAdi, AlimTarihi, TeslimTarihi) VALUES (@kitapadi,@kisiadi,@alimtarihi,@teslimtarihi)", con);
                        SqlCommand durumekle = new SqlCommand("UPDATE Kitaplar SET KitapDurumu = @durum WHERE KitapAdi = @durumkitapadi", con);
                        komut.Parameters.AddWithValue("kitapadi", kitapadi);
                        komut.Parameters.AddWithValue("kisiadi", kisiadi);
                        komut.Parameters.AddWithValue("alimtarihi", alimtarihi);
                        komut.Parameters.AddWithValue("teslimtarihi", teslimtarihi);
                        durumekle.Parameters.AddWithValue("durum", "Alındı");
                        durumekle.Parameters.AddWithValue("durumkitapadi", kitapadi);

                        try
                        {
                            komut.ExecuteNonQuery();
                            durumekle.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {

                            HataKodu = "Kitap alım eklenirken bir sorun oluştu...";
                        }
                    }    
                }
            }
            con.Close();            
        }
        public void KitapAlimGuncelle(string kisiadi, string teslimtarihi, object id)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("UPDATE KitapAlim SET KisiAdi = @kisiadi,TeslimTarihi = @teslimtarihi WHERE ID = @id", con);
            komut.Parameters.AddWithValue("kisiadi",kisiadi);
            komut.Parameters.AddWithValue("teslimtarihi",teslimtarihi);
            komut.Parameters.AddWithValue("id",id);
            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                HataKodu = "Kitap alım güncellenirken bir sorun oluştu...";
               
            }
            con.Close();
        }
        public void KitapAlimSil(object id, string kitapadi)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM KitapAlim WHERE ID = @id", con);
            komut.Parameters.AddWithValue("id",id);
            SqlCommand komutdurum = new SqlCommand("UPDATE Kitaplar SET KitapDurumu = @null WHERE KitapAdi = @kitapadi", con);
            komutdurum.Parameters.AddWithValue("null", "");
            komutdurum.Parameters.AddWithValue("kitapadi",kitapadi);
            try
            {
                komutdurum.ExecuteNonQuery();
                komut.ExecuteNonQuery();
             
            }
            catch (Exception)
            {
                HataKodu = "Kitap alım silinirken bir hata oluştu";               
            }
            con.Close();
        }
 

    }
}
