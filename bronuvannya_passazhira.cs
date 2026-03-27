using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kyrsova_robota
{
    public partial class bronuvannya_passazhira : Form
    {
        private int vagonId;
        private int seatId;
        private string fromCity;
        private string toCity;

        public bronuvannya_passazhira(int vagon, int seat, string from, string to)
        {
            InitializeComponent();
            vagonId = vagon;
            seatId = seat;
            fromCity = from;
            toCity = to;
        }

        private void bronuvannya_passazhira_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName = textBoxLastName.Text.Trim();
            string firstName = textBoxFirstName.Text.Trim();
            string middleName = textBoxMiddleName.Text.Trim();
            string inn = textBoxINN.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(middleName) || string.IsNullOrEmpty(inn) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Введіть коректний емеіл");
                return;
            }

            string connectionString = "server=localhost;user=root;database=kursova_robota;password=natalya_hlebnikova_2006;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string checkUserQuery = @"SELECT id_korystuvacha FROM korystuvachi WHERE INN = @inn";
                    MySqlCommand checkCmd = new MySqlCommand(checkUserQuery, conn);
                    checkCmd.Parameters.AddWithValue("@inn", inn);
                    object result = checkCmd.ExecuteScalar();
                    int userId;
                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                    else
                    {
                        string insertUserQuery = @"INSERT INTO korystuvachi (surname, name, patronymic, INN, email, number)
                                                   VALUES (@lastName, @firstName, @middleName, @inn, @email, @phone);
                                                   SELECT LAST_INSERT_ID();";
                        MySqlCommand insertCmd = new MySqlCommand(insertUserQuery, conn);
                        insertCmd.Parameters.AddWithValue("@lastName", lastName);
                        insertCmd.Parameters.AddWithValue("@firstName", firstName);
                        insertCmd.Parameters.AddWithValue("@middleName", middleName);
                        insertCmd.Parameters.AddWithValue("@inn", inn);
                        insertCmd.Parameters.AddWithValue("@email", email);
                        insertCmd.Parameters.AddWithValue("@phone", phone);
                        userId = Convert.ToInt32(insertCmd.ExecuteScalar());
                    }
                    string insertBookingQuery = @"INSERT INTO bronyuvannya (id_korystuvacha, id_reysy, id_mistsya, data_bronyuvannya, status)
                                                  VALUES (@userId, 
                                                          (SELECT id_reysy FROM vagony WHERE id_vagony=@vagonId LIMIT 1),
                                                          @seatId, @date, 'Заброньовано'); SELECT LAST_INSERT_ID();";
                    MySqlCommand bookingCmd = new MySqlCommand(insertBookingQuery, conn);
                    bookingCmd.Parameters.AddWithValue("@userId", userId);
                    bookingCmd.Parameters.AddWithValue("@vagonId", vagonId);
                    bookingCmd.Parameters.AddWithValue("@seatId", seatId);
                    bookingCmd.Parameters.AddWithValue("@date", DateTime.Now.Date);

                    int bookingId = Convert.ToInt32(bookingCmd.ExecuteScalar());
                    string passenger = lastName + " " + firstName + " " + middleName;
                    string route = fromCity + " - " + toCity;
                    string date = DateTime.Now.ToString("dd.MM.yyyy");
                    oplata payForm = new oplata(
                        bookingId,
                        route,
                        date,
                        vagonId.ToString(),
                        seatId.ToString(),
                        passenger
                    );
                    payForm.ShowDialog();
                    MessageBox.Show("Місце успішно заброньовано!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при бронюванні: " + ex.Message);
            }
        }
    }
}