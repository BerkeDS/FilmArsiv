using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Film_Arsivi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RGQV57Q;Initial Catalog=Film_arsivi;Integrated Security=True");

        void filmler()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * FROM film_tablo", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                FilmListe_dataGridView.DataSource = dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void Kaydet_btn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut =
                    new SqlCommand("insert into film_tablo (film_ad,kategori,link) values (@ad,@kate,@lin)", baglanti);
                komut.Parameters.AddWithValue("@ad", FilmAd_textBox.Text);
                komut.Parameters.AddWithValue("@kate", Kategori_textBox.Text);
                komut.Parameters.AddWithValue("@lin", Link_textBox.Text);
                int a = komut.ExecuteNonQuery();
                if (a > 0 )
                {
                    MessageBox.Show("Film Listenize Eklendi", "Bilgi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Film Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                filmler();

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void FilmListe_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = FilmListe_dataGridView.SelectedCells[0].RowIndex;
            string link = FilmListe_dataGridView.Rows[secilen].Cells[3].Value.ToString();

            Ekran_webBrowser.Navigate(link);
        }

        private void Hakkımızda_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kodlayan Berke");
        }

        private void Cikis_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
