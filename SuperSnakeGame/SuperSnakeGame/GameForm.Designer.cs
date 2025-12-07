namespace SuperSnakeGame
{
    partial class GameForm
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
            this.lblScore = new System.Windows.Forms.Label();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(20, 10);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(178, 46);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGame.Location = new System.Drawing.Point(110, 50);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(600, 600);
            this.pnlGame.TabIndex = 1;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(798, 594);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.lblScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Snake Game - Playing";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Timer gameTimer;
    }
}