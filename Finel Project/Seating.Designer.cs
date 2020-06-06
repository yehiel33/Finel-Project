namespace Finel_Project
{
    partial class Seating
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSeating = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbGuestList = new System.Windows.Forms.ComboBox();
            this.btnLoadGestList = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.rb8seats = new System.Windows.Forms.RadioButton();
            this.rb10seats = new System.Windows.Forms.RadioButton();
            this.rb12seats = new System.Windows.Forms.RadioButton();
            this.gbNumberOfSeats = new System.Windows.Forms.GroupBox();
            this.btnAddToTable = new System.Windows.Forms.Button();
            this.listTable = new System.Windows.Forms.ListBox();
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.btnOurRecommendation = new System.Windows.Forms.Button();
            this.lblRecommendation = new System.Windows.Forms.Label();
            this.gbNumberOfSeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeating
            // 
            this.lblSeating.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblSeating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSeating.ForeColor = System.Drawing.Color.White;
            this.lblSeating.Location = new System.Drawing.Point(12, 9);
            this.lblSeating.Name = "lblSeating";
            this.lblSeating.Size = new System.Drawing.Size(441, 57);
            this.lblSeating.TabIndex = 34;
            this.lblSeating.Text = "Seating";
            this.lblSeating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.Location = new System.Drawing.Point(21, 811);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 57);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbGuestList
            // 
            this.cmbGuestList.FormattingEnabled = true;
            this.cmbGuestList.Location = new System.Drawing.Point(21, 494);
            this.cmbGuestList.Name = "cmbGuestList";
            this.cmbGuestList.Size = new System.Drawing.Size(221, 24);
            this.cmbGuestList.TabIndex = 53;
            this.cmbGuestList.Visible = false;
            // 
            // btnLoadGestList
            // 
            this.btnLoadGestList.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLoadGestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLoadGestList.Location = new System.Drawing.Point(130, 438);
            this.btnLoadGestList.Name = "btnLoadGestList";
            this.btnLoadGestList.Size = new System.Drawing.Size(221, 34);
            this.btnLoadGestList.TabIndex = 54;
            this.btnLoadGestList.Text = "Load Gest List";
            this.btnLoadGestList.UseVisualStyleBackColor = false;
            this.btnLoadGestList.Click += new System.EventHandler(this.btnLoadGestList_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.DarkCyan;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 285);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(441, 50);
            this.lblWelcome.TabIndex = 55;
            this.lblWelcome.Text = "Please choose the size of the tables";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb8seats
            // 
            this.rb8seats.AutoSize = true;
            this.rb8seats.Location = new System.Drawing.Point(6, 21);
            this.rb8seats.Name = "rb8seats";
            this.rb8seats.Size = new System.Drawing.Size(75, 21);
            this.rb8seats.TabIndex = 56;
            this.rb8seats.TabStop = true;
            this.rb8seats.Text = "8 seats";
            this.rb8seats.UseVisualStyleBackColor = true;
            // 
            // rb10seats
            // 
            this.rb10seats.AutoSize = true;
            this.rb10seats.Location = new System.Drawing.Point(175, 20);
            this.rb10seats.Name = "rb10seats";
            this.rb10seats.Size = new System.Drawing.Size(83, 21);
            this.rb10seats.TabIndex = 57;
            this.rb10seats.TabStop = true;
            this.rb10seats.Text = "10 seats";
            this.rb10seats.UseVisualStyleBackColor = true;
            // 
            // rb12seats
            // 
            this.rb12seats.AutoSize = true;
            this.rb12seats.Location = new System.Drawing.Point(353, 20);
            this.rb12seats.Name = "rb12seats";
            this.rb12seats.Size = new System.Drawing.Size(83, 21);
            this.rb12seats.TabIndex = 58;
            this.rb12seats.TabStop = true;
            this.rb12seats.Text = "12 seats";
            this.rb12seats.UseVisualStyleBackColor = true;
            // 
            // gbNumberOfSeats
            // 
            this.gbNumberOfSeats.Controls.Add(this.rb8seats);
            this.gbNumberOfSeats.Controls.Add(this.rb12seats);
            this.gbNumberOfSeats.Controls.Add(this.rb10seats);
            this.gbNumberOfSeats.Location = new System.Drawing.Point(12, 338);
            this.gbNumberOfSeats.Name = "gbNumberOfSeats";
            this.gbNumberOfSeats.Size = new System.Drawing.Size(441, 52);
            this.gbNumberOfSeats.TabIndex = 59;
            this.gbNumberOfSeats.TabStop = false;
            // 
            // btnAddToTable
            // 
            this.btnAddToTable.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddToTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddToTable.Location = new System.Drawing.Point(21, 556);
            this.btnAddToTable.Name = "btnAddToTable";
            this.btnAddToTable.Size = new System.Drawing.Size(221, 34);
            this.btnAddToTable.TabIndex = 60;
            this.btnAddToTable.Text = "Add to table";
            this.btnAddToTable.UseVisualStyleBackColor = false;
            this.btnAddToTable.Visible = false;
            this.btnAddToTable.Click += new System.EventHandler(this.btnAddToTable_Click);
            // 
            // listTable
            // 
            this.listTable.FormattingEnabled = true;
            this.listTable.ItemHeight = 16;
            this.listTable.Location = new System.Drawing.Point(269, 494);
            this.listTable.Name = "listTable";
            this.listTable.Size = new System.Drawing.Size(188, 228);
            this.listTable.TabIndex = 61;
            this.listTable.Visible = false;
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSaveTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSaveTable.Location = new System.Drawing.Point(269, 750);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(188, 57);
            this.btnSaveTable.TabIndex = 62;
            this.btnSaveTable.Text = "Save Table";
            this.btnSaveTable.UseVisualStyleBackColor = false;
            this.btnSaveTable.Visible = false;
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // btnOurRecommendation
            // 
            this.btnOurRecommendation.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnOurRecommendation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOurRecommendation.Location = new System.Drawing.Point(12, 84);
            this.btnOurRecommendation.Name = "btnOurRecommendation";
            this.btnOurRecommendation.Size = new System.Drawing.Size(245, 42);
            this.btnOurRecommendation.TabIndex = 63;
            this.btnOurRecommendation.Text = " Our recommendation";
            this.btnOurRecommendation.UseVisualStyleBackColor = false;
            this.btnOurRecommendation.Click += new System.EventHandler(this.btnOurRecommendation_Click);
            // 
            // lblRecommendation
            // 
            this.lblRecommendation.BackColor = System.Drawing.SystemColors.Window;
            this.lblRecommendation.Font = new System.Drawing.Font("French Script MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRecommendation.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRecommendation.Location = new System.Drawing.Point(14, 148);
            this.lblRecommendation.Name = "lblRecommendation";
            this.lblRecommendation.Size = new System.Drawing.Size(439, 114);
            this.lblRecommendation.TabIndex = 64;
            this.lblRecommendation.Visible = false;
            // 
            // Seating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 921);
            this.Controls.Add(this.lblRecommendation);
            this.Controls.Add(this.btnOurRecommendation);
            this.Controls.Add(this.btnSaveTable);
            this.Controls.Add(this.listTable);
            this.Controls.Add(this.btnAddToTable);
            this.Controls.Add(this.gbNumberOfSeats);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLoadGestList);
            this.Controls.Add(this.cmbGuestList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSeating);
            this.Name = "Seating";
            this.Text = "Seating";
            this.Load += new System.EventHandler(this.Seating_Load);
            this.gbNumberOfSeats.ResumeLayout(false);
            this.gbNumberOfSeats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSeating;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbGuestList;
        private System.Windows.Forms.Button btnLoadGestList;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.RadioButton rb8seats;
        private System.Windows.Forms.RadioButton rb10seats;
        private System.Windows.Forms.RadioButton rb12seats;
        private System.Windows.Forms.GroupBox gbNumberOfSeats;
        private System.Windows.Forms.Button btnAddToTable;
        private System.Windows.Forms.ListBox listTable;
        private System.Windows.Forms.Button btnSaveTable;
        private System.Windows.Forms.Button btnOurRecommendation;
        private System.Windows.Forms.Label lblRecommendation;
    }
}