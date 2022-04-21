namespace eDentist.WinUI.Forms.Cities
{
    partial class CityEdit
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
            this.btnUpdateCity = new System.Windows.Forms.Button();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.lblEditCity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newCountryMenu = new System.Windows.Forms.ComboBox();
            this.lblNewCountry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuCities
            // 
            this.menuCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuCities.FormattingEnabled = true;
            this.menuCities.Location = new System.Drawing.Point(60, 85);
            this.menuCities.Name = "menuCities";
            this.menuCities.Size = new System.Drawing.Size(158, 21);
            this.menuCities.TabIndex = 9;
            this.menuCities.SelectedIndexChanged += new System.EventHandler(this.menuCities_SelectedIndexChanged);
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityName.Location = new System.Drawing.Point(19, 86);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(35, 20);
            this.lblCityName.TabIndex = 8;
            this.lblCityName.Text = "City";
            // 
            // btnUpdateCity
            // 
            this.btnUpdateCity.Location = new System.Drawing.Point(119, 339);
            this.btnUpdateCity.Name = "btnUpdateCity";
            this.btnUpdateCity.Size = new System.Drawing.Size(130, 23);
            this.btnUpdateCity.TabIndex = 7;
            this.btnUpdateCity.Text = "Save";
            this.btnUpdateCity.UseVisualStyleBackColor = true;
            this.btnUpdateCity.Click += new System.EventHandler(this.btnUpdateCity_Click);
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(89, 200);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(147, 20);
            this.txtCityName.TabIndex = 6;
            // 
            // lblEditCity
            // 
            this.lblEditCity.AutoSize = true;
            this.lblEditCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCity.Location = new System.Drawing.Point(19, 32);
            this.lblEditCity.Name = "lblEditCity";
            this.lblEditCity.Size = new System.Drawing.Size(89, 24);
            this.lblEditCity.TabIndex = 5;
            this.lblEditCity.Text = "Edit a city";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "City";
            // 
            // newCountryMenu
            // 
            this.newCountryMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newCountryMenu.FormattingEnabled = true;
            this.newCountryMenu.Location = new System.Drawing.Point(89, 238);
            this.newCountryMenu.Name = "newCountryMenu";
            this.newCountryMenu.Size = new System.Drawing.Size(147, 21);
            this.newCountryMenu.TabIndex = 11;
            this.newCountryMenu.SelectedIndexChanged += new System.EventHandler(this.newCountryMenu_SelectedIndexChanged);
            // 
            // lblNewCountry
            // 
            this.lblNewCountry.AutoSize = true;
            this.lblNewCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCountry.Location = new System.Drawing.Point(19, 239);
            this.lblNewCountry.Name = "lblNewCountry";
            this.lblNewCountry.Size = new System.Drawing.Size(64, 20);
            this.lblNewCountry.TabIndex = 12;
            this.lblNewCountry.Text = "Country";
            // 
            // CityEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNewCountry);
            this.Controls.Add(this.newCountryMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuCities);
            this.Controls.Add(this.lblCityName);
            this.Controls.Add(this.btnUpdateCity);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.lblEditCity);
            this.Name = "CityEdit";
            this.Size = new System.Drawing.Size(375, 438);
            this.Load += new System.EventHandler(this.CitiesEdit_LoadCities);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox menuCities;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Button btnUpdateCity;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Label lblEditCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox newCountryMenu;
        private System.Windows.Forms.Label lblNewCountry;
    }
}
