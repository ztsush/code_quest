using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace code_quest
{
    class Hero
    {
        public Image ImageUp { get; set; }
        public Image ImageDown { get; set; }
        public Image ImageRight { get; set; }
        public Image ImageLeft { get; set; }
        public Image ImageStay { get; set; }

        public Point Position;
    }
}
