//Name: Indiana Jones: The Movie: The Game
//Author: Garrett Saunders
//Date: 22/03/2019

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

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set up fullscreen
            Cursor.Hide();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            TitleScreen ts = new TitleScreen();
            this.Controls.Add(ts);
            ts.Location = new Point((this.Width - ts.Width) / 2, (this.Height - ts.Height) / 2);
        }

        public Form1()
        {
            InitializeComponent();
        }


    }
}
