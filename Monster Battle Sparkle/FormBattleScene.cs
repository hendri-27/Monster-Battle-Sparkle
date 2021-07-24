using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WMPLib;

namespace Monster_Battle_Sparkle
{
    public partial class FormBattleScene : Form
    {
        Random rnd = new Random();

        short orderText = 0, blink = 1;
        int remainExp = 0,
            hit,
            minusDef,
            exp,
            i;
        bool playerTurn, getFirstTime;

        string nameMonster, skillName, hitName, resourcesPath = Application.StartupPath + "\\Resources\\";
        WindowsMediaPlayer music = new WindowsMediaPlayer();
        WindowsMediaPlayer soundFx = new WindowsMediaPlayer();
        
        public FormBattleScene()
        {
            InitializeComponent();

            //Event handler for button monster or button bag clicked in battle form
            buttonMonster.Click += Clicked;
            buttonBag.Click += Clicked;
        }

        private void Clicked (object sender, EventArgs e)
        {
            MessageBox.Show("This feature not available right now!", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Cannot close the form until user using force close
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
        }

        private void FormBattleScene_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            //Play Music
            music.URL = resourcesPath + "BattlePokemon.mp3";
            music.settings.setMode("loop", true);
            music.settings.volume = Properties.SettingsVolume.Default.Volume;

            //Load player HP
            progressBarPlayerHp.Maximum = Properties.Settings.Default.MaxHealth;
            progressBarPlayerHp.Value = Properties.Settings.Default.HealthBar;
            if (progressBarPlayerHp.Value <= progressBarPlayerHp.Maximum * 0.5 && progressBarPlayerHp.Value > progressBarPlayerHp.Maximum * 0.2)
                progressBarPlayerHp.ForeColor = Color.Orange;
            else if (progressBarPlayerHp.Value <= progressBarPlayerHp.Maximum * 0.2)
                progressBarPlayerHp.ForeColor = Color.Red;
            labelPlayerHP.Text = Properties.Settings.Default.HealthBar + " / " + Properties.Settings.Default.MaxHealth;

            //Load player EXP
            progressBarPlayerExp.Value = Properties.Settings.Default.ExpBar;

            //Load player Level
            labelLevelPlayerMonster.Text = "Lv. " + Properties.Settings.Default.LevelMonster;

            //Load Player Skill
            if (Properties.Settings.Default.LevelMonster >= 2)
            {
                buttonSkill2.Text = "Withdraw";
                buttonSkill2.Enabled = !buttonSkill2.Enabled;

                if (Properties.Settings.Default.LevelMonster >= 10)
                {
                    buttonSkill3.Text = "Quick Attack";
                    buttonSkill3.Enabled = !buttonSkill3.Enabled;

                    if (Properties.Settings.Default.LevelMonster >= 20)
                    {
                        buttonSkill4.Text = "Iron Tail";
                        buttonSkill4.Enabled = !buttonSkill4.Enabled;

                        if (Properties.Settings.Default.LevelMonster >= 35)
                        {
                            buttonSkill2.Text = "Thunderbolt";
                            buttonSkill2.ForeColor = Color.Yellow;
                            if (Properties.Settings.Default.LevelMonster >= 50)
                            {
                                buttonSkill1.Text = "Thunder";
                                buttonSkill2.ForeColor = Color.Yellow;
                            }
                        }
                    }
                }
            }

            //Random enemy type (Starly or Bidoof)
            int pickMonster = rnd.Next(1, 3);
            if (pickMonster == 1)
            {
                nameMonster = "BIDOOF";
                pictureBoxEnemy.Image = Properties.Resources.bidoof;
            }
            else
            {
                nameMonster = "STARLY";
                pictureBoxEnemy.Image = Properties.Resources.starly;
            }

            //Random enemy Level (1 below player level or the sama as player level), and initialize enemy HP
            if (Properties.Settings.Default.LevelMonster > 1)
            {
                labelLevelEnemyMonster.Text = "Lv. " + rnd.Next(Properties.Settings.Default.LevelMonster - 1, Properties.Settings.Default.LevelMonster);
                progressBarEnemyHp.Maximum = Properties.Settings.Default.MaxHealth - Properties.Settings.Default.LevelMonster * 2;
                progressBarEnemyHp.Value = progressBarEnemyHp.Maximum;
            }
        }

