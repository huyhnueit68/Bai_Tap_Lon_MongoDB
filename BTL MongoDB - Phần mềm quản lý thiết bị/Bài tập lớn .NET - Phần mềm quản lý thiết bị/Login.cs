using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị
{
    public partial class Login : Form
    {

        public static int resultLogin = -1;
        public static string nameLogin = "Unknown";
        public static string idCustomerLogin = "NULL";
        public static string user = "NULL";
        public static string pass = "NULL";


        //connection database
        SqlConnection connect = ConnectDatabase.connect;

        //connection database

        public Login()
        {
            InitializeComponent();
        }

        private void lbmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbexit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                this.Close();
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            txtUserName.Clear();
        }

        private void txtPassWord_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassWord.Clear();
        }

        private void getMainControl()
        {
            MainControl mainMenu = new MainControl();
            mainMenu.Show();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            //query data
            user = txtUserName.Text.Trim();
            pass = txtPassWord.Text.Trim();
            //action get database
            Object.ObjCustomer item = new Object.ObjCustomer();
            try
            {
                var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
                var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
                var collection = db.GetCollection<Object.ObjCustomer>("Customer"); //truy cập collection
                var query = Builders<Object.ObjCustomer>.Filter.Eq("UserName_Customer", txtUserName.Text) & Builders<Object.ObjCustomer>.Filter.Eq("PassWord_Customer", txtPassWord.Text);
                var result = collection.Find(query).ToList();
                item = result[0];
            }
            catch (Exception ce)
            {
                MessageBox.Show(ce.Message);
            }
           
            // check database
            if (rdbAdmin.Checked)
            {
                try
                {

                    if (item.Id_Group.ToString() == "1")
                    {
                        nameLogin = item.Name_Customer.Trim();
                        resultLogin = 1;
                        getMainControl();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!\nKiểm tra lại quyền đăng nhập!");
                    }
                }
                catch (Exception ce)
                {
                    MessageBox.Show("Lỗi !\n" + ce.Message);
                }
            }
            else
            {
                try
                {
                    if (item.Id_Group.ToString() != "1")
                    {
                        nameLogin = item.Name_Customer.ToString();
                        resultLogin = 0;
                        getMainControl();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!\nKiểm tra lại quyền đăng nhập!");
                    }
                }
                catch (Exception ce)
                {
                    MessageBox.Show(ce.Message);
                }
            }
        }

        public static string getIdCustomerLogin()
        {
            //query data
            try
            {
                Object.ObjCustomer item = new Object.ObjCustomer();
                var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
                var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
                var collection = db.GetCollection<Object.ObjCustomer>("Customer"); //truy cập collection
                var query = Builders<Object.ObjCustomer>.Filter.Eq("UserName_Customer", user) & Builders<Object.ObjCustomer>.Filter.Eq("PassWord_Customer", pass);
                var result = collection.Find(query).ToList();
                item = result[0];
                return item.Id_Customer.ToString();
            }
            catch
            {
                return "NULL";
            }
            
        }
    }
}
