using System;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class add_Room : Form
    {
        public add_Room()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Name.Text))
            {
                MessageBox.Show("You must enter a Room Name!");
            }
            else
            {
                Data.Database.AddRoom(txt_Name.Text, Convert.ToInt16(nud_single.Value), Convert.ToInt16(nud_double.Value), txt_Extra_Info.Text);
                MessageBox.Show(txt_Name.Text + " Added!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}