        //Battle Scene in the beginning
        private void timerEnemyAppeared_Tick(object sender, EventArgs e)
        {
            if(orderText == 0)
            {
                labelTextBattle.Text = "A wild " + nameMonster + " appeared!";
                panelEnemyBar.Visible = pictureBoxEnemy.Visible = true;
                if (nameMonster == "BIDOOF")
                    soundFx.URL = resourcesPath + "Bidoof.mp3";
                else
                    soundFx.URL = resourcesPath + "Starly.mp3";
                labelEnemyMonster.Text = nameMonster;
                timerEnemyAppeared.Interval -= 500;
                orderText++;
            }
            else if(orderText == 1)
            {
                labelTextBattle.Text = "Go! PIKACHU!";
                timerEnemyAppeared.Interval = 1000;
                timerPokeball.Start();
                orderText++;
            }
            else if(orderText == 2)
            {
                timerEnemyAppeared.Interval = 1500;
                pokeball.Visible = !Visible;
                panelPlayerBar.Visible = true;
                pictureBoxPlayer.Visible = true;
                pokeball.Location = new Point(-20, 90);
                orderText++;
            }
            else
            {
                labelTextBattle.Text = "What will PIKACHU do?";
                panelButtonGame.Visible = true;
                timerEnemyAppeared.Stop();
            }        
        }

        //Animation throwing monster ball
        private void timerPokeball_Tick(object sender, EventArgs e)
        {
            if (pokeball.Location == new Point(90, 170))
            {
                timerPokeball.Stop();
                pokeball.Image = Properties.Resources.openPokeball;
                soundFx.URL = resourcesPath + "Pikachu.mp3";
            }
            else
            {
                pokeball.Visible = true;
                pokeball.Location = new Point(pokeball.Left + 3, pokeball.Top + 2);
            }
        }

        //Button UI
        private void ButtonFight_Click(object sender, EventArgs e)
        {
            ButtonVisible();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ButtonVisible();
        }

        private void ButtonVisible()
        {
            buttonCancel.Visible = !buttonCancel.Visible;
            buttonFight.Visible = !buttonFight.Visible;
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            panelButtonGame.Visible = false;
            int randomFlee = rnd.Next(0, 2);
            if (randomFlee == 1)
            {
                labelTextBattle.Text = "Got away safetly!";
                timerFlee.Start();
            }
            else
            {
                labelTextBattle.Text = "Can't run!";
                orderText = 5;
                timerEnemyTurn.Start();
            }
        }
    
        private void timerFlee_Tick(object sender, EventArgs e)
        {
            Properties.Settings.Default.AfterBattle = true;
            NewForm();
        }

