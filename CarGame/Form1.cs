using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CarGame
{
  
    public partial class Form1 : Form
    {

       

        public Form1()
        {
            InitializeComponent();
            SoundPlayer simpleSound = new SoundPlayer(@"CAR.wav");
            simpleSound.Play();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }
        enum Dir { left,Right ,None}
        int speed = 5;
        int score = 0;
        Random r = new Random();
        Dir dir = Dir.None;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        
            l1.Top += speed;
            l2.Top += speed;
            l3.Top += speed;
            l4.Top += speed;
            l5.Top += speed;
            l6.Top += speed;
            if (l1.Top > panelGame.Height) l1.Top = -l1.Height;
            if (l2.Top > panelGame.Height) l2.Top = -l2.Height;
            if (l3.Top > panelGame.Height) l3.Top = -l3.Height;
            if (l4.Top > panelGame.Height) l4.Top = -l4.Height;
            if (l5.Top > panelGame.Height) l5.Top = -l5.Height;
            if (l6.Top > panelGame.Height) l6.Top = -l6.Height;
            if (car1.Visible)
                car1.Top += speed;
            if (car1.Top > panelGame.Height)
            {
                car1.Visible = false;
                car1.Top = -car1.Height;
                car1.Left = r.Next((panelGame.Width - car1.Width) / 2);
                int car = r.Next(1, 6);
                if (car == 1) car1.Image = Properties.Resources.car1;
                else if (car == 2) car1.Image = Properties.Resources.car2;
                else if (car == 3) car1.Image = Properties.Resources.car3;
                else if (car == 4) car1.Image = Properties.Resources.car4;
                else  car1.Image = Properties.Resources.car5;


                car1.Visible = true;
            }
            if (car2.Visible)
                car2.Top += speed;
            if (car2.Top > panelGame.Height)
            {
                car2.Visible = false;
                car2.Top = -car2.Height;
                car2.Left = r.Next(panelGame.Width / 2, panelGame.Width - car2.Width);
                int car = r.Next(1, 6);
                if (car == 1) car2.Image = Properties.Resources.car2;
                else if (car == 2) car2.Image = Properties.Resources.car5;
                else if (car == 3) car2.Image = Properties.Resources.car4;
                else if (car == 4) car2.Image = Properties.Resources.car3;
                else car2.Image = Properties.Resources.car1;

                car2.Visible = true;
            }
            if (player.Bounds.IntersectsWith(car1.Bounds) || player.Bounds.IntersectsWith(car2.Bounds))
            {
                timerAction.Enabled = false;
                start.Visible = true;
                gameover.Visible = true;
                SoundPlayer simpleSound = new SoundPlayer(@"CAR.wav");
                simpleSound.Stop();

            }
            score++;

            if (score > 500) speed = 6;

            if (score > 1000) speed = 7;
            if (score > 2000) speed = 8;
            if (score > 3000) speed = 10;
            lblscore.Text = "Score: " + score;

            if (dir == Dir.left &&player.Left>0)
                player.Left -= speed;

            if (dir == Dir.Right&&player.Left <panelGame.Width-player.Width)
                player.Left += speed;       


        }

     
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
                dir = Dir.left;
            else if (e.KeyData == Keys.Right)
                dir = Dir.Right;
            else
                dir = Dir.None;


            if(gameover.Visible)
                if(e.KeyData==Keys.Space)
                {
                    gameover.Visible = false;
                    start.Visible=false;
                    player.Left = panelGame.Width / 2;
                    car1.Left = 0;
                    car2.Left = panelGame.Width-car2.Width;
                    speed = 5;
                    score = 0;
                    timerAction.Enabled = true;
                    SoundPlayer simpleSound = new SoundPlayer(@"CAR.wav");
                    simpleSound.Play();

                }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            dir = Dir.None;
        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void car1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_AutoSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
