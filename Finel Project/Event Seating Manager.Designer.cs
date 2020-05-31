namespace Finel_Project
{
    partial class EventSeatingManager
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnSeating = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnCostEvaluetion = new System.Windows.Forms.Button();
            this.btnGueasList = new System.Windows.Forms.Button();
            this.lblEventSeatingManager = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.DarkCyan;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWelcome.Location = new System.Drawing.Point(48, 94);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(329, 50);
            this.lblWelcome.TabIndex = 39;
            this.lblWelcome.Text = "Welcome Guest.\r\nPlease sign in or create account.";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSignIn.Location = new System.Drawing.Point(47, 171);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(157, 44);
            this.btnSignIn.TabIndex = 38;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCreateAccount.Location = new System.Drawing.Point(220, 171);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(157, 44);
            this.btnCreateAccount.TabIndex = 37;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnSeating
            // 
            this.btnSeating.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSeating.Enabled = false;
            this.btnSeating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSeating.Location = new System.Drawing.Point(219, 379);
            this.btnSeating.Name = "btnSeating";
            this.btnSeating.Size = new System.Drawing.Size(157, 123);
            this.btnSeating.TabIndex = 36;
            this.btnSeating.Text = "Seating";
            this.btnSeating.UseVisualStyleBackColor = false;
            this.btnSeating.Click += new System.EventHandler(this.btnSeating_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnStatistics.Enabled = false;
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStatistics.Location = new System.Drawing.Point(46, 379);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(157, 123);
            this.btnStatistics.TabIndex = 35;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnCostEvaluetion
            // 
            this.btnCostEvaluetion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCostEvaluetion.Enabled = false;
            this.btnCostEvaluetion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCostEvaluetion.Location = new System.Drawing.Point(219, 250);
            this.btnCostEvaluetion.Name = "btnCostEvaluetion";
            this.btnCostEvaluetion.Size = new System.Drawing.Size(158, 123);
            this.btnCostEvaluetion.TabIndex = 34;
            this.btnCostEvaluetion.Text = "Cost Evaluation";
            this.btnCostEvaluetion.UseVisualStyleBackColor = false;
            this.btnCostEvaluetion.Click += new System.EventHandler(this.btnCostEvaluetion_Click);
            // 
            // btnGueasList
            // 
            this.btnGueasList.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGueasList.Enabled = false;
            this.btnGueasList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnGueasList.Location = new System.Drawing.Point(46, 250);
            this.btnGueasList.Name = "btnGueasList";
            this.btnGueasList.Size = new System.Drawing.Size(157, 123);
            this.btnGueasList.TabIndex = 33;
            this.btnGueasList.Text = "Guest List";
            this.btnGueasList.UseVisualStyleBackColor = false;
            this.btnGueasList.Click += new System.EventHandler(this.btnGueasList_Click);
            // 
            // lblEventSeatingManager
            // 
            this.lblEventSeatingManager.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblEventSeatingManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEventSeatingManager.ForeColor = System.Drawing.Color.White;
            this.lblEventSeatingManager.Location = new System.Drawing.Point(51, 20);
            this.lblEventSeatingManager.Name = "lblEventSeatingManager";
            this.lblEventSeatingManager.Size = new System.Drawing.Size(326, 57);
            this.lblEventSeatingManager.TabIndex = 32;
            this.lblEventSeatingManager.Text = "Event Seating Manager";
            this.lblEventSeatingManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventSeatingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(441, 546);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnSeating);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnCostEvaluetion);
            this.Controls.Add(this.btnGueasList);
            this.Controls.Add(this.lblEventSeatingManager);
            this.Name = "EventSeatingManager";
            this.Text = "Event Seating Manager";
            this.Load += new System.EventHandler(this.EventSeatingManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnSeating;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnCostEvaluetion;
        private System.Windows.Forms.Button btnGueasList;
        private System.Windows.Forms.Label lblEventSeatingManager;
    }
}

