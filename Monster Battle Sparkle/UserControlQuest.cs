using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monster_Battle_Sparkle
{
    public partial class UserControlQuest : UserControl
    {
        PictureBox[] Stars;
        Random rnd = new Random();

        int BackgroundSpeed;

        public UserControlQuest()
        {
            InitializeComponent();
        }

        private void UserControlQuest_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            //Give value and add the object to form
            BackgroundSpeed = 1;
            Stars = new PictureBox[50];

            for (int i = 0; i < Stars.Length; i++)
            {
                Stars[i] = new PictureBox();
                Stars[i].BorderStyle = BorderStyle.None;
                Stars[i].Location = new Point(rnd.Next(0, 651), rnd.Next(0, 451));
                if (i % 2 == 1)
                {
                    Stars[i].Size = new Size(2, 2);
                    Stars[i].BackColor = Color.LightYellow;
                }
                else
                {
                    Stars[i].Size = new Size(3, 3);
                    Stars[i].BackColor = Color.White;
                }
                this.Controls.Add(Stars[i]);
            }

            //Load the ongoing quest and checking whether the quest is completed or not yet
            if (Properties.Settings.Default.QuestNum > 0 && Properties.Settings.Default.AcceptQuest)
            {
                switch (Properties.Settings.Default.QuestNum)
                {
                    case 1:
                        labelQuest1.Text = "Kill wild monster 20 times!";
                        panelQuest1.Enabled = labelStatus1.Visible = true;
                        if (Properties.Settings.Default.MissionQuest >= 20)
                        {
                            labelStatus1.Text = "COMPLETED";
                        }
                        else
                        {
                            labelStatus1.Text = Properties.Settings.Default.MissionQuest + " /  20";
                        }
                        break;
                    case 2:
                        labelQuest2.Text = "Walk 10.000 steps!";
                        panelQuest2.Enabled = labelStatus2.Visible = true;
                        if (Properties.Settings.Default.MissionQuest >= 10000)
                        {
                            labelStatus2.Text = "COMPLETED";
                        }
                        else
                        {
                            labelStatus2.Text = Properties.Settings.Default.MissionQuest + " /  10000";
                        }
                        break;
                    case 3:
                        labelQuest3.Text = "Kill 3 enemy with hp under 10%!";
                        panelQuest3.Enabled = labelStatus3.Visible = true;
                        if (Properties.Settings.Default.MissionQuest >= 3)
                        {
                            labelStatus3.Text = "COMPLETED";
                        }
                        else
                        {
                            labelStatus3.Text = Properties.Settings.Default.MissionQuest + " /  3";
                        }
                        break;
                    default:
                        labelQuest4.Text = "Kill wild bidoof 20 times!";
                        panelQuest4.Enabled = labelStatus4.Visible = true;
                        if (Properties.Settings.Default.MissionQuest >= 20)
                        {
                            labelStatus4.Text = "COMPLETED";
                        }
                        else
                        {
                            labelStatus4.Text = Properties.Settings.Default.MissionQuest + " /  20";
                        }
                        break;
                }
            }
        }

        //Animation for snow on the background
        private void timerBackground_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Stars.Length / 2; i++)
            {
                Stars[i].Top += BackgroundSpeed;
                if (Stars[i].Top >= this.Height)
                {
                    Stars[i].Top = -Stars[i].Height;
                }
            }

            for (int i = Stars.Length / 2; i < Stars.Length; i++)
            {
                Stars[i].Top += BackgroundSpeed + 2;
                if (Stars[i].Top >= this.Height)
                {
                    Stars[i].Top = -Stars[i].Height;
                }
            }
        }

        //Button UI
        private void labelBack_MouseLeave(object sender, EventArgs e)
        {
            labelBack.Font = new Font("Lemon/Milk", (float)15.75);
        }

        private void labelBack_MouseMove(object sender, MouseEventArgs e)
        {
            labelBack.Font = new Font("Lemon/Milk", 25);
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