        //Player Turn
        private void timerPlayerTurn_Tick(object sender, EventArgs e)
        {
            if (orderText == 3)
            {
                labelTextBattle.Text = "PIKACHU used " + skillName + "!";
                timerPlayerTurn.Interval = 1000;
                orderText++;
            }
            else if(orderText == 4)
            {
                labelTextBattle.ResetText();
                if (hit != 0)
                {
                    soundFx.URL = resourcesPath + "Hit.mp3";
                    timerGetAttacked.Start();
                    orderText++;
                }
                else
                {
                    orderText = 6;
                    labelTextBattle.Text = "The wild " + nameMonster + " defense have been lowered!";
                }
            }
            else if (orderText == 5)
            {
                i = 1;
                hit += minusDef;
                minusDef = 0;
                playerTurn = true;
                timerProgressBar.Start();
                labelTextBattle.Text = hitName;
                timerPlayerTurn.Stop();
            }
            else
            {
                orderText = 5;
                timerPlayerTurn.Stop();
                timerEnemyTurn.Start();
            }
        }
        private void buttonSkill1_Click(object sender, EventArgs e)
        {
            if (buttonSkill1.Text == "Tackle")
            {
                if (Properties.Settings.Default.LevelMonster <= 10)
                {
                    hit = rnd.Next(Properties.Settings.Default.MaxAttPlayer, Properties.Settings.Default.MaxAttPlayer + 6);
                    if (hit == Properties.Settings.Default.MaxAttPlayer + 5)
                        hitName = "A critical hit!";
                }
                else
                {
                    hit = rnd.Next(16, 22);
                    if (hit == 21)
                        hitName = "A critical hit!";
                }
            }
            else
            {
                if (Properties.Settings.Default.LevelMonster <= 80)
                {
                    hit = rnd.Next(Properties.Settings.Default.MaxAttPlayer + 20, Properties.Settings.Default.MaxAttPlayer + 31);
                    if (hit == Properties.Settings.Default.MaxAttPlayer + 30)
                        hitName = "A critical hit!";
                }
                else
                {
                    hit = rnd.Next(105, 116);
                    if (hit == 115)
                        hitName = "A critical hit!";
                }
            }
            skillName = buttonSkill1.Text;
            ButtonSKillClicked();
        }

        private void buttonSkill2_Click(object sender, EventArgs e)
        {
            if (buttonSkill2.Text == "Thunderbolt")
            {
                skillName = buttonSkill2.Text;
                if (Properties.Settings.Default.LevelMonster <= 50)
                {
                    hit = rnd.Next(Properties.Settings.Default.MaxAttPlayer + 15, Properties.Settings.Default.MaxAttPlayer + 26);
                    if (hit == Properties.Settings.Default.MaxAttPlayer + 25)
                        hitName = "A critical hit!";
                }
                else
                {
                    hit = rnd.Next(56, 67);
                    if (hit == 66)
                        hitName = "A critical hit!";
                }
            }
            else
            {
                skillName = buttonSkill2.Text;
                hit = 0;
                minusDef = rnd.Next(1, 6);
            }
            ButtonSKillClicked();
        }

        private void buttonSkill3_Click(object sender, EventArgs e)
        {
            skillName = buttonSkill3.Text;
            if (Properties.Settings.Default.LevelMonster <= 20)
            {
                hit = rnd.Next(Properties.Settings.Default.MaxAttPlayer + 5, Properties.Settings.Default.MaxAttPlayer + 16);
                if (hit == Properties.Settings.Default.MaxAttPlayer + 15)
                    hitName = "A critical hit!";
            }
            else
            {
                hit = rnd.Next(31, 42);
                if (hit == 41)
                    hitName = "A critical hit!";
            }
            ButtonSKillClicked();
        }

        private void buttonSkill4_Click(object sender, EventArgs e)
        {
            skillName = buttonSkill4.Text;
            if (Properties.Settings.Default.LevelMonster <= 35)
            {
                hit = rnd.Next(Properties.Settings.Default.MaxAttPlayer + 8, Properties.Settings.Default.MaxAttPlayer + 19);
                if (hit == Properties.Settings.Default.MaxAttPlayer + 18)
                    hitName = "A critical hit!";
            }
            else
            {
                hit = rnd.Next(49, 60);
                if (hit == 59)
                    hitName = "A critical hit!";
            }
            ButtonSKillClicked();
        }

        private void ButtonSKillClicked()
        {
            timerPlayerTurn.Interval = 100;
            ButtonVisible();
            panelButtonGame.Visible = false;
            timerPlayerTurn.Start();
        }


