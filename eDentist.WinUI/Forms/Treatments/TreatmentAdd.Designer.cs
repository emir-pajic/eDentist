
namespace eDentist.WinUI.Forms.Treatments
{
    partial class TreatmentAdd
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
            this.lblCityName = new System.Windows.Forms.Label();
            this.btnAddTreatment = new System.Windows.Forms.Button();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.lblAddTreatment = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityName.ForeColor = System.Drawing.Color.White;
            this.lblCityName.Location = new System.Drawing.Point(21, 78);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(104, 24);
            this.lblCityName.TabIndex = 8;
            this.lblCityName.Text = "Treatment";
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.BackColor = System.Drawing.Color.White;
            this.btnAddTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTreatment.Location = new System.Drawing.Point(145, 160);
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.Size = new System.Drawing.Size(316, 34);
            this.btnAddTreatment.TabIndex = 7;
            this.btnAddTreatment.Text = "Save";
            this.btnAddTreatment.UseVisualStyleBackColor = false;
            this.btnAddTreatment.Click += new System.EventHandler(this.btnAddTreatment_Click);
            // 
            // txtTreatment
            // 
            this.txtTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreatment.Location = new System.Drawing.Point(145, 78);
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(316, 29);
            this.txtTreatment.TabIndex = 6;
            // 
            // lblAddTreatment
            // 
            this.lblAddTreatment.AutoSize = true;
            this.lblAddTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTreatment.ForeColor = System.Drawing.Color.White;
            this.lblAddTreatment.Location = new System.Drawing.Point(21, 27);
            this.lblAddTreatment.Name = "lblAddTreatment";
            this.lblAddTreatment.Size = new System.Drawing.Size(157, 24);
            this.lblAddTreatment.TabIndex = 5;
            this.lblAddTreatment.Text = "Add a treatment";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(21, 114);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 24);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(145, 114);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(316, 29);
            this.txtPrice.TabIndex = 9;
            // 
            // TreatmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblCityName);
            this.Controls.Add(this.btnAddTreatment);
            this.Controls.Add(this.txtTreatment);
            this.Controls.Add(this.lblAddTreatment);
            this.Name = "TreatmentAdd";
            this.Size = new System.Drawing.Size(464, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Button btnAddTreatment;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.Label lblAddTreatment;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
    }
}
