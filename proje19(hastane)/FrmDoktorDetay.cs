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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje19_hastane_
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tc,adsoyad;

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            //doktor bilgileri
            lbltc.Text = tc;
            SqlCommand komut = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktortc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }

            //data tablosu
            adsoyad = lbladsoyad.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where randevudoktor =@a1",bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@a1", adsoyad);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frm1 = new FrmDoktorBilgiDuzenle();
            frm1.tc = lbltc.Text;
            frm1.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchsikayet.Text = "Durum: " + dataGridView1.Rows[secilen].Cells[5].Value.ToString() + Environment.NewLine;
            rchsikayet.Text += "Tarih: " + dataGridView1.Rows[secilen].Cells[1].Value.ToString() + Environment.NewLine;
            rchsikayet.Text += "Saat: " + dataGridView1.Rows[secilen].Cells[2].Value.ToString() + Environment.NewLine;
            rchsikayet.Text += "Hasta TC: " + dataGridView1.Rows[secilen].Cells[6].Value.ToString() + Environment.NewLine;
            rchsikayet.Text += "Hasta Şikayet: " + dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
