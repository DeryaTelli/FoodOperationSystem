using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace finalproje1
{
    public partial class FormYonetici : Form
    {
        public FormYonetici()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void MenuDoldur2()
        {

            OleDbDataAdapter da = new OleDbDataAdapter("select * from Menu", sabit.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMenu2.DataSource = dt;
        }
        private void SiparisDoldur2()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Siparis", sabit.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSiparis2.DataSource = dt;
        }
       

        private void FormYonetici_Load(object sender, EventArgs e)
        {
            KullaniciDoldur();
            YetkiDoldur();
        }
   
        private void YetkiDoldur()
        {
            OleDbDataAdapter dem = new OleDbDataAdapter("select*from Yetki", sabit.baglanti);
            DataTable dt = new DataTable();
            dem.Fill(dt);
            comboBoxYetki.DataSource= dt;
            comboBoxYetki.DisplayMember="Yetki";
            comboBoxYetki.ValueMember="YetkiId";

        }
        private void KullaniciDoldur()
        {
            OleDbDataAdapter dem = new OleDbDataAdapter("select*from Kullanıcı", sabit.baglanti);
            DataTable dt = new DataTable();
            dem.Fill(dt);
            dataGridViewYonetici.DataSource=dt;
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            YeniKullaniciEkle();
        }
        private void YeniKullaniciEkle()
        {
            OleDbConnection con = new OleDbConnection(sabit.baglanti);
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText ="insert into Kullanıcı(Adi,Soyadi,KullaniciAdi,Sifre,YetkiId)values(@Adi,@Soyadi,@KullaniciAdi,@Sifre,@YetkiId)";
            cmd.Parameters.AddWithValue("Adi", textBoxAdi.Text);
            cmd.Parameters.AddWithValue("Soyadi", textBoxSoyadi.Text);
            cmd.Parameters.AddWithValue("KullaniciAdi", textBoxKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("Sifre", textBoxSifre.Text);
            cmd.Parameters.AddWithValue("YetkiId", comboBoxYetki.SelectedIndex+1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("KAYIT EKLENDİ");
            KullaniciDoldur();
            KullaniciAlanTemizle();
            con.Close();
        }
        private void KullaniciAlanTemizle()
        {
            textBoxAdi.Text="";
            textBoxSoyadi.Text="";
            textBoxKullaniciAdi.Text="";
            textBoxSifre.Text="";
        }

        private void dataGridViewYonetici_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void Silme_Click(object sender, EventArgs e)
        {
             
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Kayıt Silinsin mi?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr==DialogResult.Yes)
            {
                OleDbConnection cem = new OleDbConnection(sabit.baglanti);
                cem.Open();
                OleDbCommand cmd = cem.CreateCommand();
                cmd.CommandText="delete from Kullanıcı where KullaniciId=@KullaniciId";
                cmd.Parameters.AddWithValue("KullaniciId", dataGridViewYonetici.SelectedRows[0].Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cem.Close();
                KullaniciDoldur();
                KullaniciAlanTemizle();
                MessageBox.Show("Kayıt silindi");


            }
        }

        private void buttonStokGüncelle_Click(object sender, EventArgs e)
        {
            
           
        }
       
        private void MenuDoldur()
        {

            string sart = "";

            if (textBoxYemekAdi.Text.Length>0)
            {
                sart = "where IcecekYemekAdi like '%" + textBoxYemekAdi.Text + "%'";
            }

            OleDbDataAdapter da = new OleDbDataAdapter("select * from Menu "+sart,sabit.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewStok.DataSource = dt;   
        }

        private void dataGridViewStok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridViewStok_SelectionChanged(object sender, EventArgs e)
        {
         
        }
        private void dataGridViewStok_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewStok.Focused && dataGridViewStok.SelectedRows.Count>0)
            {
                string MenuId = dataGridViewStok.SelectedRows[0].Cells[0].Value.ToString();
                OleDbDataAdapter da = new OleDbDataAdapter("select *from Menu where MenuId=@MenuId", sabit.baglanti);
                da.SelectCommand.Parameters.AddWithValue("MenuId", MenuId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                textBoxAdiY.Text=dt.Rows[0]["IcecekYemekAdi"].ToString();
                textBoxFiyatY.Text=dt.Rows[0]["Fiyat"].ToString();
                textBoxMiktarY.Text=dt.Rows[0]["Miktar"].ToString();
                comboBoxYiyecekTuru.SelectedValue=dt.Rows[0]["YiyecekTuruId"].ToString();


            }
        }
        private void dataGridViewStok_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewStok.ClearSelection();
        }

        private void tabPageStokKontrol_Click(object sender, EventArgs e)
        {    
        }
        private void FormYonetici_Load_1(object sender, EventArgs e)
        {
           
            

            MenuDoldur();
            MenuDoldur1();
            YiyecekTuruDoldur();

        }
       
        private void YiyecekTuruDoldur()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from YiyecekTuru", sabit.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxYiyecekTuru.DataSource = dt;
            comboBoxYiyecekTuru.DisplayMember = "YiyecekTuru";
            comboBoxYiyecekTuru.ValueMember = "YiyecekTuruId";

        }
        private void dataGridViewStok_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void textBoxYemekAdi_TextChanged(object sender, EventArgs e)
        {
            MenuDoldur();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            MenuGuncelle();
            
        }
        private void MenuGuncelle()
        {
            OleDbConnection con = new OleDbConnection(sabit.baglanti);
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "update Menu set IcecekYemekAdi = @IcecekYemekAdi, YiyecekTuruId=@YiyecekTuruId, Miktar=@Miktar,Fiyat=@Fiyat"+         " where MenuId=@MenuId ";
            cmd.Parameters.AddWithValue("IcecekYemekAdi", textBoxAdiY.Text);
            cmd.Parameters.AddWithValue("YiyecekTuruId", comboBoxYiyecekTuru.SelectedValue);
            cmd.Parameters.AddWithValue("Miktar", textBoxMiktarY.Text);
            cmd.Parameters.AddWithValue("Fiyat", textBoxFiyatY.Text);
            cmd.Parameters.AddWithValue("MenuId", dataGridViewStok.SelectedRows[0].Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Stok güncellendi ");
            MenuDoldur1();
            YiyecekTuruDoldur();
            MenuAlanTemizle();
            con.Close();
        }
        private void MenuDoldur1()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Menu", sabit.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewStok.DataSource = dt;
        }
        private void MenuAlanTemizle()
        {

            textBoxAdiY.Text="";
            textBoxFiyatY.Text="";
            textBoxMiktarY.Text="";
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(sabit.baglanti);
            con.Open(); 
            OleDbDataAdapter da = new OleDbDataAdapter("select Sum(Fiyat) as ToplamHasilat from Siparis", con); // sorguyu connection a yolladım da.
           // da.SelectCommand.Parameters.AddWithValue("Fiyat",textBoxHasilat.Text);
            DataTable dt = new DataTable(); 
            da.Fill(dt);

           textBoxHasilat.Text= dt.Rows[0]["ToplamHasilat"].ToString();

        }

        private void FormYonetici_Load_2(object sender, EventArgs e)
        {
            MenuDoldur1();
           YiyecekTuruDoldur();
            SiparisDoldur2();
            MenuDoldur2();
        }
    }


}

