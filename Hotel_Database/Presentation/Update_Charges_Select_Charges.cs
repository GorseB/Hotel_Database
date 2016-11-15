using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class Update_Charges_Select_Charges : Form
    {
        public Update_Charges_Select_Charges()
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
                dgv_ChooseGuest.DataSource = Charges.ToList();
            }
        }

        private void dgv_ChooseGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ChooseGuest.Rows[e.RowIndex];
                int ID = 0;
                ID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                Data.Database.Room_Charge = ID;
                DialogResult DR = new DialogResult();
                var Presentation = new Presentation.Update_Charges();
                DR = Presentation.ShowDialog();
                DGV();
            }
        }
    }
}