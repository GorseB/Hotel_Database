using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class Update_Account_Select_Account : Form
    {
        public Update_Account_Select_Account()
        {
            InitializeComponent();
            DGV();
        }

        private void DGV()
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Logins = from c in context.Logins
                             select new
                             {
                                 c.ID,
                                 c.user,
                                 c.access
                             };
                dgv_ChooseGuest.DataSource = Logins.ToList();
            }
        }

        private int GetAccountAccess() // input string created to get input from the user of a whole number, to save time.
        {
            bool IsGood = true;
            string Input;
            int Output = 0;
            do
            {
                Input = Microsoft.VisualBasic.Interaction.InputBox("Please Enter A New Access Level", "New Access", "0", 0, 0);
                try
                {
                    Output = Convert.ToInt32(Input);
                    IsGood = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("You Must Enter a Whole Number, Try Again!");
                    IsGood = true;
                }
            } while (IsGood);
            return Output;
        }

        private void dgv_ChooseGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int Access = GetAccountAccess();
                DataGridViewRow row = dgv_ChooseGuest.Rows[e.RowIndex];
                int ID = 0;
                ID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                Data.Database.UpdateAccess(ID, Access);
                MessageBox.Show("Account Updated!");
                DGV();
            }
        }
    }
}