
namespace eDentist.WinUI.Forms.Cities
{
    partial class CityAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.btnaddCity = new System.Windows.Forms.Button();
            this.lblCityName = new System.Windows.Forms.Label();
            this.menuCountries = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a city";
            // 
            // txtCityName
            // 
            this.txtCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCityName.Location = new System.Drawing.Point(83, 67);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(262, 29);
            this.txtCityName.TabIndex = 1;
            // 
            // btnaddCity
            // 
            this.btnaddCity.BackColor = System.Drawing.Color.White;
            this.btnaddCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddCity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnaddCity.Location = new System.Drawing.Point(153, 166);
            this.btnaddCity.Name = "btnaddCity";
            this.btnaddCity.Size = new System.Drawing.Size(140, 36);
            this.btnaddCity.TabIndex = 2;
            this.btnaddCity.Text = "Save";
            this.btnaddCity.UseVisualStyleBackColor = false;
            this.btnaddCity.Click += new System.EventHandler(this.btnaddCity_Click);
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityName.ForeColor = System.Drawing.Color.White;
            this.lblCityName.Location = new System.Drawing.Point(23, 74);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(44, 24);
            this.lblCityName.TabIndex = 3;
            this.lblCityName.Text = "City";
            // 
            // menuCountries
            // 
            this.menuCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCountries.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuCountries.FormattingEnabled = true;
            this.menuCountries.Location = new System.Drawing.Point(83, 119);
            this.menuCountries.Name = "menuCountries";
            this.menuCountries.Size = new System.Drawing.Size(262, 32);
            this.menuCountries.TabIndex = 4;
            this.menuCountries.SelectedIndexChanged += new System.EventHandler(this.menuCountries_SelectedIndexChanged);
            // 
            // CityAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.menuCountries);
            this.Controls.Add(this.lblCityName);
            this.Controls.Add(this.btnaddCity);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.label1);
            this.Name = "CityAdd";
            this.Size = new System.Drawing.Size(486, 417);
            this.Load += new System.EventHandler(this.CitiesAdd_LoadCountries);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Button btnaddCity;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.ComboBox menuCountries;
    }
}
