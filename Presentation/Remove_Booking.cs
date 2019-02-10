using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class RemoveBooking : Form
    {
        public RemoveBooking()
        {
            InitializeComponent();
            DGV();
        }

        private void DGV()
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Booking = from c in context.Bookings
                              select new
                              {
                                  c.ID,
                                  c.Room_IDFK,
                                  c.Guest_IDFK,
                                  c.Charges_IDFK,
                                  c.Booking_From,
                                  c.Booking_To,
                                  c.Checked_In
                              };
                dgv_ChooseBooking.DataSource = Booking.ToList();
            }
        }

        private void dgv_ChooseGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ChooseBooking.Rows[e.RowIndex];
                int BookingID = 0;
                BookingID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                bool CanRemove = Data.Database.DeleteBooking(BookingID); // might not be able to remove due to the booking referencing something
                if (CanRemove)
                {
                    MessageBox.Show("You have removed Booking Number " + BookingID);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}