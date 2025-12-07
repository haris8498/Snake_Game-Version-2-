namespace SuperSnakeGame
{
    partial class MainMenuForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnDifficult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(84, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(657, 143);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SUPER SNAKE GAME!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEasy.FlatAppearance.BorderSize = 0;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(200, 180);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(400, 80);
            this.btnEasy.TabIndex = 1;
            this.btnEasy.Text = "EASY (No Walls!)";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.Goldenrod;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.ForeColor = System.Drawing.Color.Black;
            this.btnNormal.Location = new System.Drawing.Point(200, 280);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(400, 80);
            this.btnNormal.TabIndex = 2;
            this.btnNormal.Text = "NORMAL ( Rocks!)";
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnDifficult
            // 
            this.btnDifficult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDifficult.FlatAppearance.BorderSize = 0;
            this.btnDifficult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDifficult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDifficult.Location = new System.Drawing.Point(200, 380);
            this.btnDifficult.Name = "btnDifficult";
            this.btnDifficult.Size = new System.Drawing.Size(400, 80);
            this.btnDifficult.TabIndex = 3;
            this.btnDifficult.Text = "DIFFICULT (Cage!)";
            this.btnDifficult.UseVisualStyleBackColor = false;
            this.btnDifficult.Click += new System.EventHandler(this.btnDifficult_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnDifficult);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Snake Game - Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnDifficult;
    }
}

