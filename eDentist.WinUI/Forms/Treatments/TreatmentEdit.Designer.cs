namespace eDentist.WinUI.Forms.Treatments
{
    partial class TreatmentEdit
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
            this.btnUpdateTreatment = new System.Windows.Forms.Button();
            this.menuTreatments = new System.Windows.Forms.ComboBox();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.lblEditTreatment = new System.Windows.Forms.Label();
            this.lblTreatmentDescription = new System.Windows.Forms.Label();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateTreatment
            // 
            this.btnUpdateTreatment.Location = new System.Drawing.Point(132, 251);
            this.btnUpdateTreatment.Name = "btnUpdateTreatment";
            this.btnUpdateTreatment.Size = new System.Drawing.Size(130, 23);
            this.btnUpdateTreatment.TabIndex = 25;
            this.btnUpdateTreatment.Text = "Save";
            this.btnUpdateTreatment.UseVisualStyleBackColor = true;
            this.btnUpdateTreatment.Click += new System.EventHandler(this.btnUpdateTreatment_Click);
            // 
            // menuTreatments
            // 
            this.menuTreatments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuTreatments.FormattingEnabled = true;
            this.menuTreatments.Location = new System.Drawing.Point(113, 82);
            this.menuTreatments.Name = "menuTreatments";
            this.menuTreatments.Size = new System.Drawing.Size(158, 21);
            this.menuTreatments.TabIndex = 24;
            this.menuTreatments.SelectedIndexChanged += new System.EventHandler(this.menuTreatments_SelectedIndexChanged);
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatment.Location = new System.Drawing.Point(27, 80);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(82, 20);
            this.lblTreatment.TabIndex = 23;
            this.lblTreatment.Text = "Treatment";
            // 
            // lblEditTreatment
            // 
            this.lblEditTreatment.AutoSize = true;
            this.lblEditTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTreatment.Location = new System.Drawing.Point(27, 25);
            this.lblEditTreatment.Name = "lblEditTreatment";
            this.lblEditTreatment.Size = new System.Drawing.Size(139, 24);
            this.lblEditTreatment.TabIndex = 22;
            this.lblEditTreatment.Text = "Edit a treatment";
            // 
            // lblTreatmentDescription
            // 
            this.lblTreatmentDescription.AutoSize = true;
            this.lblTreatmentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatmentDescription.Location = new System.Drawing.Point(24, 190);
            this.lblTreatmentDescription.Name = "lblTreatmentDescription";
            this.lblTreatmentDescription.Size = new System.Drawing.Size(82, 20);
            this.lblTreatmentDescription.TabIndex = 27;
            this.lblTreatmentDescription.Text = "Treatment";
            // 
            // txtTreatment
            // 
            this.txtTreatment.Location = new System.Drawing.Point(112, 190);
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(159, 20);
            this.txtTreatment.TabIndex = 26;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(25, 225);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(112, 225);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(159, 20);
            this.txtPrice.TabIndex = 28;
            // 
            // TreatmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblTreatmentDescription);
            this.Controls.Add(this.txtTreatment);
            this.Controls.Add(this.btnUpdateTreatment);
            this.Controls.Add(this.menuTreatments);
            this.Controls.Add(this.lblTreatment);
            this.Controls.Add(this.lblEditTreatment);
            this.Name = "TreatmentEdit";
            this.Size = new System.Drawing.Size(452, 401);
            this.Load += new System.EventHandler(this.TreatmentsEdit_LoadData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateTreatment;
        private System.Windows.Forms.ComboBox menuTreatments;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.Label lblEditTreatment;
        private System.Windows.Forms.Label lblTreatmentDescription;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
    }
}
