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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            SnakeSelectionForm selectionForm = new SnakeSelectionForm("Easy");
            selectionForm.Show();
            this.Hide();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            SnakeSelectionForm selectionForm = new SnakeSelectionForm("Normal");
            selectionForm.Show();
            this.Hide();
        }

        private void btnDifficult_Click(object sender, EventArgs e)
        {
            SnakeSelectionForm selectionForm = new SnakeSelectionForm("Difficult");
            selectionForm.Show();
            this.Hide();
        }
    }
}
