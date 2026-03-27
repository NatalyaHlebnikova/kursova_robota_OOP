using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kyrsova_robota
{
    public partial class vubir_vagona : Form
    {
        private int tripId;
        private string fromCity;
        private string toCity;
        public vubir_vagona(int selectedTripId, string from, string to)
        {
            InitializeComponent();
            tripId = selectedTripId;
            fromCity = from;
            toCity = to;
            LoadVagony();
        }

        private void vubir_vagona_Load(object sender, EventArgs e)
        {
            RoundControl(buttonSelectVagon, 10);
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

        private void LoadVagony()
        {
            string connectionString = "server=localhost;user=root;database=kursova_robota;password=natalya_hlebnikova_2006;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT id_vagony, typ_vahona, kilkist_mists
                        FROM vagony
                        WHERE id_reysy = @tripId
                        ORDER BY id_vagony";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tripId", tripId);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvVagony.DataSource = table;
                        if (dgvVagony.Columns.Contains("id_vagony"))
                            dgvVagony.Columns["id_vagony"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні вагонів: " + ex.Message);
            }
        }

        private void buttonSelectVagon_Click(object sender, EventArgs e)
        {
            if (dgvVagony.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, оберіть вагон.");
                return;
            }
            int vagonId = Convert.ToInt32(dgvVagony.SelectedRows[0].Cells["id_vagony"].Value);
            vubir_mistsya seatsForm = new vubir_mistsya(vagonId, fromCity, toCity);
            seatsForm.ShowDialog();
        }
    }
}