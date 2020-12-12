using Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.HelperData;
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

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Model
{
    class CustomerManage
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataCustomer(string idCustomer)
        {
            SqlCommand sqlcmd;
            if (cls.CheckStatusLogin() == true)
            {
                sqlcmd = new SqlCommand("SELECT * FROM Customer_Detail");
            }
            else
            {
                sqlcmd = new SqlCommand("SELECT * FROM Customer_Detail WHERE Id_Customer  = " + Login.getIdCustomerLogin() + "");
            }
            return cls.LayDuLieu(sqlcmd);
        }
        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataCustomer(Login.getIdCustomerLogin()).Tables[0];
        }

        public int Xoa(string id)
        {
            Object.ObjCustomer update = new Object.ObjCustomer();
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjCustomer>("Customer"); //truy cập collection book
            var Filter = Builders<Object.ObjCustomer>.Filter.Eq("Id_Customer", id);
            collection.DeleteMany(Filter);
            MessageBox.Show("Xóa thành công", "Thông báo");
            return 1;
        }

        public int Update(Object.ObjCustomer customer)
        {
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjCustomer>("Customer"); //truy cập collection book
            var Filter = Builders<Object.ObjCustomer>.Filter.Eq("Id_Customer", customer.Id_Customer);
            var arrayUpdate = Builders<Object.ObjCustomer>.Update.
                Set("PassWord_Customer", customer.PassWord_Customer).
                Set("Name_Customer", customer.Name_Customer).
                Set("Address_Customer", customer.Address_Customer).
                Set("Grender_Customer", customer.Grender_Customer).
                Set("Birthday_Customer", customer.Birthday_Customer).
                Set("Id_Group", customer.Id_Group);
            collection.UpdateOne(Filter, arrayUpdate);
            return 1;
        }

        public int Save(Object.ObjCustomer cdt)
        {
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjCustomer>("Customer"); //truy cập collection book
            Object.ObjCustomer insert = new Object.ObjCustomer();
            insert.Id_Customer = cdt.Id_Customer;
            insert.UserName_Customer = cdt.UserName_Customer;
            insert.PassWord_Customer = cdt.PassWord_Customer;
            insert.Name_Customer = cdt.Name_Customer;
            insert.Address_Customer = cdt.Address_Customer;
            insert.Grender_Customer = cdt.Grender_Customer;
            insert.Birthday_Customer = cdt.Birthday_Customer;
            insert.Id_Group = cdt.Id_Customer;
            collection.InsertOne(insert);
            return 1;
        }

        public DataGridView getListCustomerDetail(string key, string tieuchi)
        {
            DataGridView dataGrid = new DataGridView();
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjCustomer>("Customer"); //truy cập collection
            List<Object.ObjCustomer> result;
            FilterDefinition<Object.ObjCustomer> query;
            switch (tieuchi)
            {
                case "Id_Customer":
                    {
                        query = Builders<Object.ObjCustomer>.Filter.Eq("Id_Customer", key);
                        break;
                    }
                default:
                    {
                        query = Builders<Object.ObjCustomer>.Filter.Eq("Name_Customer", key);
                        break;
                    }
            }
            try
            {
                result = collection.Find(query).ToList();
                dataGrid.DataSource = result;
                return dataGrid;
            }
            catch (Exception ce)
            {
                MessageBox.Show("Null " + ce.Message);
                return null;
            }
        }
    }
}
