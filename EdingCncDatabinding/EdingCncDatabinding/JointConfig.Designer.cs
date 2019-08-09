namespace EdingCncDatabinding
{
    partial class JointConfig
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
            this.PosLimit_X = new System.Windows.Forms.TextBox();
            this.PosLimit_Y = new System.Windows.Forms.TextBox();
            this.PosLimit_Z = new System.Windows.Forms.TextBox();
            this.label_PosLimitX = new System.Windows.Forms.Label();
            this.label_PosLimitY = new System.Windows.Forms.Label();
            this.label_PosLimitZ = new System.Windows.Forms.Label();
            this.Poslimits = new System.Windows.Forms.GroupBox();
            this.Poslimits.SuspendLayout();
            this.SuspendLayout();
            // 
            // PosLimit_X
            // 
            this.PosLimit_X.Location = new System.Drawing.Point(31, 19);
            this.PosLimit_X.Name = "PosLimit_X";
            this.PosLimit_X.Size = new System.Drawing.Size(99, 20);
            this.PosLimit_X.TabIndex = 0;
            // 
            // PosLimit_Y
            // 
            this.PosLimit_Y.Location = new System.Drawing.Point(31, 45);
            this.PosLimit_Y.Name = "PosLimit_Y";
            this.PosLimit_Y.Size = new System.Drawing.Size(99, 20);
            this.PosLimit_Y.TabIndex = 1;
            // 
            // PosLimit_Z
            // 
            this.PosLimit_Z.Location = new System.Drawing.Point(31, 71);
            this.PosLimit_Z.Name = "PosLimit_Z";
            this.PosLimit_Z.Size = new System.Drawing.Size(99, 20);
            this.PosLimit_Z.TabIndex = 2;
            // 
            // label_PosLimitX
            // 
            this.label_PosLimitX.AutoSize = true;
            this.label_PosLimitX.Location = new System.Drawing.Point(11, 22);
            this.label_PosLimitX.Name = "label_PosLimitX";
            this.label_PosLimitX.Size = new System.Drawing.Size(14, 13);
            this.label_PosLimitX.TabIndex = 3;
            this.label_PosLimitX.Text = "X";
            // 
            // label_PosLimitY
            // 
            this.label_PosLimitY.AutoSize = true;
            this.label_PosLimitY.Location = new System.Drawing.Point(11, 52);
            this.label_PosLimitY.Name = "label_PosLimitY";
            this.label_PosLimitY.Size = new System.Drawing.Size(14, 13);
            this.label_PosLimitY.TabIndex = 4;
            this.label_PosLimitY.Text = "Y";
            // 
            // label_PosLimitZ
            // 
            this.label_PosLimitZ.AutoSize = true;
            this.label_PosLimitZ.Location = new System.Drawing.Point(11, 78);
            this.label_PosLimitZ.Name = "label_PosLimitZ";
            this.label_PosLimitZ.Size = new System.Drawing.Size(14, 13);
            this.label_PosLimitZ.TabIndex = 5;
            this.label_PosLimitZ.Text = "Z";
            // 
            // Poslimits
            // 
            this.Poslimits.Controls.Add(this.PosLimit_X);
            this.Poslimits.Controls.Add(this.label_PosLimitZ);
            this.Poslimits.Controls.Add(this.PosLimit_Y);
            this.Poslimits.Controls.Add(this.label_PosLimitY);
            this.Poslimits.Controls.Add(this.PosLimit_Z);
            this.Poslimits.Controls.Add(this.label_PosLimitX);
            this.Poslimits.Location = new System.Drawing.Point(245, 93);
            this.Poslimits.Name = "Poslimits";
            this.Poslimits.Size = new System.Drawing.Size(200, 100);
            this.Poslimits.TabIndex = 6;
            this.Poslimits.TabStop = false;
            this.Poslimits.Text = "Positive limit joints";
            // 
            // JointConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Poslimits);
            this.Name = "JointConfig";
            this.Text = "JointConfig";
            this.TopMost = true;
            this.Poslimits.ResumeLayout(false);
            this.Poslimits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PosLimit_X;
        private System.Windows.Forms.TextBox PosLimit_Y;
        private System.Windows.Forms.TextBox PosLimit_Z;
        private System.Windows.Forms.Label label_PosLimitX;
        private System.Windows.Forms.Label label_PosLimitY;
        private System.Windows.Forms.Label label_PosLimitZ;
        private System.Windows.Forms.GroupBox Poslimits;
    }
}