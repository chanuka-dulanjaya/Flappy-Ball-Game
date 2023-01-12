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
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimeTickEvent(object sender, EventArgs e)
        {
            ball.Top += gravity;
            downWall.Left -= wallSpeed;
            upWall.Left -= wallSpeed;
        }
    }
}
