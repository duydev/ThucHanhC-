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
    public partial class frmUocboi : Form
    {
        public frmUocboi()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(rdoUCLN.Checked)
                txtKetqua.Text = UCLN(int.Parse(txtA.Text), int.Parse(txtB.Text)).ToString();   
            else
                txtKetqua.Text = BCNN(int.Parse(txtA.Text), int.Parse(txtB.Text)).ToString();
        }

        #region Tinh Toan
        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while(a != b)
            {
                if (a > b)
                    a = a - b;
                if (b > a)
                    b = b - a;
            }
            return a;
        }

        private int BCNN(int a, int b)
        {
            return (a * b) / UCLN( a, b);
        }
        #endregion

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetqua.Clear();
        }


    }
}
