namespace eDentist.WinUI.Forms.TreatmentsMaterials
{
    partial class AddTreatmentsMaterials
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
            this.menuTreatments = new System.Windows.Forms.ComboBox();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.lblAddMaterial = new System.Windows.Forms.Label();
            this.menuMaterials = new System.Windows.Forms.ComboBox();
            this.Material = new System.Windows.Forms.Label();
            this.btnAddMaterialForTreatment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuTreatments
            // 
            this.menuTreatments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuTreatments.FormattingEnabled = true;
            this.menuTreatments.Location = new System.Drawing.Point(116, 82);
            this.menuTreatments.Name = "menuTreatments";
            this.menuTreatments.Size = new System.Drawing.Size(158, 21);
            this.menuTreatments.TabIndex = 27;
            this.menuTreatments.SelectedIndexChanged += new System.EventHandler(this.menuTreatments_SelectedIndexChanged);
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatment.Location = new System.Drawing.Point(30, 80);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(82, 20);
            this.lblTreatment.TabIndex = 26;
            this.lblTreatment.Text = "Treatment";
            // 
            // lblAddMaterial
            // 
            this.lblAddMaterial.AutoSize = true;
            this.lblAddMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMaterial.Location = new System.Drawing.Point(30, 25);
            this.lblAddMaterial.Name = "lblAddMaterial";
            this.lblAddMaterial.Size = new System.Drawing.Size(223, 24);
            this.lblAddMaterial.TabIndex = 25;
            this.lblAddMaterial.Text = "Add material for treatment";
            // 
            // menuMaterials
            // 
            this.menuMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuMaterials.FormattingEnabled = true;
            this.menuMaterials.Location = new System.Drawing.Point(116, 125);
            this.menuMaterials.Name = "menuMaterials";
            this.menuMaterials.Size = new System.Drawing.Size(158, 21);
            this.menuMaterials.TabIndex = 29;
            this.menuMaterials.SelectedIndexChanged += new System.EventHandler(this.menuMaterials_SelectedIndexChanged);
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Material.Location = new System.Drawing.Point(30, 123);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(65, 20);
            this.Material.TabIndex = 28;
            this.Material.Text = "Material";
            // 
            // btnAddMaterialForTreatment
            // 
            this.btnAddMaterialForTreatment.Location = new System.Drawing.Point(123, 172);
            this.btnAddMaterialForTreatment.Name = "btnAddMaterialForTreatment";
            this.btnAddMaterialForTreatment.Size = new System.Drawing.Size(130, 23);
            this.btnAddMaterialForTreatment.TabIndex = 30;
            this.btnAddMaterialForTreatment.Text = "Save";
            this.btnAddMaterialForTreatment.UseVisualStyleBackColor = true;
            this.btnAddMaterialForTreatment.Click += new System.EventHandler(this.btnAddMaterialForTreatment_Click);
            // 
            // AddTreatmentsMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddMaterialForTreatment);
            this.Controls.Add(this.menuMaterials);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.menuTreatments);
            this.Controls.Add(this.lblTreatment);
            this.Controls.Add(this.lblAddMaterial);
            this.Name = "AddTreatmentsMaterials";
            this.Size = new System.Drawing.Size(583, 425);
            this.Load += new System.EventHandler(this.AddTreatmentsMaterials_LoadData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox menuTreatments;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.Label lblAddMaterial;
        private System.Windows.Forms.ComboBox menuMaterials;
        private System.Windows.Forms.Label Material;
        private System.Windows.Forms.Button btnAddMaterialForTreatment;
    }
}
