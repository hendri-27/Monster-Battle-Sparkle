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
    public partial class FormHomeMap : Form
    {
        short playerImage = 2, orderText;

        string resourcesPath = Application.StartupPath + "\\Resources\\";
        public WindowsMediaPlayer music = new WindowsMediaPlayer();
        WindowsMediaPlayer soundFx = new WindowsMediaPlayer();
        bool save, pause, walk;

        public FormHomeMap()
        {
            InitializeComponent();
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

        private void FormHomeMap_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            //Playing music
            music.URL = resourcesPath + "Home.mp3";
            music.settings.setMode("loop", true);
            music.settings.volume = Properties.SettingsVolume.Default.Volume;

            //Load game
            if (Properties.Settings.Default.LoadGame == true && Properties.Settings.Default.SaveGame == false)
            {
                player.Location = Properties.Settings.Default.PlayerLocation;
                switch (Properties.Settings.Default.PlayerImage)
                {
                    case 1:
                        player.Image = Properties.Resources.up_1;
                        break;
                    case 2:
                        player.Image = Properties.Resources.down_1;
                        break;
                    case 3:
                        player.Image = Properties.Resources.left_1;
                        break;
                    default:
                        player.Image = Properties.Resources.right_1;
                        break;
                }
                Properties.Settings.Default.SaveGame = true;
            }
        }

        private void timerUp_Tick(object sender, EventArgs e)
        {
            Quest2();

            //Animation for walking up
            switch (walk)
            {
                case false:
                    player.Image = Properties.Resources.up_2;
                    break;
                case true:
                    player.Image = Properties.Resources.up_3;
                    break;
            }
            walk = !walk;
            if (player.Top > 71 && (player.Top - 10 != 331 || (player.Left != 120 && player.Left != 130 && player.Left != 140 && player.Left != 150 && player.Left != 160 && player.Left != 170 && player.Left != 180 && player.Left != 190 && player.Left != 200 && player.Left != 210 && player.Left != 220 && player.Left != 230 && player.Left != 240)) && (player.Top - 10 != 191 || (player.Left != 60 && player.Left != 70 && player.Left != 80 && player.Left != 90 && player.Left != 100 && player.Left != 110 && player.Left != 120 && player.Left != 130 && player.Left != 140 && player.Left != 150 && player.Left != 160 && player.Left != 170 && player.Left != 180 && player.Left != 190 && player.Left != 200)) && (player.Top - 10 != 101 || (player.Left != 110 && player.Left != 120 && player.Left != 130 && player.Left != 140 && player.Left != 220 && player.Left != 230 && player.Left != 240 && player.Left != 250 && player.Left != 260)) && (player.Top - 10 != 181 || (player.Left != 270 && player.Left != 280 && player.Left != 290 && player.Left != 300 && player.Left != 310 && player.Left != 320 && player.Left != 340 && player.Left != 350 && player.Left != 360 && player.Left != 370 && player.Left != 380 && player.Left != 390)) && (player.Top - 10 != 131 || (player.Left != 400 && player.Left != 410 && player.Left != 420 && player.Left != 430 && player.Left != 440 && player.Left != 450 && player.Left != 460 && player.Left != 470 && player.Left != 480)))
                player.Top -= 10;
        }

        private void timerDown_Tick(object sender, EventArgs e)
        {
            Quest2();
            if ((player.Left == 290 || player.Left == 300 || player.Left == 310 || player.Left == 320) && player.Top + 10 == 381)
                NewForm();

            //Animation for walking down
            switch (walk)
            {
                case false:
                    player.Image = Properties.Resources.down_2;
                    break;
                case true:
                    player.Image = Properties.Resources.down_3;
                    break;
            }
            walk = !walk;
            if (player.Top < 371 && (player.Top + 10 != 281 || (player.Left != 60 && player.Left != 70 && player.Left != 80 && player.Left != 90 && player.Left != 100)) && (player.Top + 10 != 241 || (player.Left != 120 && player.Left != 130 && player.Left != 140 && player.Left != 150 && player.Left != 160 && player.Left != 170 && player.Left != 180 && player.Left != 190 && player.Left != 200 && player.Left != 210 && player.Left != 220 && player.Left != 230 && player.Left != 240)) && (player.Top + 10 != 121 || (player.Left != 110 && player.Left != 120 && player.Left != 130 && player.Left != 140 && player.Left != 150 && player.Left != 160 && player.Left != 170 && player.Left != 180 && player.Left != 190 && player.Left != 200)) && (player.Top + 10 != 281 || (player.Left != 510 && player.Left != 520 && player.Left != 530 && player.Left != 540)))
                player.Top += 10;
        }

        private void timerLeft_Tick(object sender, EventArgs e)
        {
            Quest2();

            //Animation for walking left
            switch (walk)
            {
                case false:
                    player.Image = Properties.Resources.left_2;
                    break;
                case true:
                    player.Image = Properties.Resources.left_3;
                    break;
            }
            walk = !walk;
            if (player.Left > 60 && (player.Left - 10 != 100 || (player.Top != 111 && player.Top != 281 && player.Top != 291 && player.Top != 301 && player.Top != 311 && player.Top != 321 && player.Top != 331 && player.Top != 341 && player.Top != 351 && player.Top != 361 && player.Top != 371)) && (player.Left - 10 != 240 || (player.Top != 241 && player.Top != 251 && player.Top != 261 && player.Top != 271 && player.Top != 281 && player.Top != 291 && player.Top != 301 && player.Top != 311 && player.Top != 321 && player.Top != 331)) && (player.Left - 10 != 200 || (player.Top != 121 && player.Top != 131 && player.Top != 141 && player.Top != 151 && player.Top != 161 && player.Top != 171 && player.Top != 181 && player.Top != 191)) && (player.Left - 10 != 140 || (player.Top != 71 && player.Top != 81 && player.Top != 91 && player.Top != 101)) && (player.Left - 10 != 390 || (player.Top != 141 && player.Top != 151 && player.Top != 161 && player.Top != 171 && player.Top != 181)) && (player.Left - 10 != 480 || (player.Top != 71 && player.Top != 81 && player.Top != 91 && player.Top != 101 && player.Top != 111 && player.Top != 121 && player.Top != 131)))
                player.Left -= 10;
        }

        private void timerRight_Tick(object sender, EventArgs e)
        {
            Quest2();

            //Animation for walking right
            switch (walk)
            {
                case false:
                    player.Image = Properties.Resources.right_2;
                    break;
                case true:
                    player.Image = Properties.Resources.right_3;
                    break;
            }
            walk = !walk;
            if (player.Left < 540 && (player.Left + 10 != 510 || (player.Top != 281 && player.Top != 291 && player.Top != 301 && player.Top != 311 && player.Top != 321 && player.Top != 331 && player.Top != 341 && player.Top != 351 && player.Top != 361 && player.Top != 371)) && (player.Left + 10 != 120 || (player.Top != 241 && player.Top != 251 && player.Top != 261 && player.Top != 271 && player.Top != 281 && player.Top != 291 && player.Top != 301 && player.Top != 311 && player.Top != 321 && player.Top != 331)) && (player.Left + 10 != 220 || (player.Top != 71 && player.Top != 81 && player.Top != 91 && player.Top != 101)) && (player.Left + 10 != 270 || (player.Top != 111 && player.Top != 121 && player.Top != 131 && player.Top != 141 && player.Top != 151 && player.Top != 161 && player.Top != 171 && player.Top != 181)))
                player.Left += 10;
        }

        //Controller
        private void FormHomeMap_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                    timerUp.Start();
                else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                    timerDown.Start();
                else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                    timerLeft.Start();
                else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                    timerRight.Start();
                else if (e.KeyCode == Keys.B)
                    BackToGame();
                else if (e.KeyCode == Keys.Z)
                    if (player.Left - 50 == 60 && player.Top == 111)
                    {
                        orderText = 0;
                        timerGame.Interval = 1;
                        pause = true;
                        npcMom.Image = Properties.Resources.NPCMomIdleRight;
                        panelChatWheel.Visible = !panelChatWheel.Visible;
                        timerGame.Start();
                    }
            }
        }

        //Checking whether player doing quest or not or the quest is the same number or not
        private void Quest2()
        {
            if (Properties.Settings.Default.QuestNum == 2 && Properties.Settings.Default.AcceptQuest)
                Properties.Settings.Default.MissionQuest++;
        }

        private void FormHomeMap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                playerImage = 1;
                player.Image = Properties.Resources.up_1;
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                playerImage = 2;
                player.Image = Properties.Resources.down_1;
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                playerImage = 3;
                player.Image = Properties.Resources.left_1;
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                playerImage = 4;
                player.Image = Properties.Resources.right_1;
            }

            timerUp.Stop();
            timerDown.Stop();
            timerLeft.Stop();
            timerRight.Stop();
        }

        //Close the form
        private void NewForm()
        {
            this.Close();
            Thread newForm = new Thread(OpenNewForm);
            newForm.SetApartmentState(ApartmentState.STA);
            newForm.Start();
        }

        private void OpenNewForm(object obj)
        {
            FormCityMap formCityMap = new FormCityMap();
            formCityMap.PassingData(Properties.Settings.Default.LevelMonster, Properties.Settings.Default.MaxHealth, Properties.Settings.Default.HealthBar, Properties.Settings.Default.ExpBar, Properties.Settings.Default.MaxAttPlayer, Properties.Settings.Default.AfterBattle, Properties.Settings.Default.PlayerFainted, Properties.Settings.Default.AcceptQuest, Properties.Settings.Default.MissionQuest, Properties.Settings.Default.QuestNum, Properties.Settings.Default.Potion);
            Application.Run(formCityMap);
        }

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

        //Talking to NPC about quest
        private void timerGame_Tick(object sender, EventArgs e)
        {
            timerGame.Interval = 3000;
            if (Properties.Settings.Default.LevelMonster > 10)
            {
                if (!Properties.Settings.Default.AcceptQuest)
                {
                    switch (orderText)
                    {
                        case 0:
                            labelDisplay.Text = "Do you want to accept the quest?";
                            timerGame.Stop();
                            panelYesNo.Visible = !panelYesNo.Visible;
                            orderText++;
                            break;
                        case 1:
                            Properties.Settings.Default.QuestNum++;
                            if (Properties.Settings.Default.QuestNum == 5)
                                Properties.Settings.Default.QuestNum = 1;
                            labelDisplay.Text = Properties.Settings.Default.NamePlayer + " accepted the quest!";
                            orderText++;
                            break;
                        default:
                            Properties.Settings.Default.AcceptQuest = true;
                            Properties.Settings.Default.Save();
                            ResetChatWheel();
                            break;
                    }
                }
                else
                {
                    switch (Properties.Settings.Default.QuestNum)
                    {
                        case 1:
                            if (Properties.Settings.Default.MissionQuest >= 20)
                                QuestCompleted();
                            else
                                QuestNotCompleted();
                            break;
                        case 2:
                            if (Properties.Settings.Default.MissionQuest >= 10000)
                                QuestCompleted();
                            else
                                QuestNotCompleted();
                            break;
                        case 3:
                            if (Properties.Settings.Default.MissionQuest >= 3)
                                QuestCompleted();
                            else
                                QuestNotCompleted();
                            break;
                        default:
                            if (Properties.Settings.Default.MissionQuest >= 20)
                                QuestCompleted();
                            else
                                QuestNotCompleted();
                            break;
                    }
                }
            }
            else
            {
                switch (orderText)
                {
                    case 0:
                        labelDisplay.Text = "Hi " + Properties.Settings.Default.NamePlayer + ", you can get quest when your monster level more than Lv. 5!";
                        orderText++;
                        break;
                    case 1:
                        ResetChatWheel();
                        break;
                }
            }
        }

        private void QuestCompleted()
        {
            switch (orderText)
            {
                case 0:
                    labelDisplay.Text = Properties.Settings.Default.NamePlayer  + " success quest #" + Properties.Settings.Default.QuestNum;
                    orderText++;
                    break;
                case 1:
                    soundFx.URL = resourcesPath + "GetItem.mp3";
                    Properties.Settings.Default.Potion++;
                    labelDisplay.Text = Properties.Settings.Default.NamePlayer  + " get a level up potion!";
                    orderText++;
                    break;
                case 2:
                    labelDisplay.Text = "Level up potion is to make your monster increase a level!";
                    orderText++;
                    break;
                case 3:
                    Properties.Settings.Default.MissionQuest = 0;
                    Properties.Settings.Default.AcceptQuest = false;
                    ResetChatWheel();
                    break;
            }
        }

        private void QuestNotCompleted()
        {
            switch (orderText)
            {
                case 0:
                    labelDisplay.Text = "What are you doing here? How about the quest?";
                    orderText++;
                    break;
                case 1:
                    ResetChatWheel();
                    break;
            }
        }

        private void ResetChatWheel()
        {
            pause = false;
            labelDisplay.ResetText();
            panelChatWheel.Visible = !panelChatWheel.Visible;
            timerGame.Stop();
            this.Focus();
        }

        //Button UI
        private void labelMonster_Click(object sender, EventArgs e)
        {
            UserControlMonster userControlMonster = new UserControlMonster();
            this.Controls.Add(userControlMonster);
            userControlMonster.Dock = DockStyle.Fill;
            userControlMonster.BringToFront();
        }

        private void labelMonster_MouseMove(object sender, MouseEventArgs e)
        {
            labelMonster.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void labelMonster_MouseLeave(object sender, EventArgs e)
        {
            labelMonster.Font = new Font("Microsoft Sans Serif", (float)9.75);
        }

        private void labelBag_Click(object sender, EventArgs e)
        {
            UserControlBag userControlBag = new UserControlBag();
            this.Controls.Add(userControlBag);
            userControlBag.Dock = DockStyle.Fill;
            userControlBag.BringToFront();
        }

        private void labelBag_MouseMove(object sender, MouseEventArgs e)
        {
            labelBag.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void labelBag_MouseLeave(object sender, EventArgs e)
        {
            labelBag.Font = new Font("Microsoft Sans Serif", (float)9.75);
        }

        private void labelQuest_Click(object sender, EventArgs e)
        {
            UserControlQuest userControlQuest = new UserControlQuest();
            this.Controls.Add(userControlQuest);
            userControlQuest.Dock = DockStyle.Fill;
            userControlQuest.BringToFront();
        }

        private void labelQuest_MouseMove(object sender, MouseEventArgs e)
        {
            labelQuest.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void labelQuest_MouseLeave(object sender, EventArgs e)
        {
            labelQuest.Font = new Font("Microsoft Sans Serif", (float)9.75);
        }

        private void labelSetting_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentLocation = Properties.SettingsVolume.Default.AccessFrom = 2;
            Properties.SettingsVolume.Default.Save();
            Properties.Settings.Default.PlayerLocation = player.Location;
            Properties.Settings.Default.PlayerImage = playerImage;
            FormSetting formSetting = new FormSetting();
            formSetting.PassingData(Properties.Settings.Default.LevelMonster, Properties.Settings.Default.MaxHealth, Properties.Settings.Default.HealthBar, Properties.Settings.Default.ExpBar, Properties.Settings.Default.MaxAttPlayer, Properties.Settings.Default.AfterBattle, Properties.Settings.Default.PlayerFainted, Properties.Settings.Default.AcceptQuest, Properties.Settings.Default.MissionQuest, Properties.Settings.Default.QuestNum, Properties.Settings.Default.Potion, Properties.Settings.Default.CurrentLocation, Properties.Settings.Default.PlayerLocation, Properties.Settings.Default.PlayerImage);
            formSetting.Owner = this;
            formSetting.ShowDialog();
        }

        private void labelSetting_MouseMove(object sender, MouseEventArgs e)
        {
            labelSetting.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void labelSetting_MouseLeave(object sender, EventArgs e)
        {
            labelSetting.Font = new Font("Microsoft Sans Serif", (float)9.75);
        }

        private void labelSaveGame_Click(object sender, EventArgs e)
        {
            save = !save;
            labelDisplay.Text = "Would you like to save the game?";
            orderText = 0;
            panelChatWheel.Visible = panelYesNo.Visible = !panelChatWheel.Visible;
            timerSaveGame.Interval = 3000;
            BackToGame();
        }

        private void labelSaveGame_MouseMove(object sender, MouseEventArgs e)
        {
            labelSaveGame.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void labelSaveGame_MouseLeave(object sender, EventArgs e)
        {
            labelSaveGame.Font = new Font("Microsoft Sans Serif", (float)9.75);
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            BackToGame();
            this.Focus();
        }

        private void labelBack_MouseMove(object sender, MouseEventArgs e)
        {
            labelBack.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void labelBack_MouseLeave(object sender, EventArgs e)
        {
            labelBack.Font = new Font("Microsoft Sans Serif", (float)9.75);
        }

        //Saving the game
        private void buttonYes_Click(object sender, EventArgs e)
        {
            panelYesNo.Visible = !panelYesNo.Visible;
            if (save)
            {
                labelDisplay.Text = "Saving the game ...";
                timerSaveGame.Start();
            }
            else
            {
                timerGame.Interval = 1;
                timerGame.Start();
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            if (save)
            {
                labelSaveGame_Click(e, e);
            }
            else
            {
                ResetChatWheel();
                panelYesNo.Visible = !panelYesNo.Visible;
            }
            this.Focus();
        }

        private void timerSaveGame_Tick(object sender, EventArgs e)
        {
            switch (orderText)
            {
                case 0:
                    Properties.Settings.Default.LoadGame = Properties.Settings.Default.SaveGame = true;
                    Properties.Settings.Default.PlayerImage = playerImage;
                    Properties.Settings.Default.PlayerLocation = player.Location;
                    Properties.Settings.Default.Save();
                    orderText++;
                    break;
                case 1:
                    labelDisplay.Text = Properties.Settings.Default.NamePlayer + " saved the game!";
                    timerSaveGame.Interval = 1200;
                    orderText++;
                    break;
                default:
                    labelSaveGame_Click(e, e);
                    timerSaveGame.Stop();
                    break;
            }
        }

        private void BackToGame()
        {
            panelBag.Visible = !panelBag.Visible;
            panelBag.Focus();
        }
    }
}
