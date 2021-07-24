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
    public partial class FormCityMap : Form
    {
        short orderText, playerImage = 4;
        bool walk;

        string resourcesPath = Application.StartupPath + "\\Resources\\";
        public WindowsMediaPlayer music = new WindowsMediaPlayer();

        public FormCityMap()
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

        private void FormCityMap_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            //Playing music
            music.URL = resourcesPath + "City.mp3";
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

            //Load game based on from which form he comes
            else
            {
                if (Properties.Settings.Default.CurrentLocation == 1)
                {
                    player.Location = new Point(0, 200);
                    player.Image = Properties.Resources.right_1;
                }
                else if (Properties.Settings.Default.CurrentLocation == 2)
                {
                    player.Location = new Point(250, 110);
                    player.Image = Properties.Resources.down_1;
                }
                else if (Properties.Settings.Default.CurrentLocation == 3)
                {
                    player.Location = new Point(450, 110);
                    player.Image = Properties.Resources.down_1;
                }
                Properties.Settings.Default.CurrentLocation = 4;
            }
        }

        private void TimerUp_Tick(object sender, EventArgs e)
        {
            Quest2();
            //Check whether the location is the same as go to other location
            if (player.Top - 10 == 100 || player.Top - 10 == 90)
            {
                switch (player.Left)
                {
                    //Go to home location
                    case 250:
                        Properties.Settings.Default.CurrentLocation = 2;
                        NewForm();
                        break;
                    //Go to monster center location
                    case 450:
                        Properties.Settings.Default.CurrentLocation = 3;
                        NewForm();
                        break;
                }

            }

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

            if (player.Top > 50 && (player.Top - 10 != 90 || (player.Left != 0 && player.Top != 10 && player.Left != 20 && player.Left != 30 && player.Left != 40)) && (player.Top - 10 != 100 || (player.Left != 180 && player.Left != 190 && player.Left != 200 && player.Left != 210 && player.Left != 220 && player.Left != 230 && player.Left != 240 && player.Left != 260 && player.Left != 270 && player.Left != 280 && player.Left != 290 && player.Left != 300 && player.Left != 310 && player.Left != 320 && player.Left != 330 && player.Left != 340 && player.Left != 350 && player.Left != 380 && player.Left != 390 && player.Left != 400 && player.Left != 410 && player.Left != 420 && player.Left != 430 && player.Left != 440 && player.Left != 460 && player.Left != 470 && player.Left != 480 && player.Left != 490 && player.Left != 500 && player.Left != 510 && player.Left != 520 && player.Left != 530 && player.Left != 540 && player.Left != 550)))
                player.Top -= 10;
        }

        private void TimerDown_Tick(object sender, EventArgs e)
        {
            Quest2();

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
            if (player.Top < 300 && (player.Top + 10 != 300 || (player.Left != 330 && player.Left != 340)) && (player.Top + 10 != 280 || (player.Left != 350 && player.Left != 360 && player.Left != 370 && player.Left != 380 && player.Left != 390 && player.Left != 400 && player.Left != 410 && player.Left != 420 && player.Left != 430 && player.Left != 440)))
                player.Top += 10;
        }

        private void TimerLeft_Tick(object sender, EventArgs e)
        {
            Quest2();

            //Check whether the location is the same as go to forest location
            if (player.Left - 10 == -10 && (player.Top != 180 || player.Top != 190 || player.Top == 200 || player.Top == 210 || player.Top == 220))
            {
                Properties.Settings.Default.CurrentLocation = 1;
                NewForm();
            }

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
            if (player.Left > 0 && (player.Left - 10 != 40 || (player.Top != 50 && player.Top != 60 && player.Top != 70 && player.Top != 80 && player.Top != 90)) && (player.Left - 10 != 350 || (player.Top != 50 && player.Top != 60 && player.Top != 70 && player.Top != 80 && player.Top != 90 && player.Top != 100)) && (player.Left - 10 != 440 || (player.Top != 280 && player.Top != 290 && player.Top != 300)))
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
            if (player.Left < 550 && (player.Left + 10 != 180 || (player.Top != 50 && player.Top != 60 && player.Top != 70 && player.Top != 80 && player.Top != 90 && player.Top != 100)) && (player.Left + 10 != 330 || player.Top != 300) && (player.Left + 10 != 380 || (player.Top != 50 && player.Top != 60 && player.Top != 70 && player.Top != 80 && player.Top != 90 && player.Top != 100)) && (player.Left + 10 != 350 || (player.Top != 280 && player.Top != 290)))
                player.Left += 10;
        }

        //Quest for checking if the player walk or not or doing this quest or not
        private void Quest2()
        {
            if (Properties.Settings.Default.QuestNum == 2)
                Properties.Settings.Default.MissionQuest++;
        }

        //Controller
        private void FormCityMap_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void FormCityMap_KeyUp(object sender, KeyEventArgs e)
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

        private void OpenNewForm()
        {
            if (Properties.Settings.Default.CurrentLocation == 1)
            {
                FormForestMap formForestMap = new FormForestMap();
                formForestMap.PassingData(Properties.Settings.Default.LevelMonster, Properties.Settings.Default.MaxHealth, Properties.Settings.Default.HealthBar, Properties.Settings.Default.ExpBar, Properties.Settings.Default.MaxAttPlayer, Properties.Settings.Default.AfterBattle, Properties.Settings.Default.PlayerFainted, Properties.Settings.Default.AcceptQuest, Properties.Settings.Default.MissionQuest, Properties.Settings.Default.QuestNum, Properties.Settings.Default.Potion);
                Application.Run(formForestMap);
            }
            else if (Properties.Settings.Default.CurrentLocation == 2)
            {
                FormHomeMap formHomeMap = new FormHomeMap();
                formHomeMap.PassingData(Properties.Settings.Default.LevelMonster, Properties.Settings.Default.MaxHealth, Properties.Settings.Default.HealthBar, Properties.Settings.Default.ExpBar, Properties.Settings.Default.MaxAttPlayer, Properties.Settings.Default.AfterBattle, Properties.Settings.Default.PlayerFainted, Properties.Settings.Default.AcceptQuest, Properties.Settings.Default.MissionQuest, Properties.Settings.Default.QuestNum, Properties.Settings.Default.Potion);
                Application.Run(formHomeMap);
            }
            else if (Properties.Settings.Default.CurrentLocation == 3)
            {
                FormMonsterCenterMap formMonsterCenterMap = new FormMonsterCenterMap();
                formMonsterCenterMap.PassingData(Properties.Settings.Default.LevelMonster, Properties.Settings.Default.MaxHealth, Properties.Settings.Default.HealthBar, Properties.Settings.Default.ExpBar, Properties.Settings.Default.MaxAttPlayer, Properties.Settings.Default.AfterBattle, Properties.Settings.Default.PlayerFainted, Properties.Settings.Default.AcceptQuest, Properties.Settings.Default.MissionQuest, Properties.Settings.Default.QuestNum, Properties.Settings.Default.Potion);
                Application.Run(formMonsterCenterMap);
            }
            else
                Application.Run(new FormMainMenu());
        }

        //Passing data to another form
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

        // button UI
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
            Properties.Settings.Default.CurrentLocation = Properties.SettingsVolume.Default.AccessFrom = 4;
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
            labelDisplay.Text = "Would you like to save the game?";
            orderText = 0;
            panelChatWheel.Visible = panelYesNo.Visible = !panelChatWheel.Visible;
            timerSaveGame.Interval = 3000;
            BackToGame();
        }

        //Saving the game
        private void buttonYes_Click(object sender, EventArgs e)
        {
            panelYesNo.Visible = !panelYesNo.Visible;
            labelDisplay.Text = "Saving the game ...";
            timerSaveGame.Start();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            labelSaveGame_Click(e, e);
            this.Focus();
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