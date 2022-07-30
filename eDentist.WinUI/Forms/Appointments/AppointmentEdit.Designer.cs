namespace eDentist.WinUI.Forms.Appointments
{
    partial class AppointmentEdit
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
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.editAppointmentUserMenu = new System.Windows.Forms.ComboBox();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.lblEditanAppointment = new System.Windows.Forms.Label();
            this.menuPatients = new System.Windows.Forms.ComboBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.White;
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.Location = new System.Drawing.Point(208, 309);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(317, 32);
            this.btnAddAppointment.TabIndex = 51;
            this.btnAddAppointment.Text = "Save";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(22, 211);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 24);
            this.lblDate.TabIndex = 50;
            this.lblDate.Text = "Date";
            // 
            // editAppointmentUserMenu
            // 
            this.editAppointmentUserMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editAppointmentUserMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAppointmentUserMenu.FormattingEnabled = true;
            this.editAppointmentUserMenu.Location = new System.Drawing.Point(208, 116);
            this.editAppointmentUserMenu.Name = "editAppointmentUserMenu";
            this.editAppointmentUserMenu.Size = new System.Drawing.Size(317, 32);
            this.editAppointmentUserMenu.TabIndex = 49;
            this.editAppointmentUserMenu.SelectedIndexChanged += new System.EventHandler(this.editAppointmentUserMenu_SelectedIndexChanged);
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointment.ForeColor = System.Drawing.Color.White;
            this.lblAppointment.Location = new System.Drawing.Point(22, 111);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(128, 24);
            this.lblAppointment.TabIndex = 48;
            this.lblAppointment.Text = "Appointment";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointment.Location = new System.Drawing.Point(208, 217);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(317, 29);
            this.dtpAppointment.TabIndex = 47;
            // 
            // lblEditanAppointment
            // 
            this.lblEditanAppointment.AutoSize = true;
            this.lblEditanAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditanAppointment.ForeColor = System.Drawing.Color.White;
            this.lblEditanAppointment.Location = new System.Drawing.Point(22, 21);
            this.lblEditanAppointment.Name = "lblEditanAppointment";
            this.lblEditanAppointment.Size = new System.Drawing.Size(245, 29);
            this.lblEditanAppointment.TabIndex = 46;
            this.lblEditanAppointment.Text = "Edit an appointment";
            // 
            // menuPatients
            // 
            this.menuPatients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPatients.FormattingEnabled = true;
            this.menuPatients.Location = new System.Drawing.Point(208, 261);
            this.menuPatients.Name = "menuPatients";
            this.menuPatients.Size = new System.Drawing.Size(317, 32);
            this.menuPatients.TabIndex = 53;
            this.menuPatients.SelectedIndexChanged += new System.EventHandler(this.menuPatients_SelectedIndexChanged);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.ForeColor = System.Drawing.Color.White;
            this.lblPatient.Location = new System.Drawing.Point(22, 256);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(73, 24);
            this.lblPatient.TabIndex = 52;
            this.lblPatient.Text = "Patient";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 10);
            this.panel3.TabIndex = 54;
            // 
            // AppointmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuPatients);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.editAppointmentUserMenu);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.dtpAppointment);
            this.Controls.Add(this.lblEditanAppointment);
            this.Name = "AppointmentEdit";
            this.Size = new System.Drawing.Size(594, 453);
            this.Load += new System.EventHandler(this.AppointmentEdit_LoadData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox editAppointmentUserMenu;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Label lblEditanAppointment;
        private System.Windows.Forms.ComboBox menuPatients;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Panel panel3;
    }
}
