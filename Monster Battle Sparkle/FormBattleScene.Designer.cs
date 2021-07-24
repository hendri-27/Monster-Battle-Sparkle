namespace Monster_Battle_Sparkle
{
    partial class FormBattleScene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBattleScene));
            this.label6 = new System.Windows.Forms.Label();
            this.labelPlayerMonster = new System.Windows.Forms.Label();
            this.labelLevelPlayerMonster = new System.Windows.Forms.Label();
            this.progressBarPlayerHp = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.labelEnemyMonster = new System.Windows.Forms.Label();
            this.labelLevelEnemyMonster = new System.Windows.Forms.Label();
            this.progressBarEnemyHp = new System.Windows.Forms.ProgressBar();
            this.progressBarPlayerExp = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEnemyBar = new System.Windows.Forms.Panel();
            this.pictureBoxEnemyBar = new System.Windows.Forms.PictureBox();
            this.panelPlayerBar = new System.Windows.Forms.Panel();
            this.labelPlayerHP = new System.Windows.Forms.Label();
            this.pictureBoxPlayerBar = new System.Windows.Forms.PictureBox();
            this.buttonFight = new System.Windows.Forms.Button();
            this.buttonBag = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonMonster = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSkill3 = new System.Windows.Forms.Button();
            this.buttonSkill2 = new System.Windows.Forms.Button();
            this.buttonSkill4 = new System.Windows.Forms.Button();
            this.buttonSkill1 = new System.Windows.Forms.Button();
            this.panelButtonGame = new System.Windows.Forms.Panel();
            this.labelTextBattle = new System.Windows.Forms.Label();
            this.timerEnemyAppeared = new System.Windows.Forms.Timer(this.components);
            this.timerEndGame = new System.Windows.Forms.Timer(this.components);
            this.timerGetAttacked = new System.Windows.Forms.Timer(this.components);
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.timerPlayerTurn = new System.Windows.Forms.Timer(this.components);
            this.timerEnemyTurn = new System.Windows.Forms.Timer(this.components);
            this.timerExpBar = new System.Windows.Forms.Timer(this.components);
            this.timerPokeball = new System.Windows.Forms.Timer(this.components);
            this.timerFlee = new System.Windows.Forms.Timer(this.components);
            this.pokeball = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.timerPlayerLose = new System.Windows.Forms.Timer(this.components);
            this.panelEnemyBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyBar)).BeginInit();
            this.panelPlayerBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerBar)).BeginInit();
            this.panelButtonGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokeball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 9);
            this.label6.TabIndex = 36;
            this.label6.Text = "HP";
            // 
            // labelPlayerMonster
            // 
            this.labelPlayerMonster.AutoSize = true;
            this.labelPlayerMonster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.labelPlayerMonster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerMonster.ForeColor = System.Drawing.Color.Black;
            this.labelPlayerMonster.Location = new System.Drawing.Point(9, 8);
            this.labelPlayerMonster.Name = "labelPlayerMonster";
            this.labelPlayerMonster.Size = new System.Drawing.Size(54, 13);
            this.labelPlayerMonster.TabIndex = 34;
            this.labelPlayerMonster.Text = "PIKACHU";
            // 
            // labelLevelPlayerMonster
            // 
            this.labelLevelPlayerMonster.AutoSize = true;
            this.labelLevelPlayerMonster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.labelLevelPlayerMonster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevelPlayerMonster.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLevelPlayerMonster.Location = new System.Drawing.Point(84, 8);
            this.labelLevelPlayerMonster.Name = "labelLevelPlayerMonster";
            this.labelLevelPlayerMonster.Size = new System.Drawing.Size(31, 13);
            this.labelLevelPlayerMonster.TabIndex = 33;
            this.labelLevelPlayerMonster.Text = "Lv. 1";
            // 
            // progressBarPlayerHp
            // 
            this.progressBarPlayerHp.ForeColor = System.Drawing.Color.Green;
            this.progressBarPlayerHp.Location = new System.Drawing.Point(41, 25);
            this.progressBarPlayerHp.Maximum = 23;
            this.progressBarPlayerHp.Name = "progressBarPlayerHp";
            this.progressBarPlayerHp.Size = new System.Drawing.Size(80, 10);
            this.progressBarPlayerHp.Step = 1;
            this.progressBarPlayerHp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarPlayerHp.TabIndex = 32;
            this.progressBarPlayerHp.Value = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(24, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 9);
            this.label10.TabIndex = 42;
            this.label10.Text = "HP";
            // 
            // labelEnemyMonster
            // 
            this.labelEnemyMonster.AutoSize = true;
            this.labelEnemyMonster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.labelEnemyMonster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnemyMonster.ForeColor = System.Drawing.Color.Black;
            this.labelEnemyMonster.Location = new System.Drawing.Point(9, 8);
            this.labelEnemyMonster.Name = "labelEnemyMonster";
            this.labelEnemyMonster.Size = new System.Drawing.Size(0, 13);
            this.labelEnemyMonster.TabIndex = 40;
            // 
            // labelLevelEnemyMonster
            // 
            this.labelLevelEnemyMonster.AutoSize = true;
            this.labelLevelEnemyMonster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.labelLevelEnemyMonster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevelEnemyMonster.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLevelEnemyMonster.Location = new System.Drawing.Point(83, 8);
            this.labelLevelEnemyMonster.Name = "labelLevelEnemyMonster";
            this.labelLevelEnemyMonster.Size = new System.Drawing.Size(31, 13);
            this.labelLevelEnemyMonster.TabIndex = 39;
            this.labelLevelEnemyMonster.Text = "Lv. 1";
            // 
            // progressBarEnemyHp
            // 
            this.progressBarEnemyHp.ForeColor = System.Drawing.Color.Green;
            this.progressBarEnemyHp.Location = new System.Drawing.Point(41, 25);
            this.progressBarEnemyHp.Maximum = 23;
            this.progressBarEnemyHp.Name = "progressBarEnemyHp";
            this.progressBarEnemyHp.Size = new System.Drawing.Size(80, 10);
            this.progressBarEnemyHp.Step = 1;
            this.progressBarEnemyHp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarEnemyHp.TabIndex = 38;
            this.progressBarEnemyHp.Value = 23;
            // 
            // progressBarPlayerExp
            // 
            this.progressBarPlayerExp.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.progressBarPlayerExp.Location = new System.Drawing.Point(37, 55);
            this.progressBarPlayerExp.Maximum = 25;
            this.progressBarPlayerExp.Name = "progressBarPlayerExp";
            this.progressBarPlayerExp.Size = new System.Drawing.Size(90, 9);
            this.progressBarPlayerExp.Step = 100;
            this.progressBarPlayerExp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarPlayerExp.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 9);
            this.label1.TabIndex = 44;
            this.label1.Text = "EXP";
            // 
            // panelEnemyBar
            // 
            this.panelEnemyBar.Controls.Add(this.progressBarEnemyHp);
            this.panelEnemyBar.Controls.Add(this.labelLevelEnemyMonster);
            this.panelEnemyBar.Controls.Add(this.labelEnemyMonster);
            this.panelEnemyBar.Controls.Add(this.label10);
            this.panelEnemyBar.Controls.Add(this.pictureBoxEnemyBar);
            this.panelEnemyBar.Location = new System.Drawing.Point(70, 12);
            this.panelEnemyBar.Name = "panelEnemyBar";
            this.panelEnemyBar.Size = new System.Drawing.Size(133, 46);
            this.panelEnemyBar.TabIndex = 47;
            this.panelEnemyBar.Visible = false;
            // 
            // pictureBoxEnemyBar
            // 
            this.pictureBoxEnemyBar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemyBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxEnemyBar.Image = global::Monster_Battle_Sparkle.Properties.Resources.encounterSelectWindow;
            this.pictureBoxEnemyBar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEnemyBar.Name = "pictureBoxEnemyBar";
            this.pictureBoxEnemyBar.Size = new System.Drawing.Size(133, 46);
            this.pictureBoxEnemyBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemyBar.TabIndex = 41;
            this.pictureBoxEnemyBar.TabStop = false;
            // 
            // panelPlayerBar
            // 
            this.panelPlayerBar.BackColor = System.Drawing.Color.Transparent;
            this.panelPlayerBar.Controls.Add(this.labelPlayerHP);
            this.panelPlayerBar.Controls.Add(this.progressBarPlayerHp);
            this.panelPlayerBar.Controls.Add(this.label1);
            this.panelPlayerBar.Controls.Add(this.labelLevelPlayerMonster);
            this.panelPlayerBar.Controls.Add(this.progressBarPlayerExp);
            this.panelPlayerBar.Controls.Add(this.labelPlayerMonster);
            this.panelPlayerBar.Controls.Add(this.label6);
            this.panelPlayerBar.Controls.Add(this.pictureBoxPlayerBar);
            this.panelPlayerBar.Location = new System.Drawing.Point(184, 139);
            this.panelPlayerBar.Name = "panelPlayerBar";
            this.panelPlayerBar.Size = new System.Drawing.Size(133, 67);
            this.panelPlayerBar.TabIndex = 48;
            this.panelPlayerBar.Visible = false;
            // 
            // labelPlayerHP
            // 
            this.labelPlayerHP.AutoSize = true;
            this.labelPlayerHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.labelPlayerHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerHP.ForeColor = System.Drawing.Color.Black;
            this.labelPlayerHP.Location = new System.Drawing.Point(70, 35);
            this.labelPlayerHP.Name = "labelPlayerHP";
            this.labelPlayerHP.Size = new System.Drawing.Size(42, 13);
            this.labelPlayerHP.TabIndex = 45;
            this.labelPlayerHP.Text = "23 / 23";
            // 
            // pictureBoxPlayerBar
            // 
            this.pictureBoxPlayerBar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayerBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPlayerBar.Image = global::Monster_Battle_Sparkle.Properties.Resources.encounterSelectWindowExpBar;
            this.pictureBoxPlayerBar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPlayerBar.Name = "pictureBoxPlayerBar";
            this.pictureBoxPlayerBar.Size = new System.Drawing.Size(133, 67);
            this.pictureBoxPlayerBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayerBar.TabIndex = 35;
            this.pictureBoxPlayerBar.TabStop = false;
            // 
            // buttonFight
            // 
            this.buttonFight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonFight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonFight.FlatAppearance.BorderSize = 3;
            this.buttonFight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFight.Font = new System.Drawing.Font("Impact", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFight.ForeColor = System.Drawing.Color.White;
            this.buttonFight.Location = new System.Drawing.Point(33, 15);
            this.buttonFight.Name = "buttonFight";
            this.buttonFight.Size = new System.Drawing.Size(316, 182);
            this.buttonFight.TabIndex = 49;
            this.buttonFight.Text = "FIGHT";
            this.buttonFight.UseVisualStyleBackColor = false;
            this.buttonFight.Click += new System.EventHandler(this.ButtonFight_Click);
            // 
            // buttonBag
            // 
            this.buttonBag.BackColor = System.Drawing.Color.Orange;
            this.buttonBag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBag.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBag.FlatAppearance.BorderSize = 3;
            this.buttonBag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBag.Location = new System.Drawing.Point(287, 217);
            this.buttonBag.Name = "buttonBag";
            this.buttonBag.Size = new System.Drawing.Size(82, 37);
            this.buttonBag.TabIndex = 52;
            this.buttonBag.Text = "BAG";
            this.buttonBag.UseVisualStyleBackColor = false;
            // 
            // buttonRun
            // 
            this.buttonRun.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRun.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRun.FlatAppearance.BorderSize = 3;
            this.buttonRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRun.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRun.Location = new System.Drawing.Point(149, 217);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(91, 37);
            this.buttonRun.TabIndex = 51;
            this.buttonRun.Text = "RUN";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // buttonMonster
            // 
            this.buttonMonster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(67)))), ((int)(((byte)(24)))));
            this.buttonMonster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMonster.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMonster.FlatAppearance.BorderSize = 3;
            this.buttonMonster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMonster.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonster.ForeColor = System.Drawing.Color.White;
            this.buttonMonster.Location = new System.Drawing.Point(13, 217);
            this.buttonMonster.Name = "buttonMonster";
            this.buttonMonster.Size = new System.Drawing.Size(90, 37);
            this.buttonMonster.TabIndex = 50;
            this.buttonMonster.Text = "MONSTER";
            this.buttonMonster.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderSize = 3;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(13, 210);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(356, 48);
            this.buttonCancel.TabIndex = 53;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSkill3
            // 
            this.buttonSkill3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(29)))), ((int)(((byte)(92)))));
            this.buttonSkill3.Enabled = false;
            this.buttonSkill3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSkill3.FlatAppearance.BorderSize = 3;
            this.buttonSkill3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkill3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkill3.ForeColor = System.Drawing.Color.White;
            this.buttonSkill3.Location = new System.Drawing.Point(45, 110);
            this.buttonSkill3.Name = "buttonSkill3";
            this.buttonSkill3.Size = new System.Drawing.Size(143, 62);
            this.buttonSkill3.TabIndex = 57;
            this.buttonSkill3.UseVisualStyleBackColor = false;
            this.buttonSkill3.Click += new System.EventHandler(this.buttonSkill3_Click);
            // 
            // buttonSkill2
            // 
            this.buttonSkill2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(29)))), ((int)(((byte)(92)))));
            this.buttonSkill2.Enabled = false;
            this.buttonSkill2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSkill2.FlatAppearance.BorderSize = 3;
            this.buttonSkill2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkill2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkill2.ForeColor = System.Drawing.Color.White;
            this.buttonSkill2.Location = new System.Drawing.Point(194, 42);
            this.buttonSkill2.Name = "buttonSkill2";
            this.buttonSkill2.Size = new System.Drawing.Size(143, 62);
            this.buttonSkill2.TabIndex = 56;
            this.buttonSkill2.UseVisualStyleBackColor = false;
            this.buttonSkill2.Click += new System.EventHandler(this.buttonSkill2_Click);
            // 
            // buttonSkill4
            // 
            this.buttonSkill4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(29)))), ((int)(((byte)(92)))));
            this.buttonSkill4.Enabled = false;
            this.buttonSkill4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSkill4.FlatAppearance.BorderSize = 3;
            this.buttonSkill4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkill4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkill4.ForeColor = System.Drawing.Color.White;
            this.buttonSkill4.Location = new System.Drawing.Point(194, 110);
            this.buttonSkill4.Name = "buttonSkill4";
            this.buttonSkill4.Size = new System.Drawing.Size(143, 62);
            this.buttonSkill4.TabIndex = 55;
            this.buttonSkill4.UseVisualStyleBackColor = false;
            this.buttonSkill4.Click += new System.EventHandler(this.buttonSkill4_Click);
            // 
            // buttonSkill1
            // 
            this.buttonSkill1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(29)))), ((int)(((byte)(92)))));
            this.buttonSkill1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSkill1.FlatAppearance.BorderSize = 3;
            this.buttonSkill1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkill1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkill1.ForeColor = System.Drawing.Color.White;
            this.buttonSkill1.Location = new System.Drawing.Point(45, 42);
            this.buttonSkill1.Name = "buttonSkill1";
            this.buttonSkill1.Size = new System.Drawing.Size(143, 62);
            this.buttonSkill1.TabIndex = 54;
            this.buttonSkill1.Text = "Tackle";
            this.buttonSkill1.UseVisualStyleBackColor = false;
            this.buttonSkill1.Click += new System.EventHandler(this.buttonSkill1_Click);
            // 
            // panelButtonGame
            // 
            this.panelButtonGame.BackColor = System.Drawing.Color.Transparent;
            this.panelButtonGame.Controls.Add(this.buttonCancel);
            this.panelButtonGame.Controls.Add(this.buttonFight);
            this.panelButtonGame.Controls.Add(this.buttonSkill3);
            this.panelButtonGame.Controls.Add(this.buttonSkill2);
            this.panelButtonGame.Controls.Add(this.buttonSkill4);
            this.panelButtonGame.Controls.Add(this.buttonSkill1);
            this.panelButtonGame.Controls.Add(this.buttonMonster);
            this.panelButtonGame.Controls.Add(this.buttonBag);
            this.panelButtonGame.Controls.Add(this.buttonRun);
            this.panelButtonGame.Location = new System.Drawing.Point(0, 286);
            this.panelButtonGame.Name = "panelButtonGame";
            this.panelButtonGame.Size = new System.Drawing.Size(380, 267);
            this.panelButtonGame.TabIndex = 58;
            this.panelButtonGame.Visible = false;
            // 
            // labelTextBattle
            // 
            this.labelTextBattle.BackColor = System.Drawing.Color.Transparent;
            this.labelTextBattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextBattle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTextBattle.Location = new System.Drawing.Point(20, 229);
            this.labelTextBattle.Name = "labelTextBattle";
            this.labelTextBattle.Size = new System.Drawing.Size(341, 37);
            this.labelTextBattle.TabIndex = 59;
            this.labelTextBattle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerEnemyAppeared
            // 
            this.timerEnemyAppeared.Enabled = true;
            this.timerEnemyAppeared.Interval = 2000;
            this.timerEnemyAppeared.Tick += new System.EventHandler(this.timerEnemyAppeared_Tick);
            // 
            // timerEndGame
            // 
            this.timerEndGame.Interval = 2000;
            this.timerEndGame.Tick += new System.EventHandler(this.timerEndGame_Tick);
            // 
            // timerGetAttacked
            // 
            this.timerGetAttacked.Tick += new System.EventHandler(this.timerGetAttacked_Tick);
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Interval = 40;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // timerPlayerTurn
            // 
            this.timerPlayerTurn.Tick += new System.EventHandler(this.timerPlayerTurn_Tick);
            // 
            // timerEnemyTurn
            // 
            this.timerEnemyTurn.Interval = 1000;
            this.timerEnemyTurn.Tick += new System.EventHandler(this.timerEnemyTurn_Tick);
            // 
            // timerExpBar
            // 
            this.timerExpBar.Interval = 40;
            this.timerExpBar.Tick += new System.EventHandler(this.timerExpBar_Tick);
            // 
            // timerPokeball
            // 
            this.timerPokeball.Interval = 1;
            this.timerPokeball.Tick += new System.EventHandler(this.timerPokeball_Tick);
            // 
            // timerFlee
            // 
            this.timerFlee.Interval = 2000;
            this.timerFlee.Tick += new System.EventHandler(this.timerFlee_Tick);
            // 
            // pokeball
            // 
            this.pokeball.BackColor = System.Drawing.Color.Transparent;
            this.pokeball.Image = ((System.Drawing.Image)(resources.GetObject("pokeball.Image")));
            this.pokeball.Location = new System.Drawing.Point(-30, 90);
            this.pokeball.Name = "pokeball";
            this.pokeball.Size = new System.Drawing.Size(27, 40);
            this.pokeball.TabIndex = 60;
            this.pokeball.TabStop = false;
            this.pokeball.Visible = false;
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemy.Location = new System.Drawing.Point(235, 63);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEnemy.TabIndex = 46;
            this.pictureBoxEnemy.TabStop = false;
            this.pictureBoxEnemy.Visible = false;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer.Image = global::Monster_Battle_Sparkle.Properties.Resources.pikachu_Back;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(50, 129);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(100, 83);
            this.pictureBoxPlayer.TabIndex = 45;
            this.pictureBoxPlayer.TabStop = false;
            this.pictureBoxPlayer.Visible = false;
            // 
            // timerPlayerLose
            // 
            this.timerPlayerLose.Interval = 1000;
            this.timerPlayerLose.Tick += new System.EventHandler(this.timerPlayerLose_Tick);
            // 
            // FormBattleScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monster_Battle_Sparkle.Properties.Resources.battle_scene;
            this.ClientSize = new System.Drawing.Size(380, 550);
            this.Controls.Add(this.pokeball);
            this.Controls.Add(this.labelTextBattle);
            this.Controls.Add(this.pictureBoxEnemy);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.panelEnemyBar);
            this.Controls.Add(this.panelPlayerBar);
            this.Controls.Add(this.panelButtonGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormBattleScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormBattleScene_Load);
            this.panelEnemyBar.ResumeLayout(false);
            this.panelEnemyBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyBar)).EndInit();
            this.panelPlayerBar.ResumeLayout(false);
            this.panelPlayerBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerBar)).EndInit();
            this.panelButtonGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pokeball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPlayerMonster;
        private System.Windows.Forms.Label labelLevelPlayerMonster;
        private System.Windows.Forms.ProgressBar progressBarPlayerHp;
        private System.Windows.Forms.PictureBox pictureBoxPlayerBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelEnemyMonster;
        private System.Windows.Forms.Label labelLevelEnemyMonster;
        private System.Windows.Forms.ProgressBar progressBarEnemyHp;
        private System.Windows.Forms.PictureBox pictureBoxEnemyBar;
        private System.Windows.Forms.ProgressBar progressBarPlayerExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxEnemy;
        private System.Windows.Forms.Panel panelEnemyBar;
        private System.Windows.Forms.Panel panelPlayerBar;
        private System.Windows.Forms.Button buttonFight;
        private System.Windows.Forms.Button buttonBag;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonMonster;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSkill3;
        private System.Windows.Forms.Button buttonSkill2;
        private System.Windows.Forms.Button buttonSkill4;
        private System.Windows.Forms.Button buttonSkill1;
        private System.Windows.Forms.Panel panelButtonGame;
        private System.Windows.Forms.Label labelTextBattle;
        private System.Windows.Forms.Timer timerEnemyAppeared;
        private System.Windows.Forms.Timer timerEndGame;
        private System.Windows.Forms.Label labelPlayerHP;
        private System.Windows.Forms.Timer timerGetAttacked;
        private System.Windows.Forms.Timer timerProgressBar;
        private System.Windows.Forms.Timer timerPlayerTurn;
        private System.Windows.Forms.Timer timerEnemyTurn;
        private System.Windows.Forms.Timer timerExpBar;
        private System.Windows.Forms.PictureBox pokeball;
        private System.Windows.Forms.Timer timerPokeball;
        private System.Windows.Forms.Timer timerFlee;
        private System.Windows.Forms.Timer timerPlayerLose;
    }
}