﻿using System;
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

        public Player(int _x, int _y, int _size, int _upSpeed, int _downSpeed)
        {
            x = _x;
            y = _y;
            size = _size;
            upSpeed = _upSpeed;
            downSpeed = _downSpeed;
        }

        public void Move()
        {
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
