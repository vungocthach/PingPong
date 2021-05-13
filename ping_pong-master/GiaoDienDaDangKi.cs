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
    public partial class GiaoDienDaDangKi : Form
    {
        public string name;
        public GiaoDienDaDangKi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // gỡ thanh tiêu đề
            tennguoichoi.Text = DatabaseControler.Instance.select("TEN", AppControler.MAC);
            highscore.Text = DatabaseControler.Instance.select("highscore", AppControler.MAC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choivoimay f = new Choivoimay();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Huongdan f = new Huongdan();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            NhapTen f = new NhapTen();
            f.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void tennguoichoi_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click_2(object sender, EventArgs e)
        {
            NhapTen f = new NhapTen();
            f.Show();
            this.Close();
        }

        private void highscore_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LichSuNguoiChoi f = new LichSuNguoiChoi();
            f.Show();
            this.Close();
        }
    }
}
