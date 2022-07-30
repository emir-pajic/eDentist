namespace eDentist.WinUI.Forms.Appointments
{
    partial class AppointmentAdd
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
            this.lblAddNewAppointment = new System.Windows.Forms.Label();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.addAppointmentUserMenu = new System.Windows.Forms.ComboBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddNewAppointment
            // 
            this.lblAddNewAppointment.AutoSize = true;
            this.lblAddNewAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewAppointment.ForeColor = System.Drawing.Color.Coral;
            this.lblAddNewAppointment.Location = new System.Drawing.Point(36, 40);
            this.lblAddNewAppointment.Name = "lblAddNewAppointment";
            this.lblAddNewAppointment.Size = new System.Drawing.Size(267, 29);
            this.lblAddNewAppointment.TabIndex = 25;
            this.lblAddNewAppointment.Text = "Add new Appointment";
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointment.ForeColor = System.Drawing.Color.Coral;
            this.lblAppointment.Location = new System.Drawing.Point(57, 142);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(128, 24);
            this.lblAppointment.TabIndex = 37;
            this.lblAppointment.Text = "Appointment";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointment.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointment.Location = new System.Drawing.Point(212, 144);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(198, 26);
            this.dtpAppointment.TabIndex = 36;
            // 
            // addAppointmentUserMenu
            // 
            this.addAppointmentUserMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addAppointmentUserMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentUserMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addAppointmentUserMenu.FormattingEnabled = true;
            this.addAppointmentUserMenu.Location = new System.Drawing.Point(212, 183);
            this.addAppointmentUserMenu.Name = "addAppointmentUserMenu";
            this.addAppointmentUserMenu.Size = new System.Drawing.Size(198, 32);
            this.addAppointmentUserMenu.TabIndex = 38;
            this.addAppointmentUserMenu.SelectedIndexChanged += new System.EventHandler(this.addAppointmentUserMenu_SelectedIndexChanged);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.ForeColor = System.Drawing.Color.Coral;
            this.lblPatient.Location = new System.Drawing.Point(57, 179);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(73, 24);
            this.lblPatient.TabIndex = 39;
            this.lblPatient.Text = "Patient";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.Coral;
            this.btnAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAppointment.Location = new System.Drawing.Point(248, 233);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(130, 34);
            this.btnAddAppointment.TabIndex = 45;
            this.btnAddAppointment.Text = "Save";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // AppointmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.addAppointmentUserMenu);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.dtpAppointment);
            this.Controls.Add(this.lblAddNewAppointment);
            this.Name = "AppointmentAdd";
            this.Size = new System.Drawing.Size(574, 469);
            this.Load += new System.EventHandler(this.AppointmentAdd_LoadData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewAppointment;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.ComboBox addAppointmentUserMenu;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Button btnAddAppointment;
    }
}
