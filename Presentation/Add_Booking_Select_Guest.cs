using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class add_Booking_Select_Guest : Form
    {
        public add_Booking_Select_Guest()
        {
            InitializeComponent();
            DGV();
        }

        private void DGV()
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Guest_Info = from c in context.Guest_Info
                                 select new
                                 {
                                     c.ID,
                                     c.Name,
                                     c.Mobile,
                                     c.Home_Phone
                                 };
                dgv_ChooseGuest.DataSource = Guest_Info.ToList();
            }
        }

        private void dgv_ChooseGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ChooseGuest.Rows[e.RowIndex];
                int ID = 0;
                string Name = null;
                ID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                Name = row.Cells["Name"].Value.ToString();
                Data.Database.UserID = ID;
                MessageBox.Show("You have selected " + Name);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}