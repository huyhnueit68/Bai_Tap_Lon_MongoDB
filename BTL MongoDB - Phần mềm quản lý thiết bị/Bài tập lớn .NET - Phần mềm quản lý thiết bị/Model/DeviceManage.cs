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
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Device WHERE Id_Device = @id";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(id);
            return cls.CapNhatDL(cmd);
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
                MessageBox.Show(typeDevice.ToString());
                if(typeDevice != null)
                {
                    //update database for devices
                    Object.ObjDevice update = new Object.ObjDevice();
                    var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
                    var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
                    var collection = db.GetCollection<Object.ObjDevice>("Device"); //truy cập collection book
                    var Filter = Builders<Object.ObjDevice>.Filter.Eq("Id_Device", update.Id_Device);
                    var arrayUpdate = Builders<Object.ObjDevice>.Update.
                        Set("Name_Deivce", update.Name_Device).
                        Set("Price_Device", update.Price_Device).
                        Set("Function_Device", update.Function_Device).
                        Set("Id_Type", update.Id_Type).
                        Set("Name_Type", update.Name_Type).
                        Set("Room", update.Room).
                        Set("Status_Device", update.Status_Device);
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
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Device(Name_Device, Price, ,Qty_Device, Function_Device, Room, Id_Type, Status_Device) " +
                "VALUES (@nameDevice, @price, @qtyDevice,@function, @room, @idType, @status);";

            cmd.Parameters.Add("nameDevice", SqlDbType.NVarChar).Value = objDevice.Name_Device;
            cmd.Parameters.Add("price", SqlDbType.NVarChar).Value = objDevice.Price_Device;
            cmd.Parameters.Add("function", SqlDbType.NVarChar).Value = objDevice.Function_Device;
            cmd.Parameters.Add("room", SqlDbType.NVarChar).Value = objDevice.Room;
            cmd.Parameters.Add("idType", SqlDbType.NVarChar).Value = objDevice.Id_Type;
            cmd.Parameters.Add("status", SqlDbType.NVarChar).Value = objDevice.Status_Device;

            return cls.CapNhatDL(cmd);
        }

        public DataSet getListDevice(string key, string tieuchi)
        {
            string sql = "SELECT * FROM Device WHERE ";

            switch (tieuchi)
            {
                case "Id_Device":
                    sql += "Id_Device = " + key + "";
                    break;
                case "Name_Device":
                    sql += "Name_Device like '%" + key + "%'";
                    break;
                case "Room":
                    sql += "Room like '%" + key + "%'";
                    break;
                default:
                    sql += "Id_Type = " + key + "";
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
