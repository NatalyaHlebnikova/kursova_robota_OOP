using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;

namespace kyrsova_robota
{
    public partial class vubir_marshruty : Form
    {
        public vubir_marshruty()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RoundControl(button1, 10);
            RoundControl(buttonMyBookings, 10);
            LoadCities();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            string fromCity = comboBoxFrom.Text;
            string toCity = comboBoxTo.Text;
            comboBoxFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTo.DropDownStyle = ComboBoxStyle.DropDownList;

            DateTime tripDate = dateTimePicker1.Value;
            if (fromCity == "" || toCity == "")
            {
                MessageBox.Show("Будь ласка, введіть місце відправки та місце прибуття.");
                return;
            }

            string connectionString = "server=localhost; user=root; database=kursova_robota; password=natalya_hlebnikova_2006;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT COUNT(*) 
                     FROM reysy r
                     JOIN marshruty m ON r.id_marshruty = m.id_marshruty
                     WHERE m.punkt_vidpr = @from 
                     AND m.punkt_pryb = @to 
                     AND r.data_vidpr = @date";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@from", fromCity);
                    cmd.Parameters.AddWithValue("@to", toCity);
                    cmd.Parameters.Add("@date", MySqlDbType.Date).Value = tripDate;

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show("Рейсів за цими параметрами не знайдено.");
                        return;
                    }
                    vubir_reisu tripsForm = new vubir_reisu(fromCity, toCity, tripDate);
                    tripsForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка підключення: " + ex.Message);
                }
            }
        }

        private void LoadCities()
        {
            string connectionString = "server=localhost;user=root;database=kursova_robota;password=natalya_hlebnikova_2006;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT DISTINCT punkt_vidpr FROM marshruty";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBoxFrom.Items.Add(reader.GetString(0));
                        comboBoxTo.Items.Add(reader.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження міст: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonMyBookings_Click(object sender, EventArgs e)
        {
            moi_bronyuvannya form = new moi_bronyuvannya();
            form.ShowDialog();
        }
    }
}