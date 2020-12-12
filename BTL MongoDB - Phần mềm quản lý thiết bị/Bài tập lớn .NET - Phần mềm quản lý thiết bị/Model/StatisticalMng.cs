using Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.HelperData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using System.Windows.Forms;
using Microsoft.Build.Framework.XamlTypes;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Model
{
    class StatisticalMng
    {
        DataConfig cls = new DataConfig();

        public int HTTongTBDung()
        {
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjDevice>("Device"); //truy cập collection
            var query = Builders<Object.ObjDevice>.Filter.Eq("Status_Device","Đang sử dụng");
            var result = collection.Find(query).ToList();
            return result.Count;
        }

        public int HTTongThanhLy()
        {
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjLiqui>("Liquidate"); //truy cập collection
            var result = collection.AsQueryable<Object.ObjLiqui>().ToList();
            return result.Count;
        }

        public DataGridView getListDeviceByTime(DateTime start, DateTime end)
        {
            DataGridView dgv = new DataGridView();
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjRentDevice>("Rent_Device"); //truy cập collection
            var query = Builders<Object.ObjRentDevice>.Filter.Gte("Date_Rent", start) & Builders<Object.ObjRentDevice>.Filter.Lte("Date_Pay", end);
            var result = collection.Find(query).ToList();
            dgv.DataSource = result;
            return dgv;
        }

        public DataGridView getListDeviceByName(string name)
        {
            DataGridView dataGrid = new DataGridView();
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjRentDevice>("Rent_Device"); //truy cập collection
            List<Object.ObjRentDevice> result;
            FilterDefinition<Object.ObjRentDevice> query;
            query = Builders<Object.ObjRentDevice>.Filter.Eq("Name_Customer", name);
            result = collection.Find(query).ToList();
            dataGrid.DataSource = result;
            return dataGrid;

        }

        public DataGridView getDeviceToChar()
        {
            DataGridView dgv = new DataGridView();

            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjThongKe>("Liquidate"); //truy cập collection
            var query = new BsonDocument[] {
                new BsonDocument{
                    {
                        "$group", new BsonDocument {
                            { "_id", "$Date_Liqui" },
                            { "Total", new BsonDocument { { "$sum", 1 } } },
                        }
                    }
                },
                new BsonDocument{
                    {
                        "$project", new BsonDocument {
                            { "Total", 1}
                        }
                    }
                }
            };
            var result = collection.Aggregate<Object.ObjThongKe>(query).ToList();
            dgv.DataSource = result;
            return dgv;
        }
    }
}
