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
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnUpdateTreatment
            // 
            this.btnUpdateTreatment.BackColor = System.Drawing.Color.White;
            this.btnUpdateTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTreatment.Location = new System.Drawing.Point(160, 272);
            this.btnUpdateTreatment.Name = "btnUpdateTreatment";
            this.btnUpdateTreatment.Size = new System.Drawing.Size(265, 32);
            this.btnUpdateTreatment.TabIndex = 25;
            this.btnUpdateTreatment.Text = "Save";
            this.btnUpdateTreatment.UseVisualStyleBackColor = false;
            this.btnUpdateTreatment.Click += new System.EventHandler(this.btnUpdateTreatment_Click);
            // 
            // menuTreatments
            // 
            this.menuTreatments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTreatments.FormattingEnabled = true;
            this.menuTreatments.Location = new System.Drawing.Point(161, 80);
            this.menuTreatments.Name = "menuTreatments";
            this.menuTreatments.Size = new System.Drawing.Size(264, 32);
            this.menuTreatments.TabIndex = 24;
            this.menuTreatments.SelectedIndexChanged += new System.EventHandler(this.menuTreatments_SelectedIndexChanged);
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatment.ForeColor = System.Drawing.Color.White;
            this.lblTreatment.Location = new System.Drawing.Point(27, 80);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(104, 24);
            this.lblTreatment.TabIndex = 23;
            this.lblTreatment.Text = "Treatment";
            // 
            // lblEditTreatment
            // 
            this.lblEditTreatment.AutoSize = true;
            this.lblEditTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTreatment.ForeColor = System.Drawing.Color.White;
            this.lblEditTreatment.Location = new System.Drawing.Point(27, 25);
            this.lblEditTreatment.Name = "lblEditTreatment";
            this.lblEditTreatment.Size = new System.Drawing.Size(196, 29);
            this.lblEditTreatment.TabIndex = 22;
            this.lblEditTreatment.Text = "Edit a treatment";
            // 
            // lblTreatmentDescription
            // 
            this.lblTreatmentDescription.AutoSize = true;
            this.lblTreatmentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatmentDescription.ForeColor = System.Drawing.Color.White;
            this.lblTreatmentDescription.Location = new System.Drawing.Point(24, 190);
            this.lblTreatmentDescription.Name = "lblTreatmentDescription";
            this.lblTreatmentDescription.Size = new System.Drawing.Size(104, 24);
            this.lblTreatmentDescription.TabIndex = 27;
            this.lblTreatmentDescription.Text = "Treatment";
            // 
            // txtTreatment
            // 
            this.txtTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreatment.Location = new System.Drawing.Point(160, 188);
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(265, 29);
            this.txtTreatment.TabIndex = 26;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(25, 225);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 24);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(160, 223);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(265, 29);
            this.txtPrice.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(-178, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 10);
            this.panel3.TabIndex = 59;
            // 
            // TreatmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel3);
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
        private System.Windows.Forms.Panel panel3;
    }
}
