namespace eDentist.WinUI.Forms.Examinations
{
    partial class ExaminationsListStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExaminationsListStaff));
            this.dgvExaminationsStaff = new System.Windows.Forms.DataGridView();
            this.ExaminationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Treatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.App = new System.Windows.Forms.Label();
            this.txtSearchStaff = new System.Windows.Forms.TextBox();
            this.btnAddExaminationStaff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExaminationsStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExaminationsStaff
            // 
            this.dgvExaminationsStaff.AllowUserToAddRows = false;
            this.dgvExaminationsStaff.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvExaminationsStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExaminationsStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvExaminationsStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExaminationsStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExaminationsStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExaminationsStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExaminationsStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExaminationsStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExaminationID,
            this.Description,
            this.AppointmentDate,
            this.Patient,
            this.Treatment,
            this.Status});
            this.dgvExaminationsStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExaminationsStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExaminationsStaff.Location = new System.Drawing.Point(18, 183);
            this.dgvExaminationsStaff.Name = "dgvExaminationsStaff";
            this.dgvExaminationsStaff.ReadOnly = true;
            this.dgvExaminationsStaff.RowHeadersVisible = false;
            this.dgvExaminationsStaff.Size = new System.Drawing.Size(869, 247);
            this.dgvExaminationsStaff.TabIndex = 73;
            // 
            // ExaminationID
            // 
            this.ExaminationID.DataPropertyName = "ExaminationID";
            this.ExaminationID.HeaderText = "ExaminationID";
            this.ExaminationID.Name = "ExaminationID";
            this.ExaminationID.ReadOnly = true;
            this.ExaminationID.Visible = false;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppointmentDate.DataPropertyName = "AppointmentDate";
            this.AppointmentDate.HeaderText = "Date";
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.ReadOnly = true;
            // 
            // Patient
            // 
            this.Patient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Patient.DataPropertyName = "Patient";
            this.Patient.HeaderText = "Patient";
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            // 
            // Treatment
            // 
            this.Treatment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Treatment.DataPropertyName = "Treatment";
            this.Treatment.HeaderText = "Treatment";
            this.Treatment.Name = "Treatment";
            this.Treatment.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // App
            // 
            this.App.AutoSize = true;
            this.App.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App.ForeColor = System.Drawing.Color.White;
            this.App.Location = new System.Drawing.Point(13, 48);
            this.App.Name = "App";
            this.App.Size = new System.Drawing.Size(208, 29);
            this.App.TabIndex = 72;
            this.App.Text = "My Examinations";
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStaff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSearchStaff.Location = new System.Drawing.Point(18, 125);
            this.txtSearchStaff.Multiline = true;
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(330, 33);
            this.txtSearchStaff.TabIndex = 71;
            this.txtSearchStaff.Text = "Enter Description";
            this.txtSearchStaff.TextChanged += new System.EventHandler(this.txtSearchStaff_TextChanged);
            // 
            // btnAddExaminationStaff
            // 
            this.btnAddExaminationStaff.BackColor = System.Drawing.Color.White;
            this.btnAddExaminationStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddExaminationStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExaminationStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnAddExaminationStaff.Image")));
            this.btnAddExaminationStaff.Location = new System.Drawing.Point(846, 125);
            this.btnAddExaminationStaff.Name = "btnAddExaminationStaff";
            this.btnAddExaminationStaff.Size = new System.Drawing.Size(41, 37);
            this.btnAddExaminationStaff.TabIndex = 74;
            this.btnAddExaminationStaff.UseVisualStyleBackColor = false;
            this.btnAddExaminationStaff.Click += new System.EventHandler(this.btnAddExaminationStaff_Click);
            // 
            // ExaminationsListStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAddExaminationStaff);
            this.Controls.Add(this.dgvExaminationsStaff);
            this.Controls.Add(this.App);
            this.Controls.Add(this.txtSearchStaff);
            this.Name = "ExaminationsListStaff";
            this.Size = new System.Drawing.Size(1071, 598);
            this.Load += new System.EventHandler(this.ExaminationListStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExaminationsStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExaminationsStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExaminationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Treatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label App;
        private System.Windows.Forms.TextBox txtSearchStaff;
        private System.Windows.Forms.Button btnAddExaminationStaff;
    }
}
