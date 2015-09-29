using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Form1 : Form
    {
        DataTable tbOrder;
        DataTable[] ban;
        int banhientai;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khoi tao tbOrder
            tbOrder = new DataTable();
            tbOrder.Columns.Add("FoodName");
            tbOrder.Columns.Add("Quantity");

            // Khoi tao Danh Sach Ban
            ban = new DataTable[7];

            // Ban hien tai
            banhientai = 0;
            cbbBan.SelectedIndex = 0;

            dgvOrder.AutoGenerateColumns = false;
        }

        private void btnPB_Click(object sender, EventArgs e)
        {
            // Ten ten mon an de Order
            string TenMon = ((Button)sender).Text;
            //MessageBox.Show(TenMon); // For Debug

            //Kiem tra mon da co trong tbOrder
            foreach(DataRow dr in tbOrder.Rows)
            {
                if (dr["FoodName"] == TenMon)
                {
                    dr["Quantity"] = (int.Parse(dr["Quantity"].ToString()) + 1).ToString();
                    dgvOrder.DataSource = tbOrder;
                    return;
                }
            }

                // Them dong moi
                DataRow r = tbOrder.NewRow();
                r["FoodName"] = TenMon;
                r["Quantity"] = 1;
                tbOrder.Rows.Add(r);
                dgvOrder.DataSource = tbOrder;
 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ban[banhientai].Clear();
            tbOrder.Clear();
            dgvOrder.DataSource = tbOrder;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ban[banhientai] = tbOrder.Copy();
            dgvOrder.DataSource = ban[banhientai];
            tbOrder.Clear();
            MessageBox.Show("Đã gửi thành công.");
        }

        private void cbbBan_SelectedIndexChanged(object sender, EventArgs e)
        {           
            banhientai = cbbBan.SelectedIndex;
            dgvOrder.DataSource = ban[banhientai];
        }

        
    }
}
