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
    public partial class AddNewTypeDevice : Form
    {
        public static string text;
        Controller.TypeDeviceCtrl TypeDeviceCtrl = new Controller.TypeDeviceCtrl();
        public AddNewTypeDevice()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtName_Type.Clear();
            txtId_Type.Clear();
        }

        private void LamMoi()
        {
            txtName_Type.Clear();
            txtId_Type.Clear();
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void GanDuLieu(Object.ObjTypeDevice objTypeDevice)
        {
            objTypeDevice.Id_Type = Convert.ToDouble(txtId_Type.Text.Trim());
            objTypeDevice.Name_Type = txtName_Type.Text.Trim();
        }

        private bool checkNullItem()
        {
            if (txtName_Type.Text == "")
            {
                return false;
            }
            return true;
        }

        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThemTaiKhoan_Click_1(object sender, EventArgs e)
        {
            Object.ObjTypeDevice objType = new Object.ObjTypeDevice();
            if (checkNullItem())
            {
                GanDuLieu(objType);
                {
                    switch (TypeDeviceCtrl.Them(objType))
                    {
                        case 0:
                            text = "Vui lòng chọn mã thiết bị khác!";
                            ThongBao(text);
                            break;
                        case 1:
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LamMoi();
                            break;
                        case 2:
                            text = "Vui lòng chọn tên loại thiết bị khác!";
                            ThongBao(text);
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
