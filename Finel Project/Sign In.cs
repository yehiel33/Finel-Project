using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //עבודה מול אקסס
using System.Net.Mail;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Finel_Project
{
    public partial class SignIn : Form
    {
        public static bool EnableBtnFlag = false;//הגדרת משתנה דגל גלובלי שלפיו נאפשר שימוש בשאר הלחצנים

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
            this.Hide();
        }
        private void eVENT_OWNERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //כל השורות בשיטה זו נוצרות אוטומטית בעת קישור לבסיס הנתונים
        {
            this.Validate();
            this.eVENT_OWNERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finel_ProjectDataSet);
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        //שיטה להצגה וביטול הצגת סיסמא
        {
            if (cbShowPassword.Checked == true)
                txtPassword.PasswordChar = (char)0;
            else
                txtPassword.PasswordChar = '*';
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        //שיטה זו מוודאת הזנת פרטים כראויי ומבצעת הזדהות מול בסיס הנתונים
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
                MessageBox.Show("please insert user name and password");//הודעת שגיאה שתקפוץ אם לא הוזנו שם משתמש וסיסמא


            bool tryFlag = false; // משתנה שבודק אם הניסיון לכתוב לבסיס הנתונים הצליח

            try
            {
                //יצירת אוקייבט בשם "טייבל-אדפטר" שנקרא יוזר
                Finel_ProjectDataSetTableAdapters.EVENT_OWNERSTableAdapter user = new Finel_ProjectDataSetTableAdapters.EVENT_OWNERSTableAdapter();
                //ישנה פניה לשיטה "גט יוזר..." השיטה מקבלת את שם המשתמש והסיסמא שהוזנו ושולפת לתוך "דטה-טייבל" את כל הרשומות שנמצאו
                Finel_ProjectDataSet.EVENT_OWNERSDataTable dt = user.GetDataByUserNameAndPassword(txtUserName.Text, txtPassword.Text);

                if (dt.Rows.Count == 1)//במידה וקיימת רשומה אחת בלבד תתבצע הזדהות
                {
                    EventSeatingManager.globalusername = txtUserName.Text;
                    EnableBtnFlag = true;
                    tryFlag = true;
                }

                else if (dt.Rows.Count > 1)//במידה וקיימת יותר מרשומה אחת תקפוץ התראה - כנראה שיש בעיה ויש שם משתמש כפול
                {
                    MessageBox.Show("Duplicate User Name!");
                    tryFlag = false;
                }
                else//במידה ולא קיים שם משתמש או ששם המשתמש או הסיסמא לא נכונים תקפוץ הודעת שגיאה 
                {
                    MessageBox.Show("Incorrect user name or password");
                    tryFlag = false;
                }
            }
            //הודעת שגיאה במידה והעבודה מול "הדטה-בייס" לא התבצעה כנדרש
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (tryFlag == true)
            //סגירת החלון הנוכחי וחזרה לחלון הראשי
            {

                this.Close();
                EventSeatingManager eventseatingmanager = new EventSeatingManager();
                eventseatingmanager.ShowDialog();
                this.Close();
            }


        }


    }
}

