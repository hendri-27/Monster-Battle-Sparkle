namespace Monster_Battle_Sparkle
{
    partial class FormMonsterCenterMap
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
            this.player = new System.Windows.Forms.PictureBox();
            this.timerUp = new System.Windows.Forms.Timer(this.components);
            this.timerDown = new System.Windows.Forms.Timer(this.components);
            this.timerLeft = new System.Windows.Forms.Timer(this.components);
            this.timerRight = new System.Windows.Forms.Timer(this.components);
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxNurse = new System.Windows.Forms.PictureBox();
            this.pictureBoxPokeBall = new System.Windows.Forms.PictureBox();
            this.panelYesNo = new System.Windows.Forms.Panel();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.panelChatWheel = new System.Windows.Forms.Panel();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.timerSaveGame = new System.Windows.Forms.Timer(this.components);
            this.panelBag = new System.Windows.Forms.Panel();
            this.labelMonster = new System.Windows.Forms.Label();
            this.labelBag = new System.Windows.Forms.Label();
            this.labelQuest = new System.Windows.Forms.Label();
            this.labelSetting = new System.Windows.Forms.Label();
            this.labelSaveGame = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNurse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokeBall)).BeginInit();
            this.panelYesNo.SuspendLayout();
            this.panelChatWheel.SuspendLayout();
            this.panelBag.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Monster_Battle_Sparkle.Properties.Resources.up_1;
            this.player.Location = new System.Drawing.Point(303, 366);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // timerUp
            // 
            this.timerUp.Interval = 80;
            this.timerUp.Tick += new System.EventHandler(this.TimerUp_Tick);
            // 
            // timerDown
            // 
            this.timerDown.Interval = 80;
            this.timerDown.Tick += new System.EventHandler(this.TimerDown_Tick);
            // 
            // timerLeft
            // 
            this.timerLeft.Interval = 80;
            this.timerLeft.Tick += new System.EventHandler(this.TimerLeft_Tick);
            // 
            // timerRight
            // 
            this.timerRight.Interval = 80;
            this.timerRight.Tick += new System.EventHandler(this.TimerRight_Tick);
            // 
            // timerGame
            // 
            this.timerGame.Interval = 2200;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // pictureBoxNurse
            // 
            this.pictureBoxNurse.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNurse.Image = global::Monster_Battle_Sparkle.Properties.Resources.npc_nurse;
            this.pictureBoxNurse.Location = new System.Drawing.Point(303, 110);
            this.pictureBoxNurse.Name = "pictureBoxNurse";
            this.pictureBoxNurse.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxNurse.TabIndex = 6;
            this.pictureBoxNurse.TabStop = false;
            // 
            // pictureBoxPokeBall
            // 
            this.pictureBoxPokeBall.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPokeBall.Image = global::Monster_Battle_Sparkle.Properties.Resources.pokeballDark;
            this.pictureBoxPokeBall.Location = new System.Drawing.Point(274, 94);
            this.pictureBoxPokeBall.Name = "pictureBoxPokeBall";
            this.pictureBoxPokeBall.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxPokeBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPokeBall.TabIndex = 10;
            this.pictureBoxPokeBall.TabStop = false;
            this.pictureBoxPokeBall.Visible = false;
            // 
            // panelYesNo
            // 
            this.panelYesNo.BackColor = System.Drawing.Color.Transparent;
            this.panelYesNo.Controls.Add(this.buttonNo);
            this.panelYesNo.Controls.Add(this.buttonYes);
            this.panelYesNo.Location = new System.Drawing.Point(538, 316);
            this.panelYesNo.Name = "panelYesNo";
            this.panelYesNo.Size = new System.Drawing.Size(75, 56);
            this.panelYesNo.TabIndex = 167;
            this.panelYesNo.Visible = false;
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonNo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNo.ForeColor = System.Drawing.Color.Black;
            this.buttonNo.Location = new System.Drawing.Point(0, 29);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(73, 27);
            this.buttonNo.TabIndex = 1;
            this.buttonNo.TabStop = false;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonYes.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYes.ForeColor = System.Drawing.Color.Black;
            this.buttonYes.Location = new System.Drawing.Point(0, 1);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(73, 28);
            this.buttonYes.TabIndex = 0;
            this.buttonYes.TabStop = false;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // panelChatWheel
            // 
            this.panelChatWheel.BackgroundImage = global::Monster_Battle_Sparkle.Properties.Resources.encounterWindow;
            this.panelChatWheel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChatWheel.Controls.Add(this.labelDisplay);
            this.panelChatWheel.Location = new System.Drawing.Point(0, 378);
            this.panelChatWheel.Name = "panelChatWheel";
            this.panelChatWheel.Size = new System.Drawing.Size(651, 72);
            this.panelChatWheel.TabIndex = 166;
            this.panelChatWheel.Visible = false;
            // 
            // labelDisplay
            // 
            this.labelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.labelDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplay.ForeColor = System.Drawing.Color.White;
            this.labelDisplay.Location = new System.Drawing.Point(33, 12);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(579, 48);
            this.labelDisplay.TabIndex = 168;
            this.labelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerSaveGame
            // 
            this.timerSaveGame.Interval = 3000;
            this.timerSaveGame.Tick += new System.EventHandler(this.timerSaveGame_Tick);
            // 
            // panelBag
            // 
            this.panelBag.BackColor = System.Drawing.Color.Transparent;
            this.panelBag.BackgroundImage = global::Monster_Battle_Sparkle.Properties.Resources.menuBackground;
            this.panelBag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBag.Controls.Add(this.labelMonster);
            this.panelBag.Controls.Add(this.labelBag);
            this.panelBag.Controls.Add(this.labelQuest);
            this.panelBag.Controls.Add(this.labelSetting);
            this.panelBag.Controls.Add(this.labelSaveGame);
            this.panelBag.Controls.Add(this.labelBack);
            this.panelBag.Location = new System.Drawing.Point(12, 12);
            this.panelBag.Name = "panelBag";
            this.panelBag.Size = new System.Drawing.Size(139, 229);
            this.panelBag.TabIndex = 168;
            this.panelBag.Visible = false;
            // 
            // labelMonster
            // 
            this.labelMonster.BackColor = System.Drawing.Color.Transparent;
            this.labelMonster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonster.Location = new System.Drawing.Point(12, 11);
            this.labelMonster.Name = "labelMonster";
            this.labelMonster.Size = new System.Drawing.Size(115, 35);
            this.labelMonster.TabIndex = 168;
            this.labelMonster.Text = "MONSTER";
            this.labelMonster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMonster.Click += new System.EventHandler(this.labelMonster_Click);
            this.labelMonster.MouseLeave += new System.EventHandler(this.labelMonster_MouseLeave);
            this.labelMonster.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelMonster_MouseMove);
            // 
            // labelBag
            // 
            this.labelBag.BackColor = System.Drawing.Color.Transparent;
            this.labelBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBag.Location = new System.Drawing.Point(12, 45);
            this.labelBag.Name = "labelBag";
            this.labelBag.Size = new System.Drawing.Size(115, 35);
            this.labelBag.TabIndex = 169;
            this.labelBag.Text = "BAG";
            this.labelBag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBag.Click += new System.EventHandler(this.labelBag_Click);
            this.labelBag.MouseLeave += new System.EventHandler(this.labelBag_MouseLeave);
            this.labelBag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelBag_MouseMove);
            // 
            // labelQuest
            // 
            this.labelQuest.BackColor = System.Drawing.Color.Transparent;
            this.labelQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuest.Location = new System.Drawing.Point(12, 79);
            this.labelQuest.Name = "labelQuest";
            this.labelQuest.Size = new System.Drawing.Size(115, 35);
            this.labelQuest.TabIndex = 170;
            this.labelQuest.Text = "QUEST";
            this.labelQuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuest.Click += new System.EventHandler(this.labelQuest_Click);
            this.labelQuest.MouseLeave += new System.EventHandler(this.labelQuest_MouseLeave);
            this.labelQuest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelQuest_MouseMove);
            // 
            // labelSetting
            // 
            this.labelSetting.BackColor = System.Drawing.Color.Transparent;
            this.labelSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetting.Location = new System.Drawing.Point(12, 113);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(115, 35);
            this.labelSetting.TabIndex = 171;
            this.labelSetting.Text = "SETTING";
            this.labelSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSetting.Click += new System.EventHandler(this.labelSetting_Click);
            this.labelSetting.MouseLeave += new System.EventHandler(this.labelSetting_MouseLeave);
            this.labelSetting.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelSetting_MouseMove);
            // 
            // labelSaveGame
            // 
            this.labelSaveGame.BackColor = System.Drawing.Color.Transparent;
            this.labelSaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaveGame.Location = new System.Drawing.Point(12, 147);
            this.labelSaveGame.Name = "labelSaveGame";
            this.labelSaveGame.Size = new System.Drawing.Size(115, 35);
            this.labelSaveGame.TabIndex = 172;
            this.labelSaveGame.Text = "SAVE GAME";
            this.labelSaveGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSaveGame.Click += new System.EventHandler(this.labelSaveGame_Click);
            this.labelSaveGame.MouseLeave += new System.EventHandler(this.labelSaveGame_MouseLeave);
            this.labelSaveGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelSaveGame_MouseMove);
            // 
            // labelBack
            // 
            this.labelBack.BackColor = System.Drawing.Color.Transparent;
            this.labelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.Location = new System.Drawing.Point(12, 181);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(115, 35);
            this.labelBack.TabIndex = 173;
            this.labelBack.Text = "BACK";
            this.labelBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            this.labelBack.MouseLeave += new System.EventHandler(this.labelBack_MouseLeave);
            this.labelBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelBack_MouseMove);
            // 
            // FormPokeCenterMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monster_Battle_Sparkle.Properties.Resources.Poke_Center_Map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.panelBag);
            this.Controls.Add(this.panelYesNo);
            this.Controls.Add(this.pictureBoxPokeBall);
            this.Controls.Add(this.panelChatWheel);
            this.Controls.Add(this.pictureBoxNurse);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "FormPokeCenterMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Poke Center Map";
            this.Load += new System.EventHandler(this.FormMonsterCenterMap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMonsterCenterMap_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMonsterCenterMap_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNurse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokeBall)).EndInit();
            this.panelYesNo.ResumeLayout(false);
            this.panelChatWheel.ResumeLayout(false);
            this.panelBag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timerUp;
        private System.Windows.Forms.Timer timerDown;
        private System.Windows.Forms.Timer timerLeft;
        private System.Windows.Forms.Timer timerRight;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.PictureBox pictureBoxNurse;
        private System.Windows.Forms.PictureBox pictureBoxPokeBall;
        private System.Windows.Forms.Panel panelYesNo;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Panel panelChatWheel;
        private System.Windows.Forms.Timer timerSaveGame;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.Panel panelBag;
        private System.Windows.Forms.Label labelMonster;
        private System.Windows.Forms.Label labelBag;
        private System.Windows.Forms.Label labelQuest;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.Label labelSaveGame;
        private System.Windows.Forms.Label labelBack;
    }
}