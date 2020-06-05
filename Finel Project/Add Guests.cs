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
    public partial class AddGuest : Form
    {
        public AddGuest()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddGuest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finel_ProjectDataSet.GUEST_LIST' table. You can move, or remove it, as needed.
            this.gUEST_LISTTableAdapter.Fill(this.finel_ProjectDataSet.GUEST_LIST);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            finel_ProjectDataSet.GUEST_LIST.AddGUEST_LISTRow(EventSeatingManager.globalusername, txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtSide.Text, combDishType.Text, cbAlcohol.Checked, cbBus.Checked);
            gUEST_LISTTableAdapter.Update(finel_ProjectDataSet);
            gUESTLISTBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(finel_ProjectDataSet);

            MessageBox.Show("Guest Added.");

            this.Close();
        }
    }
}
