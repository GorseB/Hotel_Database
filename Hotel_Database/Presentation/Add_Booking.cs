using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class Add_Booking : Form
    {
        public Add_Booking()
        {
            InitializeComponent();
            Calender.MinDate = DateTime.Today; // cant book time that has already passed!
        }

        private void Calender_MouseLeave(object sender, EventArgs e)
        {
            if (Calender.SelectionRange.Start != Calender.SelectionRange.End)
            {
                DialogResult Result;
                Result = MessageBox.Show(this, "You have selected from " + Calender.SelectionStart.ToShortDateString() + " to " + Calender.SelectionEnd.ToShortDateString(), "Confirm Date!", MessageBoxButtons.YesNo);
                if (Result.ToString() == "Yes")
                {
                    Data.Database.DateStart = Calender.SelectionRange.Start;
                    Data.Database.DateEnd = Calender.SelectionRange.End;
                    Calender.Enabled = false;
                    btn_Select_Guest.Enabled = true;
                }
            }
        }

        private void btn_Select_Guest_Click(object sender, EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Select_Guest = new Presentation.add_Booking_Select_Guest();
            DR = Select_Guest.ShowDialog();
            if (DR == DialogResult.OK)
            {
                btn_Select_Guest.Enabled = false;
                btn_Select_Room.Enabled = true;
            }
        }

        private void btn_Select_Room_Click(object sender, EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Select_Room = new Presentation.add_Booking_Select_Room();
            DR = Select_Room.ShowDialog();
            if (DR == DialogResult.OK)
            {
                btn_Select_Room.Enabled = false;
                nud_Singles.Enabled = true;
                nud_Doubles.Enabled = true;
                btn_Create.Enabled = true;
            }
        }

        private void ValueChanged(Object sender, EventArgs e)
        {
            if (nud_Singles.Value + nud_Doubles.Value > 2)
            {
                MessageBox.Show("You can only add 2 extra beds to your room!");
                NumericUpDown nud = (NumericUpDown)sender;
                nud.Value--;
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            double total = 0;
            using (var context = new HotelDatabaseEntities())
            {
                var Room_Prices = from c in context.Room_Prices
                                  select new
                                  {
                                      c.Single_Price,
                                      c.Double_Price,
                                      c.Extra_Single_Price,
                                      c.Extra_Double_Price
                                  };
                total += Convert.ToDouble((nud_Singles.Value * Room_Prices.Single().Extra_Single_Price) + (nud_Doubles.Value * Room_Prices.Single().Extra_Double_Price)); // work out our total
                var Rooms = from c in context.Rooms
                            select new
                            {
                                c.ID,
                                c.Room_Name,
                                c.Single_Beds,
                                c.Double_Beds,
                                c.Extra_Info
                            };
                foreach (var Room in Rooms)
                {
                    if (Room.ID == Data.Database.RoomID)
                    {
                        total += (Room.Single_Beds * Room_Prices.Single().Single_Price) + (Room.Double_Beds * Room_Prices.Single().Double_Price); // this code fetches the room and room pricing from our database then works out how much the room will cost given the extra
                        // bedding and the amount of time booked.
                    }
                }
            }
            total += total * ((Data.Database.DateEnd - Data.Database.DateStart).TotalDays);
            Data.Database.Room_Charge = Convert.ToInt16(total);
            DialogResult Result;
            Result = MessageBox.Show(this, "Your total will be : $" + total, "Confirm Total?", MessageBoxButtons.YesNo); // confirming the total, outputting it to the user
            if (Result.ToString() == "Yes")
            {
                Data.Database.CreateBooking();
                MessageBox.Show("Booking Complete!"); // book the room
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}