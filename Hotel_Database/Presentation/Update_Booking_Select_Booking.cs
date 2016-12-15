using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class Update_Booking_Select_Booking : Form
    {
        public Update_Booking_Select_Booking()
        {
            InitializeComponent();
            DGV();
        }

        private void DGV()
        {
            using (var context = new HotelDatabaseEntities())
            {
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
                dgv_SelectAccount.DataSource = Bookings.ToList();
            }
        }

        private void dgv_ChooseGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_SelectAccount.Rows[e.RowIndex];
                int ID = 0;
                ID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                Data.Database.UserID = ID;
                DialogResult DR = new DialogResult();
                var Presentation = new Presentation.Update_Booking();
                DR = Presentation.ShowDialog();
                DGV();
            }
        }

        private void dgv_SelectAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}