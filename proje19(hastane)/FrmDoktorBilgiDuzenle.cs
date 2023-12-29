using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje19_hastane_
{
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tc;

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = tc;

            //cmbox doldurma
            SqlCommand komut = new SqlCommand("select bransad from tbl_branslar",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbbrans.Items.Add(dr[0].ToString());
            }

            //boşlukları doldurma
            SqlCommand komut2 = new SqlCommand("select * from tbl_doktorlar where doktortc=@a1",bgl.baglanti());
            komut2.Parameters.AddWithValue("@a1",msktc.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while( dr2.Read())
            {
                txtad.Text = dr2[1].ToString();
                txtsoyad.Text = dr2[2].ToString();
                cmbbrans.Text = dr2[3].ToString();
                txtsifre.Text = dr2[5].ToString();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktorlar set doktorad=@p1,doktorsoyad=@p2,doktorbrans=@p3,doktorsifre=@p4 where doktortc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.Parameters.AddWithValue("@p5", msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellendi", "bilgi", MessageBoxButtons.OK);
        }
    }
}
