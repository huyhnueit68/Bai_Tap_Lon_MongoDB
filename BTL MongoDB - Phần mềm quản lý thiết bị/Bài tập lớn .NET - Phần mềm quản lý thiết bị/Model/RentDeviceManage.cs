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
    class RentDeviceManage
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataRentDevice(string idCustomer)
        {
            SqlCommand sqlcmd;
            if (cls.CheckStatusLogin() == true)
            {
                sqlcmd = new SqlCommand("SELECT * FROM Rent_Device");
            }
            else
            {
                sqlcmd = new SqlCommand("SELECT * FROM Rent_Device WHERE Id_Customer  = " + Login.getIdCustomerLogin() + "");
            }
            return cls.LayDuLieu(sqlcmd);
        }

        public DataSet GetDataRentDevicePay(string idCustomer)
        {
            SqlCommand sqlcmd;
            if (cls.CheckStatusLogin() == true)
            {
                sqlcmd = new SqlCommand("SELECT * FROM Rent_Device WHERE Status_Rent = N'Đang sử dụng'");
            }
            else
            {
                sqlcmd = new SqlCommand("SELECT * FROM Rent_Device WHERE Status_Rent = N'Đang sử dụng'AND Id_Customer  = " + Login.getIdCustomerLogin() + "");
            }
            return cls.LayDuLieu(sqlcmd);
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataRentDevice(Login.getIdCustomerLogin()).Tables[0];
        }

        public void HienThiTra(DataGridView dgv)
        {
            dgv.DataSource = GetDataRentDevicePay(Login.getIdCustomerLogin()).Tables[0];
        }

        public int Update(Object.ObjRentDevice objRentDevice)
        {
            Object.ObjRentDevice update = new Object.ObjRentDevice();
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjRentDevice>("Rent_Device"); //truy cập collection book
            var Filter = Builders<Object.ObjRentDevice>.Filter.Eq("Id_Rent", objRentDevice.Id_Rent);
            var arrayUpdate = Builders<Object.ObjRentDevice>.Update.
                Set("Date_Rent", objRentDevice.Date_Rent).
                Set("Date_Pay", objRentDevice.Date_Pay);
            collection.UpdateOne(Filter, arrayUpdate);
            return 1;
        }

        public int UpdatePay(Object.ObjRentDevice objRentDevice)
        {
            //update database for devices
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection1 = db.GetCollection<Object.ObjDevice>("Device"); //truy cập collection book
            var Filter1 = Builders<Object.ObjDevice>.Filter.Eq("Id_Device", objRentDevice.Id_Device);
            var arrayUpdate1 = Builders<Object.ObjDevice>.Update.
                Set("Status_Device", "Không sử dụng");
            collection1.UpdateOne(Filter1, arrayUpdate1);
            //update status for rent device
            var collection = db.GetCollection<Object.ObjRentDevice>("Rent_Device"); //truy cập collection book
            var Filter = Builders<Object.ObjRentDevice>.Filter.Eq("Id_Rent", objRentDevice.Id_Rent);
            var arrayUpdate = Builders<Object.ObjRentDevice>.Update.
                Set("Status_Device", "Không sử dụng");
            collection.UpdateOne(Filter, arrayUpdate);
            return 1;
        }

        public void UpdateStatusDevicePay(Object.ObjRentDevice objRentDevice)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Device SET Status_Device = N'Không sử dụng' WHERE Id_Device = @idDevice; ";
            cmd.Parameters.Add("idDevice", SqlDbType.Int).Value = objRentDevice.Id_Device;
            cls.CapNhatDL(cmd);
        }

        //Hàm xử lý lấy danh sách.
        public DataGridView LayDSThietBi()
        {
            DataGridView dataGrid = new DataGridView();
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjDevice>("Device"); //truy cập collection
            List<Object.ObjDevice> result;
            FilterDefinition<Object.ObjDevice> query;
            query = Builders<Object.ObjDevice>.Filter.Eq("Status_Device", "Không sử dụng");
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

        public int Save(Object.ObjRentDevice cdt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Rent_Device(Date_Rent, Date_Pay, Id_Device, Qty_Device, Id_Customer, Status_Rent) " +
                "VALUES (@dateRent, @datePay, @idDevice, @qtyDevice, @idCustomer, N'Đang sử dụng'); ";

            cmd.Parameters.Add("dateRent", SqlDbType.DateTime).Value = cdt.Date_Rent;
            cmd.Parameters.Add("datePay", SqlDbType.DateTime).Value = cdt.Date_Pay;
            cmd.Parameters.Add("idDevice", SqlDbType.Int).Value = cdt.Id_Device;
            cmd.Parameters.Add("idCustomer", SqlDbType.Int).Value = cdt.Id_Customer;
            UpdateStatusDevice(cdt);
            return cls.CapNhatDL(cmd);
        }

        public void UpdateStatusDevice(Object.ObjRentDevice cdt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Device SET Status_Device = N'Đang sử dụng' WHERE Id_Device = @idDevice; ";
            cmd.Parameters.Add("idDevice", SqlDbType.Int).Value = cdt.Id_Device;
            cls.CapNhatDL(cmd);
        }

        public DataSet getListRent(string key, string tieuchi)
        {
            string sql = "SELECT * FROM Rent_Device WHERE ";

            if (Login.resultLogin != 1) {
                sql += "Id_Customer = " + Login.getIdCustomerLogin() + " AND ";
            }

            switch (tieuchi)
            {
                case "Id_Rent":
                    sql += "Id_Rent = " + key + "";
                    break;
                default:
                    sql += "Id_Device = " + key + "";
                    break;
            }
            try
            {
                SqlCommand sqlcmd = new SqlCommand(sql);
                return cls.LayDuLieu(sqlcmd);
            }
            catch (Exception ce)
            {
                MessageBox.Show("Null " + ce.Message);
                return null;
            }

        }
    }
}
