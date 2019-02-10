using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class Update_Room : Form
    {
        public Update_Room()
        {
            InitializeComponent();
            PopulateTextBoxes();
        }

        private void PopulateTextBoxes()
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Room = (from c in context.Rooms where c.ID == Data.Database.RoomID select c).FirstOrDefault();
                txt_Name.Text = Room.Room_Name;
                nud_single.Value = Room.Single_Beds;
                nud_double.Value = Room.Double_Beds;
                txt_Extra_Info.Text = Room.Extra_Info;
            }
        }

        private void btn_Add_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Name.Text))
            {
                MessageBox.Show("You must enter a Room Name!");
            }
            else
            {
                Data.Database.UpdateRoom(txt_Name.Text, Convert.ToInt16(nud_single.Value), Convert.ToInt16(nud_double.Value), txt_Extra_Info.Text);
                MessageBox.Show(txt_Name.Text + " Updated!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}