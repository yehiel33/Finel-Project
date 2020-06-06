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
using System.IO;

namespace Finel_Project
{
    public partial class Seating : Form
    {
        public Seating()
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

        

        private void Seating_Load(object sender, EventArgs e)
        {
           

        }

        private void btnLoadGestList_Click(object sender, EventArgs e)
        {
            cmbGuestList.Visible = true;
            listTable.Visible = true;
            btnAddToTable.Visible = true;
            btnSaveTable.Visible = true;
            // הגדרת מחרוזת שמכילה את פקודת החיבור
            string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
            // יצירת חיבור חדש לבסיס הנתונים
            OleDbConnection conn = new OleDbConnection(strDb);
            OleDbCommand cmd = new OleDbCommand("Select * From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "';", conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader(); // הגדרת אובייקט קריאה
                while (reader.Read())
                {
                    string fullguestname = reader["Guest First Name"].ToString() +" "+ reader["Guest Last Name"].ToString();
                    cmbGuestList.Items.Add(fullguestname);
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

        private void btnAddToTable_Click(object sender, EventArgs e)
        {

            if (rb8seats.Checked)
            {
                if (listTable.Items.Count < 8)
                {
                    listTable.Items.Add(cmbGuestList.Text);
                    cmbGuestList.Items.Remove(cmbGuestList.Text);
                }
                else
                    MessageBox.Show("the table is full");
           
            }
            else if (rb10seats.Checked)
            {
                if (listTable.Items.Count < 10)
                {
                    listTable.Items.Add(cmbGuestList.Text);
                    cmbGuestList.Items.Remove(cmbGuestList.Text);
                }
                else
                    MessageBox.Show("the table is full");
            }
            else //(rb12seats.Checked)
            {
                if (listTable.Items.Count < 12)
                {
                    listTable.Items.Add(cmbGuestList.Text);
                    cmbGuestList.Items.Remove(cmbGuestList.Text);
                }
                else
                    MessageBox.Show("the table is full");
            }
        }

        private void btnOurRecommendation_Click(object sender, EventArgs e)
        {
            // הגדרת מחרוזת שמכילה את פקודת החיבור
            string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
            // יצירת חיבור חדש לבסיס הנתונים
            OleDbConnection conn = new OleDbConnection(strDb);
            OleDbCommand cmd = new OleDbCommand("Select count (*) From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "';", conn);

            try
            {
                conn.Open();
                int guestnumber = (Int32) cmd.ExecuteScalar();  // הגדרת אובייקט קריאה
                lblRecommendation.Visible = true;
                int modulo8 = guestnumber % 8;
                int modulo10 = guestnumber % 10;
                int modulo12 = guestnumber % 12;

                
                if(modulo8< modulo10 && modulo8 < modulo12)
                {
                    int numberoftables = (guestnumber / 8);
                    lblRecommendation.Text = "You have " + guestnumber + " guests on your guest list.\nOur recommendation to you is to reserv " + numberoftables + " tables of 8 and one another table of 8 to " + modulo8 + " remaining guests.";
                }
                else if (modulo10<modulo8 && modulo10<modulo12)
                { 
                    int numberoftables = (guestnumber / 10);
                    lblRecommendation.Text = "You have " + guestnumber + " guests on your guest list.\nOur recommendation to you is to reserv " + numberoftables + " tables of 10 and one another table of 8 to " + modulo10 + " remaining guests.";
                }
                else if (modulo12 < modulo8 && modulo12 < modulo8)
                {
                    int numberoftables = (guestnumber / 12);
                    lblRecommendation.Text = "You have " + guestnumber + " guests on your guest list.\nOur recommendation to you is to reserv " + numberoftables + " tables of 12 and one another table of 8 to " + modulo12 + " remaining guests.";
                }
                else
                {
                    lblRecommendation.Text = "You have " + guestnumber + " guests on your guest list.\nwe didn't find recommendation for you.";
                }

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

        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            rb8seats.Checked = false;
            rb10seats.Checked = false;
            rb12seats.Checked = false;

            SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);
                for (int i = 0; i < listTable.Items.Count; i++)
                {
                    writer.WriteLine((string)listTable.Items[i]);
                }
                writer.Close();
            }
            listTable.Items.Clear();

            dlg.Dispose();
         

        }
    }
}
