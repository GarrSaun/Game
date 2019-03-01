using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public static int score;
        public static int highScore = 0;

        public Form1()
        {
            InitializeComponent();
            TitleScreen ts = new TitleScreen();
            this.Controls.Add(ts);
        }

    }
}
