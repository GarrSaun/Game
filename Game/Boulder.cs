using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    class Boulder
    {
        public int x, y, size;
        public Color colour;

        public Boulder(int _x, int _y, int _size, Color _colour)
        {
            x = _x;
            y = _y;
            size = _size;
            colour = _colour;
        }
    }
}
