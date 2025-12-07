using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSnakeGame
{
    public partial class GameOverForm : Form
    {
        private int finalScore;

        public GameOverForm(int score)
        {
            InitializeComponent();
            finalScore = score;
            lblFinalScore.Text = "FINAL SCORE: " + score;

            // Check if player won
            if (score >= 100)
            {
                lblGameOver.Text = "YOU WIN!";
                lblGameOver.ForeColor = Color.FromArgb(255, 200, 50);
                this.BackColor = Color.FromArgb(100, 180, 255);
                btnPlayAgain.BackColor = Color.FromArgb(100, 200, 255);
                btnMainMenu.BackColor = Color.FromArgb(100, 150, 255);
            }
        }

        private void GameOverForm_Load(object sender, EventArgs e)
        {

        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {

        }

        private void pnlSnakeImage_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Color snakeColor = Color.FromArgb(100, 150, 255);

            if (finalScore >= 100)
            {
                // Draw happy snake with crown
                DrawHappySnake(g, snakeColor);
            }
            else
            {
                // Draw sad snake with bandage
                DrawSadSnake(g, snakeColor);
            }
        }

        private void DrawSadSnake(Graphics g, Color snakeColor)
        {
            // Body segments
            for (int i = 0; i < 2; i++)
            {
                int segmentY = 80 + (i * 40);

                // Shadow
                using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
                {
                    g.FillEllipse(shadowBrush, 33, segmentY + 3, 80, 80);
                }

                // Body
                using (SolidBrush bodyBrush = new SolidBrush(snakeColor))
                {
                    g.FillEllipse(bodyBrush, 30, segmentY, 80, 80);
                }
            }

            // Head
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
            {
                g.FillEllipse(shadowBrush, 33, 23, 80, 80);
            }

            using (SolidBrush headBrush = new SolidBrush(snakeColor))
            {
                g.FillEllipse(headBrush, 30, 20, 80, 80);
            }

            // Sad eyes (X shape)
            using (Pen eyePen = new Pen(Color.Black, 3))
            {
                g.DrawLine(eyePen, 45, 40, 55, 50);
                g.DrawLine(eyePen, 55, 40, 45, 50);
                g.DrawLine(eyePen, 75, 40, 85, 50);
                g.DrawLine(eyePen, 85, 40, 75, 50);
            }

            // Sad mouth
            using (Pen mouthPen = new Pen(Color.Black, 3))
            {
                g.DrawArc(mouthPen, 45, 50, 40, 30, 180, 180);
            }

            // Bandage
            using (SolidBrush bandageBrush = new SolidBrush(Color.Beige))
            {
                g.FillRectangle(bandageBrush, 20, 45, 90, 15);
            }

            using (Pen bandagePen = new Pen(Color.SaddleBrown, 2))
            {
                g.DrawRectangle(bandagePen, 20, 45, 90, 15);
                g.DrawLine(bandagePen, 45, 45, 45, 60);
                g.DrawLine(bandagePen, 70, 45, 70, 60);
                g.DrawLine(bandagePen, 95, 45, 95, 60);
            }
        }

        private void DrawHappySnake(Graphics g, Color snakeColor)
        {
            // Body segments
            for (int i = 0; i < 2; i++)
            {
                int segmentY = 80 + (i * 40);

                using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
                {
                    g.FillEllipse(shadowBrush, 33, segmentY + 3, 80, 80);
                }

                using (SolidBrush bodyBrush = new SolidBrush(snakeColor))
                {
                    g.FillEllipse(bodyBrush, 30, segmentY, 80, 80);
                }
            }

            // Head
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
            {
                g.FillEllipse(shadowBrush, 33, 43, 80, 80);
            }

            using (SolidBrush headBrush = new SolidBrush(snakeColor))
            {
                g.FillEllipse(headBrush, 30, 40, 80, 80);
            }

            // Happy eyes
            using (SolidBrush eyeBrush = new SolidBrush(Color.White))
            {
                g.FillEllipse(eyeBrush, 45, 55, 15, 20);
                g.FillEllipse(eyeBrush, 75, 55, 15, 20);
            }

            using (SolidBrush pupilBrush = new SolidBrush(Color.Black))
            {
                g.FillEllipse(pupilBrush, 50, 60, 8, 12);
                g.FillEllipse(pupilBrush, 80, 60, 8, 12);
            }

            // Happy smile
            using (Pen smilePen = new Pen(Color.Black, 3))
            {
                g.DrawArc(smilePen, 45, 65, 40, 25, 0, -180);
            }

            // Crown
            using (SolidBrush crownBrush = new SolidBrush(Color.Gold))
            {
                Point[] crownPoints = new Point[]
                {
            new Point(40, 35),
            new Point(50, 20),
            new Point(60, 30),
            new Point(70, 15),
            new Point(80, 30),
            new Point(90, 20),
            new Point(100, 35)
                };
                g.FillPolygon(crownBrush, crownPoints);
            }

            using (Pen crownPen = new Pen(Color.DarkGoldenrod, 2))
            {
                Point[] crownPoints = new Point[]
                {
            new Point(40, 35),
            new Point(50, 20),
            new Point(60, 30),
            new Point(70, 15),
            new Point(80, 30),
            new Point(90, 20),
            new Point(100, 35)
                };
                g.DrawPolygon(crownPen, crownPoints);
            }

            // Crown jewels
            using (SolidBrush jewelBrush = new SolidBrush(Color.Red))
            {
                g.FillEllipse(jewelBrush, 48, 22, 6, 6);
                g.FillEllipse(jewelBrush, 68, 17, 6, 6);
                g.FillEllipse(jewelBrush, 88, 22, 6, 6);
            }

            // Confetti around snake
            Random rand = new Random(42); // Fixed seed for consistent confetti
            for (int i = 0; i < 15; i++)
            {
                Color[] colors = { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Purple };
                using (SolidBrush confettiBrush = new SolidBrush(colors[i % colors.Length]))
                {
                    int x = rand.Next(10, 130);
                    int y = rand.Next(10, 180);
                    g.FillRectangle(confettiBrush, x, y, 4, 8);
                }
            }
        }
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Close();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Close();
        }
    }
}
