using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    class Player
    {
        public int x, y, size, upSpeed, downSpeed;
        public Color colour;

        public Player(int _x, int _y, int _size, int _upSpeed, int _downSpeed, Color _colour)
        {
            x = _x;
            y = _y;
            size = _size;
            upSpeed = _upSpeed;
            downSpeed = _downSpeed;
            colour = _colour;
        }

        public void Move()
        {
              if(GameScreen.spaceDown == true)
            {
                y = y + downSpeed;
                GameScreen.spaceDown = false;
            }

            y = y - upSpeed;
        }

        public Boolean Collision(Boulder b)
        {

            Rectangle boulderRec = new Rectangle(b.x, b.y, b.size, b.size);
            Rectangle playerRec = new Rectangle(x, y, size, size);
            return boulderRec.IntersectsWith(playerRec);
        }
    }
}
