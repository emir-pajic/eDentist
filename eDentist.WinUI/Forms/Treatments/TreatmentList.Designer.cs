
namespace eDentist.WinUI.Forms.Treatments
{
    partial class TreatmentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreatmentList));
            this.App = new System.Windows.Forms.Label();
            this.btnAddTreatment = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvTreatments = new System.Windows.Forms.DataGridView();
            this.TreatmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // App
            // 
            this.App.AutoSize = true;
            this.App.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.App.Location = new System.Drawing.Point(79, 55);
            this.App.Name = "App";
            this.App.Size = new System.Drawing.Size(100, 20);
            this.App.TabIndex = 70;
            this.App.Text = "Treatments";
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTreatment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTreatment.Image")));
            this.btnAddTreatment.Location = new System.Drawing.Point(509, 78);
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.Size = new System.Drawing.Size(41, 37);
            this.btnAddTreatment.TabIndex = 69;
            this.btnAddTreatment.UseVisualStyleBackColor = true;
            this.btnAddTreatment.Click += new System.EventHandler(this.btnAddTreatment_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(374, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 24);
            this.btnSearch.TabIndex = 68;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(628, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(41, 37);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.Image")));
            this.btnDetails.Location = new System.Drawing.Point(569, 78);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(41, 37);
            this.btnDetails.TabIndex = 66;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(83, 91);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(275, 24);
            this.txtSearch.TabIndex = 65;
            this.txtSearch.Text = "Enter Name";
            // 
            // dgvTreatments
            // 
            this.dgvTreatments.AllowUserToAddRows = false;
            this.dgvTreatments.AllowUserToDeleteRows = false;
            this.dgvTreatments.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TreatmentID,
            this.Description});
            this.dgvTreatments.Location = new System.Drawing.Point(83, 147);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.ReadOnly = true;
            this.dgvTreatments.Size = new System.Drawing.Size(288, 150);
            this.dgvTreatments.TabIndex = 71;
            // 
            // TreatmentID
            // 
            this.TreatmentID.DataPropertyName = "TreatmentID";
            this.TreatmentID.HeaderText = "TreatmentID";
            this.TreatmentID.Name = "TreatmentID";
            this.TreatmentID.ReadOnly = true;
            this.TreatmentID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TreatmentID.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // TreatmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTreatments);
            this.Controls.Add(this.App);
            this.Controls.Add(this.btnAddTreatment);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.txtSearch);
            this.Name = "TreatmentList";
            this.Size = new System.Drawing.Size(737, 384);
            this.Load += new System.EventHandler(this.TreatmentsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label App;
        private System.Windows.Forms.Button btnAddTreatment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvTreatments;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreatmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}
