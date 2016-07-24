namespace ETS2_Company_Telemetry_Logger
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.bt_apply = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.txt_logPath = new System.Windows.Forms.TextBox();
            this.bt_logPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_apply
            // 
            this.bt_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_apply.ForeColor = System.Drawing.Color.Green;
            this.bt_apply.Location = new System.Drawing.Point(197, 61);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(75, 23);
            this.bt_apply.TabIndex = 0;
            this.bt_apply.Text = "Apply";
            this.bt_apply.UseVisualStyleBackColor = true;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancel.ForeColor = System.Drawing.Color.Red;
            this.bt_cancel.Location = new System.Drawing.Point(116, 61);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 1;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_logPath
            // 
            this.txt_logPath.Enabled = false;
            this.txt_logPath.Location = new System.Drawing.Point(12, 28);
            this.txt_logPath.Name = "txt_logPath";
            this.txt_logPath.Size = new System.Drawing.Size(179, 20);
            this.txt_logPath.TabIndex = 2;
            // 
            // bt_logPath
            // 
            this.bt_logPath.Location = new System.Drawing.Point(197, 26);
            this.bt_logPath.Name = "bt_logPath";
            this.bt_logPath.Size = new System.Drawing.Size(75, 23);
            this.bt_logPath.TabIndex = 3;
            this.bt_logPath.Text = "...";
            this.bt_logPath.UseVisualStyleBackColor = true;
            this.bt_logPath.Click += new System.EventHandler(this.bt_logPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log Path:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 96);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_logPath);
            this.Controls.Add(this.txt_logPath);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_apply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_apply;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.TextBox txt_logPath;
        private System.Windows.Forms.Button bt_logPath;
        private System.Windows.Forms.Label label1;
    }
}