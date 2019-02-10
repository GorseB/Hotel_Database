using System;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class Add_Account : Form
    {
        public Add_Account()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Name.Text) || String.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("You must enter a Name and Password");
            }
            else
            {
                Data.Database.CreateAccount(txt_Name.Text, txt_Password.Text, Convert.ToInt32(nud_Access.Value));
                MessageBox.Show(txt_Name.Text + " Added!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}