namespace CarGame
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelGame = new System.Windows.Forms.Panel();
            this.start = new System.Windows.Forms.Label();
            this.gameover = new System.Windows.Forms.Label();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.l5 = new System.Windows.Forms.PictureBox();
            this.l6 = new System.Windows.Forms.PictureBox();
            this.l4 = new System.Windows.Forms.PictureBox();
            this.l2 = new System.Windows.Forms.PictureBox();
            this.l3 = new System.Windows.Forms.PictureBox();
            this.l1 = new System.Windows.Forms.PictureBox();
            this.lblscore = new System.Windows.Forms.Label();
            this.timerAction = new System.Windows.Forms.Timer(this.components);
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelGame.Controls.Add(this.start);
            this.panelGame.Controls.Add(this.gameover);
            this.panelGame.Controls.Add(this.car2);
            this.panelGame.Controls.Add(this.car1);
            this.panelGame.Controls.Add(this.player);
            this.panelGame.Controls.Add(this.l5);
            this.panelGame.Controls.Add(this.l6);
            this.panelGame.Controls.Add(this.l4);
            this.panelGame.Controls.Add(this.l2);
            this.panelGame.Controls.Add(this.l3);
            this.panelGame.Controls.Add(this.l1);
            this.panelGame.Location = new System.Drawing.Point(12, 60);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(588, 494);
            this.panelGame.TabIndex = 0;
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // start
            // 
            this.start.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.start.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.start.Location = new System.Drawing.Point(203, 350);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(205, 22);
            this.start.TabIndex = 11;
            this.start.Text = "Press Space to Restart";
            this.start.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.start.Visible = false;
            // 
            // gameover
            // 
            this.gameover.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameover.Image = ((System.Drawing.Image)(resources.GetObject("gameover.Image")));
            this.gameover.Location = new System.Drawing.Point(175, 234);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(258, 141);
            this.gameover.TabIndex = 10;
            this.gameover.Text = "Game Over\r\n";
            this.gameover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gameover.Visible = false;
            // 
            // car2
            // 
            this.car2.BackColor = System.Drawing.Color.Transparent;
            this.car2.Image = global::CarGame.Properties.Resources.car1;
            this.car2.Location = new System.Drawing.Point(439, 234);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(46, 99);
            this.car2.TabIndex = 8;
            this.car2.TabStop = false;
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.Image = global::CarGame.Properties.Resources.car0;
            this.car1.Location = new System.Drawing.Point(146, 133);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(46, 99);
            this.car1.TabIndex = 7;
            this.car1.TabStop = false;
            this.car1.Click += new System.EventHandler(this.car1_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player.Image = global::CarGame.Properties.Resources.car5;
            this.player.Location = new System.Drawing.Point(287, 357);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(46, 99);
            this.player.TabIndex = 6;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // l5
            // 
            this.l5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.l5.Location = new System.Drawing.Point(466, 22);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(20, 190);
            this.l5.TabIndex = 5;
            this.l5.TabStop = false;
            // 
            // l6
            // 
            this.l6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.l6.Location = new System.Drawing.Point(466, 282);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(20, 190);
            this.l6.TabIndex = 4;
            this.l6.TabStop = false;
            // 
            // l4
            // 
            this.l4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.l4.Location = new System.Drawing.Point(295, 282);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(20, 190);
            this.l4.TabIndex = 3;
            this.l4.TabStop = false;
            // 
            // l2
            // 
            this.l2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.l2.Location = new System.Drawing.Point(120, 282);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(20, 190);
            this.l2.TabIndex = 2;
            this.l2.TabStop = false;
            // 
            // l3
            // 
            this.l3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.l3.Location = new System.Drawing.Point(295, 22);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(20, 190);
            this.l3.TabIndex = 1;
            this.l3.TabStop = false;
            // 
            // l1
            // 
            this.l1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.l1.Location = new System.Drawing.Point(120, 22);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(20, 190);
            this.l1.TabIndex = 0;
            this.l1.TabStop = false;
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Lucida Sans", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(240, 21);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(105, 23);
            this.lblscore.TabIndex = 1;
            this.lblscore.Text = "Score : 0";
            // 
            // timerAction
            // 
            this.timerAction.Enabled = true;
            this.timerAction.Interval = 1;
            this.timerAction.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(612, 566);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.panelGame);
            this.Name = "Form1";
            this.Text = "CAR Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panelGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.PictureBox l5;
        private System.Windows.Forms.PictureBox l4;
        private System.Windows.Forms.PictureBox l2;
        private System.Windows.Forms.PictureBox l3;
        private System.Windows.Forms.PictureBox l1;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.PictureBox l6;
        private System.Windows.Forms.Timer timerAction;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Label start;
    }
}

