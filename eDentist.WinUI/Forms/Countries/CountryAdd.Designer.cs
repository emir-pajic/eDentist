
namespace eDentist.WinUI.Forms.Countries
{
    partial class CountryAdd
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
            this.txtCountryAdd = new System.Windows.Forms.TextBox();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a country";
            // 
            // txtCountryAdd
            // 
            this.txtCountryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountryAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCountryAdd.Location = new System.Drawing.Point(124, 90);
            this.txtCountryAdd.Name = "txtCountryAdd";
            this.txtCountryAdd.Size = new System.Drawing.Size(192, 29);
            this.txtCountryAdd.TabIndex = 1;
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCountry.ForeColor = System.Drawing.Color.Coral;
            this.lblAddCountry.Location = new System.Drawing.Point(36, 93);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(82, 24);
            this.lblAddCountry.TabIndex = 2;
            this.lblAddCountry.Text = "Country";
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.BackColor = System.Drawing.Color.Coral;
            this.btnAddCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCountry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddCountry.Location = new System.Drawing.Point(124, 141);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(192, 28);
            this.btnAddCountry.TabIndex = 3;
            this.btnAddCountry.Text = "Save";
            this.btnAddCountry.UseVisualStyleBackColor = false;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // CountryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.lblAddCountry);
            this.Controls.Add(this.txtCountryAdd);
            this.Controls.Add(this.label1);
            this.Name = "CountryAdd";
            this.Size = new System.Drawing.Size(554, 429);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCountryAdd;
        private System.Windows.Forms.Label lblAddCountry;
        private System.Windows.Forms.Button btnAddCountry;
    }
}
