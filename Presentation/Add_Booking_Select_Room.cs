using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class add_Booking_Select_Room : Form
    {
        public add_Booking_Select_Room()
        {
            InitializeComponent();
            DGV();
        }

        private void DGV()
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Rooms = from c in context.Rooms
                            select new
                            {
                                c.ID,
                                c.Room_Name,
                                c.Single_Beds,
                                c.Double_Beds,
                                c.Extra_Info
                            };
                var Bookings = from c in context.Bookings
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
                foreach (var Booking in Bookings)
                {
                    if (Booking.Booking_From < Data.Database.DateEnd && Data.Database.DateStart < Booking.Booking_To) // This block of code reads : Foreach booking(name given to singular row) in Bookings(our table)
                                                                                                                      // If the user entered booking date and any of the already booked dates collide
                                                                                                                      // then our list of rooms = rooms where the room id does not equal the id of the colliding booking
                                                                                                                      // basically it looks through all the bookings and removes any rooms that are booked during the time period where we want to book.
                    {
                        Rooms = Rooms.Where(Room => Room.ID != Booking.Room_IDFK);
                    }
                }
                dgv_Choose_Room.DataSource = Rooms.ToList();
            }
        }

        private void dgv_ChooseGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Choose_Room.Rows[e.RowIndex];
                int RoomID = 0;
                string Room_Name = null;
                RoomID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                Room_Name = row.Cells["Room_Name"].Value.ToString();
                Data.Database.RoomID = RoomID;
                MessageBox.Show("You have selected " + Room_Name);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}