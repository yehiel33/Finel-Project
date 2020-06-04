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
            this.lblOffersComparison = new System.Windows.Forms.Label();
            this.lblChooseSuppliers = new System.Windows.Forms.Label();
            this.finel_ProjectDataSet = new Finel_Project.Finel_ProjectDataSet();
            this.finelProjectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.finelProjectDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.finelProjectDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.finelProjectDataSetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.lblCheapestOffer = new System.Windows.Forms.Label();
            this.lblSumCheapestOffer = new System.Windows.Forms.Label();
            this.lblSupplierContacts = new System.Windows.Forms.Label();
            this.lblContacts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finel_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finelProjectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finelProjectDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finelProjectDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finelProjectDataSetBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOffersComparison
            // 
            this.lblOffersComparison.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblOffersComparison.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblOffersComparison.ForeColor = System.Drawing.Color.White;
            this.lblOffersComparison.Location = new System.Drawing.Point(128, 9);
            this.lblOffersComparison.Name = "lblOffersComparison";
            this.lblOffersComparison.Size = new System.Drawing.Size(490, 57);
            this.lblOffersComparison.TabIndex = 53;
            this.lblOffersComparison.Text = "Suppliers\' offers comparison :";
            this.lblOffersComparison.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOffersComparison.Click += new System.EventHandler(this.lblSignIn_Click);
            // 
            // lblChooseSuppliers
            // 
            this.lblChooseSuppliers.BackColor = System.Drawing.Color.DarkCyan;
            this.lblChooseSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblChooseSuppliers.Location = new System.Drawing.Point(128, 79);
            this.lblChooseSuppliers.Name = "lblChooseSuppliers";
            this.lblChooseSuppliers.Size = new System.Drawing.Size(490, 98);
            this.lblChooseSuppliers.TabIndex = 54;
            this.lblChooseSuppliers.Text = "Please choose the suppliers whom you would like to compare their offers :\r\n";
            this.lblChooseSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finel_ProjectDataSet
            // 
            this.finel_ProjectDataSet.DataSetName = "Finel_ProjectDataSet";
            this.finel_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finelProjectDataSetBindingSource
            // 
            this.finelProjectDataSetBindingSource.DataSource = this.finel_ProjectDataSet;
            this.finelProjectDataSetBindingSource.Position = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.finel_ProjectDataSet;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 55;
            // 
            // finelProjectDataSetBindingSource1
            // 
            this.finelProjectDataSetBindingSource1.DataSource = this.finel_ProjectDataSet;
            this.finelProjectDataSetBindingSource1.Position = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.finelProjectDataSetBindingSource2;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(88, 325);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 56;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // finelProjectDataSetBindingSource2
            // 
            this.finelProjectDataSetBindingSource2.DataSource = this.finel_ProjectDataSet;
            this.finelProjectDataSetBindingSource2.Position = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.finelProjectDataSetBindingSource3;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(88, 368);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 57;
            // 
            // finelProjectDataSetBindingSource3
            // 
            this.finelProjectDataSetBindingSource3.DataSource = this.finel_ProjectDataSet;
            this.finelProjectDataSetBindingSource3.Position = 0;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSuppliers.Location = new System.Drawing.Point(56, 206);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(199, 63);
            this.lblSuppliers.TabIndex = 58;
            this.lblSuppliers.Text = "compare these supliers\' offers : ";
            this.lblSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSuppliers.Click += new System.EventHandler(this.lblTotalCost_Click);
            // 
            // lblCheapestOffer
            // 
            this.lblCheapestOffer.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblCheapestOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCheapestOffer.Location = new System.Drawing.Point(289, 206);
            this.lblCheapestOffer.Name = "lblCheapestOffer";
            this.lblCheapestOffer.Size = new System.Drawing.Size(222, 63);
            this.lblCheapestOffer.TabIndex = 63;
            this.lblCheapestOffer.Text = "Cheapest offer is :";
            this.lblCheapestOffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCheapestOffer.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSumCheapestOffer
            // 
            this.lblSumCheapestOffer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSumCheapestOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSumCheapestOffer.Location = new System.Drawing.Point(289, 280);
            this.lblSumCheapestOffer.Name = "lblSumCheapestOffer";
            this.lblSumCheapestOffer.Size = new System.Drawing.Size(222, 80);
            this.lblSumCheapestOffer.TabIndex = 64;
            this.lblSumCheapestOffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSupplierContacts
            // 
            this.lblSupplierContacts.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblSupplierContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSupplierContacts.Location = new System.Drawing.Point(549, 206);
            this.lblSupplierContacts.Name = "lblSupplierContacts";
            this.lblSupplierContacts.Size = new System.Drawing.Size(222, 63);
            this.lblSupplierContacts.TabIndex = 65;
            this.lblSupplierContacts.Text = "Cheapest supplier\'s contacts :";
            this.lblSupplierContacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContacts
            // 
            this.lblContacts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblContacts.Location = new System.Drawing.Point(549, 280);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(222, 80);
            this.lblContacts.TabIndex = 66;
            this.lblContacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OffersComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContacts);
            this.Controls.Add(this.lblSupplierContacts);
            this.Controls.Add(this.lblSumCheapestOffer);
            this.Controls.Add(this.lblCheapestOffer);
            this.Controls.Add(this.lblSuppliers);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblChooseSuppliers);
            this.Controls.Add(this.lblOffersComparison);
            this.Name = "OffersComparison";
            this.Text = "Offers comparison";
            ((System.ComponentModel.ISupportInitialize)(this.finel_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finelProjectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finelProjectDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finelProjectDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finelProjectDataSetBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOffersComparison;
        private System.Windows.Forms.Label lblChooseSuppliers;
        private System.Windows.Forms.BindingSource finelProjectDataSetBindingSource;
        private Finel_ProjectDataSet finel_ProjectDataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Label lblCheapestOffer;
        private System.Windows.Forms.Label lblSumCheapestOffer;
        private System.Windows.Forms.BindingSource finelProjectDataSetBindingSource1;
        private System.Windows.Forms.BindingSource finelProjectDataSetBindingSource2;
        private System.Windows.Forms.BindingSource finelProjectDataSetBindingSource3;
        private System.Windows.Forms.Label lblSupplierContacts;
        private System.Windows.Forms.Label lblContacts;
    }
}