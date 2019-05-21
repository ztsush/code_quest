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

namespace code_quest
{
    public partial class Form1 : Form
    {
        int[,] matrix = new int[100, 100];

        Point StartPosition;
        Point FinishPosition;
        Point CurrentPosition;

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
                foreach(string Item in Items)
                {
                    j++;
                    matrix[i, j] = Convert.ToInt32(Item);
                }
            }

            StartPosition = new Point(3, 3);
            FinishPosition = new Point(12, 6);
            CurrentPosition = StartPosition;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Compiler MyCompiler = new Compiler();
            
        }
    }
}
