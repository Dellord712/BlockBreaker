using System;
using System.Windows.Forms;
//BlockBreaker C# 1.0
//업데이트 날짜 : 2019-08-07
namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        delegate void Delegate(string msg);
        event Delegate Event;

        const int blocknumber = 20;
        const int blockkind = 7;
        Blocks[,] block;
        Ball ball;
        private bool doublecollision = false;
        private int score = 0;
        private string scoretxt = "";

        private bool goleft = false;
        private bool goright = false;
        private bool backboardgoleft = false;
        private bool backboardgoright = false;

        private bool ismenu = false;
        private bool menumode = false;
        private bool modeeasy = true;
        public Form1()
        {
            Event += EndGame;
            InitializeComponent();
            message.Visible = false;
            resetmessage.Visible = false;
            backlabel.Visible = false;
            modelabel.Visible = false;
            mode.Visible = false;
            block = new Blocks[blocknumber, blockkind];


            for (int i = 0; i < blocknumber; i++)
            {
                for (int j = 0; j < blockkind; j++)
                {
                    block[i, j] = new Blocks();
                    block[i, j].Initialize(this, j);
                    block[i, j].Img.Left = 100 + block[i, j].Img.Width * i;
                    block[i, j].Img.Top = 163 + block[i, j].Img.Height * j;
                    block[i, j].Img.BringToFront();
                }
            }
            Board.Left = 386;
            BackBoard.Left = 386;
            ball = new Ball();
            ball.Initialize(this);
            ball.Img.Left = Board.Left + Board.Width / 2 - ball.Img.Width / 2;
            ball.Img.Top = Board.Top - ball.Img.Height;
            ball.x = ball.Img.Left;
            ball.y = ball.Img.Top;
            ball.Img.BringToFront();
            backlabel.BringToFront();
            modelabel.BringToFront();
            mode.BringToFront();
            message.BringToFront();
            resetmessage.BringToFront();
            BackBoard.Visible = false;
            
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            scoretxt = score.ToString();
            scorebox.Text = "점수 : " + scoretxt;
            doublecollision = false;
            if (goleft)
            {
                Board.Left -= 5;
            }
            if (goright)
            {
                Board.Left += 5;
            }
            if (Board.Left <= 28)
            {
                Board.Left = 28;
            }
            if (Board.Left >= 714)
            {
                Board.Left = 714;
            }

            if (backboardgoleft)
            {
                BackBoard.Left -= 5;
            }
            if (backboardgoright)
            {
                BackBoard.Left += 5;
            }
            if (BackBoard.Left <= 28)
            {
                BackBoard.Left = 28;
            }
            if (BackBoard.Left >= 714)
            {
                BackBoard.Left = 714;
            }

            ball.Render();

            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag == "Blocks" && control.Visible)
                {
                    if (ball.Img.Bounds.IntersectsWith(control.Bounds))
                    {
                        control.Visible = false;
                        score++;
                        if (doublecollision == false)
                        {
                            if (ballposition(control.Left, control.Right, control.Top, control.Bottom))
                            {
                                ball.Collision2();
                            }
                            else
                            {
                                ball.Collision1();
                            }
                            doublecollision = true;
                        }


                    }
                }
                if (control is PictureBox && control.Tag == "board" && control.Visible)
                {
                    if (ball.Img.Bounds.IntersectsWith(control.Bounds))
                    {
                        if (control.Enabled == false)
                        {
                            control.Enabled = true;
                            ball.Collision2();
                        }
                    }
                    else
                    {
                        control.Enabled = false;
                    }
                }
            }


            if (ball.Img.Left <= 25)
            {
                ball.Collision1();
            }
            if (ball.Img.Left >= 770)
            {
                ball.Collision1();
            }
            if (ball.Img.Top <= 20 && TopBackGround.Visible)
            {
                ball.Collision2();
            }

            if (ball.Img.Top >= 480 || score == blocknumber * blockkind || ball.Img.Bottom <= 0)
            {
                Event("Game Over");
                GameTimer.Stop();
            }
        }

        private void DownKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            if (e.KeyCode == Keys.A)
            {
                backboardgoleft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                backboardgoright = true;
            }
            if (e.KeyCode == Keys.Enter && (message.Visible || (!menumode && ismenu)))
            {
                if (ismenu)
                {
                    if (modeeasy)
                    {
                        ModeEasy();
                        MenuBack();
                    }
                    else
                    {
                        ModeHard();
                        MenuBack();
                    }
                }
                else
                {
                    Reset();
                }

            }
            if (e.KeyCode == Keys.Escape)
            {
                if (ismenu == false)
                {
                    ViewMenu();
                }
                else
                {
                    if (modeeasy)
                    {
                        ModeEasy();
                        MenuBack();
                    }
                    else
                    {
                        ModeHard();
                        MenuBack();
                    }
                }
            }
            if (e.KeyCode == Keys.Down && ismenu)
            {
                menumode = true;
                ViewMenuMode();
            }
            if (e.KeyCode == Keys.Up && ismenu)
            {
                menumode = false;
                ViewMenuBack();
            }
            if (e.KeyCode == Keys.Left && menumode)
            {
                modeeasy = true;
                ViewMenuMode();
            }
            if (e.KeyCode == Keys.Right && menumode)
            {
                modeeasy = false;
                ViewMenuMode();
            }
        }

        private void UpKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (e.KeyCode == Keys.A)
            {
                backboardgoleft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                backboardgoright = false;
            }
        }

        private void EndGame(string msg)
        {
            message.Visible = true;
            message.Text = msg;
            resetmessage.Visible = true;
            resetmessage.Text = "다시하기 : Enter";
        }

        private bool ballposition(int left, int right, int top, int bottom)
        {
            int ball_x = ball.Img.Left + ball.Img.Width / 2;
            int ball_y = ball.Img.Top + ball.Img.Height / 2;
            int leftbottom_x = left;
            int leftbottom_y = bottom;
            int rightbottom_x = right;
            int rightbottom_y = bottom;
            int lefttop_x = left;
            int lefttop_y = top;
            int righttop_x = right;
            int righttop_y = top;
            int b1 = leftbottom_y + leftbottom_x;
            int b2 = rightbottom_y - rightbottom_x;
            int b3 = lefttop_y - lefttop_x;
            int b4 = righttop_y + righttop_x;
            if (ball_y >= -ball_x + b1 && ball_y >= ball_x + b2 && ball_y >= bottom)
            {
                return true;
            }
            else if (ball_y <= ball_x + b3 && ball_y <= -ball_x + b4 && ball_y <= top)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void Reset()
        {
            message.Visible = false;
            resetmessage.Visible = false;
            ball.ballreset();
            Board.Left = 386;
            BackBoard.Left = 386;
            ball.Img.Left = Board.Left + Board.Width / 2 - ball.Img.Width / 2;
            ball.Img.Top = Board.Top - ball.Img.Height;
            ball.x = ball.Img.Left;
            ball.y = ball.Img.Top;
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag == "Blocks" && !control.Visible)
                {
                    control.Visible = true;
                }
            }
            score = 0;
            GameTimer.Start();
        }

        private void MenuBack()
        {
            mode.Visible = false;
            backlabel.Visible = false;
            modelabel.Visible = false;
            ismenu = false;
            GameTimer.Start();
        }

        private void ViewMenu()
        {
            GameTimer.Stop();
            ismenu = true;
            mode.Visible = true;
            backlabel.Visible = true;
            modelabel.Visible = true;
            message.Visible = false;
            resetmessage.Visible = false;
        }

        private void ViewMenuBack()
        {
            backlabel.Text = "> 돌아가기";
            modelabel.Text = "  모드";
            if (modeeasy)
            {
                mode.Text = "  쉬움";
            }
            else
            {
                mode.Text = "어려움  ";
            }

        }

        private void ViewMenuMode()
        {
            backlabel.Text = "  돌아가기";
            modelabel.Text = "> 모드";
            if (modeeasy)
            {
                mode.Text = "> 쉬움";
            }
            else
            {
                mode.Text = "어려움 <";
            }
        }

        private void ModeHard()
        {
            BackBoard.Visible = true;
            TopBackGround.Visible = false;
            modeeasy = false;
        }

        private void ModeEasy()
        {
            BackBoard.Visible = false;
            TopBackGround.Visible = true;
            modeeasy = true;
        }

    }
}