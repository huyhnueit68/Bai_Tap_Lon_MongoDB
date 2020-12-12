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
    public partial class QuanLyNguoiDung : Form
    {
        public static string text = "";
        Model.CustomerManage CustomerManage = new Model.CustomerManage();
        Controller.CustomerDetailCtrl cutomerDetailCtrl = new Controller.CustomerDetailCtrl();

        public QuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            if(Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThemTK.Enabled = false;
                btnTimKiem.Enabled = false;
            }
            ShowDLNguoiDung();
            HienThiThongTin();
            txtId_Customer.Enabled = false;
            txtBirthday_Customer.Enabled = false;
            txtUserName_Customer.Enabled = false;
        }

        //Hàm xử lý load dữ liệu từ dgv lên các text.
        private void HienThiThongTin()
        {
            if (dgvDSChiTietNguoiDung.CurrentRow != null)
            {
                txtId_Customer.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["Id_Customer"].Value.ToString();
                txtUserName_Customer.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["UserName_Customer"].Value.ToString();
                txtPassWord_Customer.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["PassWord_Customer"].Value.ToString();
                txtName_Customer.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["Name_Customer"].Value.ToString();
                txtAddress_Customer.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["Address_Customer"].Value.ToString();
                txtGender_Customer.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["Grender_Customer"].Value.ToString();
                txtBirthday_Customer.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["Birthday_Customer"].Value.ToString();
                txtId_Group.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["Id_Group"].Value.ToString();
            }
        }

        private void dgvDSTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ShowDLNguoiDung();
            txtId_Customer.Clear();
            txtName_Customer.Clear();
            txtAddress_Customer.Clear();
            txtGender_Customer.Clear();
            txtBirthday_Customer.Clear();
            txtId_Group.Clear();
            txtUserName_Customer.Clear();
            txtPassWord_Customer.Clear();
        }

        private void mntNgaySinh_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtBirthday_Customer.Text = mntNgaySinh.SelectionStart.ToShortDateString();
            mntNgaySinh.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mntNgaySinh.Visible = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (checkNullTextBox() == false)
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                Object.ObjCustomer objCustomer = new Object.ObjCustomer();
                SetDataCustomerDetail(objCustomer);

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (cutomerDetailCtrl.Update(objCustomer) > 0)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowDLNguoiDung();
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Id Customer hoặc Id Group không tồn tại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!checkNullTextBox())
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                string id_customer = dgvDSChiTietNguoiDung.CurrentRow.Cells["Id_Customer"].Value.ToString();

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    //delete in table customer detail
                    if (cutomerDetailCtrl.Xoa(id_customer) != -9999)
                    {

                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowDLNguoiDung();
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thông tin người dùng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool checkNullTextBox()
        {
            if (txtId_Customer.Text.Trim() == "")
            {
                errId_Customer.SetError(txtId_Customer, "Nhập vào mã người dùng");
                return false;
            }
            if (txtName_Customer.Text.Trim() == "")
            {
                errName.SetError(txtName_Customer, "Nhập vào tên người dùng");
                return false;
            }
            if (txtAddress_Customer.Text.Trim() == "")
            {
                errAddress_Customer.SetError(txtAddress_Customer, "Nhập vào địa chỉ người dùng");
                return false;
            }
            if (txtGender_Customer.Text.Trim() == "")
            {
                errorGrender.SetError(txtGender_Customer, "Nhập vào giới tính người dùng");
                return false;
            }
            if (txtBirthday_Customer.Text.Trim() == "")
            {
                errorBirthday_Customer.SetError(txtBirthday_Customer, "Nhập vào ngày sinh người dùng");
                return false;
            }
            if(txtUserName_Customer.Text.Trim() == "")
            {
                errUser.SetError(txtUserName_Customer, "Nhập vào tên đăng nhập");
                return false;
            }
            if (txtPassWord_Customer.Text.Trim() == "")
            {
                errPass.SetError(txtPassWord_Customer, "Nhập mật khẩu");
                return false;
            }
            else
            {
                errId_Customer.SetError(txtId_Customer, "");
                errName.SetError(txtName_Customer, "");
                errAddress_Customer.SetError(txtAddress_Customer, "");
                errorGrender.SetError(txtGender_Customer, "");
                errorBirthday_Customer.SetError(txtBirthday_Customer, "");
                errorId_Group.SetError(txtId_Group, "");
                errUser.SetError(txtUserName_Customer, "");
                errPass.SetError(txtPassWord_Customer, "");
                return true;
            }
        }

        private void SetDataCustomerDetail(Object.ObjCustomer objCustomer)
        {
            objCustomer.Id_Customer = Convert.ToDouble(txtId_Customer.Text);
            objCustomer.UserName_Customer = txtUserName_Customer.Text;
            objCustomer.PassWord_Customer = txtPassWord_Customer.Text;
            objCustomer.Name_Customer = txtName_Customer.Text;
            objCustomer.Address_Customer = txtAddress_Customer.Text;
            objCustomer.Grender_Customer = txtGender_Customer.Text;
            objCustomer.Birthday_Customer = Convert.ToDateTime(txtBirthday_Customer.Text);
            objCustomer.Id_Group = Convert.ToDouble(txtId_Group.Text);
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            View.AddNewCustomerDetail addNewCustomerDetail = new AddNewCustomerDetail();
            addNewCustomerDetail.Show();
            ShowDLNguoiDung();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            if (rdbName_Customer.Checked)
            {
                tieuchi = "Name_Customer";
                if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                {
                    cutomerDetailCtrl.HienThiNguoiDung(dgvDSChiTietNguoiDung, txtTimKiem.Text, tieuchi);
                }
            }
            else if (rdbId_Customer.Checked)
            {
                tieuchi = "Id_Customer";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        cutomerDetailCtrl.HienThiNguoiDung(dgvDSChiTietNguoiDung, txtTimKiem.Text, tieuchi);
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

        private void ShowDLNguoiDung()
        {
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjCustomer>("Customer"); //truy cập collection
            if(Login.resultLogin == 1)
            {
                var result = collection.AsQueryable<Object.ObjCustomer>().ToList();
                dgvDSChiTietNguoiDung.DataSource = result;
            }
            else
            {
                var query = Builders<Object.ObjCustomer>.Filter.Eq("UserName_Customer", Login.user) & Builders<Object.ObjCustomer>.Filter.Eq("PassWord_Customer", Login.pass);
                var result = collection.Find(query).ToList();
                dgvDSChiTietNguoiDung.DataSource = result;
            }

        }
        //Hàm hiển thị thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mntNgaySinh_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            txtBirthday_Customer.Text = mntNgaySinh.SelectionStart.ToShortDateString();
            mntNgaySinh.Visible = false;
        }
    }
}
