namespace Monster_Battle_Sparkle
{
    partial class UserControlNewGame
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerChat = new System.Windows.Forms.Timer(this.components);
            this.timerMoving = new System.Windows.Forms.Timer(this.components);
            this.panelChatWheel = new System.Windows.Forms.Panel();
            this.labelPress = new System.Windows.Forms.Label();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.panelIdentity = new System.Windows.Forms.Panel();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.pictureBoxProf = new System.Windows.Forms.PictureBox();
            this.panelChatWheel.SuspendLayout();
            this.panelIdentity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProf)).BeginInit();
            this.SuspendLayout();
            // 
            // timerChat
            // 
            this.timerChat.Interval = 1;
            this.timerChat.Tick += new System.EventHandler(this.timerChat_Tick);
            // 
            // timerMoving
            // 
            this.timerMoving.Interval = 1;
            this.timerMoving.Tick += new System.EventHandler(this.timerMoving_Tick);
            // 
            // panelChatWheel
            // 
            this.panelChatWheel.BackgroundImage = global::Monster_Battle_Sparkle.Properties.Resources.encounterWindow;
            this.panelChatWheel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChatWheel.Controls.Add(this.labelPress);
            this.panelChatWheel.Controls.Add(this.labelDisplay);
            this.panelChatWheel.Location = new System.Drawing.Point(0, 360);
            this.panelChatWheel.Name = "panelChatWheel";
            this.panelChatWheel.Size = new System.Drawing.Size(651, 92);
            this.panelChatWheel.TabIndex = 174;
            // 
            // labelPress
            // 
            this.labelPress.AutoSize = true;
            this.labelPress.BackColor = System.Drawing.Color.Transparent;
            this.labelPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPress.Location = new System.Drawing.Point(561, 54);
            this.labelPress.Name = "labelPress";
            this.labelPress.Size = new System.Drawing.Size(62, 20);
            this.labelPress.TabIndex = 164;
            this.labelPress.Text = "press Z";
            // 
            // labelDisplay
            // 
            this.labelDisplay.BackColor = System.Drawing.Color.Transparent;
            this.labelDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplay.ForeColor = System.Drawing.Color.White;
            this.labelDisplay.Location = new System.Drawing.Point(29, 25);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(595, 41);
            this.labelDisplay.TabIndex = 163;
            this.labelDisplay.Text = "Hello trainer! Welcome to Monsbatt SPARKLE ...";
            this.labelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelIdentity
            // 
            this.panelIdentity.BackColor = System.Drawing.Color.Transparent;
            this.panelIdentity.Controls.Add(this.labelConfirm);
            this.panelIdentity.Controls.Add(this.textBoxName);
            this.panelIdentity.Controls.Add(this.label2);
            this.panelIdentity.Controls.Add(this.labelError);
            this.panelIdentity.Location = new System.Drawing.Point(76, 96);
            this.panelIdentity.Name = "panelIdentity";
            this.panelIdentity.Size = new System.Drawing.Size(307, 170);
            this.panelIdentity.TabIndex = 175;
            this.panelIdentity.Visible = false;
            // 
            // labelConfirm
            // 
            this.labelConfirm.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.labelConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirm.ForeColor = System.Drawing.Color.White;
            this.labelConfirm.Location = new System.Drawing.Point(106, 105);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(96, 45);
            this.labelConfirm.TabIndex = 3;
            this.labelConfirm.Text = "OK";
            this.labelConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelConfirm.Click += new System.EventHandler(this.labelConfirm_Click);
            this.labelConfirm.MouseLeave += new System.EventHandler(this.labelConfirm_MouseLeave);
            this.labelConfirm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelConfirm_MouseMove);
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(20, 48);
            this.textBoxName.MaxLength = 12;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(268, 26);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your name :";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Maroon;
            this.labelError.Location = new System.Drawing.Point(17, 77);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(267, 13);
            this.labelError.TabIndex = 0;
            this.labelError.Text = "*Your character name must be between 6 - 12";
            this.labelError.Visible = false;
            // 
            // pictureBoxProf
            // 
            this.pictureBoxProf.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProf.Image = global::Monster_Battle_Sparkle.Properties.Resources.Professor;
            this.pictureBoxProf.Location = new System.Drawing.Point(272, 51);
            this.pictureBoxProf.Name = "pictureBoxProf";
            this.pictureBoxProf.Size = new System.Drawing.Size(120, 272);
            this.pictureBoxProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProf.TabIndex = 176;
            this.pictureBoxProf.TabStop = false;
            // 
            // UserControlNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Monster_Battle_Sparkle.Properties.Resources.BackgroundNewGame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBoxProf);
            this.Controls.Add(this.panelChatWheel);
            this.Controls.Add(this.panelIdentity);
            this.Name = "UserControlNewGame";
            this.Size = new System.Drawing.Size(650, 450);
            this.Load += new System.EventHandler(this.UserControlNewGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserControlNewGame_KeyDown);
            this.panelChatWheel.ResumeLayout(false);
            this.panelChatWheel.PerformLayout();
            this.panelIdentity.ResumeLayout(false);
            this.panelIdentity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerChat;
        private System.Windows.Forms.Timer timerMoving;
        private System.Windows.Forms.Panel panelChatWheel;
        private System.Windows.Forms.Label labelPress;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.Panel panelIdentity;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox pictureBoxProf;
    }
}
