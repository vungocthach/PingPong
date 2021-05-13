using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pong
{
    public partial class Choivoimay : Form
    {
        public int speed_left = 2; // tốc độ banh
        public int speed_top = 2;
        public int point = 0; // diem so
        public int lastx = MousePosition.X;
        public bool paused = true;

        public Choivoimay()
        {
            InitializeComponent();
            DoubleBuffered = true;
            timer1.Enabled = true;
            this.FormBorderStyle = FormBorderStyle.None; // gỡ thanh tiêu đề
            this.TopMost = true; // đem cái form này lên phía trước
            //this.Bounds = Screen.PrimaryScreen.Bounds; // làm cho nó full màn hình
            thanhngang.Top = playground.Bottom - (playground.Bottom / 10);//đưa thanh ngang về cuối      
            gameover.Visible = false;//ẩn chữ gameover đi
            pause_label.Visible = false;// ẩn chữ pause đi
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            if(!paused)
            { 
                thanhngang.Left=Cursor.Position.X - (thanhngang.Width/2); // cài con trỏ nằm ở giữa thanh ngang
                pause_label.Location = new Point((int)playground.Width / 2 - pause_label.Width / 2, (int)playground.Height / 2 - pause_label.Height / 2);// vị trí chữ Pause sẽ nằm giữa màn hình
                gameover.Location=new Point((int)playground.Width / 2 - gameover.Width / 2, (int)playground.Height / 2 - gameover.Height / 2);// vị trí chữ gameover sẽ nằm giữa màn hình
                clickstart.Location = new Point((int)playground.Width / 2 - clickstart.Width / 2, (int)playground.Height / 2 - clickstart.Height / 2);// vị trí chữ clickstart sẽ nằm giữa màn hình
                Ball.Left += speed_left; // di chuyen trai banh
                Ball.Top += speed_top;
                if (Ball.Bounds.IntersectsWith(thanhngang.Bounds)) // nếu thanh ngang chạm bóng
                {
                    speed_top *= -1;
                    speed_left = Math.Abs(MousePosition.X - lastx);       
                    if (speed_left > 4)
                    {
                        speed_left = 4;
                    }
                    else if (speed_left < -4)
                    {
                        speed_left = -4;
                    }
                    else if (speed_left == 0)
                    {
                        Random a = new Random();
                        if (a.NextDouble() > .5)
                        {
                            speed_left = 2;
                        }
                        else
                        {
                            speed_left = -2;
                        }
                    }

                    while (Ball.Location.Y + 1 + Ball.Height > thanhngang.Location.Y)
                    {
                        Ball.Location = new Point(Ball.Location.X, Ball.Location.Y - 1);
                    }
                    point += 1;
                    Random r = new Random();
                    playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
                    label2.Text = point.ToString();
                    DoubleBuffered = true;
                }

                if (Ball.Left <= playground.Left)
                {
                    speed_left = -speed_left;
                }
                if (Ball.Right >= playground.Right)
                {
                    speed_left = -speed_left;
                }
                if (Ball.Top <= playground.Top)
                {
                    speed_top = -speed_top;
                }
                if (Ball.Bottom >= playground.Bottom)
                {
                    if (Int32.Parse(DatabaseControler.Instance.select("highscore", AppControler.MAC)) < point)
                    {
                        DatabaseControler.Instance.updateHighscore(point.ToString(), AppControler.MAC);
                    }
                    timer1.Enabled = false;// end game
                    gameover.Visible = true; // hiện chữ game over
                }
            }
           
        }
        private void Choivoimay_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Choivoimay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GiaoDienDaDangKi f = new GiaoDienDaDangKi();
                f.Show();
                this.Close(); // nhấn esc để out khỏi màn hình
            }
            if (e.KeyCode == Keys.F1)
            {
                Random r = new Random();
                Ball.Top = r.Next(10, 200);
                Ball.Left = r.Next(10,800);
                speed_left = 2;
                speed_top = 2;
                gameover.Visible = false;
                timer1.Enabled = true;
                point = 0;
                label2.Text = "0";
                paused = true;
                clickstart.Visible = true;
            }
        }
        private void thanhngang_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void pause_Click(object sender, EventArgs e)
        {
            clickstart.Visible = false;
            if (!paused)
            {
                paused = true;
                pause_label.Visible = true;
            }
            else
            {
                paused = false;
                pause_label.Visible = false;
            }
        }
        private void pause_label_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void Choivoimay_Click(object sender, EventArgs e)
        {
            
        }

        private void playground_Click(object sender, EventArgs e)
        {
            clickstart.Visible = false;
            if (!paused)
            {
                paused = true;
                pause_label.Visible = true;
            }
            else
            {
                paused = false;
                pause_label.Visible = false;
            }
        }

        private void clickstart_Click(object sender, EventArgs e)
        {
            clickstart.Visible = false;
            if (!paused)
            {
                paused = true;
                pause_label.Visible = true;
            }
            else
            {
                paused = false;
                pause_label.Visible = false;
            }
        }

        private void playground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
