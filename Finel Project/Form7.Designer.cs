namespace Finel_Project
{
    partial class Form7
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSeating = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCalculate.Location = new System.Drawing.Point(17, 95);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCalculate.Size = new System.Drawing.Size(183, 259);
            this.btnCalculate.TabIndex = 35;
            this.btnCalculate.Text = "אופציות:הושבה רנדומליתעריכת שולחנות ידנית";
            this.btnCalculate.UseVisualStyleBackColor = false;
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
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSeating);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSeating;
    }
}