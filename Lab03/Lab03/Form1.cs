using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int Tong = n + m;
            txtKetqua.Text = Tong.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSon.Clear();
            txtSom.Clear();
            txtKetqua.Clear();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            txtKetqua.Text = (int.Parse(txtSon.Text) - int.Parse(txtSom.Text)).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            txtKetqua.Text = (int.Parse(txtSon.Text) * int.Parse(txtSom.Text)).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            txtKetqua.Text = (int.Parse(txtSon.Text) / int.Parse(txtSom.Text)).ToString();
        }


    }
}
