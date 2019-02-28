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
        const int Thick = 100;
        Player p;
        Boulder b;
        Brush playerBrush = new SolidBrush(Color.IndianRed);
        Brush wallBrush = new SolidBrush(Color.Tan);
        Brush rockBrush = new SolidBrush(Color.Gray);

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            p = new Player(this.Width/2 - 20, 200, 20, 5, 5);
            b = new Boulder(this.Width / 2 - Thick / 2, 50, Thick);
            gameTimer.Enabled = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            p.Move();
            Refresh();

            if (p.Collision(b))
            {
                gameTimer.Enabled = false;
                
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

        }
    }
}