        //Enemy Turn
        private void timerEnemyTurn_Tick(object sender, EventArgs e)
        {
            if (orderText == 5)
            {
                labelTextBattle.Text = "The wild " + nameMonster + " used Tackle!";
                orderText++;
            }
            else if(orderText == 6)
            {
                labelTextBattle.ResetText();
                soundFx.URL = resourcesPath + "Hit.mp3";
                timerGetAttacked.Start();
                orderText++;
            }
            else
            {
                hit = rnd.Next(Properties.Settings.Default.MaxAttPlayer - 5, Properties.Settings.Default.MaxAttPlayer - 3);
                i = 1;
                playerTurn = false;
                timerProgressBar.Start();
                if (hit == Properties.Settings.Default.MaxAttPlayer - 2)
                {
                    labelTextBattle.Text = "A critical hit!";
                }
                timerEnemyTurn.Stop();
            }
        }

        //Effect when player or enemy get attacked
        private void timerGetAttacked_Tick(object sender, EventArgs e)
        {
            if(orderText == 5)
            {
                pictureBoxEnemy.Visible = !pictureBoxEnemy.Visible;
            }
            else
            {
                pictureBoxPlayer.Visible = !pictureBoxPlayer.Visible;
            }
            blink++;

            if (blink == 7)
            {
                timerGetAttacked.Stop();
                blink = 1;
            }
        }

