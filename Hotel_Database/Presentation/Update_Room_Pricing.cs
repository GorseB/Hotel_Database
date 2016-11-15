using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class Update_Room_Pricing : Form
    {
        public Update_Room_Pricing()
        {
            InitializeComponent();
            PopulateTextBoxes();
        }

        private void PopulateTextBoxes()
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Charges = (from c in context.Room_Prices select c).FirstOrDefault();
                nud_Single_Charge.Value = Charges.Single_Price;
                nud_Double_Charge.Value = Charges.Double_Price;
                nud_E_Single.Value = Charges.Extra_Single_Price;
                nud_E_Double.Value = Charges.Extra_Double_Price;
            }
        }

        private void btn_Add_Click(object sender, System.EventArgs e)
        {
            Data.Database.UpdateRoomPricing((int)nud_Single_Charge.Value, (int)nud_Double_Charge.Value, (int)nud_E_Single.Value, (int)nud_E_Double.Value);
            MessageBox.Show("Room Pricing Updated!");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}