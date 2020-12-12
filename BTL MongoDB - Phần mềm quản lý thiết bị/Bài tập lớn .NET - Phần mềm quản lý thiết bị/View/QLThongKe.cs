using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    public partial class QLThongKe : Form
    {
        Model.StatisticalMng StatisticalMng = new Model.StatisticalMng();
        Controller.StaisticalCtr staisticalCtr = new Controller.StaisticalCtr();
        public static string totalUsed;
        public static string totalLiqui;

        public QLThongKe()
        {
            InitializeComponent();
            loadThongKe.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadThongKe_Tick(object sender, EventArgs e)
        {
            //load tong thiet bi dang su dung
            lblTongTBSuDung.Text = StatisticalMng.HTTongTBDung().ToString();
            //load tong so thiet bi thanh ly
            lblTongTBThanhLy.Text = StatisticalMng.HTTongThanhLy().ToString();
        }

        private void QLThongKe_Load(object sender, EventArgs e)
        {

        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemThanhLy_Click(object sender, EventArgs e)
        {
            if (CheckDateTimeQuery())
            {
                staisticalCtr.ThongKeTheoTime(dgvListRentDevice, dtpStart.Value, dtpEnd.Value);
            }
            else
            {
                MessageBox.Show("Chọn thời gian kết thúc lớn hơn thời gian bắt đầu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckDateTimeQuery()
        {

            TimeSpan value = dtpEnd.Value.Subtract(dtpStart.Value);

            if (value.TotalSeconds >= 0)
            {
                return true;
            }
            else return false;
        }

        private void dgvThongKe_MouseClick(object sender, MouseEventArgs e)
        {
/*            MessageBox.Show("Xem thôi chứ đừng nghịch bạn ơi :v ", "Sad :((", MessageBoxButtons.OK, MessageBoxIcon.Error);
*/        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if(txtName_Customer.Text == "")
            {
                MessageBox.Show("Nhập vào tên người dùng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                staisticalCtr.ThongKeTheoTen(dgvListRentDevice, txtName_Customer.Text.Trim());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BieuDoTBThanhLy bieuDoTBThanhLy = new BieuDoTBThanhLy();
            bieuDoTBThanhLy.Show();

            /*ThongKeThanhLyTheoNgay thongKeThanhLyTheoNgay = new ThongKeThanhLyTheoNgay();
            thongKeThanhLyTheoNgay.Show();*/
        }
    }
}
