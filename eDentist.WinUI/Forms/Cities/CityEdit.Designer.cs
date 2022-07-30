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
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // menuCities
            // 
            this.menuCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCities.FormattingEnabled = true;
            this.menuCities.Location = new System.Drawing.Point(130, 86);
            this.menuCities.Name = "menuCities";
            this.menuCities.Size = new System.Drawing.Size(206, 32);
            this.menuCities.TabIndex = 9;
            this.menuCities.SelectedIndexChanged += new System.EventHandler(this.menuCities_SelectedIndexChanged);
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityName.ForeColor = System.Drawing.Color.Coral;
            this.lblCityName.Location = new System.Drawing.Point(19, 86);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(44, 24);
            this.lblCityName.TabIndex = 8;
            this.lblCityName.Text = "City";
            // 
            // btnUpdateCity
            // 
            this.btnUpdateCity.BackColor = System.Drawing.Color.Coral;
            this.btnUpdateCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCity.Location = new System.Drawing.Point(130, 303);
            this.btnUpdateCity.Name = "btnUpdateCity";
            this.btnUpdateCity.Size = new System.Drawing.Size(206, 32);
            this.btnUpdateCity.TabIndex = 7;
            this.btnUpdateCity.Text = "Save";
            this.btnUpdateCity.UseVisualStyleBackColor = false;
            this.btnUpdateCity.Click += new System.EventHandler(this.btnUpdateCity_Click);
            // 
            // txtCityName
            // 
            this.txtCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityName.Location = new System.Drawing.Point(130, 201);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(206, 29);
            this.txtCityName.TabIndex = 6;
            // 
            // lblEditCity
            // 
            this.lblEditCity.AutoSize = true;
            this.lblEditCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCity.ForeColor = System.Drawing.Color.Coral;
            this.lblEditCity.Location = new System.Drawing.Point(19, 32);
            this.lblEditCity.Name = "lblEditCity";
            this.lblEditCity.Size = new System.Drawing.Size(126, 29);
            this.lblEditCity.TabIndex = 5;
            this.lblEditCity.Text = "Edit a city";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(19, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "City";
            // 
            // newCountryMenu
            // 
            this.newCountryMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newCountryMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCountryMenu.FormattingEnabled = true;
            this.newCountryMenu.Location = new System.Drawing.Point(130, 242);
            this.newCountryMenu.Name = "newCountryMenu";
            this.newCountryMenu.Size = new System.Drawing.Size(206, 32);
            this.newCountryMenu.TabIndex = 11;
            this.newCountryMenu.SelectedIndexChanged += new System.EventHandler(this.newCountryMenu_SelectedIndexChanged);
            // 
            // lblNewCountry
            // 
            this.lblNewCountry.AutoSize = true;
            this.lblNewCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCountry.ForeColor = System.Drawing.Color.Coral;
            this.lblNewCountry.Location = new System.Drawing.Point(19, 242);
            this.lblNewCountry.Name = "lblNewCountry";
            this.lblNewCountry.Size = new System.Drawing.Size(82, 24);
            this.lblNewCountry.TabIndex = 12;
            this.lblNewCountry.Text = "Country";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(-217, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 10);
            this.panel3.TabIndex = 55;
            // 
            // CityEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel3);
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
        private System.Windows.Forms.Panel panel3;
    }
}
