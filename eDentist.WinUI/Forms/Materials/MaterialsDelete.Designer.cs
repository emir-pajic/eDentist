namespace eDentist.WinUI.Forms.Materials
{
    partial class MaterialsDelete
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
            this.btnRemoveMaterial = new System.Windows.Forms.Button();
            this.menuMaterials = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblRemoveMaterial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveMaterial
            // 
            this.btnRemoveMaterial.BackColor = System.Drawing.Color.Coral;
            this.btnRemoveMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMaterial.Location = new System.Drawing.Point(139, 183);
            this.btnRemoveMaterial.Name = "btnRemoveMaterial";
            this.btnRemoveMaterial.Size = new System.Drawing.Size(258, 29);
            this.btnRemoveMaterial.TabIndex = 21;
            this.btnRemoveMaterial.Text = "Save";
            this.btnRemoveMaterial.UseVisualStyleBackColor = false;
            this.btnRemoveMaterial.Click += new System.EventHandler(this.btnRemoveMaterial_Click);
            // 
            // menuMaterials
            // 
            this.menuMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMaterials.FormattingEnabled = true;
            this.menuMaterials.Location = new System.Drawing.Point(139, 132);
            this.menuMaterials.Name = "menuMaterials";
            this.menuMaterials.Size = new System.Drawing.Size(258, 32);
            this.menuMaterials.TabIndex = 20;
            this.menuMaterials.SelectedIndexChanged += new System.EventHandler(this.menuMaterials_SelectedIndexChanged);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.ForeColor = System.Drawing.Color.Coral;
            this.lblMaterial.Location = new System.Drawing.Point(29, 130);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(83, 24);
            this.lblMaterial.TabIndex = 19;
            this.lblMaterial.Text = "Material";
            // 
            // lblRemoveMaterial
            // 
            this.lblRemoveMaterial.AutoSize = true;
            this.lblRemoveMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveMaterial.ForeColor = System.Drawing.Color.Coral;
            this.lblRemoveMaterial.Location = new System.Drawing.Point(29, 24);
            this.lblRemoveMaterial.Name = "lblRemoveMaterial";
            this.lblRemoveMaterial.Size = new System.Drawing.Size(231, 29);
            this.lblRemoveMaterial.TabIndex = 18;
            this.lblRemoveMaterial.Text = "Remove a material";
            // 
            // MaterialsDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRemoveMaterial);
            this.Controls.Add(this.menuMaterials);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblRemoveMaterial);
            this.Name = "MaterialsDelete";
            this.Size = new System.Drawing.Size(414, 291);
            this.Load += new System.EventHandler(this.MaterialsDelete_LoadData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveMaterial;
        private System.Windows.Forms.ComboBox menuMaterials;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblRemoveMaterial;
    }
}
