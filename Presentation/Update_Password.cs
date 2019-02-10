using System;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class Update_Password : Form
    {
        public Update_Password()
        {
            InitializeComponent();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_NewPassword.Text))
            {
                MessageBox.Show("You must enter a new Password!");
            }
            else
            {
                Data.Database.ChangePasword(txt_NewPassword.Text);
                MessageBox.Show("Password Updated!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}