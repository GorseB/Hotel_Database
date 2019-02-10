using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class RemoveGuest : Form
    {
        public RemoveGuest()
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
                int GuestID = 0;
                string Name = null;
                GuestID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                Name = row.Cells["Name"].Value.ToString();
                bool CanDelete = Data.Database.DeleteGuest(GuestID);
                if (CanDelete)
                {
                    MessageBox.Show("You have removed " + Name);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}