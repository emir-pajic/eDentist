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
            this.panel3 = new System.Windows.Forms.Panel();
            this.treatmentsMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(44, 338);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 24);
            this.lblStatus.TabIndex = 33;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(174, 341);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(530, 29);
            this.txtStatus.TabIndex = 32;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(44, 299);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 24);
            this.lblDescription.TabIndex = 31;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(174, 302);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(530, 29);
            this.txtDescription.TabIndex = 30;
            // 
            // menuDoctors
            // 
            this.menuDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDoctors.FormattingEnabled = true;
            this.menuDoctors.Location = new System.Drawing.Point(174, 195);
            this.menuDoctors.Name = "menuDoctors";
            this.menuDoctors.Size = new System.Drawing.Size(530, 32);
            this.menuDoctors.TabIndex = 29;
            this.menuDoctors.SelectedIndexChanged += new System.EventHandler(this.menuDoctors_SelectedIndexChanged);
            // 
            // Doctor
            // 
            this.Doctor.AutoSize = true;
            this.Doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor.ForeColor = System.Drawing.Color.White;
            this.Doctor.Location = new System.Drawing.Point(44, 193);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(71, 24);
            this.Doctor.TabIndex = 28;
            this.Doctor.Text = "Doctor";
            // 
            // btnUpdateExamination
            // 
            this.btnUpdateExamination.BackColor = System.Drawing.Color.White;
            this.btnUpdateExamination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateExamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateExamination.Location = new System.Drawing.Point(174, 396);
            this.btnUpdateExamination.Name = "btnUpdateExamination";
            this.btnUpdateExamination.Size = new System.Drawing.Size(530, 28);
            this.btnUpdateExamination.TabIndex = 25;
            this.btnUpdateExamination.Text = "Save";
            this.btnUpdateExamination.UseVisualStyleBackColor = false;
            this.btnUpdateExamination.Click += new System.EventHandler(this.btnUpdateExamination_Click);
            // 
            // lblEditanExamination
            // 
            this.lblEditanExamination.AutoSize = true;
            this.lblEditanExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditanExamination.ForeColor = System.Drawing.Color.White;
            this.lblEditanExamination.Location = new System.Drawing.Point(43, 34);
            this.lblEditanExamination.Name = "lblEditanExamination";
            this.lblEditanExamination.Size = new System.Drawing.Size(241, 29);
            this.lblEditanExamination.TabIndex = 24;
            this.lblEditanExamination.Text = "Edit an examination";
            // 
            // existingExaminations
            // 
            this.existingExaminations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.existingExaminations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingExaminations.FormattingEnabled = true;
            this.existingExaminations.Location = new System.Drawing.Point(174, 74);
            this.existingExaminations.Name = "existingExaminations";
            this.existingExaminations.Size = new System.Drawing.Size(530, 32);
            this.existingExaminations.TabIndex = 35;
            this.existingExaminations.SelectedIndexChanged += new System.EventHandler(this.existingExaminations_SelectedIndexChanged);
            // 
            // Examinations
            // 
            this.Examinations.AutoSize = true;
            this.Examinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Examinations.ForeColor = System.Drawing.Color.White;
            this.Examinations.Location = new System.Drawing.Point(44, 75);
            this.Examinations.Name = "Examinations";
            this.Examinations.Size = new System.Drawing.Size(125, 24);
            this.Examinations.TabIndex = 34;
            this.Examinations.Text = "Examination";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(-42, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 10);
            this.panel3.TabIndex = 56;
            // 
            // treatmentsMenu
            // 
            this.treatmentsMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.treatmentsMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentsMenu.FormattingEnabled = true;
            this.treatmentsMenu.Location = new System.Drawing.Point(175, 249);
            this.treatmentsMenu.Name = "treatmentsMenu";
            this.treatmentsMenu.Size = new System.Drawing.Size(530, 32);
            this.treatmentsMenu.TabIndex = 58;
            this.treatmentsMenu.SelectedIndexChanged += new System.EventHandler(this.treatmentsMenu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "Treatment";
            // 
            // ExaminationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.treatmentsMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
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
            this.Size = new System.Drawing.Size(891, 559);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox treatmentsMenu;
        private System.Windows.Forms.Label label1;
    }
}
