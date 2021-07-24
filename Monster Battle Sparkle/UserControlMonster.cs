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
    public partial class UserControlMonster : UserControl
    {   
        public UserControlMonster()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            //Load Level Monster
            labelLevelMonster1.Text = "Lv. " + Properties.Settings.Default.LevelMonster;

            //Load HP Monster
            progressBarHpMonster1.Maximum = Properties.Settings.Default.MaxHealth;
            progressBarHpMonster1.Value = Properties.Settings.Default.HealthBar;
            if (progressBarHpMonster1.Value <= progressBarHpMonster1.Maximum * 0.5 && progressBarHpMonster1.Value > progressBarHpMonster1.Maximum * 0.2)
                progressBarHpMonster1.ForeColor = Color.Orange;
            else if (progressBarHpMonster1.Value <= progressBarHpMonster1.Maximum * 0.2)
                progressBarHpMonster1.ForeColor = Color.Red;
            labelHpMonster1.Text = progressBarHpMonster1.Value + " / " + progressBarHpMonster1.Maximum;

            //Load EXP Monster
            progressBarExpMonster1.Value = Properties.Settings.Default.ExpBar;
        }

        //Remove this usercontrol
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
