using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class Update_Charges : Form
    {
        public Update_Charges()
        {
            InitializeComponent();
            PopulateTextBoxes();
        }

        private void PopulateTextBoxes()
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Charges = (from c in context.Charges where c.ID == Data.Database.Room_Charge select c).FirstOrDefault();
                nud_Bar.Value = Charges.Bar_Charge;
                nud_Internet.Value = Charges.Internet_Charge;
                nud_Phone.Value = Charges.Phone_Charge;
                nud_Room.Value = Charges.Room_Charge;
                nud_Additional.Value = Charges.Additional_Charges;
                txt_Additional_Info.Text = Charges.Additional_Charges_Info;
            }
        }

        private void btn_Add_Click(object sender, System.EventArgs e)
        {
            Data.Database.UpdateCharges((int)nud_Bar.Value, (int)nud_Internet.Value, (int)nud_Phone.Value, (int)nud_Room.Value, (int)nud_Additional.Value, txt_Additional_Info.Text);
            MessageBox.Show("Charges Updated!");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lbl_Bar_Click(object sender, EventArgs e)
        {
        }

        private void Update_Charges_Load(object sender, EventArgs e)
        {
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}