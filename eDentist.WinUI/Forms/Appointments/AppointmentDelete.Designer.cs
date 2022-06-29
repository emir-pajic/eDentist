namespace eDentist.WinUI.Forms.Appointments
{
    partial class AppointmentDelete
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
            this.btnRemoveAppointment = new System.Windows.Forms.Button();
            this.menuAppointments = new System.Windows.Forms.ComboBox();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.lblRemoveAppointment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveAppointment
            // 
            this.btnRemoveAppointment.Location = new System.Drawing.Point(133, 156);
            this.btnRemoveAppointment.Name = "btnRemoveAppointment";
            this.btnRemoveAppointment.Size = new System.Drawing.Size(130, 23);
            this.btnRemoveAppointment.TabIndex = 33;
            this.btnRemoveAppointment.Text = "Save";
            this.btnRemoveAppointment.UseVisualStyleBackColor = true;
            // 
            // menuAppointments
            // 
            this.menuAppointments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuAppointments.FormattingEnabled = true;
            this.menuAppointments.Location = new System.Drawing.Point(133, 81);
            this.menuAppointments.Name = "menuAppointments";
            this.menuAppointments.Size = new System.Drawing.Size(293, 21);
            this.menuAppointments.TabIndex = 32;
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointment.Location = new System.Drawing.Point(23, 79);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(100, 20);
            this.lblAppointment.TabIndex = 31;
            this.lblAppointment.Text = "Appointment";
            // 
            // lblRemoveAppointment
            // 
            this.lblRemoveAppointment.AutoSize = true;
            this.lblRemoveAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveAppointment.Location = new System.Drawing.Point(23, 25);
            this.lblRemoveAppointment.Name = "lblRemoveAppointment";
            this.lblRemoveAppointment.Size = new System.Drawing.Size(219, 24);
            this.lblRemoveAppointment.TabIndex = 30;
            this.lblRemoveAppointment.Text = "Remove an Appointment";
            // 
            // AppointmentDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveAppointment);
            this.Controls.Add(this.menuAppointments);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.lblRemoveAppointment);
            this.Name = "AppointmentDelete";
            this.Size = new System.Drawing.Size(499, 282);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveAppointment;
        private System.Windows.Forms.ComboBox menuAppointments;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.Label lblRemoveAppointment;
    }
}
