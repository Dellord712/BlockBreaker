using System;
using System.Windows.Forms;


namespace WindowsFormsApp1
{

    class Ball
    {
        public double x = 0.0;
        public double y = 0.0;
        private double gradient = 1.0;
        private double b = 0.0;
        private bool ballup = true;
        private int ballspeed = 2;
        public PictureBox Img { get; private set; }

        public void Initialize(Form1 form1)
        {
            Img = new PictureBox();
            Img.Image = Properties.Resources.Ball;
            Img.SizeMode = PictureBoxSizeMode.AutoSize;
            form1.Controls.Add(Img);
        }

        public void Progress()
        {
            Bound();
        }

        public void Bound()
        {


        }

        public void Collision1() //Left ,Right
        {
            gradient = -gradient;
            if (gradient == 0.0 || x == 0.0)
            {
                b = y;
            }
            else
            {
                b = y - (gradient * x);
            }
        }

        public void Collision2() //Top ,Bottom
        {
            gradient = -gradient;
            if (gradient == 0.0 || x == 0.0)
            {
                b = y;
            }
            else
            {
                b = y - (gradient * x);
            }
            if (ballup)
            {
                ballup = false;
            }
            else
            {
                ballup = true;
            }
        }

        public void Render()
        {
            if (ballup)
            {
                y -= ballspeed;
                if (gradient == 0.0)
                {
                    x = y - b;
                }
                else
                {
                    x = (y - b) / gradient;

                }
                Img.Left = (int)x;
                Img.Top = (int)y;
            }
            else
            {
                y += ballspeed;
                if (gradient == 0.0)
                {
                    x = y - b;
                }
                else
                {
                    x = (y - b) / gradient;

                }
                Img.Left = (int)x;
                Img.Top = (int)y;
            }
        }

        public void ballreset()
        {
            x = 0.0;
            y = 0.0;
            gradient = 1.0;
            b = 0.0;
            ballup = true;
        }
    }
}