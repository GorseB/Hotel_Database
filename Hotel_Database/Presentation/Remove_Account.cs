using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class Remove_Account : Form
    {
        public Remove_Account()
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

        private void dgv_ChooseGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ChooseGuest.Rows[e.RowIndex];
                int ID = 0;
                ID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                Data.Database.DeleteAccount(ID);
                MessageBox.Show("Account Deleted");
                DGV();
            }
        }
    }
}