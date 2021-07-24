using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Monster_Battle_Sparkle
{
    public partial class UserControlBag : UserControl
    {
        int orderText;

        string resourcesPath = Application.StartupPath + "\\Resources\\";
        WindowsMediaPlayer soundFx = new WindowsMediaPlayer(); 

        public UserControlBag()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            //Getting data about how many potion player have
            labelAmountPotion.Text = "x " + Properties.Settings.Default.Potion;
        }

        //Button UI
        private void labelUse_Click(object sender, EventArgs e)
        {
            panelUseItem.Visible = labelNameItem.Visible = labelBack.Visible = false;
            orderText = 0;
            timerUseItem.Interval = 1;
            timerUseItem.Start();
        }

        private void labelUse_MouseMove(object sender, MouseEventArgs e)
        {
            labelUse.Font = new Font("Microsoft Sans Serif", 16);
        }

        private void labelUse_MouseLeave(object sender, EventArgs e)
        {
            labelUse.Font = new Font("Microsoft Sans Serif", 12);
        }

        //Scene using the potion item
        private void timerUseItem_Tick(object sender, EventArgs e)
        {
            if (orderText == 0)
            {
                switch (Properties.Settings.Default.Potion)
                {
                    case 0:
                        labelInfo.Text = "You dont have enough potion!";
                        orderText++;
                        break;
                    default:
                        soundFx.URL = resourcesPath + "LevelUp.mp3";
                        labelInfo.Text = "PIKACHU grew to Lv. " + ++Properties.Settings.Default.LevelMonster + "!";
                        Properties.Settings.Default.MaxAttPlayer++;
                        double currentMaxHealth = Properties.Settings.Default.MaxHealth;
                        Properties.Settings.Default.MaxHealth += (int)(Properties.Settings.Default.MaxHealth * 0.09);
                        Properties.Settings.Default.HealthBar = (int)(Math.Round(Properties.Settings.Default.HealthBar * Properties.Settings.Default.MaxHealth / currentMaxHealth, 0));
                        labelAmountPotion.Text = "x " + --Properties.Settings.Default.Potion;
                        orderText++;
                        break;
                }
                timerUseItem.Interval = 2000;
            }
            else
            {
                labelInfo.Text = "A potion that if your monster use, there is something going happen";
                panelUseItem.Visible = labelBack.Visible = labelNameItem.Visible = true;
                timerUseItem.Stop();
            }
        }

        //Remove this usercontrol
        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void labelBack_MouseMove(object sender, MouseEventArgs e)
        {
            labelBack.Font = new Font("Proxima Nova Alt Rg", 22);
        }

        private void labelBack_MouseLeave(object sender, EventArgs e)
        {
            labelBack.Font = new Font("Proxima Nova Alt Rg", 18);
        }
    }
}
