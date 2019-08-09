namespace EdingCncDatabinding
{
    partial class Form1
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
            this.ConnectCncServer = new System.Windows.Forms.Button();
            this.AxisX = new System.Windows.Forms.TextBox();
            this.AxisY = new System.Windows.Forms.TextBox();
            this.AxisZ = new System.Windows.Forms.TextBox();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_Z = new System.Windows.Forms.Label();
            this.SystemConfig = new System.Windows.Forms.Button();
            this.Poslimits = new System.Windows.Forms.GroupBox();
            this.PosLimit_X = new System.Windows.Forms.TextBox();
            this.label_PosLimitZ = new System.Windows.Forms.Label();
            this.PosLimit_Y = new System.Windows.Forms.TextBox();
            this.label_PosLimitY = new System.Windows.Forms.Label();
            this.PosLimit_Z = new System.Windows.Forms.TextBox();
            this.label_PosLimitX = new System.Windows.Forms.Label();
            this.IntervalTask = new System.Windows.Forms.TrackBar();
            this.Poslimits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalTask)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectCncServer
            // 
            this.ConnectCncServer.Location = new System.Drawing.Point(12, 12);
            this.ConnectCncServer.Name = "ConnectCncServer";
            this.ConnectCncServer.Size = new System.Drawing.Size(332, 23);
            this.ConnectCncServer.TabIndex = 0;
            this.ConnectCncServer.Text = "Connect To CncServer";
            this.ConnectCncServer.UseVisualStyleBackColor = true;
            this.ConnectCncServer.Click += new System.EventHandler(this.ConnectCncServer_Click);
            // 
            // AxisX
            // 
            this.AxisX.Location = new System.Drawing.Point(34, 41);
            this.AxisX.Name = "AxisX";
            this.AxisX.Size = new System.Drawing.Size(100, 20);
            this.AxisX.TabIndex = 1;
            // 
            // AxisY
            // 
            this.AxisY.Location = new System.Drawing.Point(34, 67);
            this.AxisY.Name = "AxisY";
            this.AxisY.Size = new System.Drawing.Size(100, 20);
            this.AxisY.TabIndex = 2;
            // 
            // AxisZ
            // 
            this.AxisZ.Location = new System.Drawing.Point(34, 93);
            this.AxisZ.Name = "AxisZ";
            this.AxisZ.Size = new System.Drawing.Size(100, 20);
            this.AxisZ.TabIndex = 3;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(14, 44);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(14, 13);
            this.label_X.TabIndex = 4;
            this.label_X.Text = "X";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(14, 70);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(14, 13);
            this.label_Y.TabIndex = 5;
            this.label_Y.Text = "Y";
            this.label_Y.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_Z
            // 
            this.label_Z.AutoSize = true;
            this.label_Z.Location = new System.Drawing.Point(14, 96);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(14, 13);
            this.label_Z.TabIndex = 6;
            this.label_Z.Text = "Z";
            // 
            // SystemConfig
            // 
            this.SystemConfig.Location = new System.Drawing.Point(6, 94);
            this.SystemConfig.Name = "SystemConfig";
            this.SystemConfig.Size = new System.Drawing.Size(124, 23);
            this.SystemConfig.TabIndex = 7;
            this.SystemConfig.Text = "Save SystemConfig";
            this.SystemConfig.UseVisualStyleBackColor = true;
            this.SystemConfig.Click += new System.EventHandler(this.SystemConfig_Click);
            // 
            // Poslimits
            // 
            this.Poslimits.Controls.Add(this.PosLimit_X);
            this.Poslimits.Controls.Add(this.SystemConfig);
            this.Poslimits.Controls.Add(this.label_PosLimitZ);
            this.Poslimits.Controls.Add(this.PosLimit_Y);
            this.Poslimits.Controls.Add(this.label_PosLimitY);
            this.Poslimits.Controls.Add(this.PosLimit_Z);
            this.Poslimits.Controls.Add(this.label_PosLimitX);
            this.Poslimits.Location = new System.Drawing.Point(144, 41);
            this.Poslimits.Name = "Poslimits";
            this.Poslimits.Size = new System.Drawing.Size(144, 125);
            this.Poslimits.TabIndex = 8;
            this.Poslimits.TabStop = false;
            this.Poslimits.Text = "Positive limit joints";
            // 
            // PosLimit_X
            // 
            this.PosLimit_X.Location = new System.Drawing.Point(31, 19);
            this.PosLimit_X.Name = "PosLimit_X";
            this.PosLimit_X.Size = new System.Drawing.Size(99, 20);
            this.PosLimit_X.TabIndex = 0;
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
            // PosLimit_Y
            // 
            this.PosLimit_Y.Location = new System.Drawing.Point(31, 45);
            this.PosLimit_Y.Name = "PosLimit_Y";
            this.PosLimit_Y.Size = new System.Drawing.Size(99, 20);
            this.PosLimit_Y.TabIndex = 1;
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
            // IntervalTask
            // 
            this.IntervalTask.Location = new System.Drawing.Point(12, 178);
            this.IntervalTask.Maximum = 1000;
            this.IntervalTask.Minimum = 1;
            this.IntervalTask.Name = "IntervalTask";
            this.IntervalTask.Size = new System.Drawing.Size(333, 45);
            this.IntervalTask.TabIndex = 9;
            this.IntervalTask.Value = 1;
            this.IntervalTask.Scroll += new System.EventHandler(this.IntervalTask_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 235);
            this.Controls.Add(this.IntervalTask);
            this.Controls.Add(this.Poslimits);
            this.Controls.Add(this.label_Z);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.AxisZ);
            this.Controls.Add(this.AxisY);
            this.Controls.Add(this.AxisX);
            this.Controls.Add(this.ConnectCncServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Poslimits.ResumeLayout(false);
            this.Poslimits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectCncServer;
        private System.Windows.Forms.TextBox AxisX;
        private System.Windows.Forms.TextBox AxisY;
        private System.Windows.Forms.TextBox AxisZ;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_Z;
        private System.Windows.Forms.Button SystemConfig;
        private System.Windows.Forms.GroupBox Poslimits;
        private System.Windows.Forms.TextBox PosLimit_X;
        private System.Windows.Forms.Label label_PosLimitZ;
        private System.Windows.Forms.TextBox PosLimit_Y;
        private System.Windows.Forms.Label label_PosLimitY;
        private System.Windows.Forms.TextBox PosLimit_Z;
        private System.Windows.Forms.Label label_PosLimitX;
        private System.Windows.Forms.TrackBar IntervalTask;
    }
}

