using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace kyrsova_robota
{
    public partial class kvitanciya : Form
    {
        public kvitanciya(int bookingId, string route, string date, string vagon, string seat, string passenger)
        {
            InitializeComponent();
            lblTicketTitle.Text = "№ квитка:";
            lblTicketValue.Text = bookingId.ToString();
            lblRouteTitle.Text = "Маршрут:";
            lblRouteValue.Text = route;
            lblDateTitle.Text = "Дата:";
            lblDateValue.Text = date;
            lblVagonTitle.Text = "Вагон:";
            lblVagonValue.Text = vagon;
            lblSeatTitle.Text = "Місце:";
            lblSeatValue.Text = seat;
            lblPassengerTitle.Text = "Пасажир:";
            lblPassengerValue.Text = passenger;
        }

        private void kvitanciya_Load(object sender, EventArgs e)
        {
            RoundControl(buttonClose, 10);
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

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRoute_Click(object sender, EventArgs e)
        {

        }

        private void lblTicket_Click(object sender, EventArgs e)
        {

        }

        private void lblPassenger_Click(object sender, EventArgs e)
        {

        }
    }
}