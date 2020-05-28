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
        /*connection string
         Provider=Microsoft.ACE.OLEDB.12.0;Data Source="C:\Users\Public\Finel Project\Finel Project.accdb" 
         */

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
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //הסתרת החלון הנוכחי ומעבר לחלון יצירת משתמש
            this.Hide();
            CreateAccount createaccount= new CreateAccount();
            createaccount.ShowDialog();
        }

        private void btnGueasList_Click(object sender, EventArgs e)
        {
            //הסתרת החלון הנוכחי ומעבר לחלון רשימת אורחים
            this.Hide();
            GuestList guestlist = new GuestList();
            guestlist.ShowDialog();
        }

        private void btnCostEvaluetion_Click(object sender, EventArgs e)
        {
            //הסתרת החלון הנוכחי ומעבר לחלון אומדן עלויות
            this.Hide();
            CostEvaluation costevaluation = new CostEvaluation();
            costevaluation.ShowDialog();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            //הסתרת החלון הנוכחי ומעבר לחלון סטטיסטיקה
            this.Hide();
            Statistics statistics = new Statistics();
            statistics.ShowDialog();
        }

        private void btnSeating_Click(object sender, EventArgs e)
        {
            //הסתרת החלון הנוכחי ומעבר לחלון הושבה
            this.Hide();
            Seating seating = new Seating();
            seating.ShowDialog();
        }
    }
}
