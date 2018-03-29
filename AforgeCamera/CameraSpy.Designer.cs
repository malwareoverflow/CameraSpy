namespace AforgeCamera
{
    partial class CameraSpy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraSpy));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Shotbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Shotbtn = new System.Windows.Forms.Button();
            this.browsebutton = new System.Windows.Forms.Button();
            this.savepathurl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stealthcheckbox = new System.Windows.Forms.CheckBox();
            this.stealthpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerseconds = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.stealthpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // Shotbutton
            // 
            this.Shotbutton.Location = new System.Drawing.Point(25, 425);
            this.Shotbutton.Name = "Shotbutton";
            this.Shotbutton.Size = new System.Drawing.Size(75, 23);
            this.Shotbutton.TabIndex = 1;
            this.Shotbutton.Text = "Start";
            this.Shotbutton.UseVisualStyleBackColor = true;
            this.Shotbutton.Click += new System.EventHandler(this.Startbutton_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(761, 227);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Shotbtn
            // 
            this.Shotbtn.Location = new System.Drawing.Point(166, 424);
            this.Shotbtn.Name = "Shotbtn";
            this.Shotbtn.Size = new System.Drawing.Size(75, 23);
            this.Shotbtn.TabIndex = 3;
            this.Shotbtn.Text = "Shot";
            this.Shotbtn.UseVisualStyleBackColor = true;
            this.Shotbtn.Click += new System.EventHandler(this.Shotbutton_Click);
            // 
            // browsebutton
            // 
            this.browsebutton.Location = new System.Drawing.Point(25, 285);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(75, 23);
            this.browsebutton.TabIndex = 4;
            this.browsebutton.Text = "Browse";
            this.browsebutton.UseVisualStyleBackColor = true;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);
            // 
            // savepathurl
            // 
            this.savepathurl.Location = new System.Drawing.Point(115, 287);
            this.savepathurl.Name = "savepathurl";
            this.savepathurl.Size = new System.Drawing.Size(100, 20);
            this.savepathurl.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Shot After Every";
            // 
            // stealthcheckbox
            // 
            this.stealthcheckbox.AutoSize = true;
            this.stealthcheckbox.Location = new System.Drawing.Point(25, 314);
            this.stealthcheckbox.Name = "stealthcheckbox";
            this.stealthcheckbox.Size = new System.Drawing.Size(86, 17);
            this.stealthcheckbox.TabIndex = 8;
            this.stealthcheckbox.Text = "StealthMode";
            this.stealthcheckbox.UseVisualStyleBackColor = true;
            this.stealthcheckbox.CheckedChanged += new System.EventHandler(this.stealthcheckbox_CheckedChanged);
            // 
            // stealthpanel
            // 
            this.stealthpanel.Controls.Add(this.label3);
            this.stealthpanel.Controls.Add(this.textBox1);
            this.stealthpanel.Controls.Add(this.label2);
            this.stealthpanel.Controls.Add(this.label4);
            this.stealthpanel.Controls.Add(this.timerseconds);
            this.stealthpanel.Controls.Add(this.label1);
            this.stealthpanel.Location = new System.Drawing.Point(25, 337);
            this.stealthpanel.Name = "stealthpanel";
            this.stealthpanel.Size = new System.Drawing.Size(304, 61);
            this.stealthpanel.TabIndex = 9;
            this.stealthpanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ctrl+";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Shortkey";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Seconds";
            // 
            // timerseconds
            // 
            this.timerseconds.Location = new System.Drawing.Point(93, 8);
            this.timerseconds.Name = "timerseconds";
            this.timerseconds.Size = new System.Drawing.Size(35, 20);
            this.timerseconds.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_tick);
            // 
            // CameraSpy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 473);
            this.Controls.Add(this.stealthpanel);
            this.Controls.Add(this.stealthcheckbox);
            this.Controls.Add(this.savepathurl);
            this.Controls.Add(this.browsebutton);
            this.Controls.Add(this.Shotbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Shotbutton);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CameraSpy";
            this.Text = "Camera Spy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.stealthpanel.ResumeLayout(false);
            this.stealthpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Shotbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Shotbtn;
        private System.Windows.Forms.Button browsebutton;
        private System.Windows.Forms.TextBox savepathurl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox stealthcheckbox;
        private System.Windows.Forms.Panel stealthpanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timerseconds;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

