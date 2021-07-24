using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WMPLib;

namespace Monster_Battle_Sparkle
{
    public partial class UserControlNewGame : UserControl
    {
        Thread newForm;

        bool pause;
        short orderText = 0;

        string resourcesPath = Application.StartupPath + "\\Resources\\";
        WindowsMediaPlayer music = new WindowsMediaPlayer();

        public UserControlNewGame()
        {
            InitializeComponent();
        }

        private void UserControlNewGame_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            //Playing music
            music.URL = resourcesPath + "NewGame.mp3";
            music.settings.setMode("loop", true);
            music.settings.volume = Properties.SettingsVolume.Default.Volume;

            //Focusing on this usercontrol
            this.Focus();
        }

        //Controller
        private void UserControlNewGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(!pause && e.KeyCode == Keys.Z)
            {
                timerChat.Start();
            }
        }

        //Button UI
        private void labelConfirm_MouseMove(object sender, MouseEventArgs e)
        {
            labelConfirm.Font = new Font("Microsoft Sans Serif", 18);
        }

        private void labelConfirm_MouseLeave(object sender, EventArgs e)
        {
            labelConfirm.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void labelConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxName.TextLength < 6)
            {
                labelError.Visible = true;
                textBoxName.Focus();
                textBoxName.SelectAll();
            }
            else
            {
                labelError.Visible = false;
                if (MessageBox.Show("Are you sure your name is " + textBoxName.Text + "?", "Your Name", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Properties.Settings.Default.NamePlayer = textBoxName.Text;
                    panelIdentity.Visible = false;
                    labelDisplay.Visible = false;
                    orderText++;
                    timerMoving.Start();
                }
                else
                {
                    textBoxName.Focus();
                    textBoxName.SelectAll();
                }
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.TextLength >= 6)
                labelError.Visible = false;
            else
                labelError.Visible = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && e.KeyChar == 32)
                e.Handled = true;
        }

        //Scene New Game
        private void timerChat_Tick(object sender, EventArgs e)
        {
            pause = true;
            labelPress.Visible = false;
            switch (orderText)
            {
                case 0:
                    labelDisplay.Text = "My name is Professor Rowan, so...";
                    break;
                case 1:
                    labelDisplay.Text = "What's your name, trainer?";
                    timerMoving.Start();
                    break;
                case 2:
                    labelDisplay.Text = "Hi, " + textBoxName.Text + "!";
                    labelDisplay.Visible = true;
                    break;
                case 3:
                    labelDisplay.Text = "So, i'm here to tell you about how to play this game!";
                    break;
                case 4:
                    labelDisplay.Text = "You can open backpack by pressing the B keys!";
                    break;
                case 5:
                    labelDisplay.Text = "You can also talk to people by pressing the Z keys!";
                    break;
                case 6:
                    labelDisplay.Text = "Let's go dive to the game!";
                    Properties.Settings.Default.Save();
                    break;
                case 7:
                    panelChatWheel.Visible = false;
                    this.BackgroundImage = null;
                    break;
                case 8:
                    NewForm();
                    break;
            }
            labelPress.Visible = true;
            if (orderText != 1)
            {
                pause = false;
                orderText++;
            }
            if (orderText != 8)
                timerChat.Stop();
            this.Focus();
        }

        //Animation for moving the picture
        private void timerMoving_Tick(object sender, EventArgs e)
        {
            //258 to 418
            switch (orderText)
            {
                case 1:
                    pictureBoxProf.Left += 2;
                    if (pictureBoxProf.Left == 418)
                    {
                        timerMoving.Stop();
                        panelIdentity.Visible = true;
                        textBoxName.Focus();
                    }
                    break;
                case 2:
                    pictureBoxProf.Left -= 2;
                    if (pictureBoxProf.Left == 258)
                    {
                        timerMoving.Stop();
                        timerChat.Start();
                    }
                    break;
            }
        }

        //Closing form main menu
        private void NewForm()
        {
            music.controls.pause();
            Application.Exit();
            newForm = new Thread(OpenNewForm);
            newForm.SetApartmentState(ApartmentState.STA);
            newForm.Start();
        }

        private void OpenNewForm()
        {
            Application.Run(new FormForestMap());
        }
    }
}
