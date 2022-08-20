namespace eDentist.WinUI.Forms.Appointments
{
    partial class AppointmentListStaffMy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAppointmentsStaffMy = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.App = new System.Windows.Forms.Label();
            this.txtSearchMyApp = new System.Windows.Forms.TextBox();
            this.btnAppointmentSummaries = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsStaffMy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppointmentsStaffMy
            // 
            this.dgvAppointmentsStaffMy.AllowUserToAddRows = false;
            this.dgvAppointmentsStaffMy.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAppointmentsStaffMy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAppointmentsStaffMy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvAppointmentsStaffMy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointmentsStaffMy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppointmentsStaffMy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointmentsStaffMy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAppointmentsStaffMy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentsStaffMy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.FirstName,
            this.LastName});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointmentsStaffMy.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAppointmentsStaffMy.Location = new System.Drawing.Point(80, 227);
            this.dgvAppointmentsStaffMy.Name = "dgvAppointmentsStaffMy";
            this.dgvAppointmentsStaffMy.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointmentsStaffMy.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAppointmentsStaffMy.RowHeadersVisible = false;
            this.dgvAppointmentsStaffMy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointmentsStaffMy.Size = new System.Drawing.Size(671, 257);
            this.dgvAppointmentsStaffMy.TabIndex = 70;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // App
            // 
            this.App.AutoSize = true;
            this.App.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App.ForeColor = System.Drawing.Color.White;
            this.App.Location = new System.Drawing.Point(75, 62);
            this.App.Name = "App";
            this.App.Size = new System.Drawing.Size(212, 29);
            this.App.TabIndex = 69;
            this.App.Text = "My Appointments";
            // 
            // txtSearchMyApp
            // 
            this.txtSearchMyApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMyApp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSearchMyApp.Location = new System.Drawing.Point(80, 162);
            this.txtSearchMyApp.Multiline = true;
            this.txtSearchMyApp.Name = "txtSearchMyApp";
            this.txtSearchMyApp.Size = new System.Drawing.Size(275, 33);
            this.txtSearchMyApp.TabIndex = 68;
            this.txtSearchMyApp.Text = "Enter Date";
            this.txtSearchMyApp.TextChanged += new System.EventHandler(this.txtSearchMyApp_TextChanged);
            // 
            // btnAppointmentSummaries
            // 
            this.btnAppointmentSummaries.BackColor = System.Drawing.Color.White;
            this.btnAppointmentSummaries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAppointmentSummaries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointmentSummaries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentSummaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentSummaries.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAppointmentSummaries.Location = new System.Drawing.Point(425, 161);
            this.btnAppointmentSummaries.Name = "btnAppointmentSummaries";
            this.btnAppointmentSummaries.Size = new System.Drawing.Size(326, 34);
            this.btnAppointmentSummaries.TabIndex = 71;
            this.btnAppointmentSummaries.Text = "Appointment summaries";
            this.btnAppointmentSummaries.UseVisualStyleBackColor = false;
            this.btnAppointmentSummaries.Click += new System.EventHandler(this.btnAppointmentSummaries_Click);
            // 
            // AppointmentListStaffMy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAppointmentSummaries);
            this.Controls.Add(this.dgvAppointmentsStaffMy);
            this.Controls.Add(this.App);
            this.Controls.Add(this.txtSearchMyApp);
            this.Name = "AppointmentListStaffMy";
            this.Size = new System.Drawing.Size(907, 638);
            this.Load += new System.EventHandler(this.AppointmentsListStaffMy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsStaffMy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppointmentsStaffMy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.Label App;
        private System.Windows.Forms.TextBox txtSearchMyApp;
        private System.Windows.Forms.Button btnAppointmentSummaries;
    }
}
