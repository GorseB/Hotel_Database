using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class Update_Room_Select_Room : Form
    {
        public Update_Room_Select_Room()
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
                dgv_Choose_Room.DataSource = Rooms.ToList();
            }
        }

        private void dgv_ChooseGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Choose_Room.Rows[e.RowIndex];
                int RoomID = 0;
                RoomID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                Data.Database.RoomID = RoomID;
                DialogResult DR = new DialogResult();
                var Presentation = new Presentation.Update_Room();
                DR = Presentation.ShowDialog();
                DGV();
            }
        }
    }
}