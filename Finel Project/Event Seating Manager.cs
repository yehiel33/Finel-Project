using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finel_Project
{
    public partial class EventSeatingManager : Form
    {
        //הגדרת משתנה גלובלי - שם בעל האירוע 
        public static string globalusername = "";

        public EventSeatingManager()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //הסתרת החלון הנוכחי ומעבר לחלון התחברות
            this.Hide(); 
            SignIn signin= new SignIn();
            signin.ShowDialog();
            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //הסתרת החלון הנוכחי ומעבר לחלון יצירת משתמש
            this.Hide();
            CreateAccount createaccount= new CreateAccount();
            createaccount.ShowDialog();
            this.Hide();
        }

        private void btnGueasList_Click(object sender, EventArgs e)
        {
            //הסתרת החלון הנוכחי ומעבר לחלון רשימת אורחים
            this.Hide();
            GuestList guestlist = new GuestList();
            guestlist.ShowDialog();
            this.Hide();
        }

        private void btnComparePrices_Click(object sender, EventArgs e)
        {
            //הסתרת החלון הנוכחי ומעבר לחלון אומדן עלויות
            this.Hide();
            OffersComparison offerscomparison = new OffersComparison();
            offerscomparison.ShowDialog();
            this.Hide();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            //הסתרת החלון הנוכחי ומעבר לחלון סטטיסטיקה
            this.Hide();
            Statistics statistics = new Statistics();
            statistics.ShowDialog();
            this.Hide();
        }

        private void btnSeating_Click(object sender, EventArgs e)
        {
            //הסתרת החלון הנוכחי ומעבר לחלון הושבה
            this.Hide();
            Seating seating = new Seating();
            seating.ShowDialog();
            this.Hide();
        }

        private void EventSeatingManager_Load(object sender, EventArgs e)
        {
            //חלק זה מאפשר את השימוש בלחצנים שיהיו נעולים עד לרגע שיהיה משתמש רשום
            
            bool flag = SignIn.EnableBtnFlag; //הגדרת משתנה דגל שמקבל ערכים ממשתנה גלובלי בטופס - התחברות 
            if (flag == true)
            {
             btnGueasList.Enabled = true;
             btnComparePrices.Enabled = true;
             btnSeating.Enabled = true;
             btnStatistics.Enabled = true;
             btnSignIn.Enabled = false;
             btnCreateAccount.Enabled = false;
             lblWelcome.Text = "Welcome " + globalusername + " !"; //הצגת שם בעל האירוע
            }
            

            
        }
    }
}
