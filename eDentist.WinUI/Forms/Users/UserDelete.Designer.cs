namespace eDentist.WinUI.Forms.Users
{
    partial class UserDelete
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
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.menuUsers = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblRemoveUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.Color.White;
            this.btnRemoveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.Location = new System.Drawing.Point(134, 207);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(293, 32);
            this.btnRemoveUser.TabIndex = 37;
            this.btnRemoveUser.Text = "Save";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // menuUsers
            // 
            this.menuUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUsers.FormattingEnabled = true;
            this.menuUsers.Location = new System.Drawing.Point(134, 122);
            this.menuUsers.Name = "menuUsers";
            this.menuUsers.Size = new System.Drawing.Size(293, 32);
            this.menuUsers.TabIndex = 36;
            this.menuUsers.SelectedIndexChanged += new System.EventHandler(this.menuUsers_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(24, 130);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 24);
            this.lblUser.TabIndex = 35;
            this.lblUser.Text = "User";
            // 
            // lblRemoveUser
            // 
            this.lblRemoveUser.AutoSize = true;
            this.lblRemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveUser.ForeColor = System.Drawing.Color.White;
            this.lblRemoveUser.Location = new System.Drawing.Point(24, 35);
            this.lblRemoveUser.Name = "lblRemoveUser";
            this.lblRemoveUser.Size = new System.Drawing.Size(202, 29);
            this.lblRemoveUser.TabIndex = 34;
            this.lblRemoveUser.Text = "Remove an user";
            // 
            // UserDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.menuUsers);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblRemoveUser);
            this.Name = "UserDelete";
            this.Size = new System.Drawing.Size(516, 417);
            this.Load += new System.EventHandler(this.UserDelete_LoadData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.ComboBox menuUsers;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblRemoveUser;
    }
}
