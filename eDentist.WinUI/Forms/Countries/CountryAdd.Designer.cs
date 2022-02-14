
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a country";
            // 
            // txtCountryAdd
            // 
            this.txtCountryAdd.Location = new System.Drawing.Point(101, 103);
            this.txtCountryAdd.Name = "txtCountryAdd";
            this.txtCountryAdd.Size = new System.Drawing.Size(192, 20);
            this.txtCountryAdd.TabIndex = 1;
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCountry.Location = new System.Drawing.Point(31, 101);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(64, 20);
            this.lblAddCountry.TabIndex = 2;
            this.lblAddCountry.Text = "Country";
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.Location = new System.Drawing.Point(101, 147);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(192, 23);
            this.btnAddCountry.TabIndex = 3;
            this.btnAddCountry.Text = "Save";
            this.btnAddCountry.UseVisualStyleBackColor = true;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // CountryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.lblAddCountry);
            this.Controls.Add(this.txtCountryAdd);
            this.Controls.Add(this.label1);
            this.Name = "CountryAdd";
            this.Size = new System.Drawing.Size(434, 299);
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
