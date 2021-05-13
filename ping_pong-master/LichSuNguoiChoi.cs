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
    public partial class LichSuNguoiChoi : Form
    {
        public LichSuNguoiChoi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // gỡ thanh tiêu đề
            lichsu.Text = DatabaseControler.Instance.showlichsu(AppControler.MAC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiaoDienDaDangKi f = new GiaoDienDaDangKi();
            f.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lichsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void lichsu_Click(object sender, EventArgs e)
        {

        }

        private void xoalichsu_Click(object sender, EventArgs e)
        {
            DatabaseControler.Instance.xoalichsu(AppControler.MAC);
            MessageBox.Show("Đã xóa lịch sử thành công");
            GiaoDienDaDangKi f =new  GiaoDienDaDangKi();
            f.Show();
            this.Close();
        }
    }
}
