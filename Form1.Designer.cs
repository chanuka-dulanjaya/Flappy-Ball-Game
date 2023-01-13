
namespace Flappy_Ball
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.downWall = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.upWall = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.extraLife = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraLife)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.life1);
            this.panel1.Controls.Add(this.life2);
            this.panel1.Controls.Add(this.life3);
            this.panel1.Location = new System.Drawing.Point(13, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 39);
            this.panel1.TabIndex = 4;
            // 
            // life1
            // 
            this.life1.Image = global::Flappy_Ball.Properties.Resources.life;
            this.life1.Location = new System.Drawing.Point(88, -1);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(40, 40);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1.TabIndex = 0;
            this.life1.TabStop = false;
            // 
            // life2
            // 
            this.life2.Image = global::Flappy_Ball.Properties.Resources.life;
            this.life2.Location = new System.Drawing.Point(48, -1);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(40, 40);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2.TabIndex = 0;
            this.life2.TabStop = false;
            // 
            // life3
            // 
            this.life3.Image = global::Flappy_Ball.Properties.Resources.life;
            this.life3.Location = new System.Drawing.Point(8, -1);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(40, 40);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3.TabIndex = 0;
            this.life3.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(450, 398);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 39);
            this.lblScore.TabIndex = 5;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTime
            // 
            this.gameTime.Enabled = true;
            this.gameTime.Interval = 20;
            this.gameTime.Tick += new System.EventHandler(this.gameTimeTickEvent);
            // 
            // downWall
            // 
            this.downWall.Image = global::Flappy_Ball.Properties.Resources.up_wall;
            this.downWall.Location = new System.Drawing.Point(360, 230);
            this.downWall.Name = "downWall";
            this.downWall.Size = new System.Drawing.Size(53, 159);
            this.downWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downWall.TabIndex = 3;
            this.downWall.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Ball.Properties.Resources.ground_12;
            this.ground.Location = new System.Drawing.Point(-1, 384);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(563, 129);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // upWall
            // 
            this.upWall.Image = global::Flappy_Ball.Properties.Resources.up_wall;
            this.upWall.Location = new System.Drawing.Point(406, -2);
            this.upWall.Name = "upWall";
            this.upWall.Size = new System.Drawing.Size(53, 129);
            this.upWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upWall.TabIndex = 1;
            this.upWall.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = global::Flappy_Ball.Properties.Resources.ball_1;
            this.ball.Location = new System.Drawing.Point(49, 135);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblGameOver.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Navy;
            this.lblGameOver.Location = new System.Drawing.Point(96, 118);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(383, 133);
            this.lblGameOver.TabIndex = 6;
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // extraLife
            // 
            this.extraLife.Image = global::Flappy_Ball.Properties.Resources.life;
            this.extraLife.Location = new System.Drawing.Point(497, 230);
            this.extraLife.Name = "extraLife";
            this.extraLife.Size = new System.Drawing.Size(40, 40);
            this.extraLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extraLife.TabIndex = 1;
            this.extraLife.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.extraLife);
            this.Controls.Add(this.upWall);
            this.Controls.Add(this.downWall);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ground);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "Flappy Ball";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUpEvent);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraLife)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox upWall;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox downWall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox extraLife;
    }
}

