using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GameOver : UserControl
    {
        public GameOver()
        {
            InitializeComponent();

            newHighScoreLabel.Visible = false;
            scoreLabel.Text += " " + Form1.score;

            if (Form1.score > Form1.highScore)
            {
                Form1.highScore = Form1.score;
                newHighScoreLabel.Visible = true;
            }

            Form1.score = 0;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            this.Dispose();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            TitleScreen ts = new TitleScreen();
            f.Controls.Add(ts);
            this.Dispose();
        }
    }
}
