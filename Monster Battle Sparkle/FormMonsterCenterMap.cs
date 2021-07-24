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
    public partial class FormMonsterCenterMap : Form
    {
        short orderText, playerImage = 1;
        bool pause, save, walk;

        string resourcesPath = Application.StartupPath + "\\Resources\\";
        public WindowsMediaPlayer music = new WindowsMediaPlayer();
        public WindowsMediaPlayer soundFx = new WindowsMediaPlayer();

        public FormMonsterCenterMap()
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

        private void FormMonsterCenterMap_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            //Playing music
            music.URL = resourcesPath + "PokemonCenter.mp3";
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

            //Load game if player monster fainted in the battle
            else if (Properties.Settings.Default.PlayerFainted)
            {
                player.Location = new Point(303, 166);
                player.Image = Properties.Resources.up_1;
                pause = panelChatWheel.Visible = labelDisplay.Visible = pictureBoxPokeBall.Visible = true;
                Properties.Settings.Default.PlayerFainted = Properties.Settings.Default.AfterBattle = false;
                orderText = 2;
                timerGame.Start();
            }
        }

        private void TimerUp_Tick(object sender, EventArgs e)
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
            if (player.Top > 86 && (player.Top - 10 != 326 || (player.Left != 53 && player.Left != 63 && player.Left != 73 && player.Left != 83 && player.Left != 93)) && (player.Top - 10 != 96 || (player.Left != 33 && player.Left != 43 && player.Left != 53 && player.Left != 63 && player.Left != 73 && player.Left != 83 && player.Left != 93 && player.Left != 103 && player.Left != 113 && player.Left != 123 && player.Left != 133 && player.Left != 143)) && (player.Top - 10 != 166 || (player.Left != 153 && player.Left != 163 && player.Left != 173 && player.Left != 183 && player.Left != 193 && player.Left != 203 && player.Left != 213 && player.Left != 223 && player.Left != 233 && player.Left != 243 && player.Left != 253 && player.Left != 263 && player.Left != 273 && player.Left != 283 && player.Left != 293 && player.Left != 303 && player.Left != 313 && player.Left != 323 && player.Left != 333 && player.Left != 343 && player.Left != 353 && player.Left != 363 && player.Left != 373 && player.Left != 383 && player.Left != 393 && player.Left != 403 && player.Left != 413 && player.Left != 423 && player.Left != 433 && player.Left != 443)) && (player.Top - 10 != 96 || (player.Left != 453 && player.Left != 463 && player.Left != 473 && player.Left != 483 && player.Left != 493 && player.Left != 573)) && (player.Top - 10 != 86 || player.Left != 563) && (player.Top - 10 != 76 || player.Left != 553) && (player.Top - 10 != 336 || (player.Left != 463 && player.Left != 473 && player.Left != 483 && player.Left != 493 && player.Left != 503 && player.Left != 513 && player.Left != 523 && player.Left != 553)))
                player.Top -= 10;
        }

        private void TimerDown_Tick(object sender, EventArgs e)
        {
            Quest2();

            //Checking whether the player location is the same as go to city form
            if ((player.Left == 283 || player.Left == 293 || player.Left == 303 || player.Left == 313) && player.Top + 10 == 376)
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
            if (player.Top < 366 && (player.Top + 10 != 256 || (player.Left != 73 && player.Left != 83)) && (player.Top + 10 != 246 || player.Left != 63) && (player.Top + 10 != 236 || player.Left != 53) && (player.Top + 10 != 226 || (player.Left != 33 && player.Left != 43)) && (player.Top + 10 != 236 || (player.Left != 463 && player.Left != 473 && player.Left != 483 && player.Left != 493 && player.Left != 503 && player.Left != 513 && player.Left != 523 && player.Left != 533 && player.Left != 543 && player.Left != 553 && player.Left != 563 && player.Left != 573)))
                player.Top += 10;
        }

        private void TimerLeft_Tick(object sender, EventArgs e)
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
            if (player.Left > 33 && (player.Left - 10 != 43 || (player.Top != 336 && player.Top != 346 && player.Top != 356 && player.Top != 366)) && (player.Left - 10 != 93 || (player.Top != 256 && player.Top != 266 && player.Top != 276 && player.Top != 286 && player.Top != 296 && player.Top != 306 && player.Top != 316 && player.Top != 326)) && (player.Left - 10 != 73 || player.Top != 246) && (player.Left - 10 != 53 || player.Top != 236) && (player.Left - 10 != 43 || player.Top != 226) && (player.Left - 10 != 443 || (player.Top != 106 && player.Top != 116 && player.Top != 126 && player.Top != 136 && player.Top != 146 && player.Top != 156 && player.Top != 166)) && (player.Left - 10 != 493 || (player.Top != 86 && player.Top != 96)))
                player.Left -= 10;
        }

        private void TimerRight_Tick(object sender, EventArgs e)
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
            if (player.Left < 573 && (player.Left + 10 != 563 || (player.Top != 346 && player.Top != 356 && player.Top != 366)) && (player.Left + 10 != 463 || (player.Top != 236 && player.Top != 246 && player.Top != 256 && player.Top != 266 && player.Top != 276 && player.Top != 286 && player.Top != 296 && player.Top != 306 && player.Top != 316 && player.Top != 326 && player.Top != 336)) && (player.Left + 10 != 573 || player.Top != 96) && (player.Left + 10 != 563 || player.Top != 86) && (player.Left + 10 != 153 || (player.Top != 106 && player.Top != 116 && player.Top != 126 && player.Top != 136 && player.Top != 146 && player.Top != 156 && player.Top != 166)))
                player.Left += 10;
        }

        //Controller
        private void FormMonsterCenterMap_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                    timerUp.Start();
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                    timerDown.Start();
                else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                    timerLeft.Start();
                else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                    timerRight.Start();
                else if (e.KeyCode == Keys.Z)
                {
                    if (player.Left == 303 && player.Top - 66 == 110)
                    {
                        save = false;
                        labelDisplay.Text = "Hello, and welcome to\nthe MonSTER CENTER.";
                        pause = panelChatWheel.Visible = labelDisplay.Visible = true;
                        orderText = 0;
                        timerGame.Start();
                    }
                }
            }
            if (e.KeyCode == Keys.B)
                BackToGame();
        }

        //Checking whether is the same quest number or not or player doing the quest or not
        private void Quest2()
        {
            if (Properties.Settings.Default.QuestNum == 2)
                Properties.Settings.Default.MissionQuest++;
        }

        private void FormMonsterCenterMap_KeyUp(object sender, KeyEventArgs e)
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

        //Scene for restore monster health
        private void timerGame_Tick(object sender, EventArgs e)
        {
            if (orderText == 0)
            {
                pictureBoxPokeBall.Image = Properties.Resources.pokeballDark;
                labelDisplay.Text = "We restore your tired MoNSTER\nto full health.";
                orderText++;
            }
            else if (orderText == 1)
            {
                labelDisplay.Text = "Would you like to rest your MoNSTER?";
                panelYesNo.Visible = !panelYesNo.Visible;
                orderText++;
                timerGame.Stop();
            }
            else if (orderText == 2)
            {
                music.controls.pause();
                soundFx.URL = resourcesPath + "Recovery.mp3";
                Properties.Settings.Default.HealthBar = Properties.Settings.Default.MaxHealth;
                pictureBoxPokeBall.Image = Properties.Resources.glowPokeball;
                timerGame.Interval = 3500;
                orderText++;
            }
            else if (orderText == 3)
            {
                music.controls.play();
                pictureBoxPokeBall.Visible = false;
                timerGame.Interval = 2200;
                labelDisplay.Text = "Thank you for waiting.";
                orderText++;
            }
            else if (orderText == 4)
            {
                labelDisplay.Text = "We`ve restore your MoNSTER\nto full health.";
                orderText++;
            }
            else if (orderText == 5)
            {
                labelDisplay.Text = "We hope to see you again!";
                timerGame.Interval = 2200;
                orderText++;
            }
            else
            {
                panelChatWheel.Visible = pause = false;
                timerGame.Stop();
                this.Focus();
            }
        }

        //Close the form
        private void NewForm()
        {
            this.Close();
            Thread newForm = new Thread(OpenNewForm);
            newForm.SetApartmentState(ApartmentState.STA);
            newForm.Start();
        }

        private void OpenNewForm()
        {
            FormCityMap formCityMap = new FormCityMap();
            formCityMap.PassingData(Properties.Settings.Default.LevelMonster, Properties.Settings.Default.MaxHealth, Properties.Settings.Default.HealthBar, Properties.Settings.Default.ExpBar, Properties.Settings.Default.MaxAttPlayer, Properties.Settings.Default.AfterBattle, Properties.Settings.Default.PlayerFainted, Properties.Settings.Default.AcceptQuest, Properties.Settings.Default.MissionQuest, Properties.Settings.Default.QuestNum, Properties.Settings.Default.Potion);
            Application.Run(formCityMap);
        }

        //Parsing Data to another form
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

        //button UI
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
            Properties.Settings.Default.CurrentLocation = Properties.SettingsVolume.Default.AccessFrom = 3;
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
            save = true;
            labelDisplay.Text = "Would you like to save the game?";
            orderText = 0;
            panelChatWheel.Visible = panelYesNo.Visible = !panelChatWheel.Visible;
            timerSaveGame.Interval = 3000;
            BackToGame();
        }
        
        //Saving Game
        private void buttonYes_Click(object sender, EventArgs e)
        {
            if (save)
            {
                panelYesNo.Visible = !panelYesNo.Visible;
                labelDisplay.Text = "Saving the game ...";
                timerSaveGame.Start();
            }
            else
            {
                labelDisplay.Text = "Okay, I`ll take your MoNSTER\nfor a few seconds";
                pictureBoxPokeBall.Visible = true;
                panelYesNo.Visible = false;
                timerGame.Start();
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            if (save)
            {
                timerGame.Interval = 1;
                labelSaveGame_Click(e, e);
                this.Focus();
            }
            else
            {
                timerGame.Interval = 1;
                orderText = 5;
                panelYesNo.Visible = false;
                timerGame.Start();
            }
        }

        private void timerSaveGame_Tick(object sender, EventArgs e)
        {
            if (orderText == 0)
            {
                Properties.Settings.Default.LoadGame = Properties.Settings.Default.SaveGame = true;
                Properties.Settings.Default.PlayerImage = playerImage;
                Properties.Settings.Default.PlayerLocation = player.Location;
                Properties.Settings.Default.Save();
                orderText++;
            }
            else if (orderText == 1)
            {
                labelDisplay.Text = Properties.Settings.Default.NamePlayer + " saved the game!";
                timerSaveGame.Interval = 1200;
                orderText++;
            }
            else
            {
                labelSaveGame_Click(e, e);
                labelDisplay.ResetText();
                timerSaveGame.Stop();
            }
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

        private void BackToGame()
        {
            panelBag.Visible = !panelBag.Visible;
            panelBag.Focus();
        }
    }
}
