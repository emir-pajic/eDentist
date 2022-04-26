namespace eDentist.WinUI.Forms.Manufacturers
{
    partial class ManufacturerDelete
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
            this.btnRemoveManufacturer = new System.Windows.Forms.Button();
            this.menuManufacturers = new System.Windows.Forms.ComboBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblRemoveManufacturer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveManufacturer
            // 
            this.btnRemoveManufacturer.Location = new System.Drawing.Point(89, 135);
            this.btnRemoveManufacturer.Name = "btnRemoveManufacturer";
            this.btnRemoveManufacturer.Size = new System.Drawing.Size(130, 23);
            this.btnRemoveManufacturer.TabIndex = 17;
            this.btnRemoveManufacturer.Text = "Save";
            this.btnRemoveManufacturer.UseVisualStyleBackColor = true;
            this.btnRemoveManufacturer.Click += new System.EventHandler(this.btnRemoveManufacturer_Click);
            // 
            // menuManufacturers
            // 
            this.menuManufacturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuManufacturers.FormattingEnabled = true;
            this.menuManufacturers.Location = new System.Drawing.Point(130, 72);
            this.menuManufacturers.Name = "menuManufacturers";
            this.menuManufacturers.Size = new System.Drawing.Size(158, 21);
            this.menuManufacturers.TabIndex = 16;
            this.menuManufacturers.SelectedIndexChanged += new System.EventHandler(this.menuManufacturers_SelectedIndexChanged);
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturer.Location = new System.Drawing.Point(20, 70);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(104, 20);
            this.lblManufacturer.TabIndex = 15;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblRemoveManufacturer
            // 
            this.lblRemoveManufacturer.AutoSize = true;
            this.lblRemoveManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveManufacturer.Location = new System.Drawing.Point(20, 16);
            this.lblRemoveManufacturer.Name = "lblRemoveManufacturer";
            this.lblRemoveManufacturer.Size = new System.Drawing.Size(211, 24);
            this.lblRemoveManufacturer.TabIndex = 14;
            this.lblRemoveManufacturer.Text = "Remove a manufacturer";
            // 
            // ManufacturerDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveManufacturer);
            this.Controls.Add(this.menuManufacturers);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblRemoveManufacturer);
            this.Name = "ManufacturerDelete";
            this.Load += new System.EventHandler(this.ManufacturersDelete_LoadData);

            this.Size = new System.Drawing.Size(350, 315);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveManufacturer;
        private System.Windows.Forms.ComboBox menuManufacturers;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblRemoveManufacturer;
    }
}
