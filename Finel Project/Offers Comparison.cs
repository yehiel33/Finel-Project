using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Finel_Project
{
    public partial class OffersComparison : Form
    {
        public static int supplier_1_regular = 0;
        public static int supplier_1_vegeterian = 0;
        public static int supplier_1_vegan = 0;
        public static int supplier_1_alcohol = 0;
        public static int supplier_1_bus = 0;

        public static int supplier_2_regular = 0;
        public static int supplier_2_vegeterian = 0;
        public static int supplier_2_vegan = 0;
        public static int supplier_2_alcohol = 0;
        public static int supplier_2_bus = 0;

        public static int supplier_3_regular = 0;
        public static int supplier_3_vegeterian = 0;
        public static int supplier_3_vegan = 0;
        public static int supplier_3_alcohol = 0;
        public static int supplier_3_bus = 0;

        public OffersComparison()
        {
            InitializeComponent();

        }

        private void Offers_Comparison_Load(object sender, EventArgs e)
        {
            string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
            OleDbConnection conn = new OleDbConnection(strDb);
            OleDbCommand cmd1 = new OleDbCommand("Select [Price For Regular] From SUPPLIERS ", conn);
            OleDbCommand cmd2 = new OleDbCommand("Select [Price For Vegeterian] From SUPPLIERS ", conn);
            OleDbCommand cmd3 = new OleDbCommand("Select [Price For Vegan] From SUPPLIERS ", conn);
            OleDbCommand cmd4 = new OleDbCommand("Select [Price For Alcohol] From SUPPLIERS ", conn);
            OleDbCommand cmd5 = new OleDbCommand("Select [Price For Bus] From SUPPLIERS ", conn);

            try
            {
                lblComparison.Visible = true;
                lblComparison.Text = "";
                conn.Open();
                OleDbDataReader reader1 = cmd1.ExecuteReader(); // הגדרת אובייקט קריאה
                OleDbDataReader reader2 = cmd2.ExecuteReader(); // הגדרת אובייקט קריאה
                OleDbDataReader reader3 = cmd3.ExecuteReader(); // הגדרת אובייקט קריאה
                OleDbDataReader reader4 = cmd4.ExecuteReader(); // הגדרת אובייקט קריאה
                OleDbDataReader reader5 = cmd5.ExecuteReader(); // הגדרת אובייקט קריאה
                int i1 = 0;
                while (reader1.Read())
                {
                    if (i1 == 0)
                        supplier_1_regular = int.Parse(reader1["Price For Regular"].ToString());

                    else if (i1 == 1)
                        supplier_2_regular = int.Parse(reader1["Price For Regular"].ToString());

                    else
                        supplier_3_regular = int.Parse(reader1["Price For Regular"].ToString());

                    i1++;
                }
                int i2 = 0;
                while (reader2.Read())
                {
                    if (i2 == 0)
                        supplier_1_vegeterian = int.Parse(reader2["Price For Vegeterian"].ToString());

                    else if (i2 == 1)
                        supplier_2_vegeterian = int.Parse(reader2["Price For Vegeterian"].ToString());

                    else
                        supplier_3_vegeterian = int.Parse(reader2["Price For Vegeterian"].ToString());

                    i2++;
                }
                int i3 = 0;
                while (reader3.Read())
                {
                    if (i3 == 0)
                        supplier_1_vegan = int.Parse(reader3["Price For Vegan"].ToString());

                    else if (i3 == 1)
                        supplier_2_vegan = int.Parse(reader3["Price For Vegan"].ToString());

                    else
                        supplier_3_vegan = int.Parse(reader3["Price For Vegan"].ToString());

                    i3++;
                }
                int i4 = 0;
                while (reader4.Read())
                {
                    if (i4 == 0)
                        supplier_1_alcohol = int.Parse(reader4["Price For Alcohol"].ToString());

                    else if (i4 == 1)
                        supplier_2_alcohol = int.Parse(reader4["Price For Alcohol"].ToString());

                    else
                        supplier_3_alcohol = int.Parse(reader4["Price For Alcohol"].ToString());

                    i4++;
                }
                int i5 = 0;
                while (reader5.Read())
                {
                    if (i5 == 0)
                        supplier_1_bus = int.Parse(reader5["Price For Bus"].ToString());

                    else if (i5 == 1)
                        supplier_2_bus = int.Parse(reader5["Price For Bus"].ToString());

                    else
                        supplier_3_bus = int.Parse(reader5["Price For Bus"].ToString());

                    i5++;

                }
                reader1.Close();
                reader2.Close();
                reader3.Close();
                reader4.Close();
                reader5.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //תוספת אפשרית למבנה טריי וקאצ' מגדירה מה יקרה בכל מקרה
            {
                conn.Close();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //חזרה לחלון הראשי
            this.Hide();
            EventSeatingManager eventseatingmanager = new EventSeatingManager();
            eventseatingmanager.ShowDialog();
            this.Close();
        }

        private void priceForRegularToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            lblprice1.Text = "";
            lblprice2.Text = "";
            lblprice3.Text = "";
            lblComparison.Visible = true;
            lblComparison.Text = "Prices of regular dish:";
            lblprice1.Text = supplier_1_regular.ToString();
            lblprice2.Text = supplier_2_regular.ToString();
            lblprice3.Text = supplier_3_regular.ToString();
        }

        private void priceForVegeterianToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            lblprice1.Text = "";
            lblprice2.Text = "";
            lblprice3.Text = "";
            lblComparison.Visible = true;
            lblComparison.Text = "Prices of vegeterian dish:";
            lblprice1.Text = supplier_1_vegeterian.ToString();
            lblprice2.Text = supplier_2_vegeterian.ToString();
            lblprice3.Text = supplier_3_vegeterian.ToString();

        }

        private void priceForVeganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
            OleDbConnection conn = new OleDbConnection(strDb);
            
            lblprice1.Text = "";
            lblprice2.Text = "";
            lblprice3.Text = "";
            lblComparison.Visible = true;
            lblComparison.Text = "Prices of vegan dish:";
            lblprice1.Text = supplier_1_vegan.ToString();
            lblprice2.Text = supplier_2_vegan.ToString();
            lblprice3.Text = supplier_3_vegan.ToString();

        }

        private void priceForAlcoholToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            lblprice1.Text = "";
            lblprice2.Text = "";
            lblprice3.Text = "";    
            lblComparison.Visible = true;
            lblComparison.Text = "Prices of Alcohol:";
            lblprice1.Text = supplier_1_alcohol.ToString();
            lblprice2.Text = supplier_2_alcohol.ToString();
            lblprice3.Text = supplier_3_alcohol.ToString();

        }

        private void priceForBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblprice1.Text = "";
            lblprice2.Text = "";
            lblprice3.Text = "";
            lblComparison.Visible = true;
            lblComparison.Text = "Prices of bus:";
            lblprice1.Text = supplier_1_bus.ToString();
            lblprice2.Text = supplier_2_bus.ToString();
            lblprice3.Text = supplier_3_bus.ToString();
        }

        private void btnFindMeTheTotalCheapestQuote_Click(object sender, EventArgs e)
        {
            int numberofalcoholdrinker = 0;  // הגדרת אובייקט קריאה
            int numberofregular = 0;
            int numberofvegeterian = 0;
            int numberofvegan = 0;
            int numberofbus = 0;

            // הגדרת מחרוזת שמכילה את פקודת החיבור
            string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
            // יצירת חיבור חדש לבסיס הנתונים
            OleDbConnection conn = new OleDbConnection(strDb);
            OleDbCommand cmd_alcoholdrinker = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [Alcohol Drinker]=true ;", conn);
            OleDbCommand cmd_regular = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [Dish Type]='רגיל' ;", conn);
            OleDbCommand cmd_vegeterian = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [Dish Type]='צמחוני' ;", conn);
            OleDbCommand cmd_vegan = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [Dish Type]='טבעוני' ;", conn);
            OleDbCommand cmd_bus = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "' AND [bus]=true ;", conn);

            try
            {
                conn.Open();
                numberofalcoholdrinker = (Int32)cmd_alcoholdrinker.ExecuteScalar();  // הגדרת אובייקט קריאה
                numberofregular = (Int32)cmd_regular.ExecuteScalar();
                numberofvegeterian = (Int32)cmd_vegeterian.ExecuteScalar();
                numberofvegan = (Int32)cmd_vegan.ExecuteScalar();
                numberofbus = (Int32)cmd_bus.ExecuteScalar();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            int totalpricesupplier_1 = (OffersComparison.supplier_1_regular * numberofregular) + (OffersComparison.supplier_1_vegeterian * numberofvegeterian) + (OffersComparison.supplier_1_vegan * numberofvegan) + (OffersComparison.supplier_1_alcohol * numberofalcoholdrinker) + (OffersComparison.supplier_1_bus * numberofbus);
            int totalpricesupplier_2 = (OffersComparison.supplier_2_regular * numberofregular) + (OffersComparison.supplier_2_vegeterian * numberofvegeterian) + (OffersComparison.supplier_2_vegan * numberofvegan) + (OffersComparison.supplier_2_alcohol * numberofalcoholdrinker) + (OffersComparison.supplier_2_bus * numberofbus);
            int totalpricesupplier_3 = (OffersComparison.supplier_3_regular * numberofregular) + (OffersComparison.supplier_3_vegeterian * numberofvegeterian) + (OffersComparison.supplier_3_vegan * numberofvegan) + (OffersComparison.supplier_3_alcohol * numberofalcoholdrinker) + (OffersComparison.supplier_3_bus * numberofbus);

            //lblFindMeTheTotalCheapestQuote.Text ="total price supplier 1:" + totalpricesupplier_1.ToString() + "\ntotal price supplier 2:" + totalpricesupplier_2.ToString() + "\ntotal price supplier 3:" + totalpricesupplier_3.ToString();

            if(totalpricesupplier_1< totalpricesupplier_2&& totalpricesupplier_1 < totalpricesupplier_3)
            {
                lblBestPrice.Visible = true;
                lblNotBestPrice.Visible = true;
                lblBestPrice.Text = ("Total cost Supplier 1: " + totalpricesupplier_1);
                lblNotBestPrice.Text = ("Total cost Supplier 2: " + totalpricesupplier_2 + "\nTotal cost Supplier 3: " + totalpricesupplier_3);
            }
            else if (totalpricesupplier_2 < totalpricesupplier_1 && totalpricesupplier_2 < totalpricesupplier_3)
            {
                lblBestPrice.Visible = true;
                lblNotBestPrice.Visible = true;
                lblBestPrice.Text = ("Total cost Supplier 2: " + totalpricesupplier_2);
                lblNotBestPrice.Text = ("Total cost Supplier 1: " + totalpricesupplier_1 + "\nTotal cost Supplier 3: " + totalpricesupplier_3);
            }
            else if(totalpricesupplier_3 < totalpricesupplier_1 && totalpricesupplier_3 < totalpricesupplier_2)
            {
                lblBestPrice.Visible = true;
                lblNotBestPrice.Visible = true;
                lblBestPrice.Text = ("Total cost Supplier 3: " + totalpricesupplier_3);
                lblNotBestPrice.Text = ("Total cost Supplier 1: " + totalpricesupplier_1 + "\nTotal cost Supplier 2: " + totalpricesupplier_2);
            }
            else
            {
                MessageBox.Show("Sorry, we couldn't find a recommendation for you.");
            }

    }

        private void lblComparison_Click(object sender, EventArgs e)
        {

        }

        private void tsmOptionToComprise_Click(object sender, EventArgs e)
        {

        }

        private void lblprice1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
