
namespace eDentist.WinUI.Forms.Manufacturers
{
    partial class ManufacturerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManufacturerList));
            this.App = new System.Windows.Forms.Label();
            this.btnAddManufacturer = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dvgManufacturers = new System.Windows.Forms.DataGridView();
            this.ManufacturerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoundationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgManufacturers)).BeginInit();
            this.SuspendLayout();
            // 
            // App
            // 
            this.App.AutoSize = true;
            this.App.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.App.Location = new System.Drawing.Point(25, 45);
            this.App.Name = "App";
            this.App.Size = new System.Drawing.Size(125, 20);
            this.App.TabIndex = 84;
            this.App.Text = "Manufacturers";
            // 
            // btnAddManufacturer
            // 
            this.btnAddManufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddManufacturer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddManufacturer.Image")));
            this.btnAddManufacturer.Location = new System.Drawing.Point(455, 68);
            this.btnAddManufacturer.Name = "btnAddManufacturer";
            this.btnAddManufacturer.Size = new System.Drawing.Size(41, 37);
            this.btnAddManufacturer.TabIndex = 83;
            this.btnAddManufacturer.UseVisualStyleBackColor = true;
            this.btnAddManufacturer.Click += new System.EventHandler(this.btnAddManufacturer_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(320, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 24);
            this.btnSearch.TabIndex = 82;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(574, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(41, 37);
            this.btnDelete.TabIndex = 81;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.Image")));
            this.btnDetails.Location = new System.Drawing.Point(515, 68);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(41, 37);
            this.btnDetails.TabIndex = 80;
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(29, 81);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(275, 24);
            this.txtSearch.TabIndex = 79;
            this.txtSearch.Text = "Enter Name";
            // 
            // dvgManufacturers
            // 
            this.dvgManufacturers.AllowUserToAddRows = false;
            this.dvgManufacturers.AllowUserToDeleteRows = false;
            this.dvgManufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgManufacturers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManufacturerID,
            this.ManufacturerName,
            this.FoundationYear,
            this.Country});
            this.dvgManufacturers.Location = new System.Drawing.Point(29, 141);
            this.dvgManufacturers.Name = "dvgManufacturers";
            this.dvgManufacturers.ReadOnly = true;
            this.dvgManufacturers.Size = new System.Drawing.Size(344, 150);
            this.dvgManufacturers.TabIndex = 85;
            // 
            // ManufacturerID
            // 
            this.ManufacturerID.DataPropertyName = "ManufacturerID";
            this.ManufacturerID.HeaderText = "ManufacturerID";
            this.ManufacturerID.Name = "ManufacturerID";
            this.ManufacturerID.ReadOnly = true;
            this.ManufacturerID.Visible = false;
            // 
            // ManufacturerName
            // 
            this.ManufacturerName.DataPropertyName = "ManufacturerName";
            this.ManufacturerName.HeaderText = "Name";
            this.ManufacturerName.Name = "ManufacturerName";
            this.ManufacturerName.ReadOnly = true;
            // 
            // FoundationYear
            // 
            this.FoundationYear.DataPropertyName = "FoundationYear";
            this.FoundationYear.HeaderText = "Foundation Year";
            this.FoundationYear.Name = "FoundationYear";
            this.FoundationYear.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // ManufacturerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvgManufacturers);
            this.Controls.Add(this.App);
            this.Controls.Add(this.btnAddManufacturer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.txtSearch);
            this.Name = "ManufacturerList";
            this.Size = new System.Drawing.Size(653, 419);
            this.Load += new System.EventHandler(this.ManufacturersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgManufacturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label App;
        private System.Windows.Forms.Button btnAddManufacturer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dvgManufacturers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoundationYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
    }
}
