namespace Monster_Battle_Sparkle
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonLoadGame = new System.Windows.Forms.Button();
            this.buttonQuitGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.timerGlowingLight = new System.Windows.Forms.Timer(this.components);
            this.buttonMultiplayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSetting.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.ForeColor = System.Drawing.Color.White;
            this.buttonSetting.Location = new System.Drawing.Point(82, 324);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(142, 35);
            this.buttonSetting.TabIndex = 2;
            this.buttonSetting.TabStop = false;
            this.buttonSetting.Text = "Setting";
            this.buttonSetting.UseVisualStyleBackColor = false;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonNewGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.ForeColor = System.Drawing.Color.White;
            this.buttonNewGame.Location = new System.Drawing.Point(82, 202);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(142, 35);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.TabStop = false;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonLoadGame
            // 
            this.buttonLoadGame.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLoadGame.Enabled = false;
            this.buttonLoadGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLoadGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadGame.ForeColor = System.Drawing.Color.White;
            this.buttonLoadGame.Location = new System.Drawing.Point(82, 243);
            this.buttonLoadGame.Name = "buttonLoadGame";
            this.buttonLoadGame.Size = new System.Drawing.Size(142, 35);
            this.buttonLoadGame.TabIndex = 1;
            this.buttonLoadGame.TabStop = false;
            this.buttonLoadGame.Text = "Load Game";
            this.buttonLoadGame.UseVisualStyleBackColor = false;
            this.buttonLoadGame.Click += new System.EventHandler(this.buttonLoadGame_Click);
            // 
            // buttonQuitGame
            // 
            this.buttonQuitGame.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonQuitGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonQuitGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonQuitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitGame.ForeColor = System.Drawing.Color.White;
            this.buttonQuitGame.Location = new System.Drawing.Point(82, 365);
            this.buttonQuitGame.Name = "buttonQuitGame";
            this.buttonQuitGame.Size = new System.Drawing.Size(142, 35);
            this.buttonQuitGame.TabIndex = 3;
            this.buttonQuitGame.TabStop = false;
            this.buttonQuitGame.Text = "Quit Game";
            this.buttonQuitGame.UseVisualStyleBackColor = false;
            this.buttonQuitGame.Click += new System.EventHandler(this.buttonQuitGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Monster_Battle_Sparkle.Properties.Resources.sparkleTitle;
            this.pictureBox1.Location = new System.Drawing.Point(58, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxTitle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTitle.Image")));
            this.pictureBoxTitle.Location = new System.Drawing.Point(-3, 8);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(309, 165);
            this.pictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTitle.TabIndex = 0;
            this.pictureBoxTitle.TabStop = false;
            // 
            // timerGlowingLight
            // 
            this.timerGlowingLight.Enabled = true;
            this.timerGlowingLight.Interval = 40;
            this.timerGlowingLight.Tick += new System.EventHandler(this.timerGlowingLight_Tick);
            // 
            // buttonMultiplayer
            // 
            this.buttonMultiplayer.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonMultiplayer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMultiplayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMultiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplayer.ForeColor = System.Drawing.Color.White;
            this.buttonMultiplayer.Location = new System.Drawing.Point(82, 283);
            this.buttonMultiplayer.Name = "buttonMultiplayer";
            this.buttonMultiplayer.Size = new System.Drawing.Size(142, 35);
            this.buttonMultiplayer.TabIndex = 4;
            this.buttonMultiplayer.TabStop = false;
            this.buttonMultiplayer.Text = "Multiplayer";
            this.buttonMultiplayer.UseVisualStyleBackColor = false;
            this.buttonMultiplayer.Click += new System.EventHandler(this.buttonMultiplayer_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.buttonMultiplayer);
            this.Controls.Add(this.buttonQuitGame);
            this.Controls.Add(this.buttonLoadGame);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonLoadGame;
        private System.Windows.Forms.Button buttonQuitGame;
        private System.Windows.Forms.Timer timerGlowingLight;
        private System.Windows.Forms.Button buttonMultiplayer;
    }
}