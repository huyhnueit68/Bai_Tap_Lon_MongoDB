﻿using System;
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
    public partial class QuanLyThietBi : Form
    {
        public static string text = "";
        Model.DeviceManage deviceMng = new Model.DeviceManage();
        Controller.DeviceCtrl deviceCtrl = new Controller.DeviceCtrl();
        public QuanLyThietBi()
        {
            InitializeComponent();
        }

        private void QuanLyThietBi_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThemTK.Enabled = false;
                btnCapNhat.Enabled = false;
            }
            ShowDLThietBi();
            HienThiThongTin();
            txtId_Device.Enabled = false;
            txtName_Type.Enabled = false;
            txtStatus.Enabled = false;
        }

        private void ShowDLThietBi()
        {
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjDevice>("Device"); //truy cập collection
            var result = collection.AsQueryable<Object.ObjDevice>().ToList();
            dgvDSThietBi.DataSource = result; 
        }

        //Hàm xử lý load dữ liệu từ dgv lên các text.
        private void HienThiThongTin()
        {
            try
            {
                if (dgvDSThietBi.CurrentRow != null)
                {
                    txtId_Device.Text = dgvDSThietBi.CurrentRow.Cells["Id_Device"].Value.ToString();
                    txtName_Device.Text = dgvDSThietBi.CurrentRow.Cells["Name_Device"].Value.ToString();
                    txtPrice.Text = dgvDSThietBi.CurrentRow.Cells["Price_Device"].Value.ToString();
                    txtFunction_Device.Text = dgvDSThietBi.CurrentRow.Cells["Function_Device"].Value.ToString();
                    txtRoom.Text = dgvDSThietBi.CurrentRow.Cells["Room"].Value.ToString();
                    txtId_Type.Text = dgvDSThietBi.CurrentRow.Cells["Id_Type"].Value.ToString();
                    txtName_Type.Text = dgvDSThietBi.CurrentRow.Cells["Name_Type"].Value.ToString();
                    txtStatus.Text = dgvDSThietBi.CurrentRow.Cells["Status_Device"].Value.ToString();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ShowDLThietBi();
            txtId_Device.Clear();
            txtName_Device.Clear();
            txtPrice.Clear();
            txtFunction_Device.Clear();
            txtRoom.Clear();
            txtId_Type.Clear();
            txtName_Type.Clear();
            txtStatus.Clear();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (checkNullTextBox() == false)
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                Object.ObjDevice objDevice = new Object.ObjDevice();
                SetDataDevice(objDevice);

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (deviceCtrl.Update(objDevice) > 0)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowDLThietBi();
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Id Customer hoặc Id Group không tồn tại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            View.AddNewDevice addNewDevice = new View.AddNewDevice();
            addNewDevice.Show();
        }

        private void dgvDSThietBi_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private bool checkNullTextBox()
        {
            if (txtId_Device.Text.Trim() == "")
            {
                errId_Device.SetError(txtId_Device, "Nhập vào mã thiết bị");
                return false;
            }
            if (txtName_Device.Text.Trim() == "")
            {
                errName_Device.SetError(txtName_Device, "Nhập vào tên thiết bị");
                return false;
            }
            if (txtPrice.Text.Trim() == "")
            {
                errPrice.SetError(txtPrice, "Nhập vào giá thiết bị");
                return false;
            }
            if (txtFunction_Device.Text.Trim() == "")
            {
                errFunction_Group.SetError(txtFunction_Device, "Nhập vào chức năng");
                return false;
            }
            if (txtRoom.Text.Trim() == "")
            {
                errRoom.SetError(txtRoom, "Nhập vào phòng cho thiết bị");
                return false;
            }
            if (txtName_Type.Text.Trim() == "")
            {
                errId_Type.SetError(txtName_Type, "Nhập vào mã nhóm thiết bị");
                return false;
            }
            if (txtStatus.Text.Trim() == "")
            {
                errStatus_Device.SetError(txtStatus, "Nhập vào trạng thái thiết bị");
                return false;
            }
            else
            {
                errId_Device.SetError(txtId_Device, "");
                errName_Device.SetError(txtName_Device, "");
                errPrice.SetError(txtPrice, "");
                errFunction_Group.SetError(txtFunction_Device, "");
                errRoom.SetError(txtRoom, "");
                errId_Type.SetError(txtName_Type, "");
                errStatus_Device.SetError(txtStatus, "");
                return true;
            }
        }

        private void SetDataDevice(Object.ObjDevice objDevice)
        {
            objDevice.Id_Device = Convert.ToDouble(txtId_Device.Text);
            objDevice.Name_Device = txtName_Device.Text;
            objDevice.Price_Device = Convert.ToDouble(txtPrice.Text);
            objDevice.Function_Device = txtFunction_Device.Text;
            objDevice.Id_Type = Convert.ToDouble(txtId_Type.Text);
            objDevice.Name_Type = txtName_Type.Text;
            objDevice.Room = txtRoom.Text;
            objDevice.Status_Device = txtStatus.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!checkNullTextBox())
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                string id_customer = dgvDSThietBi.CurrentRow.Cells["Id_Device"].Value.ToString();

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    //delete in table customer detail
                    if (deviceCtrl.Xoa(id_customer) != -9999)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowDLThietBi();
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thông thiết bị này khi đang có người mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Hàm hiển thị thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            if (cbbLoaiTimKiem.Text.Trim() == "Tên Thiết Bị")
            {
                tieuchi = "Name_Device";
                if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                {
                    deviceCtrl.HienThiNguoiDung(dgvDSThietBi, txtTimKiem.Text, tieuchi);
                }
            }
            else if (cbbLoaiTimKiem.Text.Trim() == "Mã Loại Thiết Bị")
            {
                tieuchi = "Id_Type";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        deviceCtrl.HienThiNguoiDung(dgvDSThietBi, txtTimKiem.Text, tieuchi);
                    }
                }
                else
                {
                    text = "Vui lòng nhập vào một số nếu tìm kiếm theo id!";
                    ThongBao(text);
                }
            }
            else if (cbbLoaiTimKiem.Text.Trim() == "Mã Thiết Bị")
            {
                tieuchi = "Id_Device";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        deviceCtrl.HienThiNguoiDung(dgvDSThietBi, txtTimKiem.Text, tieuchi);
                    }
                }
                else
                {
                    text = "Vui lòng nhập vào một số nếu tìm kiếm theo id!";
                    ThongBao(text);
                }
            } else if (cbbLoaiTimKiem.Text.Trim() == "Phòng Học")
            {
                tieuchi = "Room";
                if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                {
                    deviceCtrl.HienThiNguoiDung(dgvDSThietBi, txtTimKiem.Text, tieuchi);
                }
            }
            else
            {
                text = "Vui lòng chọn loại tìm kiếm!";
                ThongBao(text);
            }
        }

        private void dgvDSThietBi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_QLTaiKhoan_Click(object sender, EventArgs e)
        {

        }
    }
}
