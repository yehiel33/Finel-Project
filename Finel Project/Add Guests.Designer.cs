namespace Finel_Project
{
    partial class AddGuest
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.lblDishType = new System.Windows.Forms.Label();
            this.combDishType = new System.Windows.Forms.ComboBox();
            this.gUESTLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finel_ProjectDataSet = new Finel_Project.Finel_ProjectDataSet();
            this.gUEST_LISTTableAdapter = new Finel_Project.Finel_ProjectDataSetTableAdapters.GUEST_LISTTableAdapter();
            this.gUESTLISTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbAlcohol = new System.Windows.Forms.CheckBox();
            this.cbBus = new System.Windows.Forms.CheckBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Finel_Project.Finel_ProjectDataSetTableAdapters.TableAdapterManager();
            this.combSide = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gUESTLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finel_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUESTLISTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.DarkCyan;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFirstName.Location = new System.Drawing.Point(12, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(133, 30);
            this.lblFirstName.TabIndex = 56;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFirstName.Location = new System.Drawing.Point(151, 9);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 30);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.DarkCyan;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLastName.Location = new System.Drawing.Point(12, 52);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(133, 30);
            this.lblLastName.TabIndex = 58;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtLastName.Location = new System.Drawing.Point(151, 52);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 30);
            this.txtLastName.TabIndex = 2;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BackColor = System.Drawing.Color.DarkCyan;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 95);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(133, 30);
            this.lblPhoneNumber.TabIndex = 60;
            this.lblPhoneNumber.Text = "Phone #";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(151, 95);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(174, 30);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // lblSide
            // 
            this.lblSide.BackColor = System.Drawing.Color.DarkCyan;
            this.lblSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSide.Location = new System.Drawing.Point(12, 137);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(133, 30);
            this.lblSide.TabIndex = 62;
            this.lblSide.Text = "Side";
            this.lblSide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDishType
            // 
            this.lblDishType.BackColor = System.Drawing.Color.DarkCyan;
            this.lblDishType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDishType.Location = new System.Drawing.Point(12, 177);
            this.lblDishType.Name = "lblDishType";
            this.lblDishType.Size = new System.Drawing.Size(133, 30);
            this.lblDishType.TabIndex = 64;
            this.lblDishType.Text = "Dish Type";
            this.lblDishType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combDishType
            // 
            this.combDishType.FormattingEnabled = true;
            this.combDishType.Items.AddRange(new object[] {
            "רגיל",
            "צמחוני",
            "טבעוני"});
            this.combDishType.Location = new System.Drawing.Point(151, 183);
            this.combDishType.Name = "combDishType";
            this.combDishType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combDishType.Size = new System.Drawing.Size(115, 24);
            this.combDishType.TabIndex = 5;
            this.combDishType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gUESTLISTBindingSource
            // 
            this.gUESTLISTBindingSource.DataMember = "GUEST_LIST";
            this.gUESTLISTBindingSource.DataSource = this.finel_ProjectDataSet;
            // 
            // finel_ProjectDataSet
            // 
            this.finel_ProjectDataSet.DataSetName = "Finel_ProjectDataSet";
            this.finel_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gUEST_LISTTableAdapter
            // 
            this.gUEST_LISTTableAdapter.ClearBeforeFill = true;
            // 
            // gUESTLISTBindingSource1
            // 
            this.gUESTLISTBindingSource1.DataMember = "GUEST_LIST";
            this.gUESTLISTBindingSource1.DataSource = this.finel_ProjectDataSet;
            // 
            // cbAlcohol
            // 
            this.cbAlcohol.AutoSize = true;
            this.cbAlcohol.Location = new System.Drawing.Point(17, 224);
            this.cbAlcohol.Name = "cbAlcohol";
            this.cbAlcohol.Size = new System.Drawing.Size(76, 21);
            this.cbAlcohol.TabIndex = 6;
            this.cbAlcohol.Text = "Alcohol";
            this.cbAlcohol.UseVisualStyleBackColor = true;
            // 
            // cbBus
            // 
            this.cbBus.AutoSize = true;
            this.cbBus.Location = new System.Drawing.Point(130, 224);
            this.cbBus.Name = "cbBus";
            this.cbBus.Size = new System.Drawing.Size(54, 21);
            this.cbBus.TabIndex = 7;
            this.cbBus.Text = "Bus";
            this.cbBus.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDone.Location = new System.Drawing.Point(246, 259);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(139, 45);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancel.Location = new System.Drawing.Point(17, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 45);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EVENT_OWNERSTableAdapter = null;
            this.tableAdapterManager.GUEST_LISTTableAdapter = this.gUEST_LISTTableAdapter;
            this.tableAdapterManager.SUPPLIERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Finel_Project.Finel_ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // combSide
            // 
            this.combSide.FormattingEnabled = true;
            this.combSide.Items.AddRange(new object[] {
            "חתן",
            "כלה",
            "ללא"});
            this.combSide.Location = new System.Drawing.Point(151, 143);
            this.combSide.Name = "combSide";
            this.combSide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combSide.Size = new System.Drawing.Size(115, 24);
            this.combSide.TabIndex = 4;
            // 
            // AddGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 313);
            this.Controls.Add(this.combSide);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.cbBus);
            this.Controls.Add(this.cbAlcohol);
            this.Controls.Add(this.combDishType);
            this.Controls.Add(this.lblDishType);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "AddGuest";
            this.Text = "Add Guest";
            this.Load += new System.EventHandler(this.AddGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gUESTLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finel_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUESTLISTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.Label lblDishType;
        private System.Windows.Forms.ComboBox combDishType;
        private Finel_ProjectDataSet finel_ProjectDataSet;
        private System.Windows.Forms.BindingSource gUESTLISTBindingSource;
        private Finel_ProjectDataSetTableAdapters.GUEST_LISTTableAdapter gUEST_LISTTableAdapter;
        private System.Windows.Forms.BindingSource gUESTLISTBindingSource1;
        private System.Windows.Forms.CheckBox cbAlcohol;
        private System.Windows.Forms.CheckBox cbBus;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCancel;
        private Finel_ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox combSide;
    }
}