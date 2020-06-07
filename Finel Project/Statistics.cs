using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //Access

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
            int number_alcoholdrinkers = 0;
            int number_nonalcoholdrinkers = 0;
            int number_regular = 0;
            int number_vegeterian = 0;
            int number_vegan = 0;
            int number_bus = 0;
            int number_nobus = 0;
            int number_groom = 0;
            int number_bride = 0;
            int number_none = 0;

            // הגדרת מחרוזת שמכילה את פקודת החיבור
            string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
            // יצירת חיבור חדש לבסיס הנתונים
            OleDbConnection conn = new OleDbConnection(strDb);
            OleDbCommand cmd_alcoholdrinker = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [Alcohol Drinker]=true ;", conn);
            OleDbCommand cmd_nonalcoholdrinker = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [Alcohol Drinker]=false ;", conn);
            OleDbCommand cmd_regular = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [Dish Type]='רגיל' ;", conn);
            OleDbCommand cmd_vegeterian = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [Dish Type]='צמחוני' ;", conn);
            OleDbCommand cmd_vegan = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [Dish Type]='טבעוני' ;", conn);
            OleDbCommand cmd_bus = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [bus]=true ;", conn);
            OleDbCommand cmd_nobus = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [bus]=false ;", conn);
            OleDbCommand cmd_groom = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [Side]='חתן' ;", conn);
            OleDbCommand cmd_bride = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [Side]='כלה' ;", conn);
            OleDbCommand cmd_none = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [Side]='ללא' ;", conn);

            conn.Open();
            number_alcoholdrinkers = (Int32)cmd_alcoholdrinker.ExecuteNonQuery();
            number_nonalcoholdrinkers = (Int32)cmd_nonalcoholdrinker.ExecuteNonQuery();
            number_regular = (Int32)cmd_regular.ExecuteNonQuery();
            number_vegeterian = (Int32)cmd_vegeterian.ExecuteNonQuery();
            number_vegan = (Int32)cmd_vegan.ExecuteNonQuery();
            number_bus = (Int32)cmd_bus.ExecuteNonQuery();
            number_nobus = (Int32)cmd_nobus.ExecuteNonQuery();
            number_groom = (Int32)cmd_groom.ExecuteNonQuery();
            number_bride = (Int32)cmd_bride.ExecuteNonQuery();
            number_none = (Int32)cmd_none.ExecuteNonQuery();

            chartSides.Series["Side"].XValueMember = "Side";
            chartSides.Series["Side"].YValueMembers = number_groom;
        }
    }
}
