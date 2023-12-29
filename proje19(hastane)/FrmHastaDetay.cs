using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje19_hastane_
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;

            //Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("select hastaad,hastasoyad from Tbl_Hastalar where hastatc=@p1 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where hastatc="+tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branş Çekme
            SqlCommand komut1 = new SqlCommand("select bransad from tbl_branslar", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read()) 
            {
                cmbbrans.Items.Add(dr1[0].ToString());
            }
            bgl.baglanti().Close();



        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //doktorları çekme
            cmbdoktor.Items.Clear();   
            SqlCommand komut2 = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktorbrans=@b1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@b1", cmbbrans.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbdoktor.Items.Add(dr2[0] + " " + dr2[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tbl_randevular where randevubrans='"+cmbbrans.Text+"'"+"and randevudoktor='"+cmbdoktor.Text+"'and randevudurum=0",bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update tbl_randevular set randevudurum=1,hastatc=@p1,hastasikayet=@p2 where randevuid=@p3",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",lbltc.Text);
            komut2.Parameters.AddWithValue("@p2",rchsikayet.Text);
            komut2.Parameters.AddWithValue("@p3", textBox1.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı.", "bilgi", MessageBoxButtons.OK);
        }

        private void lnkgüncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenle fr = new FrmHastaBilgiDuzenle();
            fr.tcno = lbltc.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
