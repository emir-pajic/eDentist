﻿
namespace eDentist.WinUI.Forms.Cities
{
    partial class CityList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.App = new System.Windows.Forms.Label();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCities = new System.Windows.Forms.DataGridView();
            this.CityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).BeginInit();
            this.SuspendLayout();
            // 
            // App
            // 
            this.App.AutoSize = true;
            this.App.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.App.Location = new System.Drawing.Point(37, 47);
            this.App.Name = "App";
            this.App.Size = new System.Drawing.Size(54, 20);
            this.App.TabIndex = 77;
            this.App.Text = "Cities";
            // 
            // btnAddCity
            // 
            this.btnAddCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCity.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCity.Image")));
            this.btnAddCity.Location = new System.Drawing.Point(463, 84);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(41, 37);
            this.btnAddCity.TabIndex = 76;
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(582, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(41, 37);
            this.btnDelete.TabIndex = 74;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.Image")));
            this.btnDetails.Location = new System.Drawing.Point(523, 84);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(41, 37);
            this.btnDetails.TabIndex = 73;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(37, 97);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(275, 24);
            this.txtSearch.TabIndex = 72;
            this.txtSearch.Text = "Enter Name";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvCities
            // 
            this.dgvCities.AllowUserToAddRows = false;
            this.dgvCities.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvCities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCities.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvCities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCities.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCities.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityID,
            this.CityName,
            this.CountryName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCities.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCities.Location = new System.Drawing.Point(41, 138);
            this.dgvCities.Name = "dgvCities";
            this.dgvCities.ReadOnly = true;
            this.dgvCities.RowHeadersVisible = false;
            this.dgvCities.Size = new System.Drawing.Size(415, 263);
            this.dgvCities.TabIndex = 78;
            // 
            // CityID
            // 
            this.CityID.DataPropertyName = "CityID";
            this.CityID.HeaderText = "CityID";
            this.CityID.Name = "CityID";
            this.CityID.ReadOnly = true;
            this.CityID.Visible = false;
            // 
            // CityName
            // 
            this.CityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CityName.DataPropertyName = "CityName";
            this.CityName.HeaderText = "City";
            this.CityName.Name = "CityName";
            this.CityName.ReadOnly = true;
            // 
            // CountryName
            // 
            this.CountryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CountryName.DataPropertyName = "CountryName";
            this.CountryName.HeaderText = "Country";
            this.CountryName.Name = "CountryName";
            this.CountryName.ReadOnly = true;
            // 
            // CityList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCities);
            this.Controls.Add(this.App);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.txtSearch);
            this.Name = "CityList";
            this.Size = new System.Drawing.Size(672, 442);
            this.Load += new System.EventHandler(this.CitiesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label App;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
    }
}
