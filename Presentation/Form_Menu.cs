using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            this.Text = "Hotel Management --- Logged in as : " + Data.Database.AccountName;
            CheckAuth();
            UpdateTables();
        }

        private void CheckAuth()
        {
            switch (Data.Database.AccountAccess)
            {
                case 0: //Master Account, Do anything
                    break;

                case 1: // Admin Account, Can't Do some Things.
                    btn_CreateAcc.Enabled = false;
                    btn_DeleteAcc.Enabled = false;
                    btn_EleveateAcc.Enabled = false;
                    break;

                case 2: // User Account, Does the Least.
                    btn_CreateAcc.Enabled = false;
                    btn_DeleteAcc.Enabled = false;
                    btn_EleveateAcc.Enabled = false;
                    btn_Delete_Booking.Enabled = false;
                    btn_Delete_Room.Enabled = false;
                    btn_Delete_Guest.Enabled = false;
                    btn_Delete_Charges.Enabled = false;
                    break;
            }
        }

        private void UpdateTables()
        {
            using (var context = new HotelDatabaseEntities())
            {
                var BookingsSimple = from c in context.Complete_Bookings
                                     select new
                                     {
                                         c.Name,
                                         c.Guest_ID,
                                         c.Room_Name,
                                         c.From,
                                         c.To,
                                         c.Checked_In__,
                                         c.Receipt_ID
                                     };
                DGV_Bookings_Simple.DataSource = BookingsSimple.ToList();
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
                DGV_Bookings.DataSource = Bookings.ToList();
                var Charges = from c in context.Charges
                              select new
                              {
                                  c.ID,
                                  c.Bar_Charge,
                                  c.Internet_Charge,
                                  c.Phone_Charge,
                                  c.Room_Charge,
                                  c.Additional_Charges,
                                  c.Additional_Charges_Info,
                                  c.Total
                              };
                DGV_Charges.DataSource = Charges.ToList();
                var Guest_Info = from c in context.Guest_Info
                                 select new
                                 {
                                     c.ID,
                                     c.Name,
                                     c.Mobile,
                                     c.Home_Phone
                                 };
                DGV_GuestInfo.DataSource = Guest_Info.ToList();
                var Room_Prices = from c in context.Room_Prices
                                  select new
                                  {
                                      c.Single_Price,
                                      c.Double_Price,
                                      c.Extra_Single_Price,
                                      c.Extra_Double_Price
                                  };
                DGV_Room_Pricing.DataSource = Room_Prices.ToList();
                var Rooms = from c in context.Rooms
                            select new
                            {
                                c.ID,
                                c.Room_Name,
                                c.Single_Beds,
                                c.Double_Beds,
                                c.Extra_Info
                            };
                DGV_Rooms.DataSource = Rooms.ToList();
            }
        }

        private void Hotel_Management_Load(object sender, System.EventArgs e)
        {
        }

        private void lbl_AddBooking_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.Add_Booking();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void btn_Add_Guest_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.add_Guest();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void btn_Add_Room_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.add_Room();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void btn_Delete_Room_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.RemoveRoom();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void btn_Delete_Guest_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.RemoveGuest();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void btn_Delete_Booking_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.RemoveBooking();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void btn_Delete_Charges_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.RemoveCharges();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void btn_Update_Guest_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.Uodate_Guest_Select_Guest();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void btn_Update_Room_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.Update_Room_Select_Room();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void btn_Update_Room_Pricing_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.Update_Room_Pricing();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void btn_Add_Charge_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.Update_Charges_Select_Charges();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void btn_Update_Booking_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.Update_Booking_Select_Booking();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void lbl_Create_Click(object sender, System.EventArgs e)
        {
        }

        private void btn_Return_Click(object sender, System.EventArgs e)
        {
            Presentation.Login LoginScreen = new Presentation.Login();
            this.Close();
            LoginScreen.Show();
            // close this form and re-open the login form
        }

        private void btn_ChangePassword_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.Update_Password();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void btn_DeleteAcc_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.Remove_Account();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void btn_EleveateAcc_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.Update_Account_Select_Account();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }

        private void btn_CreateAcc_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Presentation = new Presentation.Add_Account();
            DR = Presentation.ShowDialog();
            UpdateTables();
        }
    }
}