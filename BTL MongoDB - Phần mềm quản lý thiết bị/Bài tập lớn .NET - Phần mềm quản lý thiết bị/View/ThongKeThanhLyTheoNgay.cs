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
    public partial class ThongKeThanhLyTheoNgay : Form
    {
        public ThongKeThanhLyTheoNgay()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThongKeThanhLyTheoNgay_Load(object sender, EventArgs e)
        {
            Model.StatisticalMng statisticalMng = new Model.StatisticalMng();
            dgvThongKe.DataSource = statisticalMng.getDeviceToChar().DataSource;
        }
    }
}
