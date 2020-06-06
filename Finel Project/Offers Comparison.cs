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
using System.Security.Cryptography;

namespace Finel_Project
{
    public partial class OffersComparison : Form
    {
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

            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader(); // הגדרת אובייקט קריאה
                int i=0;
                while (reader.Read())
                {
                    if (i==0)
                        lblprice1.Text = reader["Price For Regular"].ToString();
                    else if (i==1)
                        lblprice2.Text = reader["Price For Regular"].ToString();
                    else
                        lblprice3.Text = reader["Price For Regular"].ToString();
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
    }
    
}
