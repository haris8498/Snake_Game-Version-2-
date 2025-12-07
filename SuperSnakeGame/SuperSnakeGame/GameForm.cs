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
    public partial class GameForm : Form
    {
        private string difficulty;
        private string snakeName;
        private Color snakeColor;

        private List<Point> snake;
        private Point food;
        private List<Point> obstacles;
        private string direction;
        private int score;
        private int gridSize = 20;
        private Random random;

        public GameForm(string gameDifficulty, string selectedSnake, Color selectedColor)
        {
            InitializeComponent();

            difficulty = gameDifficulty;
            snakeName = selectedSnake;
            snakeColor = selectedColor;

            random = new Random();
            snake = new List<Point>();
            obstacles = new List<Point>();

            InitializeGame();

        }

        private void InitializeGame()
        {
            // Set up snake starting position (center of grid)
            snake.Clear();
            int centerX = (pnlGame.Width / gridSize) / 2;
            int centerY = (pnlGame.Height / gridSize) / 2;

            snake.Add(new Point(centerX, centerY));
            snake.Add(new Point(centerX - 1, centerY));
            snake.Add(new Point(centerX - 2, centerY));

            direction = "RIGHT";
            score = 0;
            lblScore.Text = "Score: 0";

            // Generate obstacles based on difficulty
            obstacles.Clear();
            if (difficulty == "Normal")
            {
                GenerateObstacles(5);
            }
            else if (difficulty == "Difficult")
            {
                GenerateWalls();
            }

            GenerateFood();

            gameTimer.Start();
        }

        private void GenerateFood()
        {
            int maxX = pnlGame.Width / gridSize;
            int maxY = pnlGame.Height / gridSize;

            do
            {
                food = new Point(random.Next(0, maxX), random.Next(0, maxY));
            }
            while (snake.Contains(food) || obstacles.Contains(food));
        }

        private void GenerateObstacles(int count)
        {
            int maxX = pnlGame.Width / gridSize;
            int maxY = pnlGame.Height / gridSize;

            for (int i = 0; i < count; i++)
            {
                Point obstacle;
                do
                {
                    obstacle = new Point(random.Next(2, maxX - 2), random.Next(2, maxY - 2));
                }
                while (snake.Contains(obstacle) || obstacles.Contains(obstacle) || food == obstacle);

                obstacles.Add(obstacle);
            }
        }
        private void GenerateWalls()
        {
            int maxX = pnlGame.Width / gridSize;
            int maxY = pnlGame.Height / gridSize;

            // Top and bottom walls
            for (int x = 0; x < maxX; x++)
            {
                obstacles.Add(new Point(x, 0));
                obstacles.Add(new Point(x, maxY - 1));
            }

            // Left and right walls
            for (int y = 0; y < maxY; y++)
            {
                obstacles.Add(new Point(0, y));
                obstacles.Add(new Point(maxX - 1, y));
            }
        }


        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && direction != "DOWN")
                direction = "UP";
            else if (e.KeyCode == Keys.Down && direction != "UP")
                direction = "DOWN";
            else if (e.KeyCode == Keys.Left && direction != "RIGHT")
                direction = "LEFT";
            else if (e.KeyCode == Keys.Right && direction != "LEFT")
                direction = "RIGHT";
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Move snake
            Point head = snake[0];
            Point newHead = head;

            switch (direction)
            {
                case "UP":
                    newHead = new Point(head.X, head.Y - 1);
                    break;
                case "DOWN":
                    newHead = new Point(head.X, head.Y + 1);
                    break;
                case "LEFT":
                    newHead = new Point(head.X - 1, head.Y);
                    break;
                case "RIGHT":
                    newHead = new Point(head.X + 1, head.Y);
                    break;
            }

            // Check collisions
            int maxX = pnlGame.Width / gridSize;
            int maxY = pnlGame.Height / gridSize;

            // Wall collision (only for Easy and Normal modes)
            if (difficulty != "Difficult")
            {
                if (newHead.X < 0 || newHead.X >= maxX || newHead.Y < 0 || newHead.Y >= maxY)
                {
                    GameOver();
                    return;
                }
            }
            else
            {
                // Wrap around for Difficult mode is disabled
                if (newHead.X < 0 || newHead.X >= maxX || newHead.Y < 0 || newHead.Y >= maxY)
                {
                    GameOver();
                    return;
                }
            }

            // Self collision
            if (snake.Contains(newHead))
            {
                GameOver();
                return;
            }

            // Obstacle collision
            if (obstacles.Contains(newHead))
            {
                GameOver();
                return;
            }

            // Add new head
            snake.Insert(0, newHead);

            // Check if food eaten
            if (newHead == food)
            {
                score += 5;
                lblScore.Text = "Score: " + score;
                GenerateFood();

                // Add more obstacles in Normal mode
                if (difficulty == "Normal" && score % 20 == 0)
                {
                    GenerateObstacles(1);
                }
            }
            else
            {
                // Remove tail if no food eaten
                snake.RemoveAt(snake.Count - 1);
            }

            // Redraw
            pnlGame.Invalidate();
        }

        private void Draw3DBlock(Graphics g, int x, int y, Color color, int size)
        {
            // Shadow
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
            {
                g.FillRectangle(shadowBrush, x + 2, y + 2, size - 2, size - 2);
            }

            // Main color
            using (SolidBrush mainBrush = new SolidBrush(color))
            {
                g.FillRectangle(mainBrush, x, y, size - 2, size - 2);
            }

            // Highlight
            Color lightColor = Color.FromArgb(
                Math.Min(color.R + 40, 255),
                Math.Min(color.G + 40, 255),
                Math.Min(color.B + 40, 255)
            );

            using (SolidBrush highlightBrush = new SolidBrush(lightColor))
            {
                g.FillRectangle(highlightBrush, x + 2, y + 2, size / 2, size / 2);
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();

            GameOverForm gameOverForm = new GameOverForm(score);
            gameOverForm.Show();
            this.Hide();
        }
        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw grid
            using (Pen gridPen = new Pen(Color.FromArgb(40, 120, 40)))
            {
                for (int x = 0; x <= pnlGame.Width; x += gridSize)
                {
                    g.DrawLine(gridPen, x, 0, x, pnlGame.Height);
                }
                for (int y = 0; y <= pnlGame.Height; y += gridSize)
                {
                    g.DrawLine(gridPen, 0, y, pnlGame.Width, y);
                }
            }

            // Draw obstacles
            foreach (Point obstacle in obstacles)
            {
                Draw3DBlock(g, obstacle.X * gridSize, obstacle.Y * gridSize, Color.Gray, gridSize);
            }

            // Draw food
            Draw3DBlock(g, food.X * gridSize, food.Y * gridSize, Color.Red, gridSize);

            // Draw snake
            for (int i = 0; i < snake.Count; i++)
            {
                Color segmentColor = snakeColor;
                if (i > 0)
                {
                    segmentColor = Color.FromArgb(
                        Math.Max(snakeColor.R - 20, 0),
                        Math.Max(snakeColor.G - 20, 0),
                        Math.Max(snakeColor.B - 20, 0)
                    );
                }

                Draw3DBlock(g, snake[i].X * gridSize, snake[i].Y * gridSize, segmentColor, gridSize);

                // Draw eyes on head
                if (i == 0)
                {
                    int eyeSize = gridSize / 6;
                    int eyeOffset = gridSize / 4;

                    using (SolidBrush eyeBrush = new SolidBrush(Color.White))
                    {
                        g.FillEllipse(eyeBrush,
                            snake[i].X * gridSize + eyeOffset,
                            snake[i].Y * gridSize + eyeOffset,
                            eyeSize, eyeSize);
                        g.FillEllipse(eyeBrush,
                            snake[i].X * gridSize + gridSize - eyeOffset - eyeSize,
                            snake[i].Y * gridSize + eyeOffset,
                            eyeSize, eyeSize);
                    }

                    using (SolidBrush pupilBrush = new SolidBrush(Color.Black))
                    {
                        int pupilSize = eyeSize / 2;
                        g.FillEllipse(pupilBrush,
                            snake[i].X * gridSize + eyeOffset + pupilSize / 2,
                            snake[i].Y * gridSize + eyeOffset + pupilSize / 2,
                            pupilSize, pupilSize);
                        g.FillEllipse(pupilBrush,
                            snake[i].X * gridSize + gridSize - eyeOffset - eyeSize + pupilSize / 2,
                            snake[i].Y * gridSize + eyeOffset + pupilSize / 2,
                            pupilSize, pupilSize);
                    }
                }
            }
        }
    }
}
