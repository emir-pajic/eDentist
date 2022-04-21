namespace eDentist.WinUI.Forms.Cities
{
    partial class CityDelete
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
            this.menuCities = new System.Windows.Forms.ComboBox();
            this.lblCityName = new System.Windows.Forms.Label();
            this.lblRemoveCity = new System.Windows.Forms.Label();
            this.btnRemoveCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuCities
            // 
            this.menuCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuCities.FormattingEnabled = true;
            this.menuCities.Location = new System.Drawing.Point(68, 85);
            this.menuCities.Name = "menuCities";
            this.menuCities.Size = new System.Drawing.Size(158, 21);
            this.menuCities.TabIndex = 12;
            this.menuCities.SelectedIndexChanged += new System.EventHandler(this.menuCities_SelectedIndexChanged);
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityName.Location = new System.Drawing.Point(27, 86);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(35, 20);
            this.lblCityName.TabIndex = 11;
            this.lblCityName.Text = "City";
            // 
            // lblRemoveCity
            // 
            this.lblRemoveCity.AutoSize = true;
            this.lblRemoveCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveCity.Location = new System.Drawing.Point(27, 32);
            this.lblRemoveCity.Name = "lblRemoveCity";
            this.lblRemoveCity.Size = new System.Drawing.Size(128, 24);
            this.lblRemoveCity.TabIndex = 10;
            this.lblRemoveCity.Text = "Remove a city";
            // 
            // btnRemoveCity
            // 
            this.btnRemoveCity.Location = new System.Drawing.Point(96, 151);
            this.btnRemoveCity.Name = "btnRemoveCity";
            this.btnRemoveCity.Size = new System.Drawing.Size(130, 23);
            this.btnRemoveCity.TabIndex = 13;
            this.btnRemoveCity.Text = "Save";
            this.btnRemoveCity.UseVisualStyleBackColor = true;
            this.btnRemoveCity.Click += new System.EventHandler(this.btnRemoveCity_Click);
            // 
            // CityDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveCity);
            this.Controls.Add(this.menuCities);
            this.Controls.Add(this.lblCityName);
            this.Controls.Add(this.lblRemoveCity);
            this.Name = "CityDelete";
            this.Size = new System.Drawing.Size(419, 385);
            this.Load += new System.EventHandler(this.CitiesDelete_LoadCities);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox menuCities;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Label lblRemoveCity;
        private System.Windows.Forms.Button btnRemoveCity;
    }
}
