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

            int number_alcoholdrinkers = 0;//מגדיר משתנים בשביל תרשימי העוגה
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

            try
            {
                conn.Open();
                number_alcoholdrinkers = (Int32)cmd_alcoholdrinker.ExecuteScalar();//מעדכן את המשתנים לפי נתוני הדטה-בייס
                number_nonalcoholdrinkers = (Int32)cmd_nonalcoholdrinker.ExecuteScalar();
                number_regular = (Int32)cmd_regular.ExecuteScalar();
                number_vegeterian = (Int32)cmd_vegeterian.ExecuteScalar();
                number_vegan = (Int32)cmd_vegan.ExecuteScalar();
                number_bus = (Int32)cmd_bus.ExecuteScalar();
                number_nobus = (Int32)cmd_nobus.ExecuteScalar();
                number_groom = (Int32)cmd_groom.ExecuteScalar();
                number_bride = (Int32)cmd_bride.ExecuteScalar();
                number_none = (Int32)cmd_none.ExecuteScalar();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            chartSides.Series["Side"].Points.AddXY("חתן-" + Math.Round((((double)number_groom / (number_groom + number_bride + number_none)) * 100), 2) + "%", number_groom);
            chartSides.Series["Side"].Points.AddXY("כלה-" + Math.Round((((double)number_bride / (number_groom + number_bride + number_none)) * 100), 2) + "%", number_bride);
            chartSides.Series["Side"].Points.AddXY("ללא-" + Math.Round((((double)number_none / (number_groom + number_bride + number_none)) * 100), 2) + "%", number_none);
            chartDishType.Series["Dish"].Points.AddXY("רגיל-" + Math.Round((((double)number_regular / (number_regular + number_vegeterian + number_vegan)) * 100), 2) + "%", number_regular);
            chartDishType.Series["Dish"].Points.AddXY("צמחוני-" + Math.Round((((double)number_vegeterian / (number_regular + number_vegeterian + number_vegan)) * 100), 2) + "%", number_vegeterian);
            chartDishType.Series["Dish"].Points.AddXY("טבעוני-" + Math.Round((((double)number_vegan / (number_regular + number_vegeterian + number_vegan)) * 100), 2) + "%", number_vegan);
            chartAlcohol.Series["Alcohol"].Points.AddXY("כן-" + Math.Round((((double)number_alcoholdrinkers / (number_alcoholdrinkers + number_nonalcoholdrinkers)) * 100), 2) + "%", number_alcoholdrinkers);
            chartAlcohol.Series["Alcohol"].Points.AddXY("לא-" + Math.Round((((double)number_nonalcoholdrinkers / (number_alcoholdrinkers + number_nonalcoholdrinkers)) * 100), 2) + "%", number_nonalcoholdrinkers);
            chartBus.Series["Bus"].Points.AddXY("כן-" + Math.Round((((double)number_bus / (number_bus + number_nobus)) * 100), 2) + "%", number_bus);
            chartBus.Series["Bus"].Points.AddXY("לא-" + Math.Round((((double)number_nobus / (number_bus + number_nobus)) * 100), 2) + "%", number_nobus);

            //("לא - " + Math.Round((((double)number_nobus / (number_bus + number_nobus)) * 100), 2) + "%", number_nobus);

            /*int number_alcoholdrinkers = 0;
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
            number_alcoholdrinkers = (Int32)cmd_alcoholdrinker.ExecuteScalar();
            number_nonalcoholdrinkers = (Int32)cmd_nonalcoholdrinker.ExecuteScalar();
            number_regular = (Int32)cmd_regular.ExecuteScalar();
            number_vegeterian = (Int32)cmd_vegeterian.ExecuteScalar();
            number_vegan = (Int32)cmd_vegan.ExecuteScalar();
            number_bus = (Int32)cmd_bus.ExecuteScalar();
            number_nobus = (Int32)cmd_nobus.ExecuteScalar();
            number_groom = (Int32)cmd_groom.ExecuteScalar();
            number_bride = (Int32)cmd_bride.ExecuteScalar();
            number_none = (Int32)cmd_none.ExecuteScalar();

            chartSides2.Series["Side"].Points.AddXY("חתן", number_groom);
            chartSides2.Series["Side"].Points.AddXY("כלה", number_bride);
            chartSides2.Series["Side"].Points.AddXY("ללא", number_none);
            chartSides2.Series["Side"].Points[1].XValue = number_bride;
            chartSides2.Series["Side"].Points[2].XValue = number_none;
            chartSides.Series["Side"].Y = number_groom;
            chartSides.Series["Side"].Y*/
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
