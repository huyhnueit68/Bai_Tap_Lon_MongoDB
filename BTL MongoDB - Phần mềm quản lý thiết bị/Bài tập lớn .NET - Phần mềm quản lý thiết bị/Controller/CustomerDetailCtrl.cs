using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Controller
{
    class CustomerDetailCtrl
    {
        Model.CustomerManage customerDetailMng = new Model.CustomerManage();
        HelperData.DataConfig helperData = new HelperData.DataConfig();

        public int Xoa(string id)
        {
            return customerDetailMng.Xoa(id);
        }

        public void HienThi(DataGridView dgv, string id_customer)
        {
            dgv.DataSource = customerDetailMng.GetDataCustomer(id_customer).Tables[0];
        }

        public int Update(Object.ObjCustomer customer)
        {
            return customerDetailMng.Update(customer);
        }

        public int Them(Object.ObjCustomer custome)
        {
            if (!KTMaNguoiDung(Convert.ToInt32(custome.Id_Customer)))
                return 0;
            if (!KTMaNhom(Convert.ToInt32(custome.Id_Group)))
                return 2;
            return customerDetailMng.Save(custome);
        }

        public bool KTMaNguoiDung(int id)
        {
            try
            {
                var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
                var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
                var collection = db.GetCollection<Object.ObjCustomer>("Customer"); //truy cập collection
                var query = Builders<Object.ObjCustomer>.Filter.Eq("Id_Customer", id);
                var result = collection.Find(query).ToList();
                if(result.Count > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Mã tài khoản: " + e.Message);
                return false;
            }

        }

        public bool KTMaNhom(int id)
        {
            try
            {
                var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
                var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
                var collection = db.GetCollection<Object.ObjCustomerGroup>("Group_Customer"); //truy cập collection
                var query = Builders<Object.ObjCustomerGroup>.Filter.Eq("Id_Group", id);
                var result = collection.Find(query).ToList();
                MessageBox.Show("ma ton tai la: " + result.Count.ToString());
                if (result.Count <= 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Mã nhóm: " + e.Message);
                return false;
            }
        }

        public void HienThiNguoiDung(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = customerDetailMng.getListCustomerDetail(tukhoa, tieuchi).DataSource;
        }
    }
}
