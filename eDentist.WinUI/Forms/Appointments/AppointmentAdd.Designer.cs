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
            // AppointmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAddNewAppointment);
            this.Name = "AppointmentAdd";
            this.Size = new System.Drawing.Size(362, 387);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewAppointment;
    }
}
