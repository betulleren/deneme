namespace deneme3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {


            components = new System.ComponentModel.Container();
            player = new PictureBox();
            bullet = new PictureBox();
            basicmermi = new PictureBox();
            basicdusman = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            fastdusman = new PictureBox();
            fastmermi = new PictureBox();
            lbl_over = new Label();
            bossEnemy = new PictureBox();
            strongEnemy = new PictureBox();
            strongmermi = new PictureBox();
            bossmermi = new PictureBox();
            lbl_score = new Label();
            lbl_playerHealth = new Label();
            rock = new PictureBox();
            diamond = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)basicmermi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)basicdusman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fastdusman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fastmermi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bossEnemy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)strongEnemy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)strongmermi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bossmermi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diamond).BeginInit();
            SuspendLayout(); 
            // 
            // player
            // 
            player.Image = Properties.Resources.uzayarac;
            player.Location = new Point(12, 235);
            player.Name = "player";
            player.Size = new Size(100, 73);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // bullet
            // 
            bullet.Image = Properties.Resources.deneme;
            bullet.Location = new Point(102, 250);
            bullet.Name = "bullet";
            bullet.Size = new Size(54, 45);
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.TabIndex = 1;
            bullet.TabStop = false;
            bullet.Tag = "bullet";
            // 
            // basicmermi
            // 
            basicmermi.Image = Properties.Resources.bulletthree;
            basicmermi.Location = new Point(661, 60);
            basicmermi.Name = "basicmermi";
            basicmermi.Size = new Size(67, 49);
            basicmermi.SizeMode = PictureBoxSizeMode.Zoom;
            basicmermi.TabIndex = 2;
            basicmermi.TabStop = false;
            basicmermi.Tag = "dusmanmermi";
            // 
            // basicdusman
            // 
            basicdusman.Image = Properties.Resources.basicdusman;
            basicdusman.Location = new Point(706, 57);
            basicdusman.Name = "basicdusman";
            basicdusman.Size = new Size(100, 52);
            basicdusman.SizeMode = PictureBoxSizeMode.Zoom;
            basicdusman.TabIndex = 3;
            basicdusman.TabStop = false;
            basicdusman.Tag = "enemy";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.star;
            pictureBox5.Location = new Point(470, 81);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(11, 18);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "star";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.star;
            pictureBox6.Location = new Point(387, 211);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(26, 28);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "star";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.star;
            pictureBox7.Location = new Point(156, 144);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(16, 20);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "star";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.star;
            pictureBox8.Location = new Point(283, 332);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(11, 19);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "star";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.star;
            pictureBox9.Location = new Point(645, 276);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(26, 19);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 8;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "star";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.star;
            pictureBox10.Location = new Point(734, 387);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(17, 21);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 9;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "star";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // fastdusman
            // 
            fastdusman.Image = Properties.Resources.fastEnemy;
            fastdusman.Location = new Point(706, 161);
            fastdusman.Name = "fastdusman";
            fastdusman.Size = new Size(88, 45);
            fastdusman.SizeMode = PictureBoxSizeMode.Zoom;
            fastdusman.TabIndex = 10;
            fastdusman.TabStop = false;
            fastdusman.Tag = "enemy";
            // 
            // fastmermi
            // 
            fastmermi.Image = Properties.Resources.bulletthree;
            fastmermi.Location = new Point(664, 161);
            fastmermi.Name = "fastmermi";
            fastmermi.Size = new Size(67, 44);
            fastmermi.SizeMode = PictureBoxSizeMode.Zoom;
            fastmermi.TabIndex = 11;
            fastmermi.TabStop = false;
            fastmermi.Tag = "dusmanmermi";
            // 
            // lbl_over
            // 
            lbl_over.AutoSize = true;
            lbl_over.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_over.ForeColor = Color.Yellow;
            lbl_over.Location = new Point(323, 211);
            lbl_over.Name = "lbl_over";
            lbl_over.Size = new Size(143, 31);
            lbl_over.TabIndex = 12;
            lbl_over.Text = "GAME OVER";
            // 
            // bossEnemy
            // 
            bossEnemy.Image = Properties.Resources.bossEnemy;
            bossEnemy.Location = new Point(723, 275);
            bossEnemy.Name = "bossEnemy";
            bossEnemy.Size = new Size(71, 48);
            bossEnemy.SizeMode = PictureBoxSizeMode.Zoom;
            bossEnemy.TabIndex = 13;
            bossEnemy.TabStop = false;
            bossEnemy.Tag = "enemy";
            // 
            // strongEnemy
            // 
            strongEnemy.Image = Properties.Resources.strongEnemy;
            strongEnemy.Location = new Point(702, 370);
            strongEnemy.Name = "strongEnemy";
            strongEnemy.Size = new Size(104, 50);
            strongEnemy.SizeMode = PictureBoxSizeMode.Zoom;
            strongEnemy.TabIndex = 14;
            strongEnemy.TabStop = false;
            strongEnemy.Tag = "enemy";
            // 
            // strongmermi
            // 
            strongmermi.Image = Properties.Resources.bulletthree;
            strongmermi.Location = new Point(672, 370);
            strongmermi.Name = "strongmermi";
            strongmermi.Size = new Size(56, 50);
            strongmermi.SizeMode = PictureBoxSizeMode.Zoom;
            strongmermi.TabIndex = 15;
            strongmermi.TabStop = false;
            strongmermi.Tag = "dusmanmermi";
            // 
            // bossmermi
            // 
            bossmermi.Image = Properties.Resources.bulletthree;
            bossmermi.Location = new Point(672, 276);
            bossmermi.Name = "bossmermi";
            bossmermi.Size = new Size(56, 48);
            bossmermi.SizeMode = PictureBoxSizeMode.Zoom;
            bossmermi.TabIndex = 16;
            bossmermi.TabStop = false;
            bossmermi.Tag = "dusmanmermi";
            // 
            // lbl_score
            // 
            lbl_score.AutoSize = true;
            lbl_score.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_score.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_score.Location = new Point(12, 9);
            lbl_score.Name = "lbl_score";
            lbl_score.Size = new Size(59, 25);
            lbl_score.TabIndex = 17;
            lbl_score.Text = "Score:";
            // 
            // lbl_playerHealth
            // 
            lbl_playerHealth.AutoSize = true;
            lbl_playerHealth.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_playerHealth.ForeColor = Color.Green;
            lbl_playerHealth.Location = new Point(225, 9);
            lbl_playerHealth.Name = "lbl_playerHealth";
            lbl_playerHealth.Size = new Size(69, 25);
            lbl_playerHealth.TabIndex = 18;
            lbl_playerHealth.Text = "Health:";
            // 
            // rock
            // 
            rock.Image = Properties.Resources.rockk;
            rock.Location = new Point(395, 115);
            rock.Name = "rock";
            rock.Size = new Size(71, 60);
            rock.SizeMode = PictureBoxSizeMode.Zoom;
            rock.TabIndex = 19;
            rock.TabStop = false;
            rock.Tag = "engel";
            // 
            // diamond
            // 
            diamond.Image = Properties.Resources.diamond;
            diamond.Location = new Point(444, 332);
            diamond.Name = "diamond";
            diamond.Size = new Size(45, 34);
            diamond.SizeMode = PictureBoxSizeMode.Zoom;
            diamond.TabIndex = 20;
            diamond.TabStop = false;
            diamond.Tag = "diamond";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(diamond);
            Controls.Add(rock);
            Controls.Add(strongmermi);
            Controls.Add(basicmermi);
            Controls.Add(lbl_playerHealth);
            Controls.Add(lbl_score);
            Controls.Add(bossmermi);
            Controls.Add(strongEnemy);
            Controls.Add(bossEnemy);
            Controls.Add(lbl_over);
            Controls.Add(fastmermi);
            Controls.Add(fastdusman);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox6);
            Controls.Add(basicdusman);
            Controls.Add(player);
            Controls.Add(pictureBox9);
            Controls.Add(bullet);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet).EndInit();
            ((System.ComponentModel.ISupportInitialize)basicmermi).EndInit();
            ((System.ComponentModel.ISupportInitialize)basicdusman).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)fastdusman).EndInit();
            ((System.ComponentModel.ISupportInitialize)fastmermi).EndInit();
            ((System.ComponentModel.ISupportInitialize)bossEnemy).EndInit();
            ((System.ComponentModel.ISupportInitialize)strongEnemy).EndInit();
            ((System.ComponentModel.ISupportInitialize)strongmermi).EndInit();
            ((System.ComponentModel.ISupportInitialize)bossmermi).EndInit();
            ((System.ComponentModel.ISupportInitialize)rock).EndInit();
            ((System.ComponentModel.ISupportInitialize)diamond).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private PictureBox bullet;
        private PictureBox basicmermi;
        private PictureBox basicdusman;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private System.Windows.Forms.Timer timer1;
        private PictureBox fastdusman;
        private PictureBox fastmermi;
        private Label lbl_over;
        private PictureBox bossEnemy;
        private PictureBox strongEnemy;
        private PictureBox strongmermi;
        private PictureBox bossmermi;
        private Label lbl_score;
        private Label lbl_playerHealth;
        private PictureBox rock;
        private PictureBox diamond;
    }
}
