namespace eDentist.WinUI.Forms.Materials
{
    partial class MaterialsEdit
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
            this.menuMaterials = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.btnUpdateMaterial = new System.Windows.Forms.Button();
            this.lblEditMaterial = new System.Windows.Forms.Label();
            this.menuManufacturers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // menuMaterials
            // 
            this.menuMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuMaterials.FormattingEnabled = true;
            this.menuMaterials.Location = new System.Drawing.Point(99, 81);
            this.menuMaterials.Name = "menuMaterials";
            this.menuMaterials.Size = new System.Drawing.Size(158, 21);
            this.menuMaterials.TabIndex = 21;
            this.menuMaterials.SelectedIndexChanged += new System.EventHandler(this.menuMaterials_SelectedIndexChanged);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(28, 81);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(65, 20);
            this.lblMaterial.TabIndex = 20;
            this.lblMaterial.Text = "Material";
            // 
            // btnUpdateMaterial
            // 
            this.btnUpdateMaterial.Location = new System.Drawing.Point(191, 226);
            this.btnUpdateMaterial.Name = "btnUpdateMaterial";
            this.btnUpdateMaterial.Size = new System.Drawing.Size(130, 23);
            this.btnUpdateMaterial.TabIndex = 19;
            this.btnUpdateMaterial.Text = "Save";
            this.btnUpdateMaterial.UseVisualStyleBackColor = true;
            this.btnUpdateMaterial.Click += new System.EventHandler(this.btnUpdateMaterial_Click);
            // 
            // lblEditMaterial
            // 
            this.lblEditMaterial.AutoSize = true;
            this.lblEditMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMaterial.Location = new System.Drawing.Point(28, 27);
            this.lblEditMaterial.Name = "lblEditMaterial";
            this.lblEditMaterial.Size = new System.Drawing.Size(127, 24);
            this.lblEditMaterial.TabIndex = 17;
            this.lblEditMaterial.Text = "Edit a material";
            // 
            // menuManufacturers
            // 
            this.menuManufacturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuManufacturers.FormattingEnabled = true;
            this.menuManufacturers.Location = new System.Drawing.Point(286, 167);
            this.menuManufacturers.Name = "menuManufacturers";
            this.menuManufacturers.Size = new System.Drawing.Size(158, 21);
            this.menuManufacturers.TabIndex = 24;
            this.menuManufacturers.SelectedIndexChanged += new System.EventHandler(this.menuManufacturers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Material";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(118, 167);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(143, 20);
            this.txtMaterial.TabIndex = 22;
            // 
            // MaterialsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuManufacturers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.menuMaterials);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.btnUpdateMaterial);
            this.Controls.Add(this.lblEditMaterial);
            this.Name = "MaterialsEdit";
            this.Size = new System.Drawing.Size(526, 442);
            this.Load += new System.EventHandler(this.MaterialsEdit_LoadData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox menuMaterials;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Button btnUpdateMaterial;
        private System.Windows.Forms.Label lblEditMaterial;
        private System.Windows.Forms.ComboBox menuManufacturers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaterial;
    }
}
