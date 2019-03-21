namespace PizzaCostTisham
{
    partial class frmPizzaCost
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
            this.nudDiameter = new System.Windows.Forms.NumericUpDown();
            this.lblWhatDiameterYouWant = new System.Windows.Forms.Label();
            this.lblCalculations = new System.Windows.Forms.Label();
            this.mnuPizzaCost = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).BeginInit();
            this.mnuPizzaCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudDiameter
            // 
            this.nudDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiameter.Location = new System.Drawing.Point(540, 87);
            this.nudDiameter.Name = "nudDiameter";
            this.nudDiameter.Size = new System.Drawing.Size(120, 31);
            this.nudDiameter.TabIndex = 0;
            // 
            // lblWhatDiameterYouWant
            // 
            this.lblWhatDiameterYouWant.AutoSize = true;
            this.lblWhatDiameterYouWant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatDiameterYouWant.Location = new System.Drawing.Point(25, 89);
            this.lblWhatDiameterYouWant.Name = "lblWhatDiameterYouWant";
            this.lblWhatDiameterYouWant.Size = new System.Drawing.Size(475, 25);
            this.lblWhatDiameterYouWant.TabIndex = 1;
            this.lblWhatDiameterYouWant.Text = "Please select the diameter of the pizza you want";
            // 
            // lblCalculations
            // 
            this.lblCalculations.AutoSize = true;
            this.lblCalculations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculations.Location = new System.Drawing.Point(58, 193);
            this.lblCalculations.Name = "lblCalculations";
            this.lblCalculations.Size = new System.Drawing.Size(243, 25);
            this.lblCalculations.TabIndex = 2;
            this.lblCalculations.Text = "This needs to be hidden";
            // 
            // mnuPizzaCost
            // 
            this.mnuPizzaCost.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuPizzaCost.Location = new System.Drawing.Point(0, 0);
            this.mnuPizzaCost.Name = "mnuPizzaCost";
            this.mnuPizzaCost.Size = new System.Drawing.Size(800, 24);
            this.mnuPizzaCost.TabIndex = 3;
            this.mnuPizzaCost.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // btnCalculations
            // 
            this.btnCalculations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculations.Location = new System.Drawing.Point(99, 137);
            this.btnCalculations.Name = "btnCalculations";
            this.btnCalculations.Size = new System.Drawing.Size(497, 53);
            this.btnCalculations.TabIndex = 4;
            this.btnCalculations.Text = "Calculate!";
            this.btnCalculations.UseVisualStyleBackColor = true;
            this.btnCalculations.Click += new System.EventHandler(this.btnCalculations_Click);
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculations);
            this.Controls.Add(this.lblCalculations);
            this.Controls.Add(this.lblWhatDiameterYouWant);
            this.Controls.Add(this.nudDiameter);
            this.Controls.Add(this.mnuPizzaCost);
            this.MainMenuStrip = this.mnuPizzaCost;
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost by Tisham Islam";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).EndInit();
            this.mnuPizzaCost.ResumeLayout(false);
            this.mnuPizzaCost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDiameter;
        private System.Windows.Forms.Label lblWhatDiameterYouWant;
        private System.Windows.Forms.Label lblCalculations;
        private System.Windows.Forms.MenuStrip mnuPizzaCost;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Button btnCalculations;
    }
}

