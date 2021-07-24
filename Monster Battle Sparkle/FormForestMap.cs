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
    public partial class FormForestMap : Form
    {
        Label grass1 = new Label();
        Label grass2 = new Label();
        Label grass3 = new Label();
        Label grass4 = new Label();
        Label grass5 = new Label();
        Label grass6 = new Label();
        Label grass7 = new Label();
        Label grass8 = new Label();
        Label grass9 = new Label();
        Label grass10 = new Label();
        Label grass11 = new Label();
        Label grass12 = new Label();
        Label grass13 = new Label();

        Random rnd = new Random();
        short playerImage = 3, backToMenu = 1, orderText;
        bool walk;

        string resourcesPath = Application.StartupPath + "\\Resources\\";
        public WindowsMediaPlayer music = new WindowsMediaPlayer();

        public FormForestMap()
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

        private void FormForestMap_Load(object sender, EventArgs e)
        {            
            this.DoubleBuffered = true;

            //Playing music
            music.URL = resourcesPath + "Forest.mp3";
            music.settings.setMode("loop", true);
            music.settings.volume = Properties.SettingsVolume.Default.Volume;

            //Initialize grass object
            grass1.Size = new Size(100, 250);
            grass1.Location = new Point(100, 101);
            grass1.BackColor = Color.Transparent;
            this.Controls.Add(grass1);

            grass2.Size = new Size(50, 100);
            grass2.Location = new Point(50, 151);
            grass2.BackColor = Color.Transparent;
            this.Controls.Add(grass2);

            grass3.Size = new Size(50, 50);
            grass3.Location = new Point(50, 51);
            grass3.BackColor = Color.Transparent;
            this.Controls.Add(grass3);

            grass4.Size = new Size(50, 50);
            grass4.Location = new Point(200, 101);
            grass4.BackColor = Color.Transparent;
            this.Controls.Add(grass4);

            grass5.Size = new Size(50, 50);
            grass5.Location = new Point(200, 301);
            grass5.BackColor = Color.Transparent;
            this.Controls.Add(grass5);

            grass6.Size = new Size(50, 50);
            grass6.Location = new Point(150, 351);
            grass6.BackColor = Color.Transparent;
            this.Controls.Add(grass6);

            grass7.Size = new Size(50, 100);
            grass7.Location = new Point(300, 301);
            grass7.BackColor = Color.Transparent;
            this.Controls.Add(grass7);

            grass8.Size = new Size(100, 100);
            grass8.Location = new Point(450, 301);
            grass8.BackColor = Color.Transparent;
            this.Controls.Add(grass8);

            grass9.Size = new Size(50, 50);
            grass9.Location = new Point(400, 351);
            grass9.BackColor = Color.Transparent;
            this.Controls.Add(grass9);

            grass10.Size = new Size(150, 50);
            grass10.Location = new Point(450, 50);
            grass10.BackColor = Color.Transparent;
            this.Controls.Add(grass10);

            grass11.Size = new Size(100, 50);
            grass11.Location = new Point(500, 251);
            grass11.BackColor = Color.Transparent;
            this.Controls.Add(grass11);

            grass12.Size = new Size(50, 50);
            grass12.Location = new Point(550, 351);
            grass12.BackColor = Color.Transparent;
            this.Controls.Add(grass12);

            grass13.Size = new Size(50, 50);
            grass13.Location = new Point(300, 101);
            grass13.BackColor = Color.Transparent;
            this.Controls.Add(grass13);

            //Load Game
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
                timerGame.Stop();
            }

            //Load position after battle without saving game
            else if (Properties.Settings.Default.AfterBattle)
            {
                player.Location = Properties.SettingsVolume.Default.PlayerLocation;
                Properties.Settings.Default.AfterBattle = false;
                switch (Properties.SettingsVolume.Default.PlayerImage)
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
                timerGame.Stop();
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
            if (player.Top > 30 && (player.Top - 10 != 220 || (player.Left != 260 && player.Left != 270 && player.Left != 280 && player.Left != 290 && player.Left != 300 && player.Left != 310 && player.Left != 320 && player.Left != 330 && player.Left != 340)) && (player.Top - 10 != 100 || (player.Left != 560 && player.Left != 570 && player.Left != 580 && player.Left != 590 && player.Left != 600)) && (player.Top - 10 != 50 || (player.Left != 260 && player.Left != 270 && player.Left != 280 && player.Left != 290 && player.Left != 300 && player.Left != 310 && player.Left != 320 && player.Left != 330 && player.Left != 340)))
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
            if (player.Top < 350 && (player.Top + 10 != 100 || (player.Left != 260 && player.Left != 270 && player.Left != 280 && player.Left != 290 && player.Left != 300 && player.Left != 310 && player.Left != 320 && player.Left != 330 && player.Left != 340)) && (player.Top + 10 != 350 || (player.Left != 40 && player.Left != 50 && player.Left != 60 && player.Left != 70 && player.Left != 80 && player.Left != 90)) && (player.Top + 10 != 160 || (player.Left != 560 && player.Left != 570 && player.Left != 580 && player.Left != 590 && player.Left != 600)))
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
            if (player.Left > 40 && (player.Left - 10 != 340 || (player.Top != 30 && player.Top != 40 && player.Top != 50)) && (player.Left - 10 != 340 || (player.Top != 110 && player.Top != 120 && player.Top != 130 && player.Top != 140 && player.Top != 150 && player.Top != 160 && player.Top != 170 && player.Top != 180 && player.Top != 190 && player.Top != 200 && player.Top != 210 && player.Top != 220)) && (player.Left - 10 != 50 || (player.Top != 310 && player.Top != 320 && player.Top != 330 && player.Top != 340 && player.Top != 350)))
                player.Left -= 10;
        }

        private void TimerRight_Tick(object sender, EventArgs e)
        {
            Quest2();

            //Checking whether player position is the sam as go to city form
            if (player.Left + 10 == 610 && (player.Top == 110 || player.Top == 120 || player.Top == 130 || player.Top == 140 || player.Top == 150))
            {
                backToMenu = 1;
                NewForm();
            }

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
            if (player.Left < 600 && (player.Left + 10 != 260 || (player.Top != 30 && player.Top != 40 && player.Top != 50)) && (player.Left + 10 != 260 || (player.Top != 110 && player.Top != 120 && player.Top != 130 && player.Top != 140 && player.Top != 150 && player.Top != 160 && player.Top != 170 && player.Top != 180 && player.Top != 190 && player.Top != 200 && player.Top != 210 && player.Top != 220)) && (player.Left + 10 != 560 || (player.Top != 30 && player.Top != 40 && player.Top != 50 && player.Top != 60 && player.Top != 70 && player.Top != 80 && player.Top != 90 && player.Top != 100 && player.Top != 160 && player.Top != 170 && player.Top != 180 && player.Top != 190 && player.Top != 200 && player.Top != 210 && player.Top != 220 && player.Top != 230 && player.Top != 240 && player.Top != 250 && player.Top != 260 && player.Top != 270 && player.Top != 280 && player.Top != 290 && player.Top != 300 && player.Top != 310 && player.Top != 320 && player.Top != 330 && player.Top != 340 && player.Top != 350)))
                player.Left += 10;
        }

        //Controller
        private void FormForestMap_KeyDown(object sender, KeyEventArgs e)
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

        //Checking whether quest is the same or not or doing the quest or not
        private void Quest2()
        {
            if (Properties.Settings.Default.QuestNum == 2)
                Properties.Settings.Default.MissionQuest++;
        }
        private void FormForestMap_KeyUp(object sender, KeyEventArgs e)
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
            timerGame.Start();
        }

        //Checking if player bounds intersect with grass bounds
        private void TimerGame_Tick(object sender, EventArgs e)
        {
            if(player.Bounds.IntersectsWith(grass1.Bounds) || player.Bounds.IntersectsWith(grass2.Bounds) || player.Bounds.IntersectsWith(grass3.Bounds) || player.Bounds.IntersectsWith(grass4.Bounds) || player.Bounds.IntersectsWith(grass5.Bounds) || player.Bounds.IntersectsWith(grass6.Bounds) || player.Bounds.IntersectsWith(grass7.Bounds) || player.Bounds.IntersectsWith(grass8.Bounds) || player.Bounds.IntersectsWith(grass9.Bounds) || player.Bounds.IntersectsWith(grass10.Bounds) || player.Bounds.IntersectsWith(grass11.Bounds) || player.Bounds.IntersectsWith(grass12.Bounds) || player.Bounds.IntersectsWith(grass13.Bounds))
            {
                timerGame.Stop();
                timerUp.Stop();
                timerDown.Stop();
                timerLeft.Stop();
                timerRight.Stop();
                int enemy = rnd.Next(0, 1000);

                if (enemy > 400 && enemy < 500)
                {
                    Properties.SettingsVolume.Default.PlayerImage = playerImage;
                    Properties.SettingsVolume.Default.PlayerLocation = player.Location;
                    Properties.SettingsVolume.Default.Save();
                    MessageBox.Show("Enemy Spotted.", "Info");
                    backToMenu = 3;
                    NewForm();
                }
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

        private void OpenNewForm(object obj)
        {
            if (backToMenu == 1)
            {
                FormCityMap formCityMap = new FormCityMap();
                formCityMap.PassingData(Properties.Settings.Default.LevelMonster, Properties.Settings.Default.MaxHealth, Properties.Settings.Default.HealthBar, Properties.Settings.Default.ExpBar, Properties.Settings.Default.MaxAttPlayer, Properties.Settings.Default.AfterBattle, Properties.Settings.Default.PlayerFainted, Properties.Settings.Default.AcceptQuest, Properties.Settings.Default.MissionQuest, Properties.Settings.Default.QuestNum, Properties.Settings.Default.Potion);
                Application.Run(formCityMap);
            }
            else if (backToMenu == 2)
            {
                Application.Run(new FormMainMenu());
            }
            else
            {
                FormBattleScene formBattleScene = new FormBattleScene();
                formBattleScene.PassingData(Properties.Settings.Default.LevelMonster, Properties.Settings.Default.MaxHealth, Properties.Settings.Default.HealthBar, Properties.Settings.Default.ExpBar, Properties.Settings.Default.MaxAttPlayer, Properties.Settings.Default.AfterBattle, Properties.Settings.Default.PlayerFainted, Properties.Settings.Default.AcceptQuest, Properties.Settings.Default.MissionQuest, Properties.Settings.Default.QuestNum, Properties.Settings.Default.Potion);
                Application.Run(formBattleScene);
            }
        }

        //Passing Data to another form
        public void PassingData (short levelMonster, int maxHealth, int healthBar, int expBar, int maxAttPlayer, bool afterBattle, bool playerFainted, bool acceptQuest, short missionQuest, short questNum, short potion)
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
            Properties.Settings.Default.CurrentLocation = Properties.SettingsVolume.Default.AccessFrom = 1;
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

        //Saving game
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