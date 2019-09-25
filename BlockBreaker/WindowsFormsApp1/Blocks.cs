using System;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class Blocks
    {
        public PictureBox Img { get; private set; }

        public void Initialize(Form1 form1, int color)
        {
            Img = new PictureBox();
            switch (color)
            {
                case 0:
                    Img.Image = Properties.Resources.RedBlock;
                    break;
                case 1:
                    Img.Image = Properties.Resources.OrangeBlock;
                    break;
                case 2:
                    Img.Image = Properties.Resources.YellowBlock;
                    break;
                case 3:
                    Img.Image = Properties.Resources.GreenBlock;
                    break;
                case 4:
                    Img.Image = Properties.Resources.BlueBlock;
                    break;
                case 5:
                    Img.Image = Properties.Resources.BluishVioletBlock;
                    break;
                case 6:
                    Img.Image = Properties.Resources.PurpleBlock;
                    break;
                default:
                    Img.Image = Properties.Resources.RedBlock;
                    break;
            }
            Img.SizeMode = PictureBoxSizeMode.AutoSize;
            Img.Left = 100;
            Img.Top = 100;
            Img.Visible = true;
            Img.Tag = "Blocks";
            form1.Controls.Add(Img);
        }
    }
}