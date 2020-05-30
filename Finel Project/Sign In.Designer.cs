namespace Finel_Project
{
    partial class SignIn
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.eVENT_OWNERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finel_ProjectDataSet = new Finel_Project.Finel_ProjectDataSet();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.eVENT_OWNERSTableAdapter = new Finel_Project.Finel_ProjectDataSetTableAdapters.EVENT_OWNERSTableAdapter();
            this.tableAdapterManager = new Finel_Project.Finel_ProjectDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.eVENT_OWNERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finel_ProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eVENT_OWNERSBindingSource, "User Name", true));
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtUserName.Location = new System.Drawing.Point(260, 138);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(246, 30);
            this.txtUserName.TabIndex = 47;
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
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.DarkCyan;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUserName.Location = new System.Drawing.Point(18, 138);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(244, 30);
            this.lblUserName.TabIndex = 55;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eVENT_OWNERSBindingSource, "Password", true));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPassword.Location = new System.Drawing.Point(260, 174);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(246, 30);
            this.txtPassword.TabIndex = 48;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.DarkCyan;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPassword.Location = new System.Drawing.Point(18, 174);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(244, 30);
            this.lblPassword.TabIndex = 54;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.Location = new System.Drawing.Point(260, 224);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(238, 24);
            this.cbShowPassword.TabIndex = 53;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSignIn.Location = new System.Drawing.Point(349, 265);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(157, 57);
            this.btnSignIn.TabIndex = 49;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.Location = new System.Drawing.Point(21, 265);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 57);
            this.btnBack.TabIndex = 50;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSignIn
            // 
            this.lblSignIn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSignIn.ForeColor = System.Drawing.Color.White;
            this.lblSignIn.Location = new System.Drawing.Point(12, 9);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(490, 57);
            this.lblSignIn.TabIndex = 52;
            this.lblSignIn.Text = "Sign In";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegister
            // 
            this.lblRegister.BackColor = System.Drawing.Color.DarkCyan;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRegister.Location = new System.Drawing.Point(14, 85);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(488, 36);
            this.lblRegister.TabIndex = 51;
            this.lblRegister.Text = "Please Register To The System:";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 340);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.lblRegister);
            this.Name = "SignIn";
            this.Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.eVENT_OWNERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finel_ProjectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblRegister;
        private Finel_ProjectDataSet finel_ProjectDataSet;
        private System.Windows.Forms.BindingSource eVENT_OWNERSBindingSource;
        private Finel_ProjectDataSetTableAdapters.EVENT_OWNERSTableAdapter eVENT_OWNERSTableAdapter;
        private Finel_ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}