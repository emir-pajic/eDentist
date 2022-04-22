namespace eDentist.WinUI.Forms.Countries
{
    partial class CountryDelete
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
            this.btnRemoveCountry = new System.Windows.Forms.Button();
            this.menuCountries = new System.Windows.Forms.ComboBox();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblRemoveCountry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveCountry
            // 
            this.btnRemoveCountry.Location = new System.Drawing.Point(123, 139);
            this.btnRemoveCountry.Name = "btnRemoveCountry";
            this.btnRemoveCountry.Size = new System.Drawing.Size(130, 23);
            this.btnRemoveCountry.TabIndex = 17;
            this.btnRemoveCountry.Text = "Save";
            this.btnRemoveCountry.UseVisualStyleBackColor = true;
            this.btnRemoveCountry.Click += new System.EventHandler(this.btnRemoveCountry_Click);
            // 
            // menuCountries
            // 
            this.menuCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuCountries.FormattingEnabled = true;
            this.menuCountries.Location = new System.Drawing.Point(95, 83);
            this.menuCountries.Name = "menuCountries";
            this.menuCountries.Size = new System.Drawing.Size(158, 21);
            this.menuCountries.TabIndex = 16;
            this.menuCountries.SelectedIndexChanged += new System.EventHandler(this.menuCountries_SelectedIndexChanged);
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryName.Location = new System.Drawing.Point(25, 84);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(64, 20);
            this.lblCountryName.TabIndex = 15;
            this.lblCountryName.Text = "Country";
            // 
            // lblRemoveCountry
            // 
            this.lblRemoveCountry.AutoSize = true;
            this.lblRemoveCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveCountry.Location = new System.Drawing.Point(25, 30);
            this.lblRemoveCountry.Name = "lblRemoveCountry";
            this.lblRemoveCountry.Size = new System.Drawing.Size(163, 24);
            this.lblRemoveCountry.TabIndex = 14;
            this.lblRemoveCountry.Text = "Remove a country";
            // 
            // CountryDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveCountry);
            this.Controls.Add(this.menuCountries);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.lblRemoveCountry);
            this.Name = "CountryDelete";
            this.Size = new System.Drawing.Size(284, 311);
            this.Load += new System.EventHandler(this.CountriesDelete_LoadCountries);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveCountry;
        private System.Windows.Forms.ComboBox menuCountries;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblRemoveCountry;
    }
}
