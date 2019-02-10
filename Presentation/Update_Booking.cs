using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class Update_Booking : Form
    {
        public Update_Booking()
        {
            InitializeComponent();
            PopulateTextBoxes();
        }

        private void PopulateTextBoxes()
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Booking = (from c in context.Bookings where c.ID == Data.Database.UserID select c).FirstOrDefault();
                dtp_From.Value = Booking.Booking_From;
                dtp_To.Value = Booking.Booking_To;
                cbx_CheckedIn.Checked = Booking.Checked_In;
            }
        }

        private void btn_Add_Click(object sender, System.EventArgs e)
        {
            if (dtp_From.Value > dtp_To.Value)
            {
                MessageBox.Show("The From Date is Greater than the To Date!!!");
            }
            else
            {
                Data.Database.UpdateBooking(dtp_From.Value, dtp_To.Value, cbx_CheckedIn.Checked);
                MessageBox.Show("Booking Updated!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}