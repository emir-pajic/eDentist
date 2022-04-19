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
            this.lblAddNewAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewAppointment.Location = new System.Drawing.Point(36, 40);
            this.lblAddNewAppointment.Name = "lblAddNewAppointment";
            this.lblAddNewAppointment.Size = new System.Drawing.Size(198, 24);
            this.lblAddNewAppointment.TabIndex = 25;
            this.lblAddNewAppointment.Text = "Add new Appointment";
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointment.Location = new System.Drawing.Point(21, 90);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(100, 20);
            this.lblAppointment.TabIndex = 37;
            this.lblAppointment.Text = "Appointment";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.Location = new System.Drawing.Point(136, 90);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(131, 20);
            this.dtpAppointment.TabIndex = 36;
            // 
            // addAppointmentUserMenu
            // 
            this.addAppointmentUserMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addAppointmentUserMenu.FormattingEnabled = true;
            this.addAppointmentUserMenu.Location = new System.Drawing.Point(136, 129);
            this.addAppointmentUserMenu.Name = "addAppointmentUserMenu";
            this.addAppointmentUserMenu.Size = new System.Drawing.Size(131, 21);
            this.addAppointmentUserMenu.TabIndex = 38;
            this.addAppointmentUserMenu.SelectedIndexChanged += new System.EventHandler(this.addAppointmentUserMenu_SelectedIndexChanged);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.Location = new System.Drawing.Point(21, 127);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(59, 20);
            this.lblPatient.TabIndex = 39;
            this.lblPatient.Text = "Patient";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(136, 182);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(130, 23);
            this.btnAddAppointment.TabIndex = 45;
            this.btnAddAppointment.Text = "Save";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // AppointmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.addAppointmentUserMenu);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.dtpAppointment);
            this.Controls.Add(this.lblAddNewAppointment);
            this.Name = "AppointmentAdd";
            this.Size = new System.Drawing.Size(362, 387);
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
