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
    public partial class AddNewCustomerDetail : Form
    {
        public static string text = "";
        Controller.CustomerDetailCtrl customerDetailCtrl = new Controller.CustomerDetailCtrl();
        public AddNewCustomerDetail()
        {
            InitializeComponent();
            txtBirthday_Customer.Enabled = false;
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            Object.ObjCustomer customer = new Object.ObjCustomer();
            if (checkNullItem())
            {
                GanDuLieu(customer);
                {
                    switch (customerDetailCtrl.Them(customer))
                    {
                        case 0:
                            text = "Vui lòng chọn mã người dùng khác!";
                            ThongBao(text);
                            break;
                        case 1:
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LamMoi();
                            break;
                        case 2:
                            text = "Vui lòng chọn mã nhóm khác!";
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

        private bool checkNullItem()
        {
            if (txtAddress_Customer.Text == "" || txtBirthday_Customer.Text == "" || txtGrender_Customer.Text == "" || txtId_Customer.Text == "" || txtId_Group.Text == "" || txtName_Customer.Text == "")
            {
                return false;
            }
            else return true;
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
            txtId_Customer.Clear();
            txtName_Customer.Clear();
            txtAddress_Customer.Clear();
            txtGrender_Customer.Clear();
            txtBirthday_Customer.Clear();
            txtId_Group.Clear();
            txtUserName_Customer.Clear();
            txtPassWord_Customer.Clear();
        }

        private void Id_Customer_TextChanged(object sender, EventArgs e)
        {

        }

        private void mntNgaySinh_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtBirthday_Customer.Text = mntBirthdayDay.SelectionStart.ToShortDateString();
            mntBirthdayDay.Visible = false;
        }

        private void btnNgaySinh_Click(object sender, EventArgs e)
        {
            mntBirthdayDay.Visible = true;
        }

        //Hàm xử lý lưu dữ liệu.
        private void GanDuLieu(Object.ObjCustomer customer)
        {
            customer.Id_Customer = Convert.ToDouble(txtId_Customer.Text.Trim());
            customer.UserName_Customer = txtUserName_Customer.Text.Trim();
            customer.PassWord_Customer = txtPassWord_Customer.Text.Trim();
            customer.Name_Customer = txtName_Customer.Text.Trim();
            customer.Address_Customer = txtAddress_Customer.Text.Trim();
            customer.Grender_Customer = txtGrender_Customer.Text.Trim();
            customer.Birthday_Customer = Convert.ToDateTime( txtBirthday_Customer.Text.Trim());
            customer.Id_Group = Convert.ToDouble(txtId_Group.Text.Trim());
        }

        //Hàm xử lý thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LamMoi()
        {
            txtId_Customer.Clear();
            txtName_Customer.Clear();
            txtAddress_Customer.Clear();
            txtGrender_Customer.Clear();
            txtBirthday_Customer.Clear();
            txtId_Group.Clear();
            txtUserName_Customer.Clear();
            txtPassWord_Customer.Clear();
        }

        private void txtId_Customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdentity_Card_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtId_Group_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddNewCustomerDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnDuPhu_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtBirthday_Customer.Text = mntBirthdayDay.SelectionStart.ToShortDateString();
            mntBirthdayDay.Visible = false;
        }
    }
}
