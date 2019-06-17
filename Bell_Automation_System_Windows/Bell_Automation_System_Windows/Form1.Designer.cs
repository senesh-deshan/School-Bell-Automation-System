namespace Bell_Automation_System_Windows
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time_Label = new System.Windows.Forms.Label();
            this.Status_Strip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Data_ListBox = new System.Windows.Forms.ListBox();
            this.Bell_Up_Btn = new System.Windows.Forms.Button();
            this.Bell_Down_Btn = new System.Windows.Forms.Button();
            this.Bell_Up_Down_Btn = new System.Windows.Forms.Button();
            this.News_Btn = new System.Windows.Forms.Button();
            this.Fitness_Btn = new System.Windows.Forms.Button();
            this.Interval_Btn = new System.Windows.Forms.Button();
            this.Nat_Ant_Btn = new System.Windows.Forms.Button();
            this.Scl_EN_btn = new System.Windows.Forms.Button();
            this.Scl_SI_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.Songs_Browser = new System.Windows.Forms.FolderBrowserDialog();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Songs_ListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Start_Time = new System.Windows.Forms.TextBox();
            this.Stop_Time = new System.Windows.Forms.TextBox();
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.Warning_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Status_Strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Date/Time";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time_Label
            // 
            this.Time_Label.AutoSize = true;
            this.Time_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Label.Location = new System.Drawing.Point(147, 9);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(80, 17);
            this.Time_Label.TabIndex = 1;
            this.Time_Label.Text = "                  ";
            // 
            // Status_Strip
            // 
            this.Status_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Status_Label});
            this.Status_Strip.Location = new System.Drawing.Point(0, 679);
            this.Status_Strip.Name = "Status_Strip";
            this.Status_Strip.Size = new System.Drawing.Size(1258, 22);
            this.Status_Strip.TabIndex = 3;
            this.Status_Strip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(165, 17);
            this.toolStripStatusLabel1.Text = "©RCCS. All Rights Reserved.   ";
            // 
            // Status_Label
            // 
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(83, 17);
            this.Status_Label.Text = "System Online";
            // 
            // Data_ListBox
            // 
            this.Data_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_ListBox.FormattingEnabled = true;
            this.Data_ListBox.ItemHeight = 16;
            this.Data_ListBox.Items.AddRange(new object[] {
            " "});
            this.Data_ListBox.Location = new System.Drawing.Point(21, 67);
            this.Data_ListBox.Name = "Data_ListBox";
            this.Data_ListBox.Size = new System.Drawing.Size(237, 324);
            this.Data_ListBox.TabIndex = 4;
            // 
            // Bell_Up_Btn
            // 
            this.Bell_Up_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bell_Up_Btn.Location = new System.Drawing.Point(21, 409);
            this.Bell_Up_Btn.Name = "Bell_Up_Btn";
            this.Bell_Up_Btn.Size = new System.Drawing.Size(75, 75);
            this.Bell_Up_Btn.TabIndex = 5;
            this.Bell_Up_Btn.Text = "Bell Up";
            this.Bell_Up_Btn.UseVisualStyleBackColor = true;
            this.Bell_Up_Btn.Click += new System.EventHandler(this.Bell_Up_Btn_Click);
            // 
            // Bell_Down_Btn
            // 
            this.Bell_Down_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bell_Down_Btn.Location = new System.Drawing.Point(102, 409);
            this.Bell_Down_Btn.Name = "Bell_Down_Btn";
            this.Bell_Down_Btn.Size = new System.Drawing.Size(75, 75);
            this.Bell_Down_Btn.TabIndex = 6;
            this.Bell_Down_Btn.Text = "Bell Down";
            this.Bell_Down_Btn.UseVisualStyleBackColor = true;
            this.Bell_Down_Btn.Click += new System.EventHandler(this.Bell_Down_Btn_Click);
            // 
            // Bell_Up_Down_Btn
            // 
            this.Bell_Up_Down_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bell_Up_Down_Btn.Location = new System.Drawing.Point(183, 409);
            this.Bell_Up_Down_Btn.Name = "Bell_Up_Down_Btn";
            this.Bell_Up_Down_Btn.Size = new System.Drawing.Size(75, 75);
            this.Bell_Up_Down_Btn.TabIndex = 7;
            this.Bell_Up_Down_Btn.Text = "Bell Up Down";
            this.Bell_Up_Down_Btn.UseVisualStyleBackColor = true;
            this.Bell_Up_Down_Btn.Click += new System.EventHandler(this.Bell_Up_Down_Btn_Click);
            // 
            // News_Btn
            // 
            this.News_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.News_Btn.Location = new System.Drawing.Point(21, 490);
            this.News_Btn.Name = "News_Btn";
            this.News_Btn.Size = new System.Drawing.Size(75, 75);
            this.News_Btn.TabIndex = 8;
            this.News_Btn.Text = "News";
            this.News_Btn.UseVisualStyleBackColor = true;
            this.News_Btn.Click += new System.EventHandler(this.News_Btn_Click);
            // 
            // Fitness_Btn
            // 
            this.Fitness_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fitness_Btn.Location = new System.Drawing.Point(102, 490);
            this.Fitness_Btn.Name = "Fitness_Btn";
            this.Fitness_Btn.Size = new System.Drawing.Size(75, 75);
            this.Fitness_Btn.TabIndex = 9;
            this.Fitness_Btn.Text = "Fitness";
            this.Fitness_Btn.UseVisualStyleBackColor = true;
            this.Fitness_Btn.Click += new System.EventHandler(this.Fitness_Btn_Click);
            // 
            // Interval_Btn
            // 
            this.Interval_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval_Btn.Location = new System.Drawing.Point(183, 490);
            this.Interval_Btn.Name = "Interval_Btn";
            this.Interval_Btn.Size = new System.Drawing.Size(75, 75);
            this.Interval_Btn.TabIndex = 10;
            this.Interval_Btn.Text = "Interval";
            this.Interval_Btn.UseVisualStyleBackColor = true;
            this.Interval_Btn.Click += new System.EventHandler(this.Interval_Btn_Click);
            // 
            // Nat_Ant_Btn
            // 
            this.Nat_Ant_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nat_Ant_Btn.Location = new System.Drawing.Point(21, 571);
            this.Nat_Ant_Btn.Name = "Nat_Ant_Btn";
            this.Nat_Ant_Btn.Size = new System.Drawing.Size(75, 75);
            this.Nat_Ant_Btn.TabIndex = 11;
            this.Nat_Ant_Btn.Text = "National Anthem";
            this.Nat_Ant_Btn.UseVisualStyleBackColor = true;
            this.Nat_Ant_Btn.Click += new System.EventHandler(this.Nat_Ant_Btn_Click);
            // 
            // Scl_EN_btn
            // 
            this.Scl_EN_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scl_EN_btn.Location = new System.Drawing.Point(102, 571);
            this.Scl_EN_btn.Name = "Scl_EN_btn";
            this.Scl_EN_btn.Size = new System.Drawing.Size(75, 75);
            this.Scl_EN_btn.TabIndex = 12;
            this.Scl_EN_btn.Text = "School Song EN";
            this.Scl_EN_btn.UseVisualStyleBackColor = true;
            this.Scl_EN_btn.Click += new System.EventHandler(this.Scl_EN_btn_Click);
            // 
            // Scl_SI_btn
            // 
            this.Scl_SI_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scl_SI_btn.Location = new System.Drawing.Point(183, 571);
            this.Scl_SI_btn.Name = "Scl_SI_btn";
            this.Scl_SI_btn.Size = new System.Drawing.Size(75, 75);
            this.Scl_SI_btn.TabIndex = 13;
            this.Scl_SI_btn.Text = "School Song SI";
            this.Scl_SI_btn.UseVisualStyleBackColor = true;
            this.Scl_SI_btn.Click += new System.EventHandler(this.Scl_SI_btn_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.BackColor = System.Drawing.Color.Red;
            this.Stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_btn.ForeColor = System.Drawing.Color.White;
            this.Stop_btn.Location = new System.Drawing.Point(277, 490);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(155, 155);
            this.Stop_btn.TabIndex = 14;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.UseVisualStyleBackColor = false;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // Songs_Browser
            // 
            this.Songs_Browser.Description = "Songs File Location";
            this.Songs_Browser.SelectedPath = "C:\\Program Files";
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(851, 67);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(400, 324);
            this.axWindowsMediaPlayer.TabIndex = 15;
            this.axWindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer_PlayStateChange);
            // 
            // Songs_ListBox
            // 
            this.Songs_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Songs_ListBox.FormattingEnabled = true;
            this.Songs_ListBox.ItemHeight = 16;
            this.Songs_ListBox.Items.AddRange(new object[] {
            " "});
            this.Songs_ListBox.Location = new System.Drawing.Point(453, 65);
            this.Songs_ListBox.Name = "Songs_ListBox";
            this.Songs_ListBox.Size = new System.Drawing.Size(366, 580);
            this.Songs_ListBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Scheduled";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Songs List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1047, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "0/0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(890, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Songs Played / Total Songs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(909, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Start";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(909, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Stop";
            // 
            // Start_Time
            // 
            this.Start_Time.Location = new System.Drawing.Point(944, 494);
            this.Start_Time.Name = "Start_Time";
            this.Start_Time.Size = new System.Drawing.Size(100, 20);
            this.Start_Time.TabIndex = 24;
            // 
            // Stop_Time
            // 
            this.Stop_Time.Location = new System.Drawing.Point(944, 524);
            this.Stop_Time.Name = "Stop_Time";
            this.Stop_Time.Size = new System.Drawing.Size(100, 20);
            this.Stop_Time.TabIndex = 25;
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.Location = new System.Drawing.Point(1128, 435);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(45, 23);
            this.Reset_Btn.TabIndex = 26;
            this.Reset_Btn.Text = "Reset";
            this.Reset_Btn.UseVisualStyleBackColor = true;
            this.Reset_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Warning_Label
            // 
            this.Warning_Label.AutoSize = true;
            this.Warning_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning_Label.ForeColor = System.Drawing.Color.Red;
            this.Warning_Label.Location = new System.Drawing.Point(888, 571);
            this.Warning_Label.Name = "Warning_Label";
            this.Warning_Label.Size = new System.Drawing.Size(238, 25);
            this.Warning_Label.TabIndex = 27;
            this.Warning_Label.Text = "Songs list will end soon";
            this.Warning_Label.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bell_Automation_System_Windows.Properties.Resources.RCCS_logo;
            this.pictureBox1.Location = new System.Drawing.Point(919, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(996, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Project by";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(996, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Royal College Computer Society";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 701);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Warning_Label);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.Stop_Time);
            this.Controls.Add(this.Start_Time);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Songs_ListBox);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.Scl_SI_btn);
            this.Controls.Add(this.Scl_EN_btn);
            this.Controls.Add(this.Nat_Ant_Btn);
            this.Controls.Add(this.Interval_Btn);
            this.Controls.Add(this.Fitness_Btn);
            this.Controls.Add(this.News_Btn);
            this.Controls.Add(this.Bell_Up_Down_Btn);
            this.Controls.Add(this.Bell_Down_Btn);
            this.Controls.Add(this.Bell_Up_Btn);
            this.Controls.Add(this.Data_ListBox);
            this.Controls.Add(this.Status_Strip);
            this.Controls.Add(this.Time_Label);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "Royal College Bell Automation System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RCCS_Load);
            this.Status_Strip.ResumeLayout(false);
            this.Status_Strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time_Label;
        private System.Windows.Forms.StatusStrip Status_Strip;
        private System.Windows.Forms.ToolStripStatusLabel Status_Label;
        private System.Windows.Forms.ListBox Data_ListBox;
        private System.Windows.Forms.Button Bell_Up_Btn;
        private System.Windows.Forms.Button Bell_Down_Btn;
        private System.Windows.Forms.Button Bell_Up_Down_Btn;
        private System.Windows.Forms.Button News_Btn;
        private System.Windows.Forms.Button Fitness_Btn;
        private System.Windows.Forms.Button Interval_Btn;
        private System.Windows.Forms.Button Nat_Ant_Btn;
        private System.Windows.Forms.Button Scl_EN_btn;
        private System.Windows.Forms.Button Scl_SI_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.FolderBrowserDialog Songs_Browser;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.ListBox Songs_ListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Start_Time;
        private System.Windows.Forms.TextBox Stop_Time;
        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.Label Warning_Label;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}

