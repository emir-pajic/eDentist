
namespace eDentist.WinUI.Forms.Examinations
{
    partial class ExaminationsAdd
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
            this.Doctor = new System.Windows.Forms.Label();
            this.menuAppointments = new System.Windows.Forms.ComboBox();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.btnaddCity = new System.Windows.Forms.Button();
            this.lvlAddExamination = new System.Windows.Forms.Label();
            this.menuDoctors = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Doctor
            // 
            this.Doctor.AutoSize = true;
            this.Doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor.Location = new System.Drawing.Point(32, 128);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(57, 20);
            this.Doctor.TabIndex = 18;
            this.Doctor.Text = "Doctor";
            // 
            // menuAppointments
            // 
            this.menuAppointments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuAppointments.FormattingEnabled = true;
            this.menuAppointments.Location = new System.Drawing.Point(162, 86);
            this.menuAppointments.Name = "menuAppointments";
            this.menuAppointments.Size = new System.Drawing.Size(158, 21);
            this.menuAppointments.TabIndex = 16;
            this.menuAppointments.SelectedIndexChanged += new System.EventHandler(this.menuAppointments_SelectedIndexChanged);
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointment.Location = new System.Drawing.Point(32, 87);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(100, 20);
            this.lblAppointment.TabIndex = 15;
            this.lblAppointment.Text = "Appointment";
            // 
            // btnaddCity
            // 
            this.btnaddCity.Location = new System.Drawing.Point(172, 269);
            this.btnaddCity.Name = "btnaddCity";
            this.btnaddCity.Size = new System.Drawing.Size(130, 23);
            this.btnaddCity.TabIndex = 14;
            this.btnaddCity.Text = "Save";
            this.btnaddCity.UseVisualStyleBackColor = true;
            this.btnaddCity.Click += new System.EventHandler(this.btnaddCity_Click);
            // 
            // lvlAddExamination
            // 
            this.lvlAddExamination.AutoSize = true;
            this.lvlAddExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAddExamination.Location = new System.Drawing.Point(32, 33);
            this.lvlAddExamination.Name = "lvlAddExamination";
            this.lvlAddExamination.Size = new System.Drawing.Size(178, 24);
            this.lvlAddExamination.TabIndex = 12;
            this.lvlAddExamination.Text = "Add an examination";
            // 
            // menuDoctors
            // 
            this.menuDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuDoctors.FormattingEnabled = true;
            this.menuDoctors.Location = new System.Drawing.Point(162, 130);
            this.menuDoctors.Name = "menuDoctors";
            this.menuDoctors.Size = new System.Drawing.Size(158, 21);
            this.menuDoctors.TabIndex = 19;
            this.menuDoctors.SelectedIndexChanged += new System.EventHandler(this.menuDoctors_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(32, 172);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(162, 175);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(158, 20);
            this.txtDescription.TabIndex = 20;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(32, 211);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(162, 214);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(158, 20);
            this.txtStatus.TabIndex = 22;
            // 
            // ExaminationsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.menuDoctors);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.menuAppointments);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.btnaddCity);
            this.Controls.Add(this.lvlAddExamination);
            this.Name = "ExaminationsAdd";
            this.Size = new System.Drawing.Size(547, 465);
            this.Load += new System.EventHandler(this.ExaminationsAdd_LoadData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Doctor;
        private System.Windows.Forms.ComboBox menuAppointments;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.Button btnaddCity;
        private System.Windows.Forms.Label lvlAddExamination;
        private System.Windows.Forms.ComboBox menuDoctors;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
    }
}
