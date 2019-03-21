namespace SchoolMascotTishamI
{
    partial class frmSchoolMascot
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
            this.mnuSchools = new System.Windows.Forms.MenuStrip();
            this.mniSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStMarks = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMotherTeresa = new System.Windows.Forms.ToolStripMenuItem();
            this.grbBoxxy = new System.Windows.Forms.GroupBox();
            this.lblMascots = new System.Windows.Forms.Label();
            this.lblSchools = new System.Windows.Forms.Label();
            this.mnuSchools.SuspendLayout();
            this.grbBoxxy.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSchools
            // 
            this.mnuSchools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchools});
            this.mnuSchools.Location = new System.Drawing.Point(0, 0);
            this.mnuSchools.Name = "mnuSchools";
            this.mnuSchools.Size = new System.Drawing.Size(800, 24);
            this.mnuSchools.TabIndex = 0;
            this.mnuSchools.Text = "menuStrip1";
            // 
            // mniSchools
            // 
            this.mniSchools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniStMarks,
            this.mniMotherTeresa});
            this.mniSchools.Name = "mniSchools";
            this.mniSchools.Size = new System.Drawing.Size(60, 20);
            this.mniSchools.Text = "Schools";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(149, 22);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click);
            // 
            // mniStMarks
            // 
            this.mniStMarks.Name = "mniStMarks";
            this.mniStMarks.Size = new System.Drawing.Size(149, 22);
            this.mniStMarks.Text = "St. Mark\'s";
            this.mniStMarks.Click += new System.EventHandler(this.mniStMarks_Click);
            // 
            // mniMotherTeresa
            // 
            this.mniMotherTeresa.Name = "mniMotherTeresa";
            this.mniMotherTeresa.Size = new System.Drawing.Size(149, 22);
            this.mniMotherTeresa.Text = "Mother Teresa";
            this.mniMotherTeresa.Click += new System.EventHandler(this.mniMotherTeresa_Click);
            // 
            // grbBoxxy
            // 
            this.grbBoxxy.Controls.Add(this.lblMascots);
            this.grbBoxxy.Controls.Add(this.lblSchools);
            this.grbBoxxy.Location = new System.Drawing.Point(106, 115);
            this.grbBoxxy.Name = "grbBoxxy";
            this.grbBoxxy.Size = new System.Drawing.Size(441, 166);
            this.grbBoxxy.TabIndex = 1;
            this.grbBoxxy.TabStop = false;
            // 
            // lblMascots
            // 
            this.lblMascots.AutoSize = true;
            this.lblMascots.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascots.Location = new System.Drawing.Point(33, 83);
            this.lblMascots.Name = "lblMascots";
            this.lblMascots.Size = new System.Drawing.Size(289, 75);
            this.lblMascots.TabIndex = 1;
            this.lblMascots.Text = "Mascots";
            // 
            // lblSchools
            // 
            this.lblSchools.AutoSize = true;
            this.lblSchools.Font = new System.Drawing.Font("Rosewood Std Regular", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchools.Location = new System.Drawing.Point(33, 27);
            this.lblSchools.Name = "lblSchools";
            this.lblSchools.Size = new System.Drawing.Size(213, 56);
            this.lblSchools.TabIndex = 0;
            this.lblSchools.Text = "Schools";
            //
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbBoxxy);
            this.Controls.Add(this.mnuSchools);
            this.MainMenuStrip = this.mnuSchools;
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot by Tisham Islam";
            this.mnuSchools.ResumeLayout(false);
            this.mnuSchools.PerformLayout();
            this.grbBoxxy.ResumeLayout(false);
            this.grbBoxxy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSchools;
        private System.Windows.Forms.ToolStripMenuItem mniSchools;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniStMarks;
        private System.Windows.Forms.GroupBox grbBoxxy;
        private System.Windows.Forms.Label lblMascots;
        private System.Windows.Forms.Label lblSchools;
        private System.Windows.Forms.ToolStripMenuItem mniMotherTeresa;
    }
}

