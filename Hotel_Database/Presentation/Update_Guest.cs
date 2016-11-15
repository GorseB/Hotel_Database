using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class Update_Guest : Form
    {
        public Update_Guest()
        {
            InitializeComponent();
            PopulateTextBoxes();
        }

        private void PopulateTextBoxes()
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Guest = (from c in context.Guest_Info where c.ID == Data.Database.UserID select c).FirstOrDefault();
                txt_Name.Text = Guest.Name;
                txt_Address.Text = Guest.Address;
                txt_Mobile.Text = Guest.Mobile;
                txt_Home_Phone.Text = Guest.Home_Phone;
            }
        }

        private void btn_Add_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Name.Text) || String.IsNullOrWhiteSpace(txt_Address.Text) || String.IsNullOrWhiteSpace(txt_Mobile.Text))
            {
                MessageBox.Show("You must enter a Name, Address and Mobile number!");
            }
            else
            {
                Data.Database.UpdateGuest(txt_Name.Text, txt_Address.Text, txt_Mobile.Text, txt_Home_Phone.Text);
                MessageBox.Show(txt_Name.Text + " Updated!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}