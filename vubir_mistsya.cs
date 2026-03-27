using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kyrsova_robota
{
    public partial class vubir_mistsya : Form
    {
        private int vagonId;
        private string fromCity;
        private string toCity;

        public vubir_mistsya(int id, string from, string to)
        {
            InitializeComponent();
            vagonId = id;
            fromCity = from;
            toCity = to;
        }

        private void vubir_mistsya_Load(object sender, EventArgs e)
        {
            RoundControl(button1, 10);
            LoadSeats();
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

        private void LoadSeats()
        {
            string connectionString = "server=localhost;user=root;database=kursova_robota;password=natalya_hlebnikova_2006;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT m.id_mistsya, m.nomer_mistsya, v.typ_vahona,
                               IF(b.id_bronyuvannya IS NULL, 'Вільне', b.status) AS status
                        FROM mistsya m
                        JOIN vagony v ON m.id_vagony = v.id_vagony
                        LEFT JOIN bronyuvannya b ON m.id_mistsya = b.id_mistsya
                        WHERE v.id_vagony = @vagonId
                        ORDER BY m.nomer_mistsya";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@vagonId", vagonId);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;

                        if (dataGridView1.Columns.Contains("id_mistsya"))
                            dataGridView1.Columns["id_mistsya"].Visible = false;

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["status"].Value != null)
                            {
                                string status = row.Cells["status"].Value.ToString();
                                if (status == "Вільне")
                                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                                else if (status == "Заброньовано")
                                    row.DefaultCellStyle.BackColor = Color.Khaki;
                                else if (status == "Оплачено")
                                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                                else if (status == "Скасовано")
                                    row.DefaultCellStyle.BackColor = Color.LightGray;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні місць: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            string status = row.Cells["status"].Value.ToString();

            if (status != "Вільне")
            {
                MessageBox.Show("Це місце недоступне для бронювання.");
                return;
            }
            int seatId = Convert.ToInt32(row.Cells["id_mistsya"].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, оберіть місце.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string status = row.Cells["status"].Value.ToString();
            if (status != "Вільне")
            {
                MessageBox.Show("Це місце не можна забронювати.");
                return;
            }

            int seatId = Convert.ToInt32(row.Cells["id_mistsya"].Value);
            bronuvannya_passazhira form = new bronuvannya_passazhira(vagonId, seatId, fromCity, toCity);
            form.ShowDialog();
            LoadSeats();
        }
    }
}