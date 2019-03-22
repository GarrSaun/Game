//Name: Indiana Jones: The Movie: The Game
//Author: Garrett Saunders
//Date: 22/03/2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Game
{
    public partial class GameScreen : UserControl
    {
        public static bool ready;
        const int Thick = 100;
        int count;
        Player p;
        Boulder b;

        Brush wallBrush = new SolidBrush(Color.Tan);
        Brush scoreBrush = new SolidBrush(Color.Black);
        Font scoreFont = new Font("Mongolian Baiti", 12);

        SoundPlayer scream = new SoundPlayer(Properties.Resources.scream);

        public GameScreen()
        {
            InitializeComponent();
            DoubleBuffered = true;
            OnStart();
        }

        private void GameScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Move the player unless doing so would take them out of bounds
            if (e.KeyChar == (char)Keys.Space && p.y <= this.Height - p.size)
            {
                p.MoveDown();
            }

            //Forfeit if escape is pressed
            if (e.KeyChar == (char)Keys.Escape)
            {
                GameOver();
            }
        }
        //Allow player to move again after space is released
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            p.ready = true;
        }

        public void OnStart()
        {
            p = new Player(this.Width / 2 - 20, 200, 20, 3, 30, Color.IndianRed, true);
            b = new Boulder(this.Width / 2 - Thick / 2, 50, Thick, Color.Gray);
            count = 0;
            gameTimer.Enabled = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Constantly move the player up
            p.MoveUp();

            //Stop the player from going out of bounds
            if (p.y > this.Height - p.size)
            {
                p.y = this.Height - p.size;
            }

            //Increase score
            Form1.score++;
            count++;
            Refresh();

            //Increase speed every 200 ticks
            if (count % 200 == 0)
            {
                p.upSpeed++;
            }

            //Lose if player collides with boulder
            if (p.Collision(b))
            {
                GameOver();
            }
        }

        public void GameOver()
        {
            scream.Play();
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
            //Draw Score
            e.Graphics.DrawString("Score: " + Form1.score, scoreFont, scoreBrush, 500, 60);
        }


    }
}
