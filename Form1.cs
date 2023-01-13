using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flappy_Ball
{
    public partial class Form1 : Form
    {
        int gravity = 8;
        int wallSpeed = 5;
        int gameScore = 0;
        int lifeCount = 3;
        int lifeFreeTime = 0;
        public Form1()
        { 
            InitializeComponent();
        }

        private void gameTimeTickEvent(object sender, EventArgs e)
        {

            ballFadingEffect();

            lblGameOver.Visible = false;

            lifeFreeTime += 20;

            ball.Top += gravity;
            downWall.Left -= wallSpeed;
            upWall.Left -= wallSpeed;

            extraLife.Left -= wallSpeed;

            if (upWall.Left < -150)
            {
                upWall.Left = 450;
                gameScore += 10;
            }
            if (downWall.Left < -80)
            {
                downWall.Left = 580;
                gameScore += 10;
            }
            

            if (ball.Bounds.IntersectsWith(upWall.Bounds) || ball.Bounds.IntersectsWith(downWall.Bounds) || ball.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            lblScore.Text = "" + gameScore;

            if (ball.Bounds.IntersectsWith(extraLife.Bounds) && lifeCount < 3)
            {
                extraLifeFunction();
            }

            if (extraLife.Left < 100)
            {
                extraLife.Left = 480;
            }
        }

        private void keyUpEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
        }

        private void keyDownEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }
        }

        private void endGame()
        {
            if(lifeCount == 0 && lifeFreeTime > 3000)
            {
                gameTime.Stop();
                lblGameOver.Text = "Game Over! \n Your Score is : " + gameScore;
                lblGameOver.Visible = true;
            }
            else
            {
                switch (lifeCount)
                {
                    case 3:
                        if(lifeFreeTime > 2500)
                        {
                            life1.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                        }
                        break;
                    case 2:
                        if(lifeFreeTime > 2500)
                        {
                            life2.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                        }
                        break;
                    case 1: 
                        if(lifeFreeTime > 2500)
                        {
                            life3.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                        }
                        break;
                }
                    

            }
        }

        private void ballFadingEffect()
        {
            if(ball.Visible == true && lifeFreeTime < 2500)
            {
                ball.Visible = false;
            }
            else if (ball.Visible == false && lifeFreeTime < 2500)
            {
                ball.Visible = true;
            }
            else
            {
                ball.Visible = true;
            }
        }

        private void extraLifeFunction()
        {
            lifeCount++;
            extraLife.Visible = false;
        }
    }
}
