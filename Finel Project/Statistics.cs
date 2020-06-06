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
    public partial class Statistics : Form
    {
        public Statistics()
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

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finel_ProjectDataSet.GUEST_LIST' table. You can move, or remove it, as needed.
            this.gUEST_LISTTableAdapter.Fill(this.finel_ProjectDataSet.GUEST_LIST);

        }

        private void chartSides_Click(object sender, EventArgs e)
        {

        }

        private void gUEST_LISTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gUEST_LISTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finel_ProjectDataSet);

        }

        private void gUEST_LISTBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.gUEST_LISTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finel_ProjectDataSet);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
