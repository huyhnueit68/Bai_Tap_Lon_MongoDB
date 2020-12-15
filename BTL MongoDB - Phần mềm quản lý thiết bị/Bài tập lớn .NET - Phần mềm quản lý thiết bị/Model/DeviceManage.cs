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
    class DeviceManage
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataDevice(string idCustomer)
        {
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand("SELECT * FROM Device");
            return cls.LayDuLieu(sqlcmd);
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataDevice(Login.getIdCustomerLogin()).Tables[0];
        }

        public int Xoa(string id)
        {
            //check status
            Object.ObjDevice objDevice = new Object.ObjDevice();
            var client1 = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db1 = client1.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection1 = db1.GetCollection<Object.ObjDevice>("Device"); //truy cập collection
            var query1 = Builders<Object.ObjDevice>.Filter.Eq("Id_Device", id);
            var result1 = collection1.Find(query1).ToList();
            objDevice = result1[0];
            if(objDevice.Status_Device == "Đang sử dụng")
            {
                return 0;
            }

            Object.ObjDevice update = new Object.ObjDevice();
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjDevice>("Device"); //truy cập collection
            var Filter = Builders<Object.ObjDevice>.Filter.Eq("Id_Device", id);
            collection.DeleteMany(Filter);
            return 1;
        }

        public int Update(Object.ObjDevice objDevice)
        {
            //validate id type and get name
            Object.ObjTypeDevice typeDevice = new Object.ObjTypeDevice();
            try
            {
                var client1 = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
                var db1 = client1.GetDatabase("QuanLyThietBi"); //truy cập vào database
                var collection1 = db1.GetCollection<Object.ObjTypeDevice>("Type_Device"); //truy cập collection
                var query1 = Builders<Object.ObjTypeDevice>.Filter.Eq("Id_Type", objDevice.Id_Type);
                var result1 = collection1.Find(query1).ToList();
                typeDevice = result1[0];
                if(typeDevice != null)
                {
                    //update database for devices
                    var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
                    var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
                    var collection = db.GetCollection<Object.ObjDevice>("Device"); //truy cập collection book
                    var Filter = Builders<Object.ObjDevice>.Filter.Eq("Id_Device", objDevice.Id_Device);
                    var arrayUpdate = Builders<Object.ObjDevice>.Update.
                        Set("Name_Device", objDevice.Name_Device).
                        Set("Price_Device", objDevice.Price_Device).
                        Set("Function_Device", objDevice.Function_Device).
                        Set("Id_Type", objDevice.Id_Type).
                        Set("Name_Type", typeDevice.Name_Type).
                        Set("Room", objDevice.Room).
                        Set("Status_Device", objDevice.Status_Device);
                    collection.UpdateOne(Filter, arrayUpdate);
                    return 1;
                }
            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
            return 0;
        }

        public int Save(Object.ObjDevice objDevice)
        {
            //get name type
            Object.ObjTypeDevice typeDevice = new Object.ObjTypeDevice();
            var client1 = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db1 = client1.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection1 = db1.GetCollection<Object.ObjTypeDevice>("Type_Device"); //truy cập collection
            var query1 = Builders<Object.ObjTypeDevice>.Filter.Eq("Id_Type", objDevice.Id_Type);
            var result1 = collection1.Find(query1).ToList();
            typeDevice = result1[0];
            //save data to device
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjDevice>("Device"); //truy cập collection book
            Object.ObjDevice insert = new Object.ObjDevice();
            insert.Id_Device = objDevice.Id_Device;
            insert.Name_Device = objDevice.Name_Device;
            insert.Price_Device = objDevice.Price_Device;
            insert.Function_Device = objDevice.Function_Device;
            insert.Id_Type = objDevice.Id_Type;
            insert.Name_Type = typeDevice.Name_Type;
            insert.Room = objDevice.Room;
            insert.Status_Device = objDevice.Status_Device;
            collection.InsertOne(insert);
            return 1;
        }

        public DataGridView getListDevice(string key, string tieuchi)
        {
            /*Mã Thiết Bị
            Tên Thiết Bị
            Mã Loại Thiết Bị
            Phòng Học*/

            DataGridView dataGrid = new DataGridView();
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjDevice>("Device"); //truy cập collection
            List<Object.ObjDevice> result;
            FilterDefinition<Object.ObjDevice> query;
            switch (tieuchi)
            {
                case "Id_Device":
                    {
                        query = Builders<Object.ObjDevice>.Filter.Eq("Id_Device", key);
                        break;
                    }
                case "Name_Device":
                    {
                        query = Builders<Object.ObjDevice>.Filter.Eq("Name_Device", key);
                        break;
                    }
                case "Id_Type":
                    {
                        query = Builders<Object.ObjDevice>.Filter.Eq("Id_Type", key);
                        break;
                    }
                default:
                    {
                        query = Builders<Object.ObjDevice>.Filter.Eq("Room", key);
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
