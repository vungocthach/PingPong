using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Windows;
using System.Media;


namespace pong
{
    public partial class GiaoDienChuaDangKi : Form
    {
        public GiaoDienChuaDangKi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // gỡ thanh tiêu đề
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.Beep();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.Beep();
            if (DatabaseControler.Instance.check(AppControler.MAC) == false)
            {
                DatabaseControler.Instance.insert(AppControler.MAC,"MAC","nguoichoi");
                DatabaseControler.Instance.updateHighscore("0", AppControler.MAC);
                NhapTen f = new NhapTen();
                f.Show();
                this.Hide();
            }
            else
            {
                GiaoDienDaDangKi f = new GiaoDienDaDangKi();
                f.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {    
     
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @".\FILE_20210513_221817_MusicGamePingpong.wav";
            player.PlayLooping();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
