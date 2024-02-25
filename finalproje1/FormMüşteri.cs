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
    public partial class FormMusteri : Form
    {
        public FormMusteri()
        {
            InitializeComponent();
        }

        private void Menudoldur1()
        {

            OleDbDataAdapter da = new OleDbDataAdapter("select * from Menu", sabit.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMenu1.DataSource = dt;
        }
        private void SiparisDoldur1()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Siparis", sabit.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSiparis1.DataSource = dt;

        }

      
        private void MenuAraDoldur()
        {
          
            string sart = " ";

            if (textBoxAra.Text.Length>0)
            {
                sart = "where IcecekYemekAdi like '%" + textBoxAra.Text + "%'";

                OleDbDataAdapter dem = new OleDbDataAdapter("select * from Menu "+sart, sabit.baglanti);
                DataTable dt = new DataTable();
                dem.Fill(dt);
                dataGridViewStok.DataSource= dt;
            }
        }


        private void buttonSiparisEkle_Click(object sender, EventArgs e)
        {
           
        }
       

        private void radioButtonMasa4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void buttonSiparisSil_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPageMasa_Click(object sender, EventArgs e)
        {
            //OleDbConnection cem = new OleDbConnection(sabit.baglanti);
            //OleDbCommand cmd = cem.CreateCommand();
            //cmd.CommandText="select Aktif from Masa ";
            //cmd.Parameters.AddWithValue("Aktif", checkBox1.Checked.ToString());
            //cmd.Parameters.AddWithValue("Aktif", checkBox2.Checked.ToString());
            //cmd.Parameters.AddWithValue("Aktif", checkBox3.Checked.ToString());
            //cmd.Parameters.AddWithValue("Aktif", checkBox4.Checked.ToString());
            //cmd.ExecuteNonQuery();

           


        }

        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            MenuAraDoldur();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {
            Menudoldur1();
            MasaDoldur();
            SiparisDoldur1();
        }
        private void MasaDoldur()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Masa", sabit.baglanti);
            DataTable dt = new DataTable(); da.Fill(dt);
            comboBoxMasa1.DataSource = dt;
            comboBoxMasa1.DisplayMember = "Masa";
            comboBoxMasa1.ValueMember = "MasaId";
        }


        private void dataGridViewMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMenu1.Focused && dataGridViewMenu1.SelectedRows.Count>0)
            {
                string MenuId =dataGridViewMenu1.SelectedRows[0].Cells[0].Value.ToString();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Menu where MenuId=@MenuId", sabit.baglanti);
                da.SelectCommand.Parameters.AddWithValue("MenuId", MenuId);
                DataTable dt = new DataTable(); da.Fill(dt);
                textBoxYemekAdi1.Text = dt.Rows[0]["IcecekYemekAdi"].ToString(); 
                textBoxFiyat1.Text = dt.Rows[0]["Fiyat"].ToString();             
               

            }

        }

        private void dataGridViewMenu1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewMenu1.ClearSelection();
        }

        private void buttonSiparisEkle_Click_1(object sender, EventArgs e)
        {
            YeniKullaniciEkle1();
        }
            private void YeniKullaniciEkle1()
            {
                OleDbConnection con = new OleDbConnection(sabit.baglanti);
                con.Open();
                OleDbCommand cmd = con.CreateCommand();

                cmd.CommandText = "insert into Siparis (IcecekYemekAdi,Fiyat, MasaId) values (@IcecekYemekAdi,@Fiyat,@MasaId)"; 
                cmd.Parameters.AddWithValue("IcecekYemekadi", textBoxYemekAdi1.Text);
                cmd.Parameters.AddWithValue("Fiyat", textBoxFiyat1.Text);
                cmd.Parameters.AddWithValue("yetkiId", comboBoxMasa1.SelectedValue); 
                cmd.ExecuteNonQuery();
            MessageBox.Show("Sipariş verildi ");
            SiparisDoldur1();
            MenuAlanTemizle();
                con.Close();
            }
        private void MenuAlanTemizle()
        {
            textBoxFiyat1.Text="";
            textBoxYemekAdi1.Text="";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Sipariş iptal edilsin mi?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                
                OleDbConnection con = new OleDbConnection(sabit.baglanti);
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "delete from Siparis where SiparisId=@SiparisId";
                cmd.Parameters.AddWithValue("SiparisId", dataGridViewSiparis1.SelectedRows[0].Cells[0].Value.ToString());
                cmd.ExecuteNonQuery(); 
                con.Close();
                SiparisDoldur1();
                MenuAlanTemizle();
                MessageBox.Show("Sipariş iptal edildi ");
            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("Sipariş iptal edilemedi");
            }



        }

    }
}

