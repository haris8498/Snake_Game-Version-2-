namespace SuperSnakeGame
{
    partial class GameOverForm
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
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.pnlSnakeImage = new System.Windows.Forms.Panel();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Crimson;
            this.lblGameOver.Location = new System.Drawing.Point(175, 105);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(517, 80);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "GAME OVER!";
            this.lblGameOver.Click += new System.EventHandler(this.lblGameOver_Click);
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.ForeColor = System.Drawing.Color.White;
            this.lblFinalScore.Location = new System.Drawing.Point(225, 222);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(412, 50);
            this.lblFinalScore.TabIndex = 1;
            this.lblFinalScore.Text = "FINAL SCORE: 0";
            this.lblFinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSnakeImage
            // 
            this.pnlSnakeImage.BackColor = System.Drawing.Color.Transparent;
            this.pnlSnakeImage.Location = new System.Drawing.Point(50, 320);
            this.pnlSnakeImage.Name = "pnlSnakeImage";
            this.pnlSnakeImage.Size = new System.Drawing.Size(150, 200);
            this.pnlSnakeImage.TabIndex = 2;
            this.pnlSnakeImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSnakeImage_Paint);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPlayAgain.FlatAppearance.BorderSize = 0;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(223, 350);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(266, 80);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.Text = "PLAY AGAIN";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Crimson;
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(495, 350);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(266, 80);
            this.btnMainMenu.TabIndex = 4;
            this.btnMainMenu.Text = "MAIN MENU";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.pnlSnakeImage);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.lblGameOver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameOverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Snake Game - Game Over";
            this.Load += new System.EventHandler(this.GameOverForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Panel pnlSnakeImage;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnMainMenu;
    }
}