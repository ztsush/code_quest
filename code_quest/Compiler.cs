using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace code_quest
{
    class Compiler
    {
        public ArrayList Compile(string code)
        {
            ArrayList Result = new ArrayList();
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '}')
                {
                    if (i != code.Length - 1 && code[i + 1] == ';')
                    {
                        continue;
                    }
                    code = code.Insert(i + 1, ";");
                }
                string[] Fragments = code.Split(';');
                foreach (string Fragment in Fragments)
                {
                    switch (Fragment)
                    {
                        case "turnLeft()":
                            Result.Add("turnLeft");
                            break;
                        case "turnRight()":
                            Result.Add("turnRight");
                            break;
                        case "moveForward()":
                            Result.Add("moveForward");
                            break;
                        default:
                            MessageBox.Show("|"+Fragment+"|");
                            Result.Add("ERROR");
                            break;
                    }
                }

            }


            return Result;
        }
    }
}
