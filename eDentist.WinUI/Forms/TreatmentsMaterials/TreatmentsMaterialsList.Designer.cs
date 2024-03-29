﻿namespace eDentist.WinUI.Forms.TreatmentsMaterials
{
    partial class TreatmentsMaterialsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgMaterialsForTreatment = new System.Windows.Forms.DataGridView();
            this.MaterialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.App = new System.Windows.Forms.Label();
            this.menuTreatments = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMaterialsForTreatment)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgMaterialsForTreatment
            // 
            this.dvgMaterialsForTreatment.AllowUserToAddRows = false;
            this.dvgMaterialsForTreatment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dvgMaterialsForTreatment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgMaterialsForTreatment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dvgMaterialsForTreatment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgMaterialsForTreatment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgMaterialsForTreatment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgMaterialsForTreatment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgMaterialsForTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMaterialsForTreatment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialId,
            this.MaterialName,
            this.Manufacturer,
            this.Image});
            this.dvgMaterialsForTreatment.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgMaterialsForTreatment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgMaterialsForTreatment.Location = new System.Drawing.Point(36, 191);
            this.dvgMaterialsForTreatment.Name = "dvgMaterialsForTreatment";
            this.dvgMaterialsForTreatment.ReadOnly = true;
            this.dvgMaterialsForTreatment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgMaterialsForTreatment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgMaterialsForTreatment.RowHeadersVisible = false;
            this.dvgMaterialsForTreatment.RowTemplate.Height = 40;
            this.dvgMaterialsForTreatment.Size = new System.Drawing.Size(665, 217);
            this.dvgMaterialsForTreatment.TabIndex = 81;
            // 
            // MaterialId
            // 
            this.MaterialId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialId.DataPropertyName = "MaterialID";
            this.MaterialId.HeaderText = "MaterialId";
            this.MaterialId.Name = "MaterialId";
            this.MaterialId.ReadOnly = true;
            this.MaterialId.Visible = false;
            // 
            // MaterialName
            // 
            this.MaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialName.DataPropertyName = "MaterialName";
            this.MaterialName.HeaderText = "Name";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manufacturer.DataPropertyName = "ManufacturerName";
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 104;
            // 
            // App
            // 
            this.App.AutoSize = true;
            this.App.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App.ForeColor = System.Drawing.Color.White;
            this.App.Location = new System.Drawing.Point(31, 67);
            this.App.Name = "App";
            this.App.Size = new System.Drawing.Size(401, 29);
            this.App.TabIndex = 80;
            this.App.Text = "Materials required for a treatment";
            // 
            // menuTreatments
            // 
            this.menuTreatments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuTreatments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTreatments.FormattingEnabled = true;
            this.menuTreatments.Location = new System.Drawing.Point(36, 143);
            this.menuTreatments.Name = "menuTreatments";
            this.menuTreatments.Size = new System.Drawing.Size(264, 32);
            this.menuTreatments.TabIndex = 82;
            this.menuTreatments.SelectedIndexChanged += new System.EventHandler(this.menuTreatments_SelectedIndexChanged);
            // 
            // TreatmentsMaterialsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.menuTreatments);
            this.Controls.Add(this.dvgMaterialsForTreatment);
            this.Controls.Add(this.App);
            this.Name = "TreatmentsMaterialsList";
            this.Size = new System.Drawing.Size(803, 541);
            this.Load += new System.EventHandler(this.TreatmentsMaterialsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMaterialsForTreatment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgMaterialsForTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.Label App;
        private System.Windows.Forms.ComboBox menuTreatments;
    }
}
