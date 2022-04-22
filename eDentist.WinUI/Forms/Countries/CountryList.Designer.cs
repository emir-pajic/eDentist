
namespace eDentist.WinUI.Forms.Countries
{
    partial class CountryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountryList));
            this.App = new System.Windows.Forms.Label();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCountryDetails = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dvgCountries = new System.Windows.Forms.DataGridView();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // App
            // 
            this.App.AutoSize = true;
            this.App.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.App.Location = new System.Drawing.Point(28, 58);
            this.App.Name = "App";
            this.App.Size = new System.Drawing.Size(86, 20);
            this.App.TabIndex = 70;
            this.App.Text = "Countries";
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCountry.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCountry.Image")));
            this.btnAddCountry.Location = new System.Drawing.Point(454, 95);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(41, 37);
            this.btnAddCountry.TabIndex = 69;
            this.btnAddCountry.UseVisualStyleBackColor = true;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(319, 108);
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
            this.btnDelete.Location = new System.Drawing.Point(573, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(41, 37);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCountryDetails
            // 
            this.btnCountryDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCountryDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountryDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnCountryDetails.Image")));
            this.btnCountryDetails.Location = new System.Drawing.Point(514, 95);
            this.btnCountryDetails.Name = "btnCountryDetails";
            this.btnCountryDetails.Size = new System.Drawing.Size(41, 37);
            this.btnCountryDetails.TabIndex = 66;
            this.btnCountryDetails.UseVisualStyleBackColor = true;
            this.btnCountryDetails.Click += new System.EventHandler(this.btnCountryDetails_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(28, 108);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(275, 24);
            this.txtSearch.TabIndex = 65;
            this.txtSearch.Text = "Enter Name";
            // 
            // dvgCountries
            // 
            this.dvgCountries.AllowUserToAddRows = false;
            this.dvgCountries.AllowUserToDeleteRows = false;
            this.dvgCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountryName});
            this.dvgCountries.Location = new System.Drawing.Point(32, 163);
            this.dvgCountries.Name = "dvgCountries";
            this.dvgCountries.ReadOnly = true;
            this.dvgCountries.Size = new System.Drawing.Size(144, 150);
            this.dvgCountries.TabIndex = 71;
            // 
            // CountryName
            // 
            this.CountryName.DataPropertyName = "CountryName";
            this.CountryName.HeaderText = "Country Name";
            this.CountryName.Name = "CountryName";
            this.CountryName.ReadOnly = true;
            // 
            // CountryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvgCountries);
            this.Controls.Add(this.App);
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCountryDetails);
            this.Controls.Add(this.txtSearch);
            this.Name = "CountryList";
            this.Size = new System.Drawing.Size(642, 376);
            this.Load += new System.EventHandler(this.CountriesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCountries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label App;
        private System.Windows.Forms.Button btnAddCountry;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCountryDetails;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dvgCountries;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
    }
}
