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
    public partial class GameScreen : UserControl
    {
        public static bool spaceDown;
        const int Thick = 100;
        Player p;
        Boulder b;

        Brush playerBrush = new SolidBrush(Color.IndianRed);
        Brush wallBrush = new SolidBrush(Color.Tan);
        Brush rockBrush = new SolidBrush(Color.Gray);
        Brush scoreBrush = new SolidBrush(Color.Black);
        Font scoreFont = new Font("Mongolian Baiti", 12);

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = true;
                    break;
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = false;
                    break;
            }
        }

        public void OnStart()
        {
            p = new Player(this.Width/2 - 20, 200, 20, 5, 25);
            b = new Boulder(this.Width / 2 - Thick / 2, 50, Thick);
            gameTimer.Enabled = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            p.Move();
            Form1.score++;
            Refresh();

            if (p.Collision(b))
            {
                gameTimer.Enabled = false;

                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameOver go = new GameOver();
                f.Controls.Add(go);
                return;
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //Draw Boulder
            e.Graphics.FillEllipse(rockBrush, b.x, b.y, b.size, b.size);
            //Draw sides
            e.Graphics.FillRectangle(wallBrush, 0, 0, Thick, this.Height);
            e.Graphics.FillRectangle(wallBrush, this.Width - Thick, 0, Thick, this.Height);
            //Draw player
            e.Graphics.FillRectangle(playerBrush, p.x, p.y, p.size, p.size);
            //Score
            e.Graphics.DrawString("Score: " + Form1.score, scoreFont, scoreBrush, 500, 20);

        }


    }
}
