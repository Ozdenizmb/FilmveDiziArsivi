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
    public partial class KullaniciPaneli : Form
    {
        public KullaniciPaneli()
        {
            InitializeComponent();
        }

        Connection cnt = new Connection();

        string resimyolu;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KullaniciPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Filmid, FilmAd, FilmIMDB, FilmTarih From Tbl_FilmveDizi", cnt.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            SqlCommand komut1 = new SqlCommand("Select * From Tbl_FilmveDizi Where Filmid=@p1", cnt.Baglanti());
            komut1.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                lblad.Text = dr[1].ToString();
                lbltur.Text = dr[2].ToString();
                lblcikis.Text = dr[3].ToString();
                lblyonetmen.Text = dr[4].ToString();
                lblIMDB.Text = dr[5].ToString();
                lbltarih.Text = dr[7].ToString();
                lblFilmveDizi.Text = dr[8].ToString();
                lblizlendimi.Text = dr[9].ToString();
                resimyolu = dr[6].ToString();
                if (lblizlendimi.Text == "False")
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton1.Checked = true;
                }
                pictureBox2.ImageLocation = resimyolu;
            }
            cnt.Baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_FilmveDizi set FilmIzlendimi=@p1 Where Filmid=@p2", cnt.Baglanti());
            komut2.Parameters.AddWithValue("@p1", lblizlendimi.Text);
            komut2.Parameters.AddWithValue("@p2", lblid.Text);
            komut2.ExecuteNonQuery();

            cnt.Baglanti().Close();

            MessageBox.Show(lblFilmveDizi.Text + " 'nin izlenme durumu değiştirildi!", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblizlendimi.Text = "False";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblizlendimi.Text = "True";
        }
    }
}
