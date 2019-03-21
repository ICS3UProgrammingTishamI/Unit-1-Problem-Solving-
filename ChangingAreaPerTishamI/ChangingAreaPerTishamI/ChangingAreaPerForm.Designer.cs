namespace ChangingAreaPerTishamI
{
    partial class frmChangingAreaPer
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnCalculations = new System.Windows.Forms.Button();
            this.lblPerimeterCalculations = new System.Windows.Forms.Label();
            this.lblAreaCalculations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(28, 53);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(115, 25);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (m)";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(28, 144);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(104, 25);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width (m)";
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(199, 50);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(164, 31);
            this.txtLength.TabIndex = 2;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLength_KeyPress);
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(199, 138);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(164, 31);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWidth_KeyPress);
            // 
            // btnCalculations
            // 
            this.btnCalculations.Font = new System.Drawing.Font("Rosewood Std Regular", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculations.Location = new System.Drawing.Point(395, 23);
            this.btnCalculations.Name = "btnCalculations";
            this.btnCalculations.Size = new System.Drawing.Size(395, 186);
            this.btnCalculations.TabIndex = 4;
            this.btnCalculations.Text = "Calculate!";
            this.btnCalculations.UseVisualStyleBackColor = true;
            this.btnCalculations.Click += new System.EventHandler(this.btnCalculations_Click);
            // 
            // lblPerimeterCalculations
            // 
            this.lblPerimeterCalculations.AutoSize = true;
            this.lblPerimeterCalculations.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeterCalculations.Location = new System.Drawing.Point(27, 266);
            this.lblPerimeterCalculations.Name = "lblPerimeterCalculations";
            this.lblPerimeterCalculations.Size = new System.Drawing.Size(624, 31);
            this.lblPerimeterCalculations.TabIndex = 5;
            this.lblPerimeterCalculations.Text = "Lack of real text because you need to see this stuff";
            // 
            // lblAreaCalculations
            // 
            this.lblAreaCalculations.AutoSize = true;
            this.lblAreaCalculations.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaCalculations.Location = new System.Drawing.Point(27, 316);
            this.lblAreaCalculations.Name = "lblAreaCalculations";
            this.lblAreaCalculations.Size = new System.Drawing.Size(246, 31);
            this.lblAreaCalculations.TabIndex = 6;
            this.lblAreaCalculations.Text = "Same as the above";
            // 
            // frmChangingAreaPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAreaCalculations);
            this.Controls.Add(this.lblPerimeterCalculations);
            this.Controls.Add(this.btnCalculations);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "frmChangingAreaPer";
            this.Text = "Changing Area and Perimeter by Tisham Islam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalculations;
        private System.Windows.Forms.Label lblPerimeterCalculations;
        private System.Windows.Forms.Label lblAreaCalculations;
    }
}

