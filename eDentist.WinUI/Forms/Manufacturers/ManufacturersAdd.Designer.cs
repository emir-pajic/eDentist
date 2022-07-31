
namespace eDentist.WinUI.Forms.Manufacturers
{
    partial class ManufacturersAdd
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
            this.menuCountries = new System.Windows.Forms.ComboBox();
            this.lblManufacturerName = new System.Windows.Forms.Label();
            this.btnaddCity = new System.Windows.Forms.Button();
            this.txtManufacturerName = new System.Windows.Forms.TextBox();
            this.lblAddManufacturer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoundationYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // menuCountries
            // 
            this.menuCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCountries.FormattingEnabled = true;
            this.menuCountries.Location = new System.Drawing.Point(428, 84);
            this.menuCountries.Name = "menuCountries";
            this.menuCountries.Size = new System.Drawing.Size(214, 32);
            this.menuCountries.TabIndex = 9;
            this.menuCountries.SelectedIndexChanged += new System.EventHandler(this.menuCountries_SelectedIndexChanged);
            // 
            // lblManufacturerName
            // 
            this.lblManufacturerName.AutoSize = true;
            this.lblManufacturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturerName.ForeColor = System.Drawing.Color.White;
            this.lblManufacturerName.Location = new System.Drawing.Point(26, 82);
            this.lblManufacturerName.Name = "lblManufacturerName";
            this.lblManufacturerName.Size = new System.Drawing.Size(132, 24);
            this.lblManufacturerName.TabIndex = 8;
            this.lblManufacturerName.Text = "Manufacturer";
            // 
            // btnaddCity
            // 
            this.btnaddCity.BackColor = System.Drawing.Color.White;
            this.btnaddCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddCity.Location = new System.Drawing.Point(250, 178);
            this.btnaddCity.Name = "btnaddCity";
            this.btnaddCity.Size = new System.Drawing.Size(143, 30);
            this.btnaddCity.TabIndex = 7;
            this.btnaddCity.Text = "Save";
            this.btnaddCity.UseVisualStyleBackColor = false;
            this.btnaddCity.Click += new System.EventHandler(this.btnaddCity_Click);
            // 
            // txtManufacturerName
            // 
            this.txtManufacturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturerName.Location = new System.Drawing.Point(250, 82);
            this.txtManufacturerName.Name = "txtManufacturerName";
            this.txtManufacturerName.Size = new System.Drawing.Size(143, 29);
            this.txtManufacturerName.TabIndex = 6;
            // 
            // lblAddManufacturer
            // 
            this.lblAddManufacturer.AutoSize = true;
            this.lblAddManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddManufacturer.ForeColor = System.Drawing.Color.White;
            this.lblAddManufacturer.Location = new System.Drawing.Point(26, 28);
            this.lblAddManufacturer.Name = "lblAddManufacturer";
            this.lblAddManufacturer.Size = new System.Drawing.Size(238, 29);
            this.lblAddManufacturer.TabIndex = 5;
            this.lblAddManufacturer.Text = "Add a manufacturer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Foundation year";
            // 
            // txtFoundationYear
            // 
            this.txtFoundationYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoundationYear.Location = new System.Drawing.Point(250, 123);
            this.txtFoundationYear.Name = "txtFoundationYear";
            this.txtFoundationYear.Size = new System.Drawing.Size(143, 29);
            this.txtFoundationYear.TabIndex = 10;
            // 
            // ManufacturersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFoundationYear);
            this.Controls.Add(this.menuCountries);
            this.Controls.Add(this.lblManufacturerName);
            this.Controls.Add(this.btnaddCity);
            this.Controls.Add(this.txtManufacturerName);
            this.Controls.Add(this.lblAddManufacturer);
            this.Name = "ManufacturersAdd";
            this.Size = new System.Drawing.Size(642, 415);
            this.Load += new System.EventHandler(this.ManufcaturerAdd_LoadCountries);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox menuCountries;
        private System.Windows.Forms.Label lblManufacturerName;
        private System.Windows.Forms.Button btnaddCity;
        private System.Windows.Forms.TextBox txtManufacturerName;
        private System.Windows.Forms.Label lblAddManufacturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoundationYear;
    }
}
