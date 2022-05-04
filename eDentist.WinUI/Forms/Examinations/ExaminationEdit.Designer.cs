namespace eDentist.WinUI.Forms.Examinations
{
    partial class ExaminationEdit
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.menuDoctors = new System.Windows.Forms.ComboBox();
            this.Doctor = new System.Windows.Forms.Label();
            this.btnUpdateExamination = new System.Windows.Forms.Button();
            this.lblEditanExamination = new System.Windows.Forms.Label();
            this.existingExaminations = new System.Windows.Forms.ComboBox();
            this.Examinations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(44, 276);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 33;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(174, 279);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(158, 20);
            this.txtStatus.TabIndex = 32;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(44, 237);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 31;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(174, 240);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(158, 20);
            this.txtDescription.TabIndex = 30;
            // 
            // menuDoctors
            // 
            this.menuDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuDoctors.FormattingEnabled = true;
            this.menuDoctors.Location = new System.Drawing.Point(174, 195);
            this.menuDoctors.Name = "menuDoctors";
            this.menuDoctors.Size = new System.Drawing.Size(158, 21);
            this.menuDoctors.TabIndex = 29;
            this.menuDoctors.SelectedIndexChanged += new System.EventHandler(this.menuDoctors_SelectedIndexChanged);
            // 
            // Doctor
            // 
            this.Doctor.AutoSize = true;
            this.Doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor.Location = new System.Drawing.Point(44, 193);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(57, 20);
            this.Doctor.TabIndex = 28;
            this.Doctor.Text = "Doctor";
            // 
            // btnUpdateExamination
            // 
            this.btnUpdateExamination.Location = new System.Drawing.Point(184, 334);
            this.btnUpdateExamination.Name = "btnUpdateExamination";
            this.btnUpdateExamination.Size = new System.Drawing.Size(130, 23);
            this.btnUpdateExamination.TabIndex = 25;
            this.btnUpdateExamination.Text = "Save";
            this.btnUpdateExamination.UseVisualStyleBackColor = true;
            this.btnUpdateExamination.Click += new System.EventHandler(this.btnUpdateExamination_Click);
            // 
            // lblEditanExamination
            // 
            this.lblEditanExamination.AutoSize = true;
            this.lblEditanExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditanExamination.Location = new System.Drawing.Point(43, 34);
            this.lblEditanExamination.Name = "lblEditanExamination";
            this.lblEditanExamination.Size = new System.Drawing.Size(175, 24);
            this.lblEditanExamination.TabIndex = 24;
            this.lblEditanExamination.Text = "Edit an examination";
            // 
            // existingExaminations
            // 
            this.existingExaminations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.existingExaminations.FormattingEnabled = true;
            this.existingExaminations.Location = new System.Drawing.Point(174, 74);
            this.existingExaminations.Name = "existingExaminations";
            this.existingExaminations.Size = new System.Drawing.Size(363, 21);
            this.existingExaminations.TabIndex = 35;
            this.existingExaminations.SelectedIndexChanged += new System.EventHandler(this.existingExaminations_SelectedIndexChanged);
            // 
            // Examinations
            // 
            this.Examinations.AutoSize = true;
            this.Examinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Examinations.Location = new System.Drawing.Point(44, 75);
            this.Examinations.Name = "Examinations";
            this.Examinations.Size = new System.Drawing.Size(96, 20);
            this.Examinations.TabIndex = 34;
            this.Examinations.Text = "Examination";
            // 
            // ExaminationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.existingExaminations);
            this.Controls.Add(this.Examinations);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.menuDoctors);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.btnUpdateExamination);
            this.Controls.Add(this.lblEditanExamination);
            this.Name = "ExaminationEdit";
            this.Size = new System.Drawing.Size(601, 496);
            this.Load += new System.EventHandler(this.ExaminationsEdit_LoadData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox menuDoctors;
        private System.Windows.Forms.Label Doctor;
        private System.Windows.Forms.Button btnUpdateExamination;
        private System.Windows.Forms.Label lblEditanExamination;
        private System.Windows.Forms.ComboBox existingExaminations;
        private System.Windows.Forms.Label Examinations;
    }
}
