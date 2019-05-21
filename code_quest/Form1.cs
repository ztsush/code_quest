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
        Stage CurrentStage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //початкове вікно
            Image FieldBackround = Image.FromFile("Resources/field_background.jpg");
            pb_field.BackgroundImage = FieldBackround;

            this.BackColor = Color.FromArgb(40, 41, 35);
            panel_editor.BackColor = Color.FromArgb(66, 67, 62);
            panel_editor.Visible = false;
            pb_field.Width += panel_editor.Width;

            Point OpenQuestLocation = new Point();
            OpenQuestLocation.X = pb_field.Width / 2 - panel_open_quest.Width/2;
            OpenQuestLocation.Y = pb_field.Height / 2 - panel_open_quest.Height / 2;
            panel_open_quest.Location = OpenQuestLocation;

            ///////////////////////////////////
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // ставлю панель вибору квеста на центр
            Point OpenQuestLocation = new Point();
            OpenQuestLocation.X = pb_field.Width / 2 - panel_open_quest.Width / 2;
            OpenQuestLocation.Y = pb_field.Height / 2 - panel_open_quest.Height / 2;
            panel_open_quest.Location = OpenQuestLocation;


        }

        private void btn_open_quest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog OpenQuestDialog = new FolderBrowserDialog();
            if (OpenQuestDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentStage = new Stage();

                try
                {
                    string MainInput = File.ReadAllText(OpenQuestDialog.SelectedPath + "/main.txt");
                    string[] MainInputArr = MainInput.Split('\n');
                    CurrentStage.Field.Image = Image.FromFile(OpenQuestDialog.SelectedPath+"/image.jpg");
                    CurrentStage.Field.Size = new Size(Convert.ToInt32(MainInputArr[0].Split(':')[0]), Convert.ToInt32(MainInputArr[0].Split(':')[1]));
                    CurrentStage.StartPosition = new Point(Convert.ToInt32(MainInputArr[1].Split(':')[0]), Convert.ToInt32(MainInputArr[1].Split(':')[1]));
                    CurrentStage.FinishPosition = new Point(Convert.ToInt32(MainInputArr[2].Split(':')[0]), Convert.ToInt32(MainInputArr[2].Split(':')[1]));
                    bool[,] CurrentMatrix = new bool[100, 100];
                    String MatrixInput = File.ReadAllText(OpenQuestDialog.SelectedPath + "/matrix.txt");
                    string[] MatrixInputArr = MatrixInput.Split('\n');
                    int i = 0, j = 0;
                    foreach (string Line in MatrixInputArr)
                    {
                        j = 0;
                        string[] LineArr = Line.Split(' ');
                        foreach (string item in LineArr)
                        {
                            CurrentMatrix[i, j] = (item == "1");
                            j++;
                        }
                        i++;
                    }
                    CurrentStage.Field.Matrix = CurrentMatrix;
                }
                catch
                {

                }
                /*
                 test view
                MessageBox.Show(CurrentStage.Field.Size.ToString());
                MessageBox.Show(CurrentStage.StartPosition.ToString());
                MessageBox.Show(CurrentStage.FinishPosition.ToString());

                string output = "";
                for(int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        output += " " + CurrentStage.Field.Matrix[i, j];
                    }
                    output += "\n";
                }
                MessageBox.Show(output);
                */
                panel_open_quest.Visible = false;
                pb_field.Image = CurrentStage.Field.Image;
            }
        }
    }
}
