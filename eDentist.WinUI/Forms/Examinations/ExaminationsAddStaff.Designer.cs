namespace eDentist.WinUI.Forms.Examinations
{
    partial class ExaminationsAddStaff
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
            this.treatmentsMenuStaff = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatusStaff = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescriptionStaff = new System.Windows.Forms.TextBox();
            this.menuAppointmentsStaff = new System.Windows.Forms.ComboBox();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.btnaddExamination = new System.Windows.Forms.Button();
            this.lvlAddExamination = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treatmentsMenuStaff
            // 
            this.treatmentsMenuStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.treatmentsMenuStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentsMenuStaff.FormattingEnabled = true;
            this.treatmentsMenuStaff.Location = new System.Drawing.Point(225, 146);
            this.treatmentsMenuStaff.Name = "treatmentsMenuStaff";
            this.treatmentsMenuStaff.Size = new System.Drawing.Size(232, 32);
            this.treatmentsMenuStaff.TabIndex = 37;
            this.treatmentsMenuStaff.SelectedIndexChanged += new System.EventHandler(this.treatmentsMenuStaff_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Treatment";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(74, 227);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 24);
            this.lblStatus.TabIndex = 35;
            this.lblStatus.Text = "Status";
            // 
            // txtStatusStaff
            // 
            this.txtStatusStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusStaff.Location = new System.Drawing.Point(224, 231);
            this.txtStatusStaff.Name = "txtStatusStaff";
            this.txtStatusStaff.Size = new System.Drawing.Size(232, 29);
            this.txtStatusStaff.TabIndex = 34;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(74, 188);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 24);
            this.lblDescription.TabIndex = 33;
            this.lblDescription.Text = "Description";
            // 
            // txtDescriptionStaff
            // 
            this.txtDescriptionStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionStaff.Location = new System.Drawing.Point(224, 192);
            this.txtDescriptionStaff.Name = "txtDescriptionStaff";
            this.txtDescriptionStaff.Size = new System.Drawing.Size(232, 29);
            this.txtDescriptionStaff.TabIndex = 32;
            // 
            // menuAppointmentsStaff
            // 
            this.menuAppointmentsStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuAppointmentsStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAppointmentsStaff.FormattingEnabled = true;
            this.menuAppointmentsStaff.Location = new System.Drawing.Point(224, 101);
            this.menuAppointmentsStaff.Name = "menuAppointmentsStaff";
            this.menuAppointmentsStaff.Size = new System.Drawing.Size(232, 32);
            this.menuAppointmentsStaff.TabIndex = 29;
            this.menuAppointmentsStaff.SelectedIndexChanged += new System.EventHandler(this.menuAppointmentsStaff_SelectedIndexChanged);
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointment.ForeColor = System.Drawing.Color.White;
            this.lblAppointment.Location = new System.Drawing.Point(74, 101);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(128, 24);
            this.lblAppointment.TabIndex = 28;
            this.lblAppointment.Text = "Appointment";
            // 
            // btnaddExamination
            // 
            this.btnaddExamination.BackColor = System.Drawing.Color.White;
            this.btnaddExamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddExamination.Location = new System.Drawing.Point(280, 280);
            this.btnaddExamination.Name = "btnaddExamination";
            this.btnaddExamination.Size = new System.Drawing.Size(130, 32);
            this.btnaddExamination.TabIndex = 27;
            this.btnaddExamination.Text = "Save";
            this.btnaddExamination.UseVisualStyleBackColor = false;
            this.btnaddExamination.Click += new System.EventHandler(this.btnaddExamination_Click);
            // 
            // lvlAddExamination
            // 
            this.lvlAddExamination.AutoSize = true;
            this.lvlAddExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAddExamination.ForeColor = System.Drawing.Color.White;
            this.lvlAddExamination.Location = new System.Drawing.Point(74, 47);
            this.lvlAddExamination.Name = "lvlAddExamination";
            this.lvlAddExamination.Size = new System.Drawing.Size(241, 29);
            this.lvlAddExamination.TabIndex = 26;
            this.lvlAddExamination.Text = "Add an examination";
            // 
            // ExaminationsAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.treatmentsMenuStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatusStaff);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescriptionStaff);
            this.Controls.Add(this.menuAppointmentsStaff);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.btnaddExamination);
            this.Controls.Add(this.lvlAddExamination);
            this.Name = "ExaminationsAddStaff";
            this.Size = new System.Drawing.Size(641, 462);
            this.Load += new System.EventHandler(this.ExaminationsAddStaff_LoadData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox treatmentsMenuStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatusStaff;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescriptionStaff;
        private System.Windows.Forms.ComboBox menuAppointmentsStaff;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.Button btnaddExamination;
        private System.Windows.Forms.Label lvlAddExamination;
    }
}
