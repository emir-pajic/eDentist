namespace eDentist.WinUI.Forms.Examinations
{
    partial class ExaminationDelete
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
            this.btnRemoveExamination = new System.Windows.Forms.Button();
            this.menuExaminations = new System.Windows.Forms.ComboBox();
            this.lblExamination = new System.Windows.Forms.Label();
            this.lblRemoveExamination = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveExamination
            // 
            this.btnRemoveExamination.BackColor = System.Drawing.Color.White;
            this.btnRemoveExamination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveExamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveExamination.Location = new System.Drawing.Point(258, 193);
            this.btnRemoveExamination.Name = "btnRemoveExamination";
            this.btnRemoveExamination.Size = new System.Drawing.Size(148, 31);
            this.btnRemoveExamination.TabIndex = 29;
            this.btnRemoveExamination.Text = "Save";
            this.btnRemoveExamination.UseVisualStyleBackColor = false;
            this.btnRemoveExamination.Click += new System.EventHandler(this.btnRemoveExamination_Click);
            // 
            // menuExaminations
            // 
            this.menuExaminations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuExaminations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuExaminations.FormattingEnabled = true;
            this.menuExaminations.Location = new System.Drawing.Point(167, 132);
            this.menuExaminations.Name = "menuExaminations";
            this.menuExaminations.Size = new System.Drawing.Size(370, 32);
            this.menuExaminations.TabIndex = 28;
            this.menuExaminations.SelectedIndexChanged += new System.EventHandler(this.menuExaminations_SelectedIndexChanged);
            // 
            // lblExamination
            // 
            this.lblExamination.AutoSize = true;
            this.lblExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamination.ForeColor = System.Drawing.Color.White;
            this.lblExamination.Location = new System.Drawing.Point(17, 140);
            this.lblExamination.Name = "lblExamination";
            this.lblExamination.Size = new System.Drawing.Size(125, 24);
            this.lblExamination.TabIndex = 27;
            this.lblExamination.Text = "Examination";
            // 
            // lblRemoveExamination
            // 
            this.lblRemoveExamination.AutoSize = true;
            this.lblRemoveExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveExamination.ForeColor = System.Drawing.Color.White;
            this.lblRemoveExamination.Location = new System.Drawing.Point(17, 22);
            this.lblRemoveExamination.Name = "lblRemoveExamination";
            this.lblRemoveExamination.Size = new System.Drawing.Size(293, 29);
            this.lblRemoveExamination.TabIndex = 26;
            this.lblRemoveExamination.Text = "Remove an Examination";
            // 
            // ExaminationDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRemoveExamination);
            this.Controls.Add(this.menuExaminations);
            this.Controls.Add(this.lblExamination);
            this.Controls.Add(this.lblRemoveExamination);
            this.Name = "ExaminationDelete";
            this.Size = new System.Drawing.Size(824, 470);
            this.Load += new System.EventHandler(this.ExaminationsDelete_LoadData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveExamination;
        private System.Windows.Forms.ComboBox menuExaminations;
        private System.Windows.Forms.Label lblExamination;
        private System.Windows.Forms.Label lblRemoveExamination;
    }
}
