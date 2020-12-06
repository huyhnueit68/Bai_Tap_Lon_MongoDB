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
    class DeviceCtrl
    {
        Model.DeviceManage deviceMng = new Model.DeviceManage();
        HelperData.DataConfig helperData = new HelperData.DataConfig();

        public int Xoa(string id)
        {
            return deviceMng.Xoa(id);
        }

        public int Update(Object.ObjDevice objDevice)
        {
            return deviceMng.Update(objDevice);
        }

        public void HienThi(DataGridView dgv, string id_group)
        {
            dgv.DataSource = deviceMng.GetDataDevice(id_group).Tables[0];
        }

        public int Them(Object.ObjDevice objDevice)
        {
            if (!KiemTraMaTB(Convert.ToInt32(objDevice.Id_Device)))
                return 0;
            if (!KiemTraMaLoai(Convert.ToInt32(objDevice.Id_Type)))
                return 2;
            return deviceMng.Save(objDevice);
        }

        public bool KiemTraMaTB(int id)
        {
            try
            {
                var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
                var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
                var collection = db.GetCollection<Object.ObjDevice>("Device"); //truy cập collection
                var query = Builders<Object.ObjDevice>.Filter.Eq("Id_Device", id);
                var result = collection.Find(query).ToList();
                if(result.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }    
            }
            catch (Exception ce)
            {
                MessageBox.Show(ce.Message);
                return false;
            }
        }

        public bool KiemTraMaLoai(int id)
        {
            try
            {
                var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
                var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
                var collection = db.GetCollection<Object.ObjTypeDevice>("Type_Device"); //truy cập collection
                var query = Builders<Object.ObjTypeDevice>.Filter.Eq("Id_Type", id);
                var result = collection.Find(query).ToList();
                if (result.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ce)
            {
                MessageBox.Show(ce.Message);
                return false;
            }
        }

        public void HienThiNguoiDung(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = deviceMng.getListDevice(tukhoa, tieuchi).DataSource;

        }
    }
}
