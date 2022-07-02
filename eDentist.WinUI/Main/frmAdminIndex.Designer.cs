
namespace eDentist.WinUI.Main
{
    partial class frmAdminIndex
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminIndex));
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Content = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_editProfile = new System.Windows.Forms.Button();
            this.btn_mngTreatments = new System.Windows.Forms.Button();
            this.btn_mngMaterials = new System.Windows.Forms.Button();
            this.btn_mngCountries = new System.Windows.Forms.Button();
            this.btn_mngManufacturers = new System.Windows.Forms.Button();
            this.btn_mngUsers = new System.Windows.Forms.Button();
            this.btn_mngAppo = new System.Windows.Forms.Button();
            this.pbUserPicture = new System.Windows.Forms.PictureBox();
            this.btn_mngExam = new System.Windows.Forms.Button();
            this.btn_mngCities = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(154, 36);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(862, 601);
            this.ContentPanel.TabIndex = 1003;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Content);
            this.panel1.Location = new System.Drawing.Point(150, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 38);
            this.panel1.TabIndex = 1001;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(815, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 32);
            this.button2.TabIndex = 1000;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(760, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 31);
            this.button1.TabIndex = 1001;
            this.button1.Text = "—";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(152, 38);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(737, 474);
            this.Content.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btn_editProfile);
            this.panel2.Controls.Add(this.btn_mngTreatments);
            this.panel2.Controls.Add(this.btn_mngMaterials);
            this.panel2.Controls.Add(this.btn_mngCountries);
            this.panel2.Controls.Add(this.btn_mngManufacturers);
            this.panel2.Controls.Add(this.btn_mngUsers);
            this.panel2.Controls.Add(this.btn_mngAppo);
            this.panel2.Controls.Add(this.pbUserPicture);
            this.panel2.Controls.Add(this.btn_mngExam);
            this.panel2.Controls.Add(this.btn_mngCities);
            this.panel2.Location = new System.Drawing.Point(-6, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 641);
            this.panel2.TabIndex = 1002;
            // 
            // btn_editProfile
            // 
            this.btn_editProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_editProfile.FlatAppearance.BorderSize = 0;
            this.btn_editProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editProfile.ForeColor = System.Drawing.Color.Black;
            this.btn_editProfile.Location = new System.Drawing.Point(1, 551);
            this.btn_editProfile.Name = "btn_editProfile";
            this.btn_editProfile.Size = new System.Drawing.Size(156, 43);
            this.btn_editProfile.TabIndex = 77;
            this.btn_editProfile.Text = "Edit profile";
            this.btn_editProfile.UseVisualStyleBackColor = false;
            // 
            // btn_mngTreatments
            // 
            this.btn_mngTreatments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_mngTreatments.FlatAppearance.BorderSize = 0;
            this.btn_mngTreatments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mngTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mngTreatments.ForeColor = System.Drawing.Color.Black;
            this.btn_mngTreatments.Location = new System.Drawing.Point(1, 305);
            this.btn_mngTreatments.Name = "btn_mngTreatments";
            this.btn_mngTreatments.Size = new System.Drawing.Size(155, 43);
            this.btn_mngTreatments.TabIndex = 76;
            this.btn_mngTreatments.Text = "Manage Treatments";
            this.btn_mngTreatments.UseVisualStyleBackColor = false;
            this.btn_mngTreatments.Click += new System.EventHandler(this.btn_mngTreatments_Click);
            // 
            // btn_mngMaterials
            // 
            this.btn_mngMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_mngMaterials.FlatAppearance.BorderSize = 0;
            this.btn_mngMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mngMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mngMaterials.ForeColor = System.Drawing.Color.Black;
            this.btn_mngMaterials.Location = new System.Drawing.Point(1, 354);
            this.btn_mngMaterials.Name = "btn_mngMaterials";
            this.btn_mngMaterials.Size = new System.Drawing.Size(155, 43);
            this.btn_mngMaterials.TabIndex = 75;
            this.btn_mngMaterials.Text = "Manage Materials";
            this.btn_mngMaterials.UseVisualStyleBackColor = false;
            this.btn_mngMaterials.Click += new System.EventHandler(this.btn_mngMaterials_Click);
            // 
            // btn_mngCountries
            // 
            this.btn_mngCountries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_mngCountries.FlatAppearance.BorderSize = 0;
            this.btn_mngCountries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mngCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mngCountries.Location = new System.Drawing.Point(0, 452);
            this.btn_mngCountries.Name = "btn_mngCountries";
            this.btn_mngCountries.Size = new System.Drawing.Size(156, 43);
            this.btn_mngCountries.TabIndex = 74;
            this.btn_mngCountries.Text = "Manage Countries";
            this.btn_mngCountries.UseVisualStyleBackColor = false;
            this.btn_mngCountries.Click += new System.EventHandler(this.btn_mngCountries_Click);
            // 
            // btn_mngManufacturers
            // 
            this.btn_mngManufacturers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_mngManufacturers.FlatAppearance.BorderSize = 0;
            this.btn_mngManufacturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mngManufacturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mngManufacturers.ForeColor = System.Drawing.Color.Black;
            this.btn_mngManufacturers.Location = new System.Drawing.Point(2, 403);
            this.btn_mngManufacturers.Name = "btn_mngManufacturers";
            this.btn_mngManufacturers.Size = new System.Drawing.Size(154, 43);
            this.btn_mngManufacturers.TabIndex = 73;
            this.btn_mngManufacturers.Text = "Manage Manufacturers";
            this.btn_mngManufacturers.UseVisualStyleBackColor = false;
            this.btn_mngManufacturers.Click += new System.EventHandler(this.btn_mngManufacturers_Click);
            // 
            // btn_mngUsers
            // 
            this.btn_mngUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_mngUsers.FlatAppearance.BorderSize = 0;
            this.btn_mngUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mngUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mngUsers.Location = new System.Drawing.Point(2, 159);
            this.btn_mngUsers.Name = "btn_mngUsers";
            this.btn_mngUsers.Size = new System.Drawing.Size(154, 43);
            this.btn_mngUsers.TabIndex = 72;
            this.btn_mngUsers.Text = "Manage Users";
            this.btn_mngUsers.UseVisualStyleBackColor = false;
            this.btn_mngUsers.Click += new System.EventHandler(this.btn_mngUsers_Click);
            // 
            // btn_mngAppo
            // 
            this.btn_mngAppo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_mngAppo.FlatAppearance.BorderSize = 0;
            this.btn_mngAppo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mngAppo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mngAppo.ForeColor = System.Drawing.Color.Black;
            this.btn_mngAppo.Location = new System.Drawing.Point(2, 208);
            this.btn_mngAppo.Name = "btn_mngAppo";
            this.btn_mngAppo.Size = new System.Drawing.Size(155, 43);
            this.btn_mngAppo.TabIndex = 71;
            this.btn_mngAppo.Text = "Manage Appointments";
            this.btn_mngAppo.UseVisualStyleBackColor = false;
            this.btn_mngAppo.Click += new System.EventHandler(this.btn_mngAppo_Click);
            // 
            // pbUserPicture
            // 
            this.pbUserPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbUserPicture.BackgroundImage")));
            this.pbUserPicture.Location = new System.Drawing.Point(4, 4);
            this.pbUserPicture.Name = "pbUserPicture";
            this.pbUserPicture.Size = new System.Drawing.Size(154, 162);
            this.pbUserPicture.TabIndex = 70;
            this.pbUserPicture.TabStop = false;
            // 
            // btn_mngExam
            // 
            this.btn_mngExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_mngExam.FlatAppearance.BorderSize = 0;
            this.btn_mngExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mngExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mngExam.Location = new System.Drawing.Point(1, 256);
            this.btn_mngExam.Name = "btn_mngExam";
            this.btn_mngExam.Size = new System.Drawing.Size(155, 43);
            this.btn_mngExam.TabIndex = 10;
            this.btn_mngExam.Text = "Manage Examinations";
            this.btn_mngExam.UseVisualStyleBackColor = false;
            this.btn_mngExam.Click += new System.EventHandler(this.btn_mngExam_Click);
            // 
            // btn_mngCities
            // 
            this.btn_mngCities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_mngCities.FlatAppearance.BorderSize = 0;
            this.btn_mngCities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mngCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mngCities.ForeColor = System.Drawing.Color.Black;
            this.btn_mngCities.Location = new System.Drawing.Point(0, 502);
            this.btn_mngCities.Name = "btn_mngCities";
            this.btn_mngCities.Size = new System.Drawing.Size(156, 43);
            this.btn_mngCities.TabIndex = 7;
            this.btn_mngCities.Text = "Manage Cities";
            this.btn_mngCities.UseVisualStyleBackColor = false;
            this.btn_mngCities.Click += new System.EventHandler(this.btn_mngCities_Click);
            // 
            // frmAdminIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 639);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminIndex";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_editProfile;
        private System.Windows.Forms.Button btn_mngTreatments;
        private System.Windows.Forms.Button btn_mngMaterials;
        private System.Windows.Forms.Button btn_mngCountries;
        private System.Windows.Forms.Button btn_mngManufacturers;
        private System.Windows.Forms.Button btn_mngUsers;
        private System.Windows.Forms.Button btn_mngAppo;
        private System.Windows.Forms.PictureBox pbUserPicture;
        private System.Windows.Forms.Button btn_mngExam;
        private System.Windows.Forms.Button btn_mngCities;
    }
}