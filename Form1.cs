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
        Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private class O_S_Button : Button
        {
            internal delegate void D(O_S_Button sender);
            internal D d;
            private byte offset = 3;
            internal static ushort width = 40, dis = (ushort)(width * 2);
            private ushort border, coord;
            internal O_S_Button(byte n)
            {
                Text = Convert.ToString(n);
                Width = Height = width;
                FlatStyle = FlatStyle.Flat;
                BackColor = FlatAppearance.BorderColor = FlatAppearance.MouseDownBackColor = FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            }
            internal void r(O_S_Button sender)
            {
                if (Top == sender.Top)
                {
                    if (Left < sender.Left)
                    {
                        border = (ushort)(sender.Left - dis);
                        if (Left > border)
                        {
                            coord = (ushort)(Left - offset);
                            Left = coord < border ? border : coord;
                        }
                        return;
                    }
                    border = (ushort)(sender.Left + dis);
                    if (Left < border)
                    {
                        coord = (ushort)(Left + offset);
                        Left = coord > border ? border : coord;
                    }
                }
                else
                {
                    if (Left != sender.Left)
                    {
                        return;
                    }
                    if (Top < sender.Top)
                    {
                        border = (ushort)(sender.Top - dis);
                        if (Top > border)
                        {
                            coord = (ushort)(Top - offset);
                            Top = coord < border ? border : coord;
                        }
                        return;
                    }
                    border = (ushort)(sender.Top + dis);
                    if (Top < border)
                    {
                        coord = (ushort)(Top + offset);
                        Top = coord > border ? border : coord;
                    }
                }
            }
            internal void EventMethod(object sender, EventArgs e)
            {
                d(this);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const byte count = 62;

            Button[] hButtons = new Button[count] { button0,
                                                    button1,
                                                    button2,
                                                    button3,
                                                    button4,
                                                    button5,
                                                    button6,
                                                    button7,
                                                    button8,
                                                    button9,
                                                    button10,
                                                    button11,
                                                    button12,
                                                    button13,
                                                    button14,
                                                    button15,
                                                    button16,
                                                    button17,
                                                    button18,
                                                    button19,
                                                    button20,
                                                    button21,
                                                    button22,
                                                    button23,
                                                    button24,
                                                    button25,
                                                    button26,
                                                    button27,
                                                    button28,
                                                    button29,
                                                    button30,
                                                    button31,
                                                    button32,
                                                    button33,
                                                    button34,
                                                    button35,
                                                    button36,
                                                    button37,
                                                    button38,
                                                    button39,
                                                    button40,
                                                    button41,
                                                    button42,
                                                    button43,
                                                    button44,
                                                    button45,
                                                    button46,
                                                    button47,
                                                    button48,
                                                    button49,
                                                    button50,
                                                    button51,
                                                    button52,
                                                    button53,
                                                    button54,
                                                    button55,
                                                    button56,
                                                    button57,
                                                    button58,
                                                    button59,
                                                    button60,
                                                    button61
                                                  };

            O_S_Button[] buttons = new O_S_Button[count];

            for (byte i = 0; i < count; ++i)
            {
                buttons[i] = new O_S_Button(i);
                buttons[i].Left = hButtons[i].Left / O_S_Button.width * O_S_Button.width;
                buttons[i].Top = hButtons[i].Top / O_S_Button.width * O_S_Button.width;
                Controls.Add(buttons[i]);
            }
            for (byte i = 1; i < count; ++i)
                buttons[i - 1].d = buttons[i].r;

            timer = new Timer();
            timer.Interval = 15;
            for (byte i = 0; i < count - 1; ++i)
                timer.Tick += buttons[i].EventMethod;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
