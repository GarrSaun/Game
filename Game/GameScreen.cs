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
        bool escapeDown;
        const int Thick = 100;
        int count;
        Player p;
        Boulder b;

        Brush wallBrush = new SolidBrush(Color.Tan);
        Brush scoreBrush = new SolidBrush(Color.Black);
        Font scoreFont = new Font("Mongolian Baiti", 12);

        public GameScreen()
        {
            InitializeComponent();
            DoubleBuffered = true;
            OnStart();
        }


        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.Escape:
                    escapeDown = true;
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
                case Keys.Escape:
                    escapeDown = false;
                    break;
            }
        }

        public void OnStart()
        {
            p = new Player(this.Width / 2 - 20, 200, 20, 3, 30, Color.IndianRed);
            b = new Boulder(this.Width / 2 - Thick / 2, 50, Thick, Color.Gray);
            count = 0;
            gameTimer.Enabled = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (p.y <= this.Height - p.size)
            {
                p.Move();
            }
            else //Stops user from glitching out of bounds
            {
                p.y = this.Height - p.size;
            }
            Form1.score++;
            count++;
            Refresh();

            if (count % 200 == 0)
            {
                p.upSpeed++;
            }

            if (p.Collision(b))
            {
                GameOver();
            }

            if (escapeDown == true)
            {
                GameOver();
            }
        }

        public void GameOver()
        {
            gameTimer.Enabled = false;

            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameOver go = new GameOver();
            f.Controls.Add(go);
            go.Location = new Point((f.Width - go.Width) / 2, (f.Height - go.Height) / 2);
            this.Dispose();
            return;
        }
        
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //Draw Boulder
            e.Graphics.FillEllipse(new SolidBrush(b.colour), b.x, b.y, b.size, b.size);
            //Draw sides
            e.Graphics.FillRectangle(wallBrush, 0, 0, Thick, this.Height);
            e.Graphics.FillRectangle(wallBrush, this.Width - Thick, 0, Thick, this.Height);
            //Draw player
            e.Graphics.FillRectangle(new SolidBrush(p.colour), p.x, p.y, p.size, p.size);
            //Score
            e.Graphics.DrawString("Score: " + Form1.score, scoreFont, scoreBrush, 500, 60);
        }


    }
}
