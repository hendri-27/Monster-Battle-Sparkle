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
    public partial class FormMainMenu : Form
    {
        PictureBox[] Stars;

        Random rnd = new Random();
        Thread newForm;

        int BackgroundSpeed;

        string resourcesPath = Application.StartupPath + "\\Resources\\";
        public WindowsMediaPlayer music = new WindowsMediaPlayer();

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

        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            //Checking whether the game has load or save game
            if (Properties.Settings.Default.LoadGame || Properties.Settings.Default.SaveGame)
            {
                buttonLoadGame.Enabled = true;
            }

            //Playing music
            music.URL = resourcesPath + "TitleScreen.mp3";
            music.settings.setMode("loop", true);
            music.settings.volume = Properties.SettingsVolume.Default.Volume;

            //Animation for glowing light goes up
            BackgroundSpeed = -1;
            Stars = new PictureBox[30];
            for (int i = 0; i < Stars.Length; i++)
            {
                Stars[i] = new PictureBox();
                Stars[i].BorderStyle = BorderStyle.None;
                Stars[i].Location = new Point(rnd.Next(0, 651), rnd.Next(480, 750));
                if (i % 2 == 0)
                {
                    Stars[i].Size = new Size(2, 2);
                    Stars[i].BackColor = Color.Yellow;
                }
                else if (i % 5 == 0)
                {
                    Stars[i].Size = new Size(3, 3);
                    Stars[i].BackColor = Color.GreenYellow;
                }
                else
                {
                    Stars[i].Size = new Size(2, 1);
                    Stars[i].BackColor = Color.LightSkyBlue;
                }
                this.Controls.Add(Stars[i]);
            }
        }

        private void timerGlowingLight_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Stars.Length / 2; i++)
            {
                Stars[i].Top += BackgroundSpeed;
                if (Stars[i].Top <= 0)
                {
                    Stars[i].Top = rnd.Next(250, 450);
                }
            }

            for (int i = Stars.Length / 2; i < Stars.Length; i++)
            {
                Stars[i].Top += BackgroundSpeed - 1;
                if (Stars[i].Top <= 0)
                {
                    Stars[i].Top = rnd.Next(250, 450);
                }
            }
        }

        //Button UI
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.LoadGame)
            {
                if (MessageBox.Show("Are you sure you want to make a New Game?", "New Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Properties.Settings.Default.Reset();
                    OpeningForm();
                }
            }
            else
            {
                Properties.Settings.Default.Reset();
                OpeningForm();
            }
        }

        private void OpeningForm()
        {
            music.controls.pause();
            UserControlNewGame userControlNewGame = new UserControlNewGame();
            this.Controls.Add(userControlNewGame);
            userControlNewGame.Dock = DockStyle.Fill;
            userControlNewGame.BringToFront();
        }

        private void buttonLoadGame_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveGame = false;
            NewForm();
        }

        private void NewForm()
        {
            music.controls.stop();
            this.Close();
            newForm = new Thread(OpenNewForm);
            newForm.SetApartmentState(ApartmentState.STA);
            newForm.Start();
        }

        private void OpenNewForm()
        {
            if (Properties.Settings.Default.CurrentLocation == 1)
                Application.Run(new FormForestMap());

            else if (Properties.Settings.Default.CurrentLocation == 2)
                Application.Run(new FormHomeMap());

            else if (Properties.Settings.Default.CurrentLocation == 3)
                Application.Run(new FormMonsterCenterMap());

            else
                Application.Run(new FormCityMap());
        }

        private void buttonMultiplayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not available right now!", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            Properties.SettingsVolume.Default.AccessFrom = 0;
            Properties.SettingsVolume.Default.Save();
            FormSetting formSetting = new FormSetting();
            formSetting.PassingData(Properties.Settings.Default.LevelMonster, Properties.Settings.Default.MaxHealth, Properties.Settings.Default.HealthBar, Properties.Settings.Default.ExpBar, Properties.Settings.Default.MaxAttPlayer, Properties.Settings.Default.AfterBattle, Properties.Settings.Default.PlayerFainted, Properties.Settings.Default.AcceptQuest, Properties.Settings.Default.MissionQuest, Properties.Settings.Default.QuestNum, Properties.Settings.Default.Potion, Properties.Settings.Default.CurrentLocation, Properties.Settings.Default.PlayerLocation, Properties.Settings.Default.PlayerImage);
            formSetting.Owner = this;
            formSetting.ShowDialog();
        }

        private void buttonQuitGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the game?", "Quit Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
