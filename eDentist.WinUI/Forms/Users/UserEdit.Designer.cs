namespace eDentist.WinUI.Forms.Users
{
    partial class UserEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.editUserRoleMenu = new System.Windows.Forms.ComboBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblCity = new System.Windows.Forms.Label();
            this.editUserCitiesMenu = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEditUser = new System.Windows.Forms.Label();
            this.lblEditUserSelect = new System.Windows.Forms.Label();
            this.UsersMenu = new System.Windows.Forms.ComboBox();
            this.profileImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(34, 312);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 68;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(207, 312);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(131, 20);
            this.txtEmail.TabIndex = 67;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(207, 466);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(130, 23);
            this.btnEditUser.TabIndex = 66;
            this.btnEditUser.Text = "Save";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(34, 426);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 20);
            this.lblRole.TabIndex = 65;
            this.lblRole.Text = "Role";
            // 
            // editUserRoleMenu
            // 
            this.editUserRoleMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editUserRoleMenu.FormattingEnabled = true;
            this.editUserRoleMenu.Location = new System.Drawing.Point(207, 425);
            this.editUserRoleMenu.Name = "editUserRoleMenu";
            this.editUserRoleMenu.Size = new System.Drawing.Size(131, 21);
            this.editUserRoleMenu.TabIndex = 64;
            this.editUserRoleMenu.SelectedIndexChanged += new System.EventHandler(this.editUserRoleMenu_SelectedIndexChanged);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(34, 386);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(113, 20);
            this.lblTelephone.TabIndex = 59;
            this.lblTelephone.Text = "Phone number";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(207, 386);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(131, 20);
            this.txtTelephone.TabIndex = 58;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(34, 350);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(99, 20);
            this.lblDateOfBirth.TabIndex = 57;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(207, 349);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(131, 20);
            this.dtpDateOfBirth.TabIndex = 56;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(34, 268);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 20);
            this.lblCity.TabIndex = 55;
            this.lblCity.Text = "City";
            // 
            // editUserCitiesMenu
            // 
            this.editUserCitiesMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editUserCitiesMenu.FormattingEnabled = true;
            this.editUserCitiesMenu.Location = new System.Drawing.Point(207, 267);
            this.editUserCitiesMenu.Name = "editUserCitiesMenu";
            this.editUserCitiesMenu.Size = new System.Drawing.Size(131, 21);
            this.editUserCitiesMenu.TabIndex = 54;
            this.editUserCitiesMenu.SelectedIndexChanged += new System.EventHandler(this.editUserCitiesMenu_SelectedIndexChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(34, 228);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 20);
            this.lblUserName.TabIndex = 53;
            this.lblUserName.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(207, 228);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(131, 20);
            this.txtUserName.TabIndex = 52;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(34, 190);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 51;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(207, 190);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(131, 20);
            this.txtLastName.TabIndex = 50;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(34, 149);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 49;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(207, 151);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(131, 20);
            this.txtFirstName.TabIndex = 48;
            // 
            // lblEditUser
            // 
            this.lblEditUser.AutoSize = true;
            this.lblEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUser.Location = new System.Drawing.Point(34, 18);
            this.lblEditUser.Name = "lblEditUser";
            this.lblEditUser.Size = new System.Drawing.Size(84, 24);
            this.lblEditUser.TabIndex = 47;
            this.lblEditUser.Text = "Edit user";
            // 
            // lblEditUserSelect
            // 
            this.lblEditUserSelect.AutoSize = true;
            this.lblEditUserSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUserSelect.Location = new System.Drawing.Point(34, 67);
            this.lblEditUserSelect.Name = "lblEditUserSelect";
            this.lblEditUserSelect.Size = new System.Drawing.Size(43, 20);
            this.lblEditUserSelect.TabIndex = 70;
            this.lblEditUserSelect.Text = "User";
            // 
            // UsersMenu
            // 
            this.UsersMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsersMenu.FormattingEnabled = true;
            this.UsersMenu.Location = new System.Drawing.Point(207, 66);
            this.UsersMenu.Name = "UsersMenu";
            this.UsersMenu.Size = new System.Drawing.Size(261, 21);
            this.UsersMenu.TabIndex = 69;
            this.UsersMenu.SelectedIndexChanged += new System.EventHandler(this.UsersMenu_SelectedIndexChanged);
            // 
            // profileImage
            // 
            this.profileImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.profileImage.Location = new System.Drawing.Point(410, 149);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(214, 220);
            this.profileImage.TabIndex = 75;
            this.profileImage.TabStop = false;
            this.profileImage.Tag = "";
            this.profileImage.Click += new System.EventHandler(this.profileImage_Click);
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.profileImage);
            this.Controls.Add(this.lblEditUserSelect);
            this.Controls.Add(this.UsersMenu);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.editUserRoleMenu);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.editUserCitiesMenu);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblEditUser);
            this.Name = "UserEdit";
            this.Size = new System.Drawing.Size(785, 628);
            this.Load += new System.EventHandler(this.UsersEdit_LoadData);
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox editUserRoleMenu;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox editUserCitiesMenu;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblEditUser;
        private System.Windows.Forms.Label lblEditUserSelect;
        private System.Windows.Forms.ComboBox UsersMenu;
        private System.Windows.Forms.PictureBox profileImage;
    }
}
