using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace finalproje1
{
    public partial class FormKullaniciGiris : Form
    {
        public FormKullaniciGiris()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void textBoxSoyadı_TextChanged(object sender, EventArgs e)
        {
        }
        private void kullanıcıadı_Click(object sender, EventArgs e)
        {
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(sabit.baglanti);
            con.Open();
            OleDbDataAdapter dem = new OleDbDataAdapter("select * from Kullanıcı where KullaniciAdi=@kullaniciadi and Sifre=@Sifre",con);
            dem.SelectCommand.Parameters.AddWithValue("KullaniciAdi", textBoxKullaniciadi.Text);
            dem.SelectCommand.Parameters.AddWithValue("Sifre", textBoxSifre.Text);
            DataTable cem = new DataTable();
            dem.Fill(cem);

            if (cem.Rows.Count>0)
            {
                sabit.KullaniciId=cem.Rows[0]["KullaniciId"].ToString();
                sabit.KullaniciAdi=cem.Rows[0]["Adi"].ToString()+cem.Rows[0]["Soyadi"].ToString();
                int a = Convert.ToInt32(cem.Rows[0]["YetkiId"]);
                
                if (a==1)
                {
                   FormYonetici yonetici=new FormYonetici();
                    yonetici.Show();
                    this.Close();
                }
                else if (a==2)
                {
                    FormCalisan calisan = new FormCalisan();
                    calisan.Show();
                    this.Close();
                }
                else
                {
                    FormMusteri musteri = new FormMusteri();
                    musteri.Show();
                    this.Close();
                }

                
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı..");
            }
            con.Close();
            
        }
    }
}
