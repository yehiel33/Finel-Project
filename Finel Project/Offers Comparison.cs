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
            string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
            OleDbConnection conn = new OleDbConnection(strDb);
            OleDbCommand cmd = new OleDbCommand("Select [Price For Regular] From SUPPLIERS ", conn);
            lblprice1.Text = "";
            lblprice2.Text = "";
            lblprice3.Text = "";
            try
            {
                lblComparison.Visible = true;
                lblComparison.Text = "Prices of regular dish:";
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader(); // הגדרת אובייקט קריאה
                int i=0;
                while (reader.Read())
                {

                    if (i == 0)
                    {
                        supplier_1_regular = int.Parse(reader["Price For Regular"].ToString());
                        lblprice1.Text = reader["Price For Regular"].ToString();
                    }
                    else if (i == 1)
                    {
                        supplier_2_regular = int.Parse(reader["Price For Regular"].ToString());
                        lblprice2.Text = reader["Price For Regular"].ToString();
                    }
                    else
                    {
                        supplier_3_regular = int.Parse(reader["Price For Regular"].ToString());
                        lblprice3.Text = reader["Price For Regular"].ToString();
                    }
                    i++;
                }
                reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //תוספת אפשרית למבנה טריי וקאצ' מגדירה מה יקרה בכל מקרה
            {
                conn.Close();
            }
        }

        private void priceForVegeterianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
            OleDbConnection conn = new OleDbConnection(strDb);
            OleDbCommand cmd = new OleDbCommand("Select [Price For Vegeterian] From SUPPLIERS ", conn);
            lblprice1.Text = "";
            lblprice2.Text = "";
            lblprice3.Text = "";
            try
            {
                lblComparison.Visible = true;
                lblComparison.Text = "Prices of vegeterian dish:";
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader(); // הגדרת אובייקט קריאה
                int i = 0;
                while (reader.Read())
                {
                    if (i == 0)
                    {
                        supplier_1_vegeterian = int.Parse(reader["Price For Vegeterian"].ToString());
                        lblprice1.Text = reader["Price For Vegeterian"].ToString();
                    }
                    else if (i == 1)
                    {
                        supplier_2_vegeterian = int.Parse(reader["Price For Vegeterian"].ToString());
                        lblprice2.Text = reader["Price For Vegeterian"].ToString();
                    }
                    else
                    {
                        supplier_3_vegeterian = int.Parse(reader["Price For Vegeterian"].ToString());
                        lblprice3.Text = reader["Price For Vegeterian"].ToString();
                    }

                    i++;
                }
                reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //תוספת אפשרית למבנה טריי וקאצ' מגדירה מה יקרה בכל מקרה
            {
                conn.Close();
            }
        }

        private void priceForVeganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
            OleDbConnection conn = new OleDbConnection(strDb);
            OleDbCommand cmd = new OleDbCommand("Select [Price For Vegan] From SUPPLIERS ", conn);
            lblprice1.Text = "";
            lblprice2.Text = "";
            lblprice3.Text = "";
            try
            {

                lblComparison.Visible = true;
                lblComparison.Text = "Prices of Vegan dish:";
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader(); // הגדרת אובייקט קריאה
                int i = 0;
                while (reader.Read())
                {
                    if (i == 0)
                    {
                        supplier_1_vegan = int.Parse(reader["Price For Vegan"].ToString());
                        lblprice1.Text = reader["Price For Vegan"].ToString();
                    }
                    else if (i == 1)
                    {
                        supplier_2_vegan = int.Parse(reader["Price For Vegan"].ToString());
                        lblprice2.Text = reader["Price For Vegan"].ToString();
                    }
                    else
                    {
                        supplier_3_vegan = int.Parse(reader["Price For Vegan"].ToString());
                        lblprice3.Text = reader["Price For Vegan"].ToString();
                    }
                 
                    i++;
                }
                reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //תוספת אפשרית למבנה טריי וקאצ' מגדירה מה יקרה בכל מקרה
            {
                conn.Close();
            }
        }

        private void priceForAlcoholToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
            OleDbConnection conn = new OleDbConnection(strDb);
            OleDbCommand cmd = new OleDbCommand("Select [Price For Alcohol] From SUPPLIERS ", conn);
            lblprice1.Text = "";
            lblprice2.Text = "";
            lblprice3.Text = "";
            try
            {
                lblComparison.Visible = true;
                lblComparison.Text = "Prices of Alcohol:";
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader(); // הגדרת אובייקט קריאה
                int i = 0;
                while (reader.Read())
                {
                    if (i == 0)
                    {
                        supplier_1_alcohol = int.Parse(reader["Price For Alcohol"].ToString());
                        lblprice1.Text = reader["Price For Alcohol"].ToString();
                    }
                    else if (i == 1)
                    {
                        supplier_2_alcohol = int.Parse(reader["Price For Alcohol"].ToString());
                        lblprice2.Text = reader["Price For Alcohol"].ToString();
                    }
                    else
                    {
                        supplier_3_alcohol = int.Parse(reader["Price For Alcohol"].ToString());
                        lblprice3.Text = reader["Price For Alcohol"].ToString();
                    }
              
                    i++;
                }
                reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //תוספת אפשרית למבנה טריי וקאצ' מגדירה מה יקרה בכל מקרה
            {
                conn.Close();
            }
        }

        private void priceForBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
            OleDbConnection conn = new OleDbConnection(strDb);
            OleDbCommand cmd = new OleDbCommand("Select [Price For Bus] From SUPPLIERS ", conn);
            lblprice1.Text = "";
            lblprice2.Text = "";
            lblprice3.Text = "";
            try
            {
                lblComparison.Visible = true;
                lblComparison.Text = "Prices of Bus:";
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader(); // הגדרת אובייקט קריאה
                int i = 0;
                while (reader.Read())
                {
                    if (i == 0)
                    {
                        supplier_1_bus = int.Parse(reader["Price For Bus"].ToString());
                        lblprice1.Text = reader["Price For Bus"].ToString();
                    }
                    else if (i == 1)
                    {
                        supplier_2_bus = int.Parse(reader["Price For Bus"].ToString());
                        lblprice2.Text = reader["Price For Bus"].ToString();
                    }
                    else
                    {
                        supplier_3_bus = int.Parse(reader["Price For Bus"].ToString());
                        lblprice3.Text = reader["Price For Bus"].ToString();
                    }
                    i++;
                }
                reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //תוספת אפשרית למבנה טריי וקאצ' מגדירה מה יקרה בכל מקרה
            {
                conn.Close();
            }
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
                MessageBox.Show(err.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblFindMeTheTotalCheapestQuote.Visible = true;
            int totalpricesupplier_1 = (OffersComparison.supplier_1_regular * numberofregular) + (OffersComparison.supplier_1_vegeterian * numberofvegeterian) + (OffersComparison.supplier_1_vegan * numberofvegan) + (OffersComparison.supplier_1_alcohol * numberofalcoholdrinker) + (OffersComparison.supplier_1_bus * numberofbus);
            int totalpricesupplier_2 = (OffersComparison.supplier_2_regular * numberofregular) + (OffersComparison.supplier_2_vegeterian * numberofvegeterian) + (OffersComparison.supplier_2_vegan * numberofvegan) + (OffersComparison.supplier_2_alcohol * numberofalcoholdrinker) + (OffersComparison.supplier_2_bus * numberofbus);
            int totalpricesupplier_3 = (OffersComparison.supplier_3_regular * numberofregular) + (OffersComparison.supplier_3_vegeterian * numberofvegeterian) + (OffersComparison.supplier_3_vegan * numberofvegan) + (OffersComparison.supplier_3_alcohol * numberofalcoholdrinker) + (OffersComparison.supplier_3_bus * numberofbus);

            lblFindMeTheTotalCheapestQuote.Text ="total price supplier 1:" + totalpricesupplier_1.ToString() + "\ntotal price supplier 2:" + totalpricesupplier_2.ToString() + "\ntotal price supplier 3:" + totalpricesupplier_3.ToString();

    }
    }
    
}
