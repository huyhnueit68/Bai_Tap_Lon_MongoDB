using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    public partial class QuanLyLoaiTB : Form
    {
        public static string text;
        Controller.TypeDeviceCtrl TypeDeviceCtrl = new Controller.TypeDeviceCtrl();
        public QuanLyLoaiTB()
        {
            InitializeComponent();
        }

        private void QuanLyLoaiTB_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThemTK.Enabled = false;
                btnTimKiem.Enabled = false;
            }
            ShowDLLoaiTB();
            HienThiThongTin();
            txtId_Type.Enabled = false;
        }

        private void ShowDLLoaiTB()
        {
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjTypeDevice>("Type_Device"); //truy cập collection
            var result = collection.AsQueryable<Object.ObjTypeDevice>().ToList();
            dgvLoaiTB.DataSource = result;
        }

        private void HienThiThongTin()
        {
            try
            {
                if (dgvLoaiTB.CurrentRow != null)
                {
                    txtId_Type.Text = dgvLoaiTB.CurrentRow.Cells["Id_Type"].Value.ToString();
                    txtName_Type.Text = dgvLoaiTB.CurrentRow.Cells["Name_Type"].Value.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dgvLoaiTB_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtId_Type.Clear();
            txtName_Type.Clear();
            ShowDLLoaiTB();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (checkNullTextBox() == false)
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                Object.ObjTypeDevice objTypeDevice = new Object.ObjTypeDevice();
                SetDataTypeDevice(objTypeDevice);

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (TypeDeviceCtrl.Update(objTypeDevice) > 0)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowDLLoaiTB();
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Id Customer hoặc Id Group không tồn tại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SetDataTypeDevice(Object.ObjTypeDevice objType)
        {
            objType.Id_Type = Convert.ToDouble(txtId_Type.Text);
            objType.Name_Type = txtName_Type.Text;
        }

        private bool checkNullTextBox()
        {
            if (txtId_Type.Text.Trim() == "")
            {
                errIdType.SetError(txtId_Type, "Nhập vào mã loại thiết bị");
                return false;
            }
            if (txtName_Type.Text.Trim() == "")
            {
                errNameType.SetError(txtName_Type, "Nhập vào tên loại thiết bị");
                return false;
            }
            else
            {
                errIdType.SetError(txtId_Type, "");
                errNameType.SetError(txtName_Type, "");
                return true;
            }
        }

        //Hàm hiển thị thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            AddNewTypeDevice addNewTypeDevice = new AddNewTypeDevice();
            addNewTypeDevice.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!checkNullTextBox())
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                string id_Type = dgvLoaiTB.CurrentRow.Cells["Id_Type"].Value.ToString();

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    //delete in table customer detail
                    if (TypeDeviceCtrl.Xoa(Convert.ToInt32(id_Type)) != -9999)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowDLLoaiTB();
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thông tin người dùng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            if (rdbName_Type.Checked)
            {
                tieuchi = "Name_Type";
                if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                {
                    TypeDeviceCtrl.HienThiNguoiDung(dgvLoaiTB, txtTimKiem.Text, tieuchi);
                }
            }
            else if (rdbId_Type.Checked)
            {
                tieuchi = "Id_Type";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        TypeDeviceCtrl.HienThiNguoiDung(dgvLoaiTB, txtTimKiem.Text, tieuchi);
                    }
                }
                else
                {
                    text = "Vui lòng nhập vào một số nếu tìm kiếm theo id!";
                    ThongBao(text);
                }
            }
            else
            {
                text = "Vui lòng chọn loại tìm kiếm!";
                ThongBao(text);
            }
        }
    }
}
