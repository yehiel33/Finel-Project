namespace Finel_Project
{
    partial class OffersComparison
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
            this.components = new System.ComponentModel.Container();
            this.sUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finel_ProjectDataSet = new Finel_Project.Finel_ProjectDataSet();
            this.sUPPLIERSTableAdapter = new Finel_Project.Finel_ProjectDataSetTableAdapters.SUPPLIERSTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.msSelect = new System.Windows.Forms.MenuStrip();
            this.tsmOptionToComprise = new System.Windows.Forms.ToolStripMenuItem();
            this.priceForRegularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceForVegeterianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceForVeganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceForAlcoholToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceForBusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblprice1 = new System.Windows.Forms.Label();
            this.lblprice2 = new System.Windows.Forms.Label();
            this.lblprice3 = new System.Windows.Forms.Label();
            this.lblSupplier2 = new System.Windows.Forms.Label();
            this.lblSupplier3 = new System.Windows.Forms.Label();
            this.lblSupplier1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finel_ProjectDataSet)).BeginInit();
            this.msSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // sUPPLIERSBindingSource
            // 
            this.sUPPLIERSBindingSource.DataMember = "SUPPLIERS";
            this.sUPPLIERSBindingSource.DataSource = this.finel_ProjectDataSet;
            // 
            // finel_ProjectDataSet
            // 
            this.finel_ProjectDataSet.DataSetName = "Finel_ProjectDataSet";
            this.finel_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUPPLIERSTableAdapter
            // 
            this.sUPPLIERSTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.Location = new System.Drawing.Point(17, 381);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 57);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // msSelect
            // 
            this.msSelect.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOptionToComprise});
            this.msSelect.Location = new System.Drawing.Point(0, 0);
            this.msSelect.Name = "msSelect";
            this.msSelect.Size = new System.Drawing.Size(470, 30);
            this.msSelect.TabIndex = 54;
            this.msSelect.Text = "select option to compare";
            // 
            // tsmOptionToComprise
            // 
            this.tsmOptionToComprise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceForRegularToolStripMenuItem,
            this.priceForVegeterianToolStripMenuItem,
            this.priceForVeganToolStripMenuItem,
            this.priceForAlcoholToolStripMenuItem,
            this.priceForBusToolStripMenuItem});
            this.tsmOptionToComprise.Name = "tsmOptionToComprise";
            this.tsmOptionToComprise.Size = new System.Drawing.Size(150, 26);
            this.tsmOptionToComprise.Text = "option to comprise";
            // 
            // priceForRegularToolStripMenuItem
            // 
            this.priceForRegularToolStripMenuItem.Name = "priceForRegularToolStripMenuItem";
            this.priceForRegularToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.priceForRegularToolStripMenuItem.Text = "Price For Regular";
            this.priceForRegularToolStripMenuItem.Click += new System.EventHandler(this.priceForRegularToolStripMenuItem_Click);
            // 
            // priceForVegeterianToolStripMenuItem
            // 
            this.priceForVegeterianToolStripMenuItem.Name = "priceForVegeterianToolStripMenuItem";
            this.priceForVegeterianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.priceForVegeterianToolStripMenuItem.Text = "Price For Vegeterian";
            // 
            // priceForVeganToolStripMenuItem
            // 
            this.priceForVeganToolStripMenuItem.Name = "priceForVeganToolStripMenuItem";
            this.priceForVeganToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.priceForVeganToolStripMenuItem.Text = "Price For Vegan";
            // 
            // priceForAlcoholToolStripMenuItem
            // 
            this.priceForAlcoholToolStripMenuItem.Name = "priceForAlcoholToolStripMenuItem";
            this.priceForAlcoholToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.priceForAlcoholToolStripMenuItem.Text = "Price For Alcohol";
            // 
            // priceForBusToolStripMenuItem
            // 
            this.priceForBusToolStripMenuItem.Name = "priceForBusToolStripMenuItem";
            this.priceForBusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.priceForBusToolStripMenuItem.Text = "Price For Bus";
            // 
            // lblprice1
            // 
            this.lblprice1.BackColor = System.Drawing.SystemColors.Window;
            this.lblprice1.Location = new System.Drawing.Point(12, 104);
            this.lblprice1.Name = "lblprice1";
            this.lblprice1.Size = new System.Drawing.Size(132, 32);
            this.lblprice1.TabIndex = 58;
            this.lblprice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblprice2
            // 
            this.lblprice2.BackColor = System.Drawing.SystemColors.Window;
            this.lblprice2.Location = new System.Drawing.Point(176, 104);
            this.lblprice2.Name = "lblprice2";
            this.lblprice2.Size = new System.Drawing.Size(129, 32);
            this.lblprice2.TabIndex = 59;
            this.lblprice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblprice3
            // 
            this.lblprice3.BackColor = System.Drawing.SystemColors.Window;
            this.lblprice3.Location = new System.Drawing.Point(328, 104);
            this.lblprice3.Name = "lblprice3";
            this.lblprice3.Size = new System.Drawing.Size(130, 32);
            this.lblprice3.TabIndex = 60;
            this.lblprice3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSupplier2
            // 
            this.lblSupplier2.BackColor = System.Drawing.Color.DarkCyan;
            this.lblSupplier2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSupplier2.Location = new System.Drawing.Point(329, 59);
            this.lblSupplier2.Name = "lblSupplier2";
            this.lblSupplier2.Size = new System.Drawing.Size(129, 32);
            this.lblSupplier2.TabIndex = 56;
            this.lblSupplier2.Text = "חיים מסיבות";
            this.lblSupplier2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSupplier3
            // 
            this.lblSupplier3.BackColor = System.Drawing.Color.DarkCyan;
            this.lblSupplier3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSupplier3.Location = new System.Drawing.Point(176, 59);
            this.lblSupplier3.Name = "lblSupplier3";
            this.lblSupplier3.Size = new System.Drawing.Size(129, 32);
            this.lblSupplier3.TabIndex = 57;
            this.lblSupplier3.Text = "קלאס אירועים";
            this.lblSupplier3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSupplier1
            // 
            this.lblSupplier1.BackColor = System.Drawing.Color.DarkCyan;
            this.lblSupplier1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSupplier1.Location = new System.Drawing.Point(12, 59);
            this.lblSupplier1.Name = "lblSupplier1";
            this.lblSupplier1.Size = new System.Drawing.Size(132, 32);
            this.lblSupplier1.TabIndex = 55;
            this.lblSupplier1.Text = "אא הפקות";
            this.lblSupplier1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OffersComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.lblprice3);
            this.Controls.Add(this.lblprice2);
            this.Controls.Add(this.lblprice1);
            this.Controls.Add(this.lblSupplier3);
            this.Controls.Add(this.lblSupplier2);
            this.Controls.Add(this.lblSupplier1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.msSelect);
            this.MainMenuStrip = this.msSelect;
            this.Name = "OffersComparison";
            this.Text = "Offers Comparison";
            this.Load += new System.EventHandler(this.Offers_Comparison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finel_ProjectDataSet)).EndInit();
            this.msSelect.ResumeLayout(false);
            this.msSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Finel_ProjectDataSet finel_ProjectDataSet;
        private System.Windows.Forms.BindingSource sUPPLIERSBindingSource;
        private Finel_ProjectDataSetTableAdapters.SUPPLIERSTableAdapter sUPPLIERSTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MenuStrip msSelect;
        private System.Windows.Forms.ToolStripMenuItem tsmOptionToComprise;
        private System.Windows.Forms.ToolStripMenuItem priceForRegularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceForVegeterianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceForVeganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceForAlcoholToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceForBusToolStripMenuItem;
        private System.Windows.Forms.Label lblprice1;
        private System.Windows.Forms.Label lblprice2;
        private System.Windows.Forms.Label lblprice3;
        private System.Windows.Forms.Label lblSupplier2;
        private System.Windows.Forms.Label lblSupplier3;
        private System.Windows.Forms.Label lblSupplier1;
    }
}