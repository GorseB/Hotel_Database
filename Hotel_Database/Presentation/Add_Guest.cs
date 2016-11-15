using System;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class add_Guest : Form
    {
        public add_Guest()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Name.Text) || String.IsNullOrWhiteSpace(txt_Address.Text) || String.IsNullOrWhiteSpace(txt_Mobile.Text))
            {
                MessageBox.Show("You must enter a Name, Address and Mobile number!");
            }
            else
            {
                Data.Database.CreatGuest(txt_Name.Text, txt_Address.Text, txt_Mobile.Text, txt_Home_Phone.Text);
                MessageBox.Show(txt_Name.Text + " Added!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}