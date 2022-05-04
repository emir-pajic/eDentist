namespace eDentist.WinUI.Forms.Treatments
{
    partial class TreatmentDelete
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
            this.btnRemoveTreatment = new System.Windows.Forms.Button();
            this.menuTreatments = new System.Windows.Forms.ComboBox();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.lblRemoveTreatment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveTreatment
            // 
            this.btnRemoveTreatment.Location = new System.Drawing.Point(96, 143);
            this.btnRemoveTreatment.Name = "btnRemoveTreatment";
            this.btnRemoveTreatment.Size = new System.Drawing.Size(130, 23);
            this.btnRemoveTreatment.TabIndex = 25;
            this.btnRemoveTreatment.Text = "Save";
            this.btnRemoveTreatment.UseVisualStyleBackColor = true;
            this.btnRemoveTreatment.Click += new System.EventHandler(this.btnRemoveTreatment_Click);
            // 
            // menuTreatments
            // 
            this.menuTreatments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuTreatments.FormattingEnabled = true;
            this.menuTreatments.Location = new System.Drawing.Point(137, 80);
            this.menuTreatments.Name = "menuTreatments";
            this.menuTreatments.Size = new System.Drawing.Size(158, 21);
            this.menuTreatments.TabIndex = 24;
            this.menuTreatments.SelectedIndexChanged += new System.EventHandler(this.menuTreatments_SelectedIndexChanged);
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatment.Location = new System.Drawing.Point(27, 78);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(65, 20);
            this.lblTreatment.TabIndex = 23;
            this.lblTreatment.Text = "Material";
            // 
            // lblRemoveTreatment
            // 
            this.lblRemoveTreatment.AutoSize = true;
            this.lblRemoveTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveTreatment.Location = new System.Drawing.Point(27, 24);
            this.lblRemoveTreatment.Name = "lblRemoveTreatment";
            this.lblRemoveTreatment.Size = new System.Drawing.Size(178, 24);
            this.lblRemoveTreatment.TabIndex = 22;
            this.lblRemoveTreatment.Text = "Remove a treatment";
            // 
            // TreatmentDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveTreatment);
            this.Controls.Add(this.menuTreatments);
            this.Controls.Add(this.lblTreatment);
            this.Controls.Add(this.lblRemoveTreatment);
            this.Name = "TreatmentDelete";
            this.Size = new System.Drawing.Size(335, 248);
            this.Load += new System.EventHandler(this.TreatmentsDelete_LoadData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveTreatment;
        private System.Windows.Forms.ComboBox menuTreatments;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.Label lblRemoveTreatment;
    }
}
