using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace code_quest
{
    public partial class Form1 : Form
    {
        int[,] matrix = new int[100, 100];
        Hero Hero = new Hero();

        Point StartPosition;
        Point FinishPosition;
        Point CurrentPosition;

        string CheckMovement(string Direction)
        {
            Point EstimatedPos = Hero.Position;
            if (Direction == "l")
            {
                EstimatedPos.X--;
            }
            if (Direction == "r")
            {
                EstimatedPos.X++;
            }
            if (Direction == "u")
            {
                EstimatedPos.Y--;
            }
            if (Direction == "d")
            {
                EstimatedPos.Y++;
            }
            int EX = EstimatedPos.X;
            int EY = EstimatedPos.Y;
            
            if (matrix[EX, EY] == 1)
            {
                return "c"; // correct
            }
            else if (matrix[EX, EY] == 2)
            {
                return "p"; // problem
            }
            else if (matrix[EX, EY] == 3)
            {
                return "d"; // dead
            }
            else if(matrix[EX, EY] == 0)
            {
                return "e"; // error
            }
            else
            {
                return "s"; // shit
            }   
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string MatrixInput = File.ReadAllText("matrix.txt");
            string[] MatrixRows = MatrixInput.Split('\n');
            int i = 0, j = 0;
            foreach (string Row in MatrixRows)
            {
                string[] Items = Row.Split(' ');
                i++;
                j = 0;
                foreach (string Item in Items)
                {
                    j++;
                    matrix[i, j] = Convert.ToInt32(Item);
                }
            }

            StartPosition = new Point(3, 3);
            FinishPosition = new Point(12, 6);
            CurrentPosition = StartPosition;
            pb_field.Image = Hero.Image;
            pb_hero.Location = new Point(StartPosition.X * 50, StartPosition.Y * 50);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Compiler MyCompiler = new Compiler();
            ArrayList Result = MyCompiler.Compile(tb_code.Text);
            int i = 0;
            foreach (var Command in Result)
            {
                i++;
                if (Command is string)
                {
                    switch (Command)
                    {
                        case "turnLeft":
                            Hero.TurnLeft();
                            break;
                        case "turnRight":
                            Hero.TurnRight();
                            break;
                        case "moveForward":
                            if (CheckMovement(Hero.Direction) == "c")
                            {
                                Hero.MoveForward();
                                pb_hero.Location = new Point(Hero.Position.X * 49, Hero.Position.Y * 49);
                                MessageBox.Show("yes");
                            }
                            else if(CheckMovement(Hero.Direction) == "p")
                            {
                                return;
                            }
                            else if (CheckMovement(Hero.Direction) == "d")
                            {
                                tb_result.Text = "___WASTED___";
                                return;
                            }
                            break;
                        default:
                            MessageBox.Show((string)Command);
                            // tb_result.Text = "ERROR: line-" + i.ToString();
                            return;
                            break;
                    }
                }
            }
            
        }
    }
}
