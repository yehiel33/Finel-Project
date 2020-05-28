﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //access connection
using Finel_Project.Finel_ProjectDataSetTableAdapters;

namespace Finel_Project
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
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

        private void eVENT_OWNERSBindingNavigatorSaveItem_Click(object sender, EventArgs e) // פונקציה ראשונה שנוצרת בעת קישור הדטה בייס לקוד
        {
            this.Validate();
            this.eVENT_OWNERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finel_ProjectDataSet);
        }

        private void CreateAccount_Load(object sender, EventArgs e) // פונקציה מספר שנייה שנוצרת בעת קישור הדטה בייס לקוד
        {
            // TODO: This line of code loads data into the 'finel_ProjectDataSet.EVENT_OWNERS' table. You can move, or remove it, as needed.
            this.eVENT_OWNERSTableAdapter.Fill(this.finel_ProjectDataSet.EVENT_OWNERS);

        }

        private void btnCreateAcount_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")// בדיקה שהשדות לא ריקים
            {
                MessageBox.Show("Please insert User Name and Password");
            }
            else
            {
                try
                {
                    //הוספת שורה לדטה סט שתכיל את התוכן של תיבות הטקסט
                    finel_ProjectDataSet.EVENT_OWNERS.AddEVENT_OWNERSRow(txtFirstName.Text, txtLastName.Text, txtEventName.Text, txtEventType.Text, txtUserName.Text, txtPassword.Text);
                    //פקודה זו מעדכנת את הדטה סט
                    eVENT_OWNERSTableAdapter.Update(finel_ProjectDataSet);
                    //סיום עריכה
                    eVENT_OWNERSBindingSource.EndEdit();
                    // מעדכן את בסיס הנתונים מול הדטה סט
                    tableAdapterManager.UpdateAll(finel_ProjectDataSet);
                    //ניקויי שדות
                    txtFirstName.Text = txtLastName.Text = txtEventName.Text = txtEventType.Text = txtUserName.Text = txtPassword.Text = "";
                    MessageBox.Show("Registration completed successfully!");

                    this.Hide();
                    EventSeatingManager eventseatingmanager = new EventSeatingManager();
                    eventseatingmanager.ShowDialog();


                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "error");
                }

            }

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //הצגה וביטול הצגת סיסמא
            if (cbShowPassword.Checked == true)
                txtPassword.PasswordChar = (char)0;
            else
                txtPassword.PasswordChar = '*'; 
        }
    }     
}
