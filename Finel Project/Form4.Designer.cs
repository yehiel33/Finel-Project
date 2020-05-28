namespace Finel_Project
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.btnDeleteGuest = new System.Windows.Forms.Button();
            this.btnShowAllGuests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(227, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 122);
            this.label1.TabIndex = 0;
            this.label1.Text = "גריד וויו";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.Location = new System.Drawing.Point(26, 358);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 67);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExit.Location = new System.Drawing.Point(453, 358);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 67);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddGuest.Location = new System.Drawing.Point(27, 280);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(182, 34);
            this.btnAddGuest.TabIndex = 36;
            this.btnAddGuest.Text = "Add Guest";
            this.btnAddGuest.UseVisualStyleBackColor = false;
            // 
            // btnDeleteGuest
            // 
            this.btnDeleteGuest.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnDeleteGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDeleteGuest.Location = new System.Drawing.Point(212, 280);
            this.btnDeleteGuest.Name = "btnDeleteGuest";
            this.btnDeleteGuest.Size = new System.Drawing.Size(182, 34);
            this.btnDeleteGuest.TabIndex = 35;
            this.btnDeleteGuest.Text = "Delete Guest";
            this.btnDeleteGuest.UseVisualStyleBackColor = false;
            // 
            // btnShowAllGuests
            // 
            this.btnShowAllGuests.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnShowAllGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShowAllGuests.Location = new System.Drawing.Point(400, 280);
            this.btnShowAllGuests.Name = "btnShowAllGuests";
            this.btnShowAllGuests.Size = new System.Drawing.Size(182, 34);
            this.btnShowAllGuests.TabIndex = 34;
            this.btnShowAllGuests.Text = "Show All Guests";
            this.btnShowAllGuests.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddGuest);
            this.Controls.Add(this.btnDeleteGuest);
            this.Controls.Add(this.btnShowAllGuests);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Button btnDeleteGuest;
        private System.Windows.Forms.Button btnShowAllGuests;
    }
}