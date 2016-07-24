namespace ETS2_Company_Telemetry_Logger
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.realTime_timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_gear = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_income = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.gb_truck = new System.Windows.Forms.GroupBox();
            this.lbl_maxSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_trailer = new System.Windows.Forms.GroupBox();
            this.pb_trailerAttached = new System.Windows.Forms.PictureBox();
            this.lbl_trailerDamage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_trailerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_restart = new System.Windows.Forms.Button();
            this.gb_truck.SuspendLayout();
            this.gb_trailer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_trailerAttached)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // realTime_timer
            // 
            this.realTime_timer.Enabled = true;
            this.realTime_timer.Interval = 500;
            this.realTime_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed:";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(53, 16);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(12, 13);
            this.lbl_speed.TabIndex = 1;
            this.lbl_speed.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gear:";
            // 
            // lbl_gear
            // 
            this.lbl_gear.AutoSize = true;
            this.lbl_gear.Location = new System.Drawing.Point(45, 39);
            this.lbl_gear.Name = "lbl_gear";
            this.lbl_gear.Size = new System.Drawing.Size(12, 13);
            this.lbl_gear.TabIndex = 3;
            this.lbl_gear.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Income:";
            // 
            // lbl_income
            // 
            this.lbl_income.AutoSize = true;
            this.lbl_income.Location = new System.Drawing.Point(57, 39);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(12, 13);
            this.lbl_income.TabIndex = 5;
            this.lbl_income.Text = "x";
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Gold;
            this.lbl_status.Location = new System.Drawing.Point(49, 24);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(82, 17);
            this.lbl_status.TabIndex = 6;
            this.lbl_status.Text = "Working...";
            this.lbl_status.UseMnemonic = false;
            // 
            // gb_truck
            // 
            this.gb_truck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gb_truck.Controls.Add(this.lbl_maxSpeed);
            this.gb_truck.Controls.Add(this.label1);
            this.gb_truck.Controls.Add(this.label4);
            this.gb_truck.Controls.Add(this.lbl_speed);
            this.gb_truck.Controls.Add(this.label3);
            this.gb_truck.Controls.Add(this.lbl_gear);
            this.gb_truck.Location = new System.Drawing.Point(13, 79);
            this.gb_truck.Name = "gb_truck";
            this.gb_truck.Size = new System.Drawing.Size(147, 80);
            this.gb_truck.TabIndex = 7;
            this.gb_truck.TabStop = false;
            this.gb_truck.Text = "Truck:";
            // 
            // lbl_maxSpeed
            // 
            this.lbl_maxSpeed.AutoSize = true;
            this.lbl_maxSpeed.Location = new System.Drawing.Point(81, 62);
            this.lbl_maxSpeed.Name = "lbl_maxSpeed";
            this.lbl_maxSpeed.Size = new System.Drawing.Size(12, 13);
            this.lbl_maxSpeed.TabIndex = 11;
            this.lbl_maxSpeed.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max. Speed:";
            // 
            // gb_trailer
            // 
            this.gb_trailer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gb_trailer.Controls.Add(this.pb_trailerAttached);
            this.gb_trailer.Controls.Add(this.lbl_trailerDamage);
            this.gb_trailer.Controls.Add(this.label6);
            this.gb_trailer.Controls.Add(this.lbl_trailerName);
            this.gb_trailer.Controls.Add(this.label2);
            this.gb_trailer.Controls.Add(this.label5);
            this.gb_trailer.Controls.Add(this.lbl_income);
            this.gb_trailer.Location = new System.Drawing.Point(13, 168);
            this.gb_trailer.Name = "gb_trailer";
            this.gb_trailer.Size = new System.Drawing.Size(147, 142);
            this.gb_trailer.TabIndex = 9;
            this.gb_trailer.TabStop = false;
            this.gb_trailer.Text = "Trailer:";
            // 
            // pb_trailerAttached
            // 
            this.pb_trailerAttached.Image = global::ETS2_Company_Telemetry_Logger.Properties.Resources.not_att;
            this.pb_trailerAttached.Location = new System.Drawing.Point(9, 87);
            this.pb_trailerAttached.Name = "pb_trailerAttached";
            this.pb_trailerAttached.Size = new System.Drawing.Size(132, 50);
            this.pb_trailerAttached.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_trailerAttached.TabIndex = 10;
            this.pb_trailerAttached.TabStop = false;
            // 
            // lbl_trailerDamage
            // 
            this.lbl_trailerDamage.AutoSize = true;
            this.lbl_trailerDamage.Location = new System.Drawing.Point(62, 62);
            this.lbl_trailerDamage.Name = "lbl_trailerDamage";
            this.lbl_trailerDamage.Size = new System.Drawing.Size(12, 13);
            this.lbl_trailerDamage.TabIndex = 9;
            this.lbl_trailerDamage.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Damage:";
            // 
            // lbl_trailerName
            // 
            this.lbl_trailerName.AutoSize = true;
            this.lbl_trailerName.Location = new System.Drawing.Point(53, 16);
            this.lbl_trailerName.Name = "lbl_trailerName";
            this.lbl_trailerName.Size = new System.Drawing.Size(12, 13);
            this.lbl_trailerName.TabIndex = 7;
            this.lbl_trailerName.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(181, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.configurationToolStripMenuItem.Text = "Menu";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bt_restart
            // 
            this.bt_restart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_restart.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_restart.ForeColor = System.Drawing.Color.Black;
            this.bt_restart.Location = new System.Drawing.Point(48, 46);
            this.bt_restart.Name = "bt_restart";
            this.bt_restart.Size = new System.Drawing.Size(75, 23);
            this.bt_restart.TabIndex = 13;
            this.bt_restart.Text = "RESTART";
            this.bt_restart.UseVisualStyleBackColor = false;
            this.bt_restart.Visible = false;
            this.bt_restart.Click += new System.EventHandler(this.bt_restart_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 314);
            this.Controls.Add(this.bt_restart);
            this.Controls.Add(this.gb_trailer);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.gb_truck);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "TruckLog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.gb_truck.ResumeLayout(false);
            this.gb_truck.PerformLayout();
            this.gb_trailer.ResumeLayout(false);
            this.gb_trailer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_trailerAttached)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer realTime_timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_gear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_income;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.GroupBox gb_truck;
        private System.Windows.Forms.GroupBox gb_trailer;
        private System.Windows.Forms.Label lbl_trailerDamage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_trailerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_maxSpeed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_trailerAttached;
        private System.Windows.Forms.Button bt_restart;
    }
}

