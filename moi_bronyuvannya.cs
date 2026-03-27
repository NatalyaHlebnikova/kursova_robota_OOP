using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kyrsova_robota
{
    public partial class moi_bronyuvannya : Form
    {
        public moi_bronyuvannya()
        {
            InitializeComponent();
        }

        private void moi_bronyuvannya_Load(object sender, EventArgs e)
        {
            RoundControl(buttonCancel, 10);
            RoundControl(buttonPay, 10);
            LoadBookings();
        }

        private void RoundControl(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            control.Region = new Region(path);
        }

        private void LoadBookings()
        {
            string connectionString = "server=localhost;user=root;database=kursova_robota;password=natalya_hlebnikova_2006;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT b.id_bronyuvannya, k.surname, k.name,
                                     m.punkt_vidpr, m.punkt_pryb, r.data_vidpr, v.id_vagony,
                                     ms.nomer_mistsya, b.status
                                     FROM bronyuvannya b
                                     JOIN korystuvachi k ON b.id_korystuvacha = k.id_korystuvacha
                                     JOIN reysy r ON b.id_reysy = r.id_reysy
                                     JOIN marshruty m ON r.id_marshruty = m.id_marshruty
                                     JOIN mistsya ms ON b.id_mistsya = ms.id_mistsya
                                     JOIN vagony v ON ms.id_vagony = v.id_vagony
                                     ORDER BY b.id_bronyuvannya DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvBookings.DataSource = table;
                    if (dgvBookings.Columns.Contains("id_bronyuvannya"))
                        dgvBookings.Columns["id_bronyuvannya"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть бронювання");
                return;
            }
            int id = Convert.ToInt32(
                dgvBookings.SelectedRows[0].Cells["id_bronyuvannya"].Value
            );

            string connectionString = "server=localhost;user=root;database=kursova_robota;password=natalya_hlebnikova_2006;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE bronyuvannya SET status='Скасовано' WHERE id_bronyuvannya=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Бронювання скасовано");
            LoadBookings();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть бронювання");
                return;
            }
            DataGridViewRow row = dgvBookings.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["id_bronyuvannya"].Value);
            string passenger = row.Cells["surname"].Value + " " + row.Cells["name"].Value;
            string route = row.Cells["punkt_vidpr"].Value + " - " + row.Cells["punkt_pryb"].Value;
            string date = Convert.ToDateTime(row.Cells["data_vidpr"].Value).ToString("dd.MM.yyyy");
            string vagon = row.Cells["id_vagony"].Value.ToString();
            string seat = row.Cells["nomer_mistsya"].Value.ToString();
            oplata payForm = new oplata(id, route, date, vagon, seat, passenger);
            payForm.ShowDialog();
            LoadBookings();
        }
    }
}