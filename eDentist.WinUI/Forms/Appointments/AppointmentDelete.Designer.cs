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
            this.btnRemoveAppointment.BackColor = System.Drawing.Color.White;
            this.btnRemoveAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAppointment.Location = new System.Drawing.Point(250, 150);
            this.btnRemoveAppointment.Name = "btnRemoveAppointment";
            this.btnRemoveAppointment.Size = new System.Drawing.Size(216, 31);
            this.btnRemoveAppointment.TabIndex = 33;
            this.btnRemoveAppointment.Text = "Save";
            this.btnRemoveAppointment.UseVisualStyleBackColor = false;
            this.btnRemoveAppointment.Click += new System.EventHandler(this.btnRemoveAppointment_Click);
            // 
            // menuAppointments
            // 
            this.menuAppointments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAppointments.FormattingEnabled = true;
            this.menuAppointments.Location = new System.Drawing.Point(167, 97);
            this.menuAppointments.Name = "menuAppointments";
            this.menuAppointments.Size = new System.Drawing.Size(385, 32);
            this.menuAppointments.TabIndex = 32;
            this.menuAppointments.SelectedIndexChanged += new System.EventHandler(this.menuAppointments_SelectedIndexChanged);
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointment.ForeColor = System.Drawing.Color.White;
            this.lblAppointment.Location = new System.Drawing.Point(21, 100);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(128, 24);
            this.lblAppointment.TabIndex = 31;
            this.lblAppointment.Text = "Appointment";
            // 
            // lblRemoveAppointment
            // 
            this.lblRemoveAppointment.AutoSize = true;
            this.lblRemoveAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveAppointment.ForeColor = System.Drawing.Color.White;
            this.lblRemoveAppointment.Location = new System.Drawing.Point(23, 25);
            this.lblRemoveAppointment.Name = "lblRemoveAppointment";
            this.lblRemoveAppointment.Size = new System.Drawing.Size(297, 29);
            this.lblRemoveAppointment.TabIndex = 30;
            this.lblRemoveAppointment.Text = "Remove an Appointment";
            // 
            // AppointmentDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRemoveAppointment);
            this.Controls.Add(this.menuAppointments);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.lblRemoveAppointment);
            this.Name = "AppointmentDelete";
            this.Size = new System.Drawing.Size(674, 282);
            this.Load += new System.EventHandler(this.AppointmentsDelete_LoadData);
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
