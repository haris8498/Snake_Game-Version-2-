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
    public partial class SnakeSelectionForm : Form
    {

        private string difficulty;

        public SnakeSelectionForm(string selectedDifficulty)
        {
            InitializeComponent();
            difficulty = selectedDifficulty;
        }

        private void DrawSnake(Graphics g, Color snakeColor, int x, int y)
        {
            // Enable anti-aliasing for smooth graphics
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw snake body (3 segments)
            for (int i = 0; i < 3; i++)
            {
                int segmentY = y + (i * 45);

                // Shadow
                using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
                {
                    g.FillEllipse(shadowBrush, x + 3, segmentY + 3, 90, 90);
                }

                // Main body
                using (SolidBrush mainBrush = new SolidBrush(snakeColor))
                {
                    g.FillEllipse(mainBrush, x, segmentY, 90, 90);
                }

                // Highlight
                Color lightColor = Color.FromArgb(
                    Math.Min(snakeColor.R + 40, 255),
                    Math.Min(snakeColor.G + 40, 255),
                    Math.Min(snakeColor.B + 40, 255)
                );
                using (SolidBrush highlightBrush = new SolidBrush(lightColor))
                {
                    g.FillEllipse(highlightBrush, x + 10, segmentY + 10, 40, 40);
                }
            }

            // Draw head
            int headY = y - 45;

            // Shadow
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
            {
                g.FillEllipse(shadowBrush, x + 3, headY + 3, 90, 90);
            }

            // Head
            using (SolidBrush headBrush = new SolidBrush(snakeColor))
            {
                g.FillEllipse(headBrush, x, headY, 90, 90);
            }

            // Eyes
            using (SolidBrush eyeBrush = new SolidBrush(Color.White))
            {
                g.FillEllipse(eyeBrush, x + 20, headY + 25, 20, 25);
                g.FillEllipse(eyeBrush, x + 50, headY + 25, 20, 25);
            }

            using (SolidBrush pupilBrush = new SolidBrush(Color.Black))
            {
                g.FillEllipse(pupilBrush, x + 25, headY + 30, 10, 15);
                g.FillEllipse(pupilBrush, x + 55, headY + 30, 10, 15);
            }

            // Tongue
            using (Pen tonguePen = new Pen(Color.Red, 3))
            {
                g.DrawLine(tonguePen, x + 45, headY + 70, x + 45, headY + 95);
                g.DrawLine(tonguePen, x + 45, headY + 95, x + 40, headY + 100);
                g.DrawLine(tonguePen, x + 45, headY + 95, x + 50, headY + 100);
            }
        }


        private void SnakeSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void pnlHaris_Paint(object sender, PaintEventArgs e)
        {
            DrawSnake(e.Graphics, Color.FromArgb(100, 150, 255), 75, 80);
        }

        private void pnlMehak_Paint(object sender, PaintEventArgs e)
        {
            DrawSnake(e.Graphics, Color.FromArgb(255, 100, 180), 75, 80);
        }

        private void pnlRafay_Paint(object sender, PaintEventArgs e)
        {
            DrawSnake(e.Graphics, Color.FromArgb(255, 140, 50), 75, 80);
        }

        private void btnSelectHaris_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(difficulty, "Haris", Color.FromArgb(100, 150, 255));
            gameForm.Show();
            this.Hide();
        }

        private void btnSelectMehak_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(difficulty, "Mehak", Color.FromArgb(255, 100, 180));
            gameForm.Show();
            this.Hide();
        }

        private void btnSelectRafay_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(difficulty, "Rafay", Color.FromArgb(255, 140, 50));
            gameForm.Show();
            this.Hide();
        }
    }
}
