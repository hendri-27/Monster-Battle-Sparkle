namespace Monster_Battle_Sparkle
{
    partial class FormSetting
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
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonBackToTitle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAudio = new System.Windows.Forms.Panel();
            this.labelVolume = new System.Windows.Forms.Label();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonHowToPlay = new System.Windows.Forms.Button();
            this.buttonAudioGame = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelHowToPlay = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.panelAudio.SuspendLayout();
            this.panelHowToPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(143, 29);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(152, 45);
            this.trackBarVolume.TabIndex = 0;
            this.trackBarVolume.TickFrequency = 10;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Transparent;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.buttonReset.Location = new System.Drawing.Point(95, 230);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(92, 35);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonBackToTitle
            // 
            this.buttonBackToTitle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.buttonBackToTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToTitle.ForeColor = System.Drawing.Color.White;
            this.buttonBackToTitle.Location = new System.Drawing.Point(4, 130);
            this.buttonBackToTitle.Name = "buttonBackToTitle";
            this.buttonBackToTitle.Size = new System.Drawing.Size(188, 40);
            this.buttonBackToTitle.TabIndex = 2;
            this.buttonBackToTitle.Text = "BACK TO TITLE";
            this.buttonBackToTitle.UseVisualStyleBackColor = true;
            this.buttonBackToTitle.Click += new System.EventHandler(this.buttonBackToTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Volume";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "             SETTINGS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAudio
            // 
            this.panelAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelAudio.Controls.Add(this.labelVolume);
            this.panelAudio.Controls.Add(this.buttonSaveChanges);
            this.panelAudio.Controls.Add(this.label1);
            this.panelAudio.Controls.Add(this.trackBarVolume);
            this.panelAudio.Controls.Add(this.buttonReset);
            this.panelAudio.Location = new System.Drawing.Point(196, 41);
            this.panelAudio.Name = "panelAudio";
            this.panelAudio.Size = new System.Drawing.Size(344, 278);
            this.panelAudio.TabIndex = 5;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.ForeColor = System.Drawing.Color.White;
            this.labelVolume.Location = new System.Drawing.Point(302, 33);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(19, 13);
            this.labelVolume.TabIndex = 1;
            this.labelVolume.Text = "50";
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveChanges.ForeColor = System.Drawing.Color.White;
            this.buttonSaveChanges.Location = new System.Drawing.Point(193, 230);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(139, 35);
            this.buttonSaveChanges.TabIndex = 4;
            this.buttonSaveChanges.Text = "SAVE CHANGES";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonHowToPlay
            // 
            this.buttonHowToPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.buttonHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHowToPlay.ForeColor = System.Drawing.Color.White;
            this.buttonHowToPlay.Location = new System.Drawing.Point(4, 86);
            this.buttonHowToPlay.Name = "buttonHowToPlay";
            this.buttonHowToPlay.Size = new System.Drawing.Size(188, 40);
            this.buttonHowToPlay.TabIndex = 6;
            this.buttonHowToPlay.Text = "HOW TO PLAY";
            this.buttonHowToPlay.UseVisualStyleBackColor = true;
            this.buttonHowToPlay.Click += new System.EventHandler(this.buttonHowToPlay_Click);
            // 
            // buttonAudioGame
            // 
            this.buttonAudioGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.buttonAudioGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAudioGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAudioGame.ForeColor = System.Drawing.Color.White;
            this.buttonAudioGame.Location = new System.Drawing.Point(4, 44);
            this.buttonAudioGame.Name = "buttonAudioGame";
            this.buttonAudioGame.Size = new System.Drawing.Size(188, 40);
            this.buttonAudioGame.TabIndex = 7;
            this.buttonAudioGame.Text = "AUDIO GAME";
            this.buttonAudioGame.UseVisualStyleBackColor = true;
            this.buttonAudioGame.Click += new System.EventHandler(this.buttonAudioGame_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(3, 274);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(188, 40);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelHowToPlay
            // 
            this.panelHowToPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelHowToPlay.Controls.Add(this.label15);
            this.panelHowToPlay.Controls.Add(this.label14);
            this.panelHowToPlay.Controls.Add(this.label12);
            this.panelHowToPlay.Controls.Add(this.label11);
            this.panelHowToPlay.Controls.Add(this.label10);
            this.panelHowToPlay.Controls.Add(this.label13);
            this.panelHowToPlay.Controls.Add(this.label7);
            this.panelHowToPlay.Controls.Add(this.label8);
            this.panelHowToPlay.Controls.Add(this.label9);
            this.panelHowToPlay.Controls.Add(this.label6);
            this.panelHowToPlay.Controls.Add(this.label5);
            this.panelHowToPlay.Controls.Add(this.label4);
            this.panelHowToPlay.Controls.Add(this.label3);
            this.panelHowToPlay.Location = new System.Drawing.Point(196, 41);
            this.panelHowToPlay.Name = "panelHowToPlay";
            this.panelHowToPlay.Size = new System.Drawing.Size(343, 278);
            this.panelHowToPlay.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(121, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 26);
            this.label15.TabIndex = 14;
            this.label15.Text = "S  /  Down";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(121, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 26);
            this.label14.TabIndex = 13;
            this.label14.Text = "Z";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(121, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 26);
            this.label12.TabIndex = 12;
            this.label12.Text = "B";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(121, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 26);
            this.label11.TabIndex = 11;
            this.label11.Text = "D  /  Right";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(121, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 26);
            this.label10.TabIndex = 10;
            this.label10.Text = "A  /  Left";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(121, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 26);
            this.label13.TabIndex = 9;
            this.label13.Text = "W  /  Up";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Right";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Menu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Talk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Up";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Down";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(178, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "KEYBOARD";
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(540, 318);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAudioGame);
            this.Controls.Add(this.buttonHowToPlay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBackToTitle);
            this.Controls.Add(this.panelAudio);
            this.Controls.Add(this.panelHowToPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.panelAudio.ResumeLayout(false);
            this.panelAudio.PerformLayout();
            this.panelHowToPlay.ResumeLayout(false);
            this.panelHowToPlay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonBackToTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelAudio;
        private System.Windows.Forms.Button buttonHowToPlay;
        private System.Windows.Forms.Button buttonAudioGame;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Panel panelHowToPlay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}