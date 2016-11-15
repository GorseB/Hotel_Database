using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class RemoveRoom : Form
    {
        public RemoveRoom()
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
                dgv_ChooseRoom.DataSource = Rooms.ToList();
            }
        }

        private void dgv_ChooseGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ChooseRoom.Rows[e.RowIndex];
                int RooomID = 0;
                string Name = null;
                RooomID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                Name = row.Cells["Room_Name"].Value.ToString();
                bool CanDelete = Data.Database.DeleteRoom(RooomID);
                if (CanDelete)
                {
                    MessageBox.Show("You have removed the " + Name);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}