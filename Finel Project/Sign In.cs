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


namespace Finel_Project
{
    public partial class SignIn : Form
    {
        public static bool OptionsEnabledFlag = false;
        public SignIn()
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

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //הצגה וביטול הצגת סיסמא
            if (cbShowPassword.Checked == true)
                txtPassword.PasswordChar = (char)0;
            else
                txtPassword.PasswordChar = '*';
        }

        private void btnCreateAcount_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("please insert user name and password");
            }
            else
            {
                string strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT COUNT (*) from EVENT_OWNERS where User Name='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "';", conn); //command sql
                int count ;
                count = (Int32)cmd.ExecuteScalar();

                if (count == 1)
                {
                    OptionsEnabledFlag = true;
                    this.Hide();
                    EventSeatingManager eventseatingmanager = new EventSeatingManager();
                    eventseatingmanager.ShowDialog();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Unexpected error");
                }
                else
                {
                    MessageBox.Show("Incorrect user name or password");
                }
            }

        }
    }
}
