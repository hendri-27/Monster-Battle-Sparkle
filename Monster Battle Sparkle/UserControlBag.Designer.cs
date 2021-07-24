namespace Monster_Battle_Sparkle
{
    partial class UserControlBag
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelBack = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAmountPotion = new System.Windows.Forms.Label();
            this.labelNameItem = new System.Windows.Forms.Label();
            this.panelUseItem = new System.Windows.Forms.Panel();
            this.labelUse = new System.Windows.Forms.Label();
            this.timerUseItem = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelUseItem.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Monster_Battle_Sparkle.Properties.Resources.bagIcon;
            this.pictureBox1.Location = new System.Drawing.Point(28, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Monster_Battle_Sparkle.Properties.Resources.itemInfo;
            this.panel1.Controls.Add(this.panelUseItem);
            this.panel1.Controls.Add(this.labelNameItem);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 100);
            this.panel1.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInfo.Location = new System.Drawing.Point(78, 44);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(450, 40);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "A potion that if your pokemon use, there is something going happen\r\n.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Monster_Battle_Sparkle.Properties.Resources.expPotion;
            this.pictureBox3.Location = new System.Drawing.Point(10, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Monster_Battle_Sparkle.Properties.Resources.slotItem;
            this.panel2.Controls.Add(this.labelAmountPotion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(271, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 296);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Monster_Battle_Sparkle.Properties.Resources.FontBag;
            this.pictureBox4.Location = new System.Drawing.Point(89, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 25);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // labelBack
            // 
            this.labelBack.BackColor = System.Drawing.Color.Transparent;
            this.labelBack.Font = new System.Drawing.Font("Proxima Nova Alt Rg", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelBack.Location = new System.Drawing.Point(503, 8);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(114, 36);
            this.labelBack.TabIndex = 6;
            this.labelBack.Text = "BACK";
            this.labelBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            this.labelBack.MouseLeave += new System.EventHandler(this.labelBack_MouseLeave);
            this.labelBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelBack_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Proxima Nova Alt Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "No. 01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Proxima Nova Alt Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Level Up Potion";
            // 
            // labelAmountPotion
            // 
            this.labelAmountPotion.Font = new System.Drawing.Font("Proxima Nova Alt Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountPotion.Location = new System.Drawing.Point(267, 37);
            this.labelAmountPotion.Name = "labelAmountPotion";
            this.labelAmountPotion.Size = new System.Drawing.Size(54, 18);
            this.labelAmountPotion.TabIndex = 2;
            this.labelAmountPotion.Text = "x 0";
            this.labelAmountPotion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNameItem
            // 
            this.labelNameItem.AutoSize = true;
            this.labelNameItem.BackColor = System.Drawing.Color.Transparent;
            this.labelNameItem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameItem.ForeColor = System.Drawing.Color.Aquamarine;
            this.labelNameItem.Location = new System.Drawing.Point(78, 13);
            this.labelNameItem.Name = "labelNameItem";
            this.labelNameItem.Size = new System.Drawing.Size(138, 23);
            this.labelNameItem.TabIndex = 2;
            this.labelNameItem.Text = "Level Up Potion";
            // 
            // panelUseItem
            // 
            this.panelUseItem.BackColor = System.Drawing.Color.Transparent;
            this.panelUseItem.BackgroundImage = global::Monster_Battle_Sparkle.Properties.Resources.menuBackground;
            this.panelUseItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUseItem.Controls.Add(this.labelUse);
            this.panelUseItem.Location = new System.Drawing.Point(561, 33);
            this.panelUseItem.Name = "panelUseItem";
            this.panelUseItem.Size = new System.Drawing.Size(94, 40);
            this.panelUseItem.TabIndex = 3;
            // 
            // labelUse
            // 
            this.labelUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUse.Location = new System.Drawing.Point(15, 8);
            this.labelUse.Name = "labelUse";
            this.labelUse.Size = new System.Drawing.Size(65, 25);
            this.labelUse.TabIndex = 0;
            this.labelUse.Text = "USE";
            this.labelUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUse.Click += new System.EventHandler(this.labelUse_Click);
            this.labelUse.MouseLeave += new System.EventHandler(this.labelUse_MouseLeave);
            this.labelUse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelUse_MouseMove);
            // 
            // timerUseItem
            // 
            this.timerUseItem.Interval = 1;
            this.timerUseItem.Tick += new System.EventHandler(this.timerUseItem_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(67, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "ITEMS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Monster_Battle_Sparkle.Properties.Resources.pocketInfo;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(28, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 90);
            this.panel3.TabIndex = 8;
            // 
            // UserControlBag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monster_Battle_Sparkle.Properties.Resources.BackgroundBag;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Name = "UserControlBag";
            this.Size = new System.Drawing.Size(650, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelUseItem.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelAmountPotion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelUseItem;
        private System.Windows.Forms.Label labelUse;
        private System.Windows.Forms.Label labelNameItem;
        private System.Windows.Forms.Timer timerUseItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
    }
}
