using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domino
{
    public partial class Form1 : Form
    {
        int offset = 1;
        Button[] buttons = new Button[2];
        //System.Timers.Timer tmr = new System.Timers.Timer() { Interval = 10 };
        Timer tmr = new Timer() { Interval = 10 };
        public Form1()
        {
            InitializeComponent();
            for (byte i = 0; i < 2; ++i)
            {
                buttons[i] = new Button();
                buttons[i].Location = new Point(760 + 80 * i, 500);
                buttons[i].Size = new Size(40, 40);
                Controls.Add(buttons[i]);
            }
            //tmr.Tick += ;
            //tmr.Start();
        }

        private delegate void MoveButton();
        private EventHandler ButtonMove;
        private MoveButton moveButton;
        //private Dictionary<Direction, MoveButton> dir;
        //private enum Direction { Left, Right, Up, Down };

        //public Movement()
        //{
        //    dir = new Dictionary<Direction, MoveButton>
        //    {
        //        { Direction.Left,this.MoveLeft },
        //    };
        //}

        //private static void Move(object sender, EventArgs e)
        //{
        //    if (moveButton != null)
        //        moveButton();
        //}

        private void MoveLeft(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Left -= offset;
        }

        private void MoveRight(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Left += offset;
        }

        private void MoveUp(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Top -= offset;
        }

        private void MoveDown(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Top += offset;
        }

    }
}
