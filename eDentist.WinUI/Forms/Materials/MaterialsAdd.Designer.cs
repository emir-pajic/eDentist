
namespace eDentist.WinUI.Forms.Materials
{
    partial class MaterialsAdd
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
            this.menuManufacturers = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.lblAddMaterial = new System.Windows.Forms.Label();
            this.materialImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.materialImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuManufacturers
            // 
            this.menuManufacturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuManufacturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuManufacturers.FormattingEnabled = true;
            this.menuManufacturers.Location = new System.Drawing.Point(135, 190);
            this.menuManufacturers.Name = "menuManufacturers";
            this.menuManufacturers.Size = new System.Drawing.Size(205, 32);
            this.menuManufacturers.TabIndex = 16;
            this.menuManufacturers.SelectedIndexChanged += new System.EventHandler(this.menuManufacturers_SelectedIndexChanged);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.ForeColor = System.Drawing.Color.Coral;
            this.lblMaterial.Location = new System.Drawing.Point(15, 142);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(83, 24);
            this.lblMaterial.TabIndex = 15;
            this.lblMaterial.Text = "Material";
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.BackColor = System.Drawing.Color.Coral;
            this.btnAddMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMaterial.Location = new System.Drawing.Point(135, 235);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(205, 32);
            this.btnAddMaterial.TabIndex = 14;
            this.btnAddMaterial.Text = "Save";
            this.btnAddMaterial.UseVisualStyleBackColor = false;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // txtMaterial
            // 
            this.txtMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterial.Location = new System.Drawing.Point(135, 142);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(205, 29);
            this.txtMaterial.TabIndex = 13;
            // 
            // lblAddMaterial
            // 
            this.lblAddMaterial.AutoSize = true;
            this.lblAddMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMaterial.ForeColor = System.Drawing.Color.Coral;
            this.lblAddMaterial.Location = new System.Drawing.Point(12, 35);
            this.lblAddMaterial.Name = "lblAddMaterial";
            this.lblAddMaterial.Size = new System.Drawing.Size(181, 29);
            this.lblAddMaterial.TabIndex = 12;
            this.lblAddMaterial.Text = "Add a material";
            // 
            // materialImage
            // 
            this.materialImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.materialImage.Location = new System.Drawing.Point(388, 142);
            this.materialImage.Name = "materialImage";
            this.materialImage.Size = new System.Drawing.Size(227, 125);
            this.materialImage.TabIndex = 48;
            this.materialImage.TabStop = false;
            this.materialImage.Tag = "";
            this.materialImage.Click += new System.EventHandler(this.materialImage_Click);
            // 
            // MaterialsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.materialImage);
            this.Controls.Add(this.menuManufacturers);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.lblAddMaterial);
            this.Name = "MaterialsAdd";
            this.Size = new System.Drawing.Size(568, 386);
            this.Load += new System.EventHandler(this.MaterialsAdd_LoadManufacturers);
            ((System.ComponentModel.ISupportInitialize)(this.materialImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox menuManufacturers;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label lblAddMaterial;
        private System.Windows.Forms.PictureBox materialImage;
    }
}
