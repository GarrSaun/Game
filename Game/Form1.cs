//Name: Indiana Jones: The Movie: The Game
//Author: Garrett Saunders
//Date: 03/08/2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Game
{
    public partial class Form1 : Form
    {
        public static int score;
        public static int highScore = 0;
        public static List<int> scoreList = new List<int>();

        XmlReader reader = XmlReader.Create("Resources/HighScore.xml");

        private void Form1_Load(object sender, EventArgs e)
        {
            //Read Xml
            try
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        reader.ReadToNextSibling("score");
                        highScore = Convert.ToInt16(reader.ReadString());

                        scoreList.Add(highScore);
                    }
                }
                
            }
            catch
            {

            }
            reader.Close();

            //Set up fullscreen
            Cursor.Hide();
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
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
