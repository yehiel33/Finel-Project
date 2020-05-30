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
using System.Net.Mail;
using System.Data.SqlClient;

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
       private void eVENT_OWNERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eVENT_OWNERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finel_ProjectDataSet);

        }
        
       
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //הצגה וביטול הצגת סיסמא
            if (cbShowPassword.Checked == true)
                txtPassword.PasswordChar = (char)0;
            else
                txtPassword.PasswordChar = '*';
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("please insert user name and password");
            }
            try
            {
                Finel_ProjectDataSetTableAdapters.EVENT_OWNERSTableAdapter user = new Finel_ProjectDataSetTableAdapters.EVENT_OWNERSTableAdapter();
                Finel_ProjectDataSet.EVENT_OWNERSDataTable dt = user.GetDataByUserNameAndPassword(txtUserName.Text, txtPassword.Text);
                if(dt.Rows.Count==1)
                {
                    OptionsEnabledFlag = true;
                    this.Close();
                    EventSeatingManager eventseatingmanager = new EventSeatingManager();
                    eventseatingmanager.ShowDialog();
                }
               
                if(dt.Rows.Count>1)
                {
                    MessageBox.Show("Duplicate User Name!");
                }
                else
                {
                    MessageBox.Show("Incorrect user name or password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

       
    }
    }

