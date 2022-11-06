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

namespace _102.ORN.Film_Arsivi
{
    public partial class AdminSayfasi : Form
    {
        public AdminSayfasi()
        {
            InitializeComponent();
        }

        Connection cnt = new Connection();

        public void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Filmid, FilmAd, FilmTur, FilmCikis, FilmYonetmen, FilmIMDB, FilmResim, FilmTarih, FilmveDizi From Tbl_FilmveDizi", cnt.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txttur.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtcikis.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtyonetmen.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtIMDB.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtresim.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txttarih.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtnedir.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_FilmveDizi (FilmAd, FilmTur, FilmCikis, FilmYonetmen, FilmIMDB, FilmResim, FilmTarih, FilmveDizi) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", cnt.Baglanti());
            komut1.Parameters.AddWithValue("@p1", txtad.Text);
            komut1.Parameters.AddWithValue("@p2", txttur.Text);
            komut1.Parameters.AddWithValue("@p3", txtcikis.Text);
            komut1.Parameters.AddWithValue("@p4", txtyonetmen.Text);
            komut1.Parameters.AddWithValue("@p5", txtIMDB.Text);
            komut1.Parameters.AddWithValue("@p6", txtresim.Text);
            komut1.Parameters.AddWithValue("@p7", txttarih.Text);
            komut1.Parameters.AddWithValue("@p8", txtnedir.Text);
            komut1.ExecuteNonQuery();
            cnt.Baglanti().Close();

            listele();

            MessageBox.Show(txtnedir.Text + " Başarıyla Sisteme Kaydedildi!", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Delete From Tbl_FilmveDizi Where Filmid=@p1", cnt.Baglanti());
            komut2.Parameters.AddWithValue("@p1", txtid.Text);
            komut2.ExecuteNonQuery();
            cnt.Baglanti().Close();

            listele();

            MessageBox.Show(txtnedir.Text + " Başarıyla Sistemden Silinmiştir!", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Update Tbl_FilmveDizi set FilmAd=@p1, FilmTur=@p2, FilmCikis=@p3, FilmYonetmen=@p4, FilmIMDB=@p5, FilmResim=@p6, FilmTarih=@p7, FilmveDizi=@p8 Where Filmid=@p9", cnt.Baglanti());
            komut3.Parameters.AddWithValue("@p1", txtad.Text);
            komut3.Parameters.AddWithValue("@p2", txttur.Text);
            komut3.Parameters.AddWithValue("@p3", txtcikis.Text);
            komut3.Parameters.AddWithValue("@p4", txtyonetmen.Text);
            komut3.Parameters.AddWithValue("@p5", txtIMDB.Text);
            komut3.Parameters.AddWithValue("@p6", txtresim.Text);
            komut3.Parameters.AddWithValue("@p7", txttarih.Text);
            komut3.Parameters.AddWithValue("@p8", txtnedir.Text);
            komut3.Parameters.AddWithValue("@p9", txtid.Text);
            komut3.ExecuteNonQuery();
            cnt.Baglanti().Close();

            listele();

            MessageBox.Show(txtnedir.Text + " Başarıyla Sistemde Güncellenmiştir!", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtresim.Text = openFileDialog1.FileName;
        }
    }
}
