using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class RemoveCharges : Form
    {
        public RemoveCharges()
        {
            InitializeComponent();
            DGV();
        }

        private void DGV()
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Charges = from c in context.Charges
                              select new
                              {
                                  c.ID,
                                  c.Bar_Charge,
                                  c.Internet_Charge,
                                  c.Phone_Charge,
                                  c.Room_Charge,
                                  c.Additional_Charges,
                                  c.Additional_Charges_Info,
                                  c.Total
                              };
                dgv_ChooseCharges.DataSource = Charges.ToList();
            }
        }

        private void dgv_ChooseGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ChooseCharges.Rows[e.RowIndex];
                int ChargesID = 0;
                ChargesID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                bool CanRemove = Data.Database.DeleteCharges(ChargesID);
                if (CanRemove)
                {
                    MessageBox.Show("You have removed Charges Number " + ChargesID);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}