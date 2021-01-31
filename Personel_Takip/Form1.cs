using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//System.Data.OleDb kütüphensinin eklenmesi.
using System.Data.OleDb;


namespace Personel_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //VERİ TABANI DOSYA YOLU VE  PROVİDER NESNESİNİN BELİRLENMESİ
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0; Data Source =Personel.accdb");

        //Formlar arası veri aktarımında kullanılacak değişkenler 
        public static string tcno, adi, soyadi, yetki;

        private void Btn_giris_Click(object sender, EventArgs e)
        {
            if(hak!=0)//hak değişkeninin değeri  eşit değilse 0 giriş hakkına sahipse
            {
                baglantim.Open();// Veri tabanı bağlantısı
                OleDbCommand selectsorgu = new OleDbCommand("select* from Yoneticiler ", baglantim);
                OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();//Yöneticiler tablosundaki herşeyi getir ve datareader nesnesinde sakla demek
               
                while (kayitokuma.Read())//Data readde yönetciler varsa 
                {
                    
                    if ((kayitokuma["kullaniciadi"].ToString() == txt_yadi.Text )&& (kayitokuma["parola"].ToString() == txt_yparola.Text))
                    {
                     

                        durum = true;
                        tcno = kayitokuma.GetValue(0).ToString();//Acces tabanındaki tcyi buraya getir.
                        adi = kayitokuma.GetValue(1).ToString();
                        soyadi = kayitokuma.GetValue(2).ToString();
                       this.Hide();//Giriş yapıldığına göre bu fromu gizle 
                        Form2 frm2 = new Form2();
                        frm2.Show();
                        break;//Yapmak istediğimiz işlem bittiğine göre program while döngüsü içinde kalmasın diye döngüyü sonlandırmlıyız.



                    }
                   




                }

                if (durum == false)
                {
                    hak--;
                    baglantim.Close();


                }
            }
            lbl_hak.Text = Convert.ToString(hak);
            if(hak==0)
            {
                btn_giris.Enabled = false;
                MessageBox.Show("Giriş Hakkınız Kalmadı!!!","Personel Takip Programı",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                this.Close();
            }
        }

        //Yalnızca bu formda  geçerli olacak değişken tanımlamaları 
        int hak = 3;
        bool durum = false;
        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Text = "YÖNETİCİ GİRİŞİ...";
            this.AcceptButton = btn_giris;// Entere basıldığında giriş butonunu çalıştır demek
            this.CancelButton = btn_cikis;//Entere basıldığında çıkış yap 
            lbl_hak.Text = Convert.ToString(hak);
            this.StartPosition = FormStartPosition.CenterParent;//Ekranın merkezinde gelsin,gözüksün demek
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Yani tam ekran ve simge durumunu küçültme  tuşlarını pasif etme 


        }



















    }
}


