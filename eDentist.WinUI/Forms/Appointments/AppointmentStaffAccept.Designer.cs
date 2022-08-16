namespace eDentist.WinUI.Forms.Appointments
{
    partial class AppointmentStaffAccept
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
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.btnAcceptAppointment = new System.Windows.Forms.Button();
            this.acceptAppointmentUserMenu = new System.Windows.Forms.ComboBox();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.lblAcceptApp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPatient
            // 
            this.txtPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPatient.Location = new System.Drawing.Point(267, 185);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.ReadOnly = true;
            this.txtPatient.Size = new System.Drawing.Size(317, 29);
            this.txtPatient.TabIndex = 66;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.ForeColor = System.Drawing.Color.White;
            this.lblPatient.Location = new System.Drawing.Point(82, 190);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(73, 24);
            this.lblPatient.TabIndex = 63;
            this.lblPatient.Text = "Patient";
            // 
            // btnAcceptAppointment
            // 
            this.btnAcceptAppointment.BackColor = System.Drawing.Color.White;
            this.btnAcceptAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceptAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptAppointment.Location = new System.Drawing.Point(267, 248);
            this.btnAcceptAppointment.Name = "btnAcceptAppointment";
            this.btnAcceptAppointment.Size = new System.Drawing.Size(317, 32);
            this.btnAcceptAppointment.TabIndex = 62;
            this.btnAcceptAppointment.Text = "Save";
            this.btnAcceptAppointment.UseVisualStyleBackColor = false;
            this.btnAcceptAppointment.Click += new System.EventHandler(this.btnAcceptAppointment_Click);
            // 
            // acceptAppointmentUserMenu
            // 
            this.acceptAppointmentUserMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acceptAppointmentUserMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptAppointmentUserMenu.FormattingEnabled = true;
            this.acceptAppointmentUserMenu.Location = new System.Drawing.Point(267, 131);
            this.acceptAppointmentUserMenu.Name = "acceptAppointmentUserMenu";
            this.acceptAppointmentUserMenu.Size = new System.Drawing.Size(317, 32);
            this.acceptAppointmentUserMenu.TabIndex = 60;
            this.acceptAppointmentUserMenu.SelectedIndexChanged += new System.EventHandler(this.acceptAppointmentUserMenu_SelectedIndexChanged_1);
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointment.ForeColor = System.Drawing.Color.White;
            this.lblAppointment.Location = new System.Drawing.Point(81, 126);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(128, 24);
            this.lblAppointment.TabIndex = 59;
            this.lblAppointment.Text = "Appointment";
            // 
            // lblAcceptApp
            // 
            this.lblAcceptApp.AutoSize = true;
            this.lblAcceptApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceptApp.ForeColor = System.Drawing.Color.White;
            this.lblAcceptApp.Location = new System.Drawing.Point(81, 36);
            this.lblAcceptApp.Name = "lblAcceptApp";
            this.lblAcceptApp.Size = new System.Drawing.Size(278, 29);
            this.lblAcceptApp.TabIndex = 57;
            this.lblAcceptApp.Text = "Accept an appointment";
            // 
            // AppointmentStaffAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.btnAcceptAppointment);
            this.Controls.Add(this.acceptAppointmentUserMenu);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.lblAcceptApp);
            this.Name = "AppointmentStaffAccept";
            this.Size = new System.Drawing.Size(1015, 484);
            this.Load += new System.EventHandler(this.AppointmentStaffAccept_LoadData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Button btnAcceptAppointment;
        private System.Windows.Forms.ComboBox acceptAppointmentUserMenu;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.Label lblAcceptApp;
    }
}