        //Decrease progress bar when player or enemy get attacked
        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                if (progressBarEnemyHp.Value - 1 > 0)
                {
                    progressBarEnemyHp.Value -= 1;
                    if (progressBarEnemyHp.Value <= progressBarEnemyHp.Maximum * 0.5 && progressBarEnemyHp.Value > progressBarEnemyHp.Maximum * 0.2)
                        progressBarEnemyHp.ForeColor = Color.Orange;
                    else if (progressBarEnemyHp.Value <= progressBarEnemyHp.Maximum * 0.2)
                        progressBarEnemyHp.ForeColor = Color.Red;
                    if (i == hit)
                    {
                        timerProgressBar.Stop();
                        timerEnemyTurn.Start();
                    }
                }
                else
                {
                    progressBarEnemyHp.Value = 0;
                    timerEndGame.Interval = 1000;

                    if (nameMonster == "BIDOOF")
                        soundFx.URL = resourcesPath + "Bidoof.mp3";
                    else
                        soundFx.URL = resourcesPath + "Starly.mp3";

                    timerProgressBar.Stop();
                    timerEndGame.Start();
                }
            }
            else
            {
                if (progressBarPlayerHp.Value - 1 > 0)
                {
                    progressBarPlayerHp.Value -= 1;
                    if (progressBarPlayerHp.Value <= progressBarPlayerHp.Maximum * 0.5 && progressBarPlayerHp.Value > progressBarPlayerHp.Maximum * 0.2)
                        progressBarPlayerHp.ForeColor = Color.Orange;
                    else if (progressBarPlayerHp.Value <= progressBarPlayerHp.Maximum * 0.2)
                        progressBarPlayerHp.ForeColor = Color.Red;

                    Properties.Settings.Default.HealthBar -= 1;
                    labelPlayerHP.Text = Properties.Settings.Default.HealthBar + " / " + Properties.Settings.Default.MaxHealth;

                    if (i == hit)
                    {
                        timerProgressBar.Stop();
                        timerEnemyAppeared.Start();
                        orderText = 3;
                    }
                }
                else
                {
                    labelPlayerHP.Text = "0 / " + Properties.Settings.Default.MaxHealth;
                    Properties.Settings.Default.HealthBar = 0;
                    progressBarPlayerHp.Value = 0;
                    timerProgressBar.Stop();
                    timerPlayerLose.Start();
                }
            }
            i++;
        }

        //Finish battle when player win
        private void timerEndGame_Tick(object sender, EventArgs e)
        {
            if (orderText == 5)
            {
                labelTextBattle.Text = "The wild " + nameMonster + " fainted!";
                QuestMission();
                pictureBoxEnemy.Visible = panelEnemyBar.Visible = false;
                timerEndGame.Interval = 2000;
                orderText++;
            }
            else if (orderText == 6)
            {
                music.URL = resourcesPath + "Victory.mp3";
                i = 1;
                getFirstTime = true;
                exp = rnd.Next(11,16);
                labelTextBattle.Text = "PIKACHU gained\n" + exp + " Exp. Points!";
                timerEndGame.Stop();
                timerExpBar.Start();
            }
            else if (orderText == 7)
            {
                Properties.Settings.Default.ExpBar = remainExp;
                labelTextBattle.Text = "PIKACHU grew to \nLv. " + Properties.Settings.Default.LevelMonster + "!";

                if (Properties.Settings.Default.LevelMonster == 2 || Properties.Settings.Default.LevelMonster == 10 || Properties.Settings.Default.LevelMonster == 20 || Properties.Settings.Default.LevelMonster == 35 || Properties.Settings.Default.LevelMonster == 50)
                    orderText++;
                else
                    orderText = 9;
            }
            else if (orderText == 8)
            {
                if (Properties.Settings.Default.LevelMonster >= 2)
                {
                    labelTextBattle.Text = "PIKACHU learn new moves Withdraw!";

                    if (Properties.Settings.Default.LevelMonster >= 10)
                    {
                        labelTextBattle.Text = "PIKACHU learn new moves Quick Attack!";

                        if (Properties.Settings.Default.LevelMonster >= 20)
                        {
                            labelTextBattle.Text = "PIKACHU learn new moves Iron Tail";

                            if (Properties.Settings.Default.LevelMonster >= 35)
                            {
                                labelTextBattle.Text = "PIKACHU learn new moves Thunderbolt";

                                if (Properties.Settings.Default.LevelMonster >= 50)
                                {
                                    labelTextBattle.Text = "PIKACHU learn new moves Thunder";
                                }
                            }
                        }
                    }
                }
                orderText++;
            }
            else
            {
                timerFlee.Start();
            }
        }

        //Increase player progress bar exp when player win the game
        private void timerExpBar_Tick(object sender, EventArgs e)
        {
            if (progressBarPlayerExp.Value + 1 < 25 && getFirstTime)
            {
                progressBarPlayerExp.Value += 1;

                if (i == exp)
                {
                    Properties.Settings.Default.ExpBar = progressBarPlayerExp.Value;
                    orderText = 9;
                    timerExpBar.Stop();
                    timerEndGame.Start();
                }
                i++;
            }
            else
            {
                if (getFirstTime)
                {
                    i = 0;
                    soundFx.URL = resourcesPath + "LevelUp.mp3";
                    labelLevelPlayerMonster.Text = "Lv. " + ++Properties.Settings.Default.LevelMonster;

                    Properties.Settings.Default.MaxAttPlayer++;

                    remainExp = Properties.Settings.Default.ExpBar + exp - 25;
                    progressBarPlayerExp.Value = 0;

                    double currentMaxHealth = Properties.Settings.Default.MaxHealth;
                    progressBarPlayerHp.Maximum = Properties.Settings.Default.MaxHealth += (int)(Properties.Settings.Default.MaxHealth * 0.09);
                    progressBarPlayerHp.Value = Properties.Settings.Default.HealthBar = (int)(Math.Round(Properties.Settings.Default.HealthBar * Properties.Settings.Default.MaxHealth / currentMaxHealth, 0));
                    labelPlayerHP.Text = Properties.Settings.Default.HealthBar + " / " + Properties.Settings.Default.MaxHealth;
                    getFirstTime = false;
                }
                else
                {
                    if (remainExp != i)
                    {
                        if (progressBarPlayerExp.Value + 1 < 25)
                        {
                            progressBarPlayerExp.Value += 1;
                            i++;
                        }
                        else
                        {
                            getFirstTime = true;
                        }
                    }
                    else
                    {
                        orderText++;
                        timerExpBar.Stop();
                        timerEndGame.Start();
                    }
                }
            }
        }

        //Finish battle when player lose
        private void timerPlayerLose_Tick(object sender, EventArgs e)
        {
            if (orderText == 7)
            {
                soundFx.URL = resourcesPath + "Pikachu.mp3";
                orderText++;
            }
            else if(orderText == 8)
            {
                pictureBoxPlayer.Visible = panelPlayerBar.Visible = false;
                labelTextBattle.Text = "PIKACHU fainted!";
                orderText++;
            }
            else
            {
                Properties.Settings.Default.CurrentLocation = 3;
                Properties.Settings.Default.PlayerFainted = true;
                labelTextBattle.ResetText();
                timerFlee.Start();
                timerPlayerTurn.Stop();
            }
        }

        private void QuestMission()
        {
            if (Properties.Settings.Default.AcceptQuest)
            {
                if (Properties.Settings.Default.QuestNum == 1)
                    Properties.Settings.Default.MissionQuest ++;
                else if (Properties.Settings.Default.QuestNum == 3 && Properties.Settings.Default.HealthBar <= Properties.Settings.Default.MaxHealth * 10 / 100)
                    Properties.Settings.Default.MissionQuest ++;
                else if (Properties.Settings.Default.QuestNum == 4 && nameMonster == "BIDOOF")
                    Properties.Settings.Default.MissionQuest ++;
            }
        }

        //Closing this form
        private void NewForm()
        {
            this.Close();
            Thread newForm = new Thread(OpenNewForm);
            newForm.SetApartmentState(ApartmentState.STA);
            newForm.Start();
        }

        private void OpenNewForm()
        {
            if (!Properties.Settings.Default.PlayerFainted)
            {
                FormForestMap formForestMap = new FormForestMap();
                formForestMap.PassingData(Properties.Settings.Default.LevelMonster, Properties.Settings.Default.MaxHealth, Properties.Settings.Default.HealthBar, Properties.Settings.Default.ExpBar, Properties.Settings.Default.MaxAttPlayer, Properties.Settings.Default.AfterBattle, Properties.Settings.Default.PlayerFainted, Properties.Settings.Default.AcceptQuest, Properties.Settings.Default.MissionQuest, Properties.Settings.Default.QuestNum, Properties.Settings.Default.Potion);
                Application.Run(new FormForestMap());
            }
            else
            {
                FormMonsterCenterMap formMonsterCenterMap = new FormMonsterCenterMap();
                formMonsterCenterMap.PassingData(Properties.Settings.Default.LevelMonster, Properties.Settings.Default.MaxHealth, Properties.Settings.Default.HealthBar, Properties.Settings.Default.ExpBar, Properties.Settings.Default.MaxAttPlayer, Properties.Settings.Default.AfterBattle, Properties.Settings.Default.PlayerFainted, Properties.Settings.Default.AcceptQuest, Properties.Settings.Default.MissionQuest, Properties.Settings.Default.QuestNum, Properties.Settings.Default.Potion);
                Application.Run(formMonsterCenterMap);
            }
        }

        //Passing Data to another form
        public void PassingData(short levelMonster, int maxHealth, int healthBar, int expBar, int maxAttPlayer, bool afterBattle, bool playerFainted, bool acceptQuest, short missionQuest, short questNum, short potion)
        {
            Properties.Settings.Default.LevelMonster = levelMonster;
            Properties.Settings.Default.MaxHealth = maxHealth;
            Properties.Settings.Default.HealthBar = healthBar;
            Properties.Settings.Default.ExpBar = expBar;
            Properties.Settings.Default.MaxAttPlayer = maxAttPlayer;
            Properties.Settings.Default.AfterBattle = afterBattle;
            Properties.Settings.Default.PlayerFainted = playerFainted;
            Properties.Settings.Default.AcceptQuest = acceptQuest;
            Properties.Settings.Default.MissionQuest = missionQuest;
            Properties.Settings.Default.QuestNum = questNum;
            Properties.Settings.Default.Potion = potion;
        }
    }
}
