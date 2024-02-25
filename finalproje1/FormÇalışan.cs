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
    public partial class FormCalisan : Form
    {
        public FormCalisan()
        {
            InitializeComponent();
        }

        private void buttonSiparişC_Click(object sender, EventArgs e)
        {
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void FormCalisan_Load(object sender, EventArgs e)
        {
           
            
            MasaDoldur();
            MenuDoldur1();
            YiyecekTuruDoldur();
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridViewCalısan.Focused && dataGridViewCalısan.SelectedRows.Count>0)
            {
                string MenuId = dataGridViewCalısan.SelectedRows[0].Cells[0].Value.ToString();
                OleDbDataAdapter de = new OleDbDataAdapter("select*from Menu where MenuId=@MenuId", sabit.baglanti);
                de.SelectCommand.Parameters.AddWithValue("MenuId", MenuId);
                DataTable dt = new DataTable();
                de.Fill(dt);
                textBoxAdi.Text = dt.Rows[0]["IcecekYemekAdi"].ToString();
                textBoxFiyat.Text = dt.Rows[0]["Fiyat"].ToString();
                textBoxMiktar.Text = dt.Rows[0]["Miktar"].ToString();
                comboBoxYiyecekTuru.SelectedValue = dt.Rows[0]["YiyecekTuruId"].ToString();
            }
        }

        private void dataGridViewCalısan_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewCalısan.ClearSelection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MenuDoldur();
        }
        private void MenuDoldur()
        {
            string sart = "";

            if (textBox1.Text.Length>0)
            {
                sart = "where IcecekYemekAdi like '%" + textBox1.Text + "%'";
            }

            OleDbDataAdapter da = new OleDbDataAdapter("select * from Menu "+sart, sabit.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewCalısan.DataSource = dt;
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
        private void MenuDoldur1()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Menu", sabit.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewCalısan.DataSource = dt;

        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(sabit.baglanti);
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select Sum(Fiyat) as ToplamHasilat from Siparis Where MasaId=@MasaId", con);
            da.SelectCommand.Parameters.AddWithValue("MasaId",comboBoxMasa1.SelectedValue.ToString());
            DataTable dt = new DataTable();
            da.Fill(dt);
           //comboBoxMasa1.SelectedValue = dt.Rows[0]["MasaId"].ToString();
            textBoxHesap.Text= dt.Rows[0]["ToplamHasilat"].ToString();
            
        }
        private void MasaDoldur()
        {

            OleDbDataAdapter da = new OleDbDataAdapter("select * from Masa", sabit.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxMasa1.DataSource = dt;
            comboBoxMasa1.DisplayMember = "Masa";
            comboBoxMasa1.ValueMember = "MasaId";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuGuncelle();
            MessageBox.Show("Stok güncellendi");
            MenuDoldur1();
            YiyecekTuruDoldur();
            MenuAlanTemizle();
        }
        private void MenuGuncelle()
        {
            OleDbConnection con = new OleDbConnection(sabit.baglanti);
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "update Menu set IcecekYemekAdi = @IcecekYemekAdi, YiyecekTuruId= @YiyecekTuruId, Miktar=@Miktar,Fiyat=@Fiyat"+         " where MenuId=@MenuId ";
            cmd.Parameters.AddWithValue("IcecekYemekAdi", textBoxAdi.Text);
            cmd.Parameters.AddWithValue("Fiyat", textBoxFiyat.Text);
            cmd.Parameters.AddWithValue("Miktar", textBoxMiktar.Text);
            cmd.Parameters.AddWithValue("YiyecekTuruId", comboBoxYiyecekTuru.SelectedValue);
            cmd.Parameters.AddWithValue("MenuId", dataGridViewCalısan.SelectedRows[0].Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void MenuAlanTemizle()
        {
            textBoxAdi.Text="";
            textBoxFiyat.Text="";
            textBoxMiktar.Text="";

        }


        private void dataGridViewSiparis1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewSiparis1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }
    }
}
