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

namespace Monster_Battle_Sparkle
{
    public partial class FormSetting : Form
    {
        FormForestMap formForestMap = null;
        FormHomeMap formHomeMap = null;
        FormMonsterCenterMap formMonsterCenterMap = null;
        FormCityMap formCityMap = null;
        FormMainMenu formMainMenu = null;

        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            //Checking whether load form setting from main menu or not
            switch (Properties.SettingsVolume.Default.AccessFrom == 0)
            {
                case true:
                    buttonBackToTitle.Visible = false;
                    break;
                case false:
                    buttonBackToTitle.Visible = true;
                    break;
            }

            //Checking for the owner of this form setting
            switch (Properties.SettingsVolume.Default.AccessFrom)
            {
                case 1:
                    formForestMap = (FormForestMap)this.Owner;
                    break;
                case 2:
                    formHomeMap = (FormHomeMap)this.Owner;
                    break;
                case 3:
                    formMonsterCenterMap = (FormMonsterCenterMap)this.Owner;
                    break;
                case 4:
                    formCityMap = (FormCityMap)this.Owner;
                    break;
                default:
                    formMainMenu = (FormMainMenu)this.Owner;
                    break;
            }

            //Load volume setting data
            trackBarVolume.Value = Properties.SettingsVolume.Default.Volume;
            labelVolume.Text = Properties.SettingsVolume.Default.Volume.ToString();
        }

        private void buttonAudioGame_Click(object sender, EventArgs e)
        {
            panelAudio.Visible = true;
        }

        //Changing the volume of the music
        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            switch(Properties.SettingsVolume.Default.AccessFrom)
            {
                case 1:
                    formForestMap.music.settings.volume = trackBarVolume.Value;
                    break;
                case 2:
                    formHomeMap.music.settings.volume = trackBarVolume.Value;
                    break;
                case 3:
                    formMonsterCenterMap.music.settings.volume = formMonsterCenterMap.soundFx.settings.volume = trackBarVolume.Value;
                    break;
                case 4:
                    formCityMap.music.settings.volume = trackBarVolume.Value;
                    break;
                default:
                    formMainMenu.music.settings.volume = trackBarVolume.Value;
                    break;
            }
            labelVolume.Text = trackBarVolume.Value.ToString();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            Properties.SettingsVolume.Default.Volume = (short)trackBarVolume.Value;
            Properties.SettingsVolume.Default.Save();
            MessageBox.Show("Setting has been saved!");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Properties.SettingsVolume.Default.Volume = 50;
            Properties.SettingsVolume.Default.Save();
            trackBarVolume.Value = 50;
            trackBarVolume_Scroll(e, e);
        }

        private void buttonHowToPlay_Click(object sender, EventArgs e)
        {
            panelAudio.Visible = false;
        }

        //Open main menu form
        private void buttonBackToTitle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful, saving the game!", "Game Saved");
            Properties.Settings.Default.SaveGame = Properties.Settings.Default.LoadGame = true;
            Properties.Settings.Default.Save();
            Application.Exit();
            Thread newForm = new Thread(BackToTitle);
            newForm.SetApartmentState(ApartmentState.STA);
            newForm.Start();
        }

        //Passing Data for save the game in this settings
        public void PassingData(short levelMonster, int maxHealth, int healthBar, int expBar, int maxAttPlayer, bool afterBattle, bool playerFainted, bool acceptQuest, short missionQuest, short questNum, short potion, short currentLocation, Point locationPlayer, short playerImage)
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
            Properties.Settings.Default.CurrentLocation = currentLocation;
            Properties.Settings.Default.PlayerLocation = locationPlayer;
            Properties.Settings.Default.PlayerImage = playerImage;
        }

        private void BackToTitle()
        {
            Application.Run(new FormMainMenu());
        }

        //Close the form
        private void buttonExit_Click(object sender, EventArgs e)
        {
            switch (Properties.SettingsVolume.Default.AccessFrom)
            {
                case 1:
                    formForestMap.music.settings.volume = Properties.SettingsVolume.Default.Volume;
                    break;
                case 2:
                    formHomeMap.music.settings.volume = Properties.SettingsVolume.Default.Volume;
                    break;
                case 3:
                    formMonsterCenterMap.music.settings.volume = formMonsterCenterMap.soundFx.settings.volume = Properties.SettingsVolume.Default.Volume;
                    break;
                case 4:
                    formCityMap.music.settings.volume = Properties.SettingsVolume.Default.Volume;
                    break;
                default:
                    formMainMenu.music.settings.volume = Properties.SettingsVolume.Default.Volume;
                    break;
            }
            this.Close();
        }
    }
}
