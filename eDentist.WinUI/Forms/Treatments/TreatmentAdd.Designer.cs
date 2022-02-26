
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
            this.SuspendLayout();
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityName.Location = new System.Drawing.Point(21, 78);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(82, 20);
            this.lblCityName.TabIndex = 8;
            this.lblCityName.Text = "Treatment";
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.Location = new System.Drawing.Point(175, 122);
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.Size = new System.Drawing.Size(130, 23);
            this.btnAddTreatment.TabIndex = 7;
            this.btnAddTreatment.Text = "Save";
            this.btnAddTreatment.UseVisualStyleBackColor = true;
            this.btnAddTreatment.Click += new System.EventHandler(this.btnAddTreatment_Click);
            // 
            // txtTreatment
            // 
            this.txtTreatment.Location = new System.Drawing.Point(109, 78);
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(316, 20);
            this.txtTreatment.TabIndex = 6;
            // 
            // lblAddTreatment
            // 
            this.lblAddTreatment.AutoSize = true;
            this.lblAddTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTreatment.Location = new System.Drawing.Point(21, 27);
            this.lblAddTreatment.Name = "lblAddTreatment";
            this.lblAddTreatment.Size = new System.Drawing.Size(142, 24);
            this.lblAddTreatment.TabIndex = 5;
            this.lblAddTreatment.Text = "Add a treatment";
            // 
            // TreatmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
