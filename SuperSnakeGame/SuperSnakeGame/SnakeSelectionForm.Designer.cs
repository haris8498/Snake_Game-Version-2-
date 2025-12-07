namespace SuperSnakeGame
{
    partial class SnakeSelectionForm
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
            this.lblChooseSnake = new System.Windows.Forms.Label();
            this.pnlHaris = new System.Windows.Forms.Panel();
            this.lblHaris = new System.Windows.Forms.Label();
            this.btnSelectHaris = new System.Windows.Forms.Button();
            this.pnlMehak = new System.Windows.Forms.Panel();
            this.btnSelectMehak = new System.Windows.Forms.Button();
            this.lblMehak = new System.Windows.Forms.Label();
            this.pnlRafay = new System.Windows.Forms.Panel();
            this.btnSelectRafay = new System.Windows.Forms.Button();
            this.lblRafay = new System.Windows.Forms.Label();
            this.pnlHaris.SuspendLayout();
            this.pnlMehak.SuspendLayout();
            this.pnlRafay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChooseSnake
            // 
            this.lblChooseSnake.AutoSize = true;
            this.lblChooseSnake.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseSnake.ForeColor = System.Drawing.Color.White;
            this.lblChooseSnake.Location = new System.Drawing.Point(102, 46);
            this.lblChooseSnake.Name = "lblChooseSnake";
            this.lblChooseSnake.Size = new System.Drawing.Size(682, 64);
            this.lblChooseSnake.TabIndex = 0;
            this.lblChooseSnake.Text = "CHOOSE YOUR SNAKE!";
            // 
            // pnlHaris
            // 
            this.pnlHaris.BackColor = System.Drawing.Color.Honeydew;
            this.pnlHaris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHaris.Controls.Add(this.btnSelectHaris);
            this.pnlHaris.Controls.Add(this.lblHaris);
            this.pnlHaris.Location = new System.Drawing.Point(50, 120);
            this.pnlHaris.Name = "pnlHaris";
            this.pnlHaris.Size = new System.Drawing.Size(250, 400);
            this.pnlHaris.TabIndex = 1;
            this.pnlHaris.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHaris_Paint);
            // 
            // lblHaris
            // 
            this.lblHaris.AutoSize = true;
            this.lblHaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaris.Location = new System.Drawing.Point(22, 23);
            this.lblHaris.Name = "lblHaris";
            this.lblHaris.Size = new System.Drawing.Size(202, 64);
            this.lblHaris.TabIndex = 0;
            this.lblHaris.Text = "HARIS";
            // 
            // btnSelectHaris
            // 
            this.btnSelectHaris.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSelectHaris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectHaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectHaris.ForeColor = System.Drawing.Color.White;
            this.btnSelectHaris.Location = new System.Drawing.Point(25, 320);
            this.btnSelectHaris.Name = "btnSelectHaris";
            this.btnSelectHaris.Size = new System.Drawing.Size(200, 60);
            this.btnSelectHaris.TabIndex = 1;
            this.btnSelectHaris.Text = "SELECT HARIS";
            this.btnSelectHaris.UseVisualStyleBackColor = false;
            this.btnSelectHaris.Click += new System.EventHandler(this.btnSelectHaris_Click);
            // 
            // pnlMehak
            // 
            this.pnlMehak.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlMehak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMehak.Controls.Add(this.btnSelectMehak);
            this.pnlMehak.Controls.Add(this.lblMehak);
            this.pnlMehak.Location = new System.Drawing.Point(375, 120);
            this.pnlMehak.Name = "pnlMehak";
            this.pnlMehak.Size = new System.Drawing.Size(250, 400);
            this.pnlMehak.TabIndex = 2;
            this.pnlMehak.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMehak_Paint);
            // 
            // btnSelectMehak
            // 
            this.btnSelectMehak.BackColor = System.Drawing.Color.HotPink;
            this.btnSelectMehak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectMehak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectMehak.ForeColor = System.Drawing.Color.White;
            this.btnSelectMehak.Location = new System.Drawing.Point(25, 320);
            this.btnSelectMehak.Name = "btnSelectMehak";
            this.btnSelectMehak.Size = new System.Drawing.Size(200, 60);
            this.btnSelectMehak.TabIndex = 1;
            this.btnSelectMehak.Text = "SELECT MEHAK";
            this.btnSelectMehak.UseVisualStyleBackColor = false;
            this.btnSelectMehak.Click += new System.EventHandler(this.btnSelectMehak_Click);
            // 
            // lblMehak
            // 
            this.lblMehak.AutoSize = true;
            this.lblMehak.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMehak.Location = new System.Drawing.Point(14, 23);
            this.lblMehak.Name = "lblMehak";
            this.lblMehak.Size = new System.Drawing.Size(230, 64);
            this.lblMehak.TabIndex = 0;
            this.lblMehak.Text = "MEHAK";
            // 
            // pnlRafay
            // 
            this.pnlRafay.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlRafay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRafay.Controls.Add(this.btnSelectRafay);
            this.pnlRafay.Controls.Add(this.lblRafay);
            this.pnlRafay.Location = new System.Drawing.Point(700, 120);
            this.pnlRafay.Name = "pnlRafay";
            this.pnlRafay.Size = new System.Drawing.Size(250, 400);
            this.pnlRafay.TabIndex = 3;
            this.pnlRafay.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRafay_Paint);
            // 
            // btnSelectRafay
            // 
            this.btnSelectRafay.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSelectRafay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectRafay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectRafay.ForeColor = System.Drawing.Color.White;
            this.btnSelectRafay.Location = new System.Drawing.Point(25, 320);
            this.btnSelectRafay.Name = "btnSelectRafay";
            this.btnSelectRafay.Size = new System.Drawing.Size(200, 60);
            this.btnSelectRafay.TabIndex = 1;
            this.btnSelectRafay.Text = "SELECT RAFAY";
            this.btnSelectRafay.UseVisualStyleBackColor = false;
            this.btnSelectRafay.Click += new System.EventHandler(this.btnSelectRafay_Click);
            // 
            // lblRafay
            // 
            this.lblRafay.AutoSize = true;
            this.lblRafay.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRafay.Location = new System.Drawing.Point(14, 23);
            this.lblRafay.Name = "lblRafay";
            this.lblRafay.Size = new System.Drawing.Size(217, 64);
            this.lblRafay.TabIndex = 0;
            this.lblRafay.Text = "RAFAY";
            // 
            // SnakeSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.pnlRafay);
            this.Controls.Add(this.pnlMehak);
            this.Controls.Add(this.pnlHaris);
            this.Controls.Add(this.lblChooseSnake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SnakeSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Snake Game - Select Snake";
            this.Load += new System.EventHandler(this.SnakeSelectionForm_Load);
            this.pnlHaris.ResumeLayout(false);
            this.pnlHaris.PerformLayout();
            this.pnlMehak.ResumeLayout(false);
            this.pnlMehak.PerformLayout();
            this.pnlRafay.ResumeLayout(false);
            this.pnlRafay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseSnake;
        private System.Windows.Forms.Panel pnlHaris;
        private System.Windows.Forms.Button btnSelectHaris;
        private System.Windows.Forms.Label lblHaris;
        private System.Windows.Forms.Panel pnlMehak;
        private System.Windows.Forms.Button btnSelectMehak;
        private System.Windows.Forms.Label lblMehak;
        private System.Windows.Forms.Panel pnlRafay;
        private System.Windows.Forms.Button btnSelectRafay;
        private System.Windows.Forms.Label lblRafay;
    }
}