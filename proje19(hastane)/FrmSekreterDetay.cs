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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }


        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tc;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            //ad soyad tc çekme
            lbltc.Text = tc;
            SqlCommand komut = new SqlCommand("select * from tbl_sekreter where sekretertc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                lbladsoyad.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();

            //branşları datagride çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_branslar",bgl.baglanti());
            da.Fill(dt);
            dtbrans.DataSource = dt;

            //doktorları datagride çekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select (doktorad + ' ' + doktorsoyad) as doktorlar,doktorbrans from tbl_doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dtdoktor.DataSource = dt1;

            //branşları cmbox aktarma
            SqlCommand komut1 = new SqlCommand("select bransad from tbl_branslar",bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                cmbbrans.Items.Add(dr1[0].ToString());
            }
            bgl.baglanti().Close();


        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_randevular (randevutarih,randevusaat,randevubrans,randevudoktor) values (@p1,@p2,@p3,@p4)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktarih.Text);
            komut.Parameters.AddWithValue("@p2", msksaat.Text);
            komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4", cmbdoktor.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu.","bilgi",MessageBoxButtons.OK);


        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut1 = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktorbrans=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",cmbbrans.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbdoktor.Items.Add(dr1[0] + " " + dr1[1]);
            }
            bgl.baglanti().Close();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            msktarih.Text = " ";
            msksaat.Text = " ";
            cmbbrans.Text = " ";
            cmbdoktor.Text = " ";
        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_duyurular (duyuru) values (@p1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",rchduyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu.", "bilgi", MessageBoxButtons.OK);
        }

        private void btndoktorpanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli dp = new FrmDoktorPaneli();
            dp.Show();
        }

        private void btnrandevuliste_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm = new FrmRandevuListesi();
            frm.Show();
        }

        private void btnbranspanel_Click(object sender, EventArgs e)
        {
            FrmBrans frm = new FrmBrans();
            frm.Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }
    }
}
