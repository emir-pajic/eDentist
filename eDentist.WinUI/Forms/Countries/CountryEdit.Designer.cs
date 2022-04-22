
namespace eDentist.WinUI.Forms.Countries
{
    partial class CountryEdit
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
            this.lblnewCountryName = new System.Windows.Forms.Label();
            this.menuCountries = new System.Windows.Forms.ComboBox();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.lblEditCountry = new System.Windows.Forms.Label();
            this.btnUpdateCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnewCountryName
            // 
            this.lblnewCountryName.AutoSize = true;
            this.lblnewCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewCountryName.Location = new System.Drawing.Point(30, 164);
            this.lblnewCountryName.Name = "lblnewCountryName";
            this.lblnewCountryName.Size = new System.Drawing.Size(64, 20);
            this.lblnewCountryName.TabIndex = 15;
            this.lblnewCountryName.Text = "Country";
            // 
            // menuCountries
            // 
            this.menuCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuCountries.FormattingEnabled = true;
            this.menuCountries.Location = new System.Drawing.Point(100, 80);
            this.menuCountries.Name = "menuCountries";
            this.menuCountries.Size = new System.Drawing.Size(158, 21);
            this.menuCountries.TabIndex = 14;
            this.menuCountries.SelectedIndexChanged += new System.EventHandler(this.menuCountries_SelectedIndexChanged);
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryName.Location = new System.Drawing.Point(30, 81);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(64, 20);
            this.lblCountryName.TabIndex = 13;
            this.lblCountryName.Text = "Country";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(100, 164);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(158, 20);
            this.txtCountryName.TabIndex = 12;
            // 
            // lblEditCountry
            // 
            this.lblEditCountry.AutoSize = true;
            this.lblEditCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCountry.Location = new System.Drawing.Point(30, 27);
            this.lblEditCountry.Name = "lblEditCountry";
            this.lblEditCountry.Size = new System.Drawing.Size(124, 24);
            this.lblEditCountry.TabIndex = 11;
            this.lblEditCountry.Text = "Edit a country";
            // 
            // btnUpdateCountry
            // 
            this.btnUpdateCountry.Location = new System.Drawing.Point(128, 219);
            this.btnUpdateCountry.Name = "btnUpdateCountry";
            this.btnUpdateCountry.Size = new System.Drawing.Size(130, 23);
            this.btnUpdateCountry.TabIndex = 16;
            this.btnUpdateCountry.Text = "Save";
            this.btnUpdateCountry.UseVisualStyleBackColor = true;
            this.btnUpdateCountry.Click += new System.EventHandler(this.btnUpdateCountry_Click);
            // 
            // CountryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateCountry);
            this.Controls.Add(this.lblnewCountryName);
            this.Controls.Add(this.menuCountries);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.lblEditCountry);
            this.Name = "CountryEdit";
            this.Size = new System.Drawing.Size(372, 326);
            this.Load += new System.EventHandler(this.CountriesEdit_LoadCountries);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnewCountryName;
        private System.Windows.Forms.ComboBox menuCountries;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Label lblEditCountry;
        private System.Windows.Forms.Button btnUpdateCountry;
    }
}
