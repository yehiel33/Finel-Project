using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finel_Project
{
    public partial class GuestList : Form
    {
        public GuestList()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //חזרה לחלון הראשי
            this.Hide();
            EventSeatingManager eventseatingmanager = new EventSeatingManager();
            eventseatingmanager.ShowDialog();
        }

        private void gUEST_LISTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gUEST_LISTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finel_ProjectDataSet);

        }

        private void GuestList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finel_ProjectDataSet.GUEST_LIST' table. You can move, or remove it, as needed.
            this.gUEST_LISTTableAdapter.Fill(this.finel_ProjectDataSet.GUEST_LIST);
            //DataView dv = new DataView();
            //dv.Table = finel_ProjectDataSet.Tables[1];
            //dv.RowFilter = "Event Owner =" + EventSeatingManager.globalusername;
            //gUEST_LISTDataGridView.DataSource = dv;

        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            AddGuest addguest = new AddGuest();
            addguest.ShowDialog();
        }

        private void gUEST_LISTDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowAllGuests_Click(object sender, EventArgs e)
        {
            //DataView dv = new DataView();
            //dv.Table = finel_ProjectDataSet.Tables[1];
            //dv.RowFilter = "Event Owner = 'OOkun'"; EventSeatingManager.globalusername;
            //gUEST_LISTDataGridView.DataSource = dv;
            DataView dv;
            dv = new DataView(finel_ProjectDataSet.Tables[1], "Event Owner = 'OOkun' ", "Event Owner Desc", DataViewRowState.CurrentRows);
            gUEST_LISTDataGridView.DataSource = dv;
        }
    }
}
