﻿using System;
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

        private void SignIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finel_ProjectDataSet.EVENT_OWNERS' table. You can move, or remove it, as needed.
            this.eVENT_OWNERSTableAdapter.Fill(this.finel_ProjectDataSet.EVENT_OWNERS);

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
            else
            {
                try
                {
                    string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    OleDbCommand command = new OleDbCommand();
                    conn.Open();
                    command.Connection = conn;
                    command.CommandText = "select * from EVENT_OWNERS where User Name='" + txtUserName.Text + "'and Password='" + txtPassword.Text + "'";
                    OleDbDataReader reader= command.ExecuteReader();
                    int count = 0;

                    /* string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
                     OleDbConnection conn = new OleDbConnection(strDb);
                     OleDbCommand cmd = new OleDbCommand("SETECT (*) FROM EVENT_OWNERS WHERE User Name='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "';", conn); //command sql
                     conn.Open();

                     OleDbDataReader reader = cmd.ExecuteReader();
                     int count = 0;
                    */
                    while (reader.Read())
                    {
                        count++;
                    }
                    if (count ==1)
                    {
                        OptionsEnabledFlag = true;
                        conn.Close();
                        this.Close();
                        EventSeatingManager eventseatingmanager = new EventSeatingManager();
                        eventseatingmanager.ShowDialog();
                    }
                    if (count > 1)
                    {
                        MessageBox.Show("Duplicate User Name!");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect user name or password");
                    }
                    conn.Close();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }

     
    }
    }

