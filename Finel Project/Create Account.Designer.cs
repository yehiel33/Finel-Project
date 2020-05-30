namespace Finel_Project
{
    partial class CreateAccount
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
            this.lblEventType = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.eVENT_OWNERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finel_ProjectDataSet = new Finel_Project.Finel_ProjectDataSet();
            this.lblEventName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.btnCreateAcount = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.cbEventType = new System.Windows.Forms.ComboBox();
            this.eVENT_OWNERSTableAdapter = new Finel_Project.Finel_ProjectDataSetTableAdapters.EVENT_OWNERSTableAdapter();
            this.tableAdapterManager = new Finel_Project.Finel_ProjectDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.eVENT_OWNERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finel_ProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEventType
            // 
            this.lblEventType.BackColor = System.Drawing.Color.DarkCyan;
            this.lblEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEventType.Location = new System.Drawing.Point(18, 289);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(244, 30);
            this.lblEventType.TabIndex = 48;
            this.lblEventType.Text = "Event Type";
            this.lblEventType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEventName.Location = new System.Drawing.Point(260, 241);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(246, 30);
            this.txtEventName.TabIndex = 3;
            // 
            // eVENT_OWNERSBindingSource
            // 
            this.eVENT_OWNERSBindingSource.DataMember = "EVENT_OWNERS";
            this.eVENT_OWNERSBindingSource.DataSource = this.finel_ProjectDataSet;
            // 
            // finel_ProjectDataSet
            // 
            this.finel_ProjectDataSet.DataSetName = "Finel_ProjectDataSet";
            this.finel_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblEventName
            // 
            this.lblEventName.BackColor = System.Drawing.Color.DarkCyan;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEventName.Location = new System.Drawing.Point(18, 241);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(244, 30);
            this.lblEventName.TabIndex = 47;
            this.lblEventName.Text = "Event Name";
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFirstName.Location = new System.Drawing.Point(260, 147);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(246, 30);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.DarkCyan;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFirstName.Location = new System.Drawing.Point(18, 147);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(244, 30);
            this.lblFirstName.TabIndex = 46;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtLastName.Location = new System.Drawing.Point(260, 193);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(246, 30);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.DarkCyan;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLastName.Location = new System.Drawing.Point(18, 193);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(244, 30);
            this.lblLastName.TabIndex = 45;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.Location = new System.Drawing.Point(264, 427);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(238, 24);
            this.cbShowPassword.TabIndex = 44;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // btnCreateAcount
            // 
            this.btnCreateAcount.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCreateAcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCreateAcount.Location = new System.Drawing.Point(339, 482);
            this.btnCreateAcount.Name = "btnCreateAcount";
            this.btnCreateAcount.Size = new System.Drawing.Size(167, 57);
            this.btnCreateAcount.TabIndex = 7;
            this.btnCreateAcount.Text = "Create Acount";
            this.btnCreateAcount.UseVisualStyleBackColor = false;
            this.btnCreateAcount.Click += new System.EventHandler(this.btnCreateAcount_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.Location = new System.Drawing.Point(23, 482);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 57);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPassword.Location = new System.Drawing.Point(260, 381);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(246, 30);
            this.txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.DarkCyan;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPassword.Location = new System.Drawing.Point(18, 381);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(244, 30);
            this.lblPassword.TabIndex = 37;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.DarkCyan;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUserName.Location = new System.Drawing.Point(18, 335);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(244, 30);
            this.lblUserName.TabIndex = 35;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtUserName.Location = new System.Drawing.Point(260, 335);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(246, 30);
            this.txtUserName.TabIndex = 5;
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.White;
            this.lblCreateAccount.Location = new System.Drawing.Point(12, 9);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(490, 57);
            this.lblCreateAccount.TabIndex = 43;
            this.lblCreateAccount.Text = "Create Account";
            this.lblCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegister
            // 
            this.lblRegister.BackColor = System.Drawing.Color.DarkCyan;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRegister.Location = new System.Drawing.Point(14, 85);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(488, 36);
            this.lblRegister.TabIndex = 42;
            this.lblRegister.Text = "Please Register To The System:";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbEventType
            // 
            this.cbEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbEventType.FormattingEnabled = true;
            this.cbEventType.Items.AddRange(new object[] {
            "בר מצווה",
            "חתונה",
            "ברית ",
            "יום הולדת"});
            this.cbEventType.Location = new System.Drawing.Point(260, 289);
            this.cbEventType.Name = "cbEventType";
            this.cbEventType.Size = new System.Drawing.Size(246, 30);
            this.cbEventType.TabIndex = 4;
            // 
            // eVENT_OWNERSTableAdapter
            // 
            this.eVENT_OWNERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EVENT_OWNERSTableAdapter = this.eVENT_OWNERSTableAdapter;
            this.tableAdapterManager.GUEST_LISTTableAdapter = null;
            this.tableAdapterManager.SUPPLIERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Finel_Project.Finel_ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 552);
            this.Controls.Add(this.cbEventType);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.btnCreateAcount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.lblRegister);
            this.Name = "CreateAccount";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eVENT_OWNERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finel_ProjectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Button btnCreateAcount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label lblRegister;
        private Finel_ProjectDataSet finel_ProjectDataSet;
        private System.Windows.Forms.BindingSource eVENT_OWNERSBindingSource;
        private Finel_ProjectDataSetTableAdapters.EVENT_OWNERSTableAdapter eVENT_OWNERSTableAdapter;
        private Finel_ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbEventType;
    }
}