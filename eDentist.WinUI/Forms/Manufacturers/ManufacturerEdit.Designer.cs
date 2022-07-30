namespace eDentist.WinUI.Forms.Manufacturers
{
    partial class ManufacturerEdit
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
            this.txtFoundationYear = new System.Windows.Forms.TextBox();
            this.menuCountries = new System.Windows.Forms.ComboBox();
            this.lblManufacturerName = new System.Windows.Forms.Label();
            this.btnEditManufacturer = new System.Windows.Forms.Button();
            this.txtManufacturerName = new System.Windows.Forms.TextBox();
            this.lblManufacturerEdit = new System.Windows.Forms.Label();
            this.manufacturersMenu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Foundation year";
            // 
            // txtFoundationYear
            // 
            this.txtFoundationYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoundationYear.Location = new System.Drawing.Point(215, 249);
            this.txtFoundationYear.Name = "txtFoundationYear";
            this.txtFoundationYear.Size = new System.Drawing.Size(167, 29);
            this.txtFoundationYear.TabIndex = 17;
            // 
            // menuCountries
            // 
            this.menuCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCountries.FormattingEnabled = true;
            this.menuCountries.Location = new System.Drawing.Point(418, 205);
            this.menuCountries.Name = "menuCountries";
            this.menuCountries.Size = new System.Drawing.Size(279, 32);
            this.menuCountries.TabIndex = 16;
            this.menuCountries.SelectedIndexChanged += new System.EventHandler(this.menuCountries_SelectedIndexChanged);
            // 
            // lblManufacturerName
            // 
            this.lblManufacturerName.AutoSize = true;
            this.lblManufacturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturerName.ForeColor = System.Drawing.Color.White;
            this.lblManufacturerName.Location = new System.Drawing.Point(31, 208);
            this.lblManufacturerName.Name = "lblManufacturerName";
            this.lblManufacturerName.Size = new System.Drawing.Size(132, 24);
            this.lblManufacturerName.TabIndex = 15;
            this.lblManufacturerName.Text = "Manufacturer";
            // 
            // btnEditManufacturer
            // 
            this.btnEditManufacturer.BackColor = System.Drawing.Color.White;
            this.btnEditManufacturer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditManufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditManufacturer.Location = new System.Drawing.Point(215, 301);
            this.btnEditManufacturer.Name = "btnEditManufacturer";
            this.btnEditManufacturer.Size = new System.Drawing.Size(167, 34);
            this.btnEditManufacturer.TabIndex = 14;
            this.btnEditManufacturer.Text = "Save";
            this.btnEditManufacturer.UseVisualStyleBackColor = false;
            this.btnEditManufacturer.Click += new System.EventHandler(this.btnEditManufacturer_Click);
            // 
            // txtManufacturerName
            // 
            this.txtManufacturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturerName.Location = new System.Drawing.Point(215, 208);
            this.txtManufacturerName.Name = "txtManufacturerName";
            this.txtManufacturerName.Size = new System.Drawing.Size(167, 29);
            this.txtManufacturerName.TabIndex = 13;
            // 
            // lblManufacturerEdit
            // 
            this.lblManufacturerEdit.AutoSize = true;
            this.lblManufacturerEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturerEdit.ForeColor = System.Drawing.Color.White;
            this.lblManufacturerEdit.Location = new System.Drawing.Point(31, 25);
            this.lblManufacturerEdit.Name = "lblManufacturerEdit";
            this.lblManufacturerEdit.Size = new System.Drawing.Size(238, 29);
            this.lblManufacturerEdit.TabIndex = 12;
            this.lblManufacturerEdit.Text = "Edit a manufacturer";
            // 
            // manufacturersMenu
            // 
            this.manufacturersMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturersMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturersMenu.FormattingEnabled = true;
            this.manufacturersMenu.Location = new System.Drawing.Point(215, 99);
            this.manufacturersMenu.Name = "manufacturersMenu";
            this.manufacturersMenu.Size = new System.Drawing.Size(269, 32);
            this.manufacturersMenu.TabIndex = 21;
            this.manufacturersMenu.SelectedIndexChanged += new System.EventHandler(this.manufacturersMenu_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Manufacturer";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(-19, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 10);
            this.panel3.TabIndex = 57;
            // 
            // ManufacturerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.manufacturersMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFoundationYear);
            this.Controls.Add(this.menuCountries);
            this.Controls.Add(this.lblManufacturerName);
            this.Controls.Add(this.btnEditManufacturer);
            this.Controls.Add(this.txtManufacturerName);
            this.Controls.Add(this.lblManufacturerEdit);
            this.Name = "ManufacturerEdit";
            this.Size = new System.Drawing.Size(770, 478);
            this.Load += new System.EventHandler(this.ManufacturersEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoundationYear;
        private System.Windows.Forms.ComboBox menuCountries;
        private System.Windows.Forms.Label lblManufacturerName;
        private System.Windows.Forms.Button btnEditManufacturer;
        private System.Windows.Forms.TextBox txtManufacturerName;
        private System.Windows.Forms.Label lblManufacturerEdit;
        private System.Windows.Forms.ComboBox manufacturersMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
    }
}
