using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_quest
{
    class Hero
    {
        public Point Position { get; set; }
        public Image Image { get; set; }
        public string Direction = "r"; 
        public void TurnRight()
        {
            if(Direction == "r")
            {
                Direction = "d";
            }
            else if (Direction == "d")
            {
                Direction = "l";
            }
            else if (Direction == "l")
            {
                Direction = "u";
            }
            else if (Direction == "u")
            {
                Direction = "r";
            }

        }
        public void TurnLeft()
        {
            if (Direction == "r")
            {
                Direction = "u";
            }
            else if (Direction == "d")
            {
                Direction = "r";
            }
            else if (Direction == "l")
            {
                Direction = "d";
            }
            else if (Direction == "u")
            {
                Direction = "l";
            }
        }
        public void MoveForward()
        {
           // Position = new Point(1, 1);
            if (Direction == "r")
            {
                Position = new Point(Position.X+1,Position.Y);
            }
            else if (Direction == "l")
            {
                Position = new Point(Position.X - 1, Position.Y);
            }
            else if (Direction == "u")
            {
                Position = new Point(Position.X, Position.Y - 1);
            }
            else if (Direction == "d")
            {
                Position = new Point(Position.X, Position.Y + 1);
            }
        }

    }
}
