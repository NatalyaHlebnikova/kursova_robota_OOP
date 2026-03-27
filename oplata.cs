using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;

namespace kyrsova_robota
{
    public partial class oplata : Form
    {
        private int bookingId;
        private string route, date, vagon, seat, passenger;

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

        private void oplata_Load(object sender, EventArgs e)
        {
            RoundControl(buttonPay, 10);
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (textBoxCard.Text == "" || textBoxDate.Text == "" || textBoxCVV.Text == "")
            {
                MessageBox.Show("Заповніть всі поля!");
                return;
            }

            string connectionString = "server=localhost;user=root;database=kursova_robota;password=natalya_hlebnikova_2006;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE bronyuvannya SET status='Оплачено' WHERE id_bronyuvannya=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", bookingId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Оплата успішна!");
                kvitanciya ticket = new kvitanciya(
                    bookingId,
                    route,
                    date,
                    vagon,
                    seat,
                    passenger
                );
                ticket.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка оплати: " + ex.Message);
            }
        }

        public oplata(int bookingId, string route, string date, string vagon, string seat, string passenger)
        {
            InitializeComponent();
            this.bookingId = bookingId;
            this.route = route;
            this.date = date;
            this.vagon = vagon;
            this.seat = seat;
            this.passenger = passenger;
        }
    }
}