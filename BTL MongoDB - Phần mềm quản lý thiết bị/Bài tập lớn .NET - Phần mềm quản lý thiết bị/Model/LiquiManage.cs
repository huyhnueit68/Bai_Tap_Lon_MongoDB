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
    class LiquiManage
    {
        DataConfig cls = new DataConfig();

        public void HienThi(DataGridView dgv)
        {
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjLiqui>("Liquidate"); //truy cập collection book
            var result = collection.AsQueryable<Object.ObjLiqui>().ToList();
            dgv.DataSource = result;
        }


        public int Xoa(string id)
        {
            Object.ObjDevice delete = new Object.ObjDevice();
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjLiqui>("Liquidate"); //truy cập collection
            var Filter = Builders<Object.ObjLiqui>.Filter.Eq("Id_Liqui", id);
            collection.DeleteMany(Filter);
            return 1;
        }

        public DataGridView GetDataLiqui(string idCustomer)
        {
            DataGridView dgv = new DataGridView();
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjLiqui>("Liquidate"); //truy cập collection book
            var result = collection.AsQueryable<Object.ObjLiqui>().ToList();
            dgv.DataSource = result;
            return dgv;
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

        public int Save(Object.ObjLiqui cdt)
        {
            //get name device, room and type
            Object.ObjDevice item1 = new Object.ObjDevice();
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database

            Object.ObjDevice item2 = new Object.ObjDevice();
            var collection2 = db.GetCollection<Object.ObjDevice>("Device"); //truy cập collection
            var query2 = Builders<Object.ObjDevice>.Filter.Eq("Id_Device", cdt.Id_Device);
            var result2 = collection2.Find(query2).ToList();
            item2 = result2[0];
            //set value and save for rent device
            var collection = db.GetCollection<Object.ObjLiqui>("Liquidate"); //truy cập collection
            Object.ObjLiqui insert = new Object.ObjLiqui();

            insert.Id_Liqui = cdt.Id_Liqui;
            insert.Name_Liqui = cdt.Name_Liqui;
            insert.Date_Liqui = cdt.Date_Liqui;
            insert.Id_Device = cdt.Id_Device;
            insert.Name_Device = item2.Name_Device;
            insert.Room = item2.Room;
            insert.Id_Type = item2.Id_Type;
            collection.InsertOne(insert);

            //delete colelction device when liquidate
            var Filter = Builders<Object.ObjDevice>.Filter.Eq("Id_Device", cdt.Id_Device);
            collection2.DeleteMany(Filter);
            return 1;
        }

        public void UpdateStatusDevice(Object.ObjLiqui cdt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Device SET Status_Device = N'Thanh Lý' WHERE Id_Device = @idDevice; ";
            cmd.Parameters.Add("idDevice", SqlDbType.Int).Value = cdt.Id_Device;
            cls.CapNhatDL(cmd);
        }

        public int Update(Object.ObjLiqui objLiqui)
        {
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjLiqui>("Liquidate"); //truy cập collection book
            var Filter = Builders<Object.ObjLiqui>.Filter.Eq("Id_Liqui", objLiqui.Id_Liqui);
            var arrayUpdate = Builders<Object.ObjLiqui>.Update.
                Set("Name_Liqui", objLiqui.Name_Liqui).
                Set("Date_Liqui", objLiqui.Date_Liqui.ToString());
            collection.UpdateOne(Filter, arrayUpdate);
            return 1;
        }

        public DataGridView getListLiqui(string key, string tieuchi)
        {
            DataGridView dataGrid = new DataGridView();
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjLiqui>("Liquidate"); //truy cập collection
            List<Object.ObjLiqui> result;
            FilterDefinition<Object.ObjLiqui> query;
            switch (tieuchi)
            {
                case "Id_Liqui":
                    {
                        query = Builders<Object.ObjLiqui>.Filter.Eq("Id_Liqui", key);
                        break;
                    }
                default:
                    {
                        query = Builders<Object.ObjLiqui>.Filter.Eq("Name_Liqui", key);
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
