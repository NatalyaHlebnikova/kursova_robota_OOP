using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kyrsova_robota
{
    public partial class vubir_reisu : Form
    {
        private string fromCity;
        private string toCity;
        private DateTime tripDate;

        public vubir_reisu(string from, string to, DateTime date)
        {
            InitializeComponent();
            fromCity = from;
            toCity = to;
            tripDate = date;
            LoadTrips();
        }

        private void vubir_reisu_Load(object sender, EventArgs e)
        {
            RoundControl(button1, 10);
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

        private void LoadTrips()
        {
            string connectionString = "server=localhost;user=root;database=kursova_robota;password=natalya_hlebnikova_2006;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT r.id_reysy, r.nomer_reysu, r.data_vidpr, r.chas_vidpr, r.chas_pryb, r.vartist_kvytka
                                   FROM reysy r
                                   JOIN marshruty m ON r.id_marshruty = m.id_marshruty
                                   WHERE m.punkt_vidpr = @from AND m.punkt_pryb = @to AND r.data_vidpr = @date";
                    
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@from", fromCity);
                        cmd.Parameters.AddWithValue("@to", toCity);
                        cmd.Parameters.AddWithValue("@date", tripDate.ToString("yyyy-MM-dd"));
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvTrips.DataSource = table;
                        if (table.Rows.Count == 0)
                        {
                            MessageBox.Show("Рейси за цими параметрами не знайдено.");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні рейсів: " + ex.Message);
            }
        }

        private void dgvTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvTrips.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, оберіть рейс.");
                return;
            }
            int tripId = Convert.ToInt32(dgvTrips.SelectedRows[0].Cells["id_reysy"].Value);
            vubir_vagona vagForm = new vubir_vagona(tripId, fromCity, toCity);
            vagForm.ShowDialog();
        }
    }
}