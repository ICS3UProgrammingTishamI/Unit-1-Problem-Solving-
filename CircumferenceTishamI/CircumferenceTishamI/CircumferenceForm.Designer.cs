namespace CircumferenceTishamI
{
    partial class frmCircumference
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
            this.lblCalculations = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.mnuCircumference = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculations = new System.Windows.Forms.Button();
            this.mnuCircumference.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalculations
            // 
            this.lblCalculations.AutoSize = true;
            this.lblCalculations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculations.Location = new System.Drawing.Point(158, 272);
            this.lblCalculations.Name = "lblCalculations";
            this.lblCalculations.Size = new System.Drawing.Size(278, 25);
            this.lblCalculations.TabIndex = 0;
            this.lblCalculations.Text = "The criumianvfefrenf is vore";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(119, 109);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(317, 25);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Enter the radius of a circle (cm):";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(452, 109);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(116, 31);
            this.txtInput.TabIndex = 2;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // mnuCircumference
            // 
            this.mnuCircumference.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuCircumference.Location = new System.Drawing.Point(0, 0);
            this.mnuCircumference.Name = "mnuCircumference";
            this.mnuCircumference.Size = new System.Drawing.Size(800, 24);
            this.mnuCircumference.TabIndex = 3;
            this.mnuCircumference.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(92, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnCalculations
            // 
            this.btnCalculations.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculations.Location = new System.Drawing.Point(109, 146);
            this.btnCalculations.Name = "btnCalculations";
            this.btnCalculations.Size = new System.Drawing.Size(499, 105);
            this.btnCalculations.TabIndex = 4;
            this.btnCalculations.Text = "Calculate!";
            this.btnCalculations.UseVisualStyleBackColor = true;
            this.btnCalculations.Click += new System.EventHandler(this.btnCalculations_Click);
            // 
            // frmCircumference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculations);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblCalculations);
            this.Controls.Add(this.mnuCircumference);
            this.MainMenuStrip = this.mnuCircumference;
            this.Name = "frmCircumference";
            this.Text = "Circumference by Tisham Islam";
            this.mnuCircumference.ResumeLayout(false);
            this.mnuCircumference.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculations;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.MenuStrip mnuCircumference;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnCalculations;
    }
}

