namespace eDentist.WinUI.Forms.Appointments
{
    partial class AppointmentAddPatient
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
            this.btnAddAppointmentPatient = new System.Windows.Forms.Button();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.dtpAppointmentPatient = new System.Windows.Forms.DateTimePicker();
            this.lblAddNewAppointment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAppointmentPatient
            // 
            this.btnAddAppointmentPatient.BackColor = System.Drawing.Color.White;
            this.btnAddAppointmentPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddAppointmentPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAppointmentPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointmentPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointmentPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAppointmentPatient.Location = new System.Drawing.Point(303, 202);
            this.btnAddAppointmentPatient.Name = "btnAddAppointmentPatient";
            this.btnAddAppointmentPatient.Size = new System.Drawing.Size(130, 34);
            this.btnAddAppointmentPatient.TabIndex = 51;
            this.btnAddAppointmentPatient.Text = "Save";
            this.btnAddAppointmentPatient.UseVisualStyleBackColor = false;
            this.btnAddAppointmentPatient.Click += new System.EventHandler(this.btnAddAppointmentPatient_Click);
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointment.ForeColor = System.Drawing.Color.White;
            this.lblAppointment.Location = new System.Drawing.Point(86, 149);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(128, 24);
            this.lblAppointment.TabIndex = 48;
            this.lblAppointment.Text = "Appointment";
            // 
            // dtpAppointmentPatient
            // 
            this.dtpAppointmentPatient.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentPatient.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpAppointmentPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentPatient.Location = new System.Drawing.Point(241, 149);
            this.dtpAppointmentPatient.Name = "dtpAppointmentPatient";
            this.dtpAppointmentPatient.Size = new System.Drawing.Size(281, 26);
            this.dtpAppointmentPatient.TabIndex = 47;
            // 
            // lblAddNewAppointment
            // 
            this.lblAddNewAppointment.AutoSize = true;
            this.lblAddNewAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewAppointment.ForeColor = System.Drawing.Color.White;
            this.lblAddNewAppointment.Location = new System.Drawing.Point(65, 47);
            this.lblAddNewAppointment.Name = "lblAddNewAppointment";
            this.lblAddNewAppointment.Size = new System.Drawing.Size(267, 29);
            this.lblAddNewAppointment.TabIndex = 46;
            this.lblAddNewAppointment.Text = "Add new Appointment";
            // 
            // AppointmentAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAddAppointmentPatient);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.dtpAppointmentPatient);
            this.Controls.Add(this.lblAddNewAppointment);
            this.Name = "AppointmentAddPatient";
            this.Size = new System.Drawing.Size(675, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAppointmentPatient;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.DateTimePicker dtpAppointmentPatient;
        private System.Windows.Forms.Label lblAddNewAppointment;
    }
}
