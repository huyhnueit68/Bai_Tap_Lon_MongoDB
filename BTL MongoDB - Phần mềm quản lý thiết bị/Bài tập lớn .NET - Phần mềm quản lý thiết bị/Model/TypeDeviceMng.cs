using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using System.Windows;
using System.Windows.Forms;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Model
{
    class TypeDeviceMng
    {
        public int Update(Object.ObjTypeDevice objType)
        {
            //validate id type and get name
            Object.ObjTypeDevice typeDevice = new Object.ObjTypeDevice();
            //update database for devices
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjTypeDevice>("Type_Device"); //truy cập collection book
            var Filter = Builders<Object.ObjTypeDevice>.Filter.Eq("Id_Type", objType.Id_Type);
            var arrayUpdate = Builders<Object.ObjTypeDevice>.Update.
                Set("Name_Type", objType.Name_Type);
            collection.UpdateOne(Filter, arrayUpdate);
            return 1;
        }
        public int Save(Object.ObjTypeDevice objType)
        {
            //get name type
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjTypeDevice>("Type_Device"); //truy cập collection book
            Object.ObjTypeDevice insert = new Object.ObjTypeDevice();
            insert.Id_Type = objType.Id_Type;
            insert.Name_Type = objType.Name_Type;
            collection.InsertOne(insert);
            return 1;
        }

        public int Xoa(int id)
        {
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjTypeDevice>("Type_Device"); //truy cập collection book
            var Filter = Builders<Object.ObjTypeDevice>.Filter.Eq("Id_Type", id);
            collection.DeleteMany(Filter);
            return 1;
        }

        public DataGridView getListCustomerDetail(string key, string tieuchi)
        {
            DataGridView dataGrid = new DataGridView();
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjTypeDevice>("Type_Device"); //truy cập collection
            List<Object.ObjTypeDevice> result;
            FilterDefinition<Object.ObjTypeDevice> query;
            switch (tieuchi)
            {
                case "Id_Type":
                    {
                        query = Builders<Object.ObjTypeDevice>.Filter.Eq("Id_Type", key);
                        break;
                    }
                default:
                    {
                        query = Builders<Object.ObjTypeDevice>.Filter.Eq("Name_Type", key);
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
                return null;
            }
        }
    }
}
