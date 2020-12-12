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

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Controller
{
    class TypeDeviceCtrl
    {
        Model.TypeDeviceMng TypeDeviceMng = new Model.TypeDeviceMng();
        public int Update(Object.ObjTypeDevice objTypeDevice)
        {
            return TypeDeviceMng.Update(objTypeDevice);
        }

        public int Them(Object.ObjTypeDevice objTypeDevice)
        {
            if (!KiemTraMaLoaiTB(Convert.ToInt32(objTypeDevice.Id_Type)))
                return 0;
            if (!KiemTraTenLoaiTB(objTypeDevice.Name_Type))
                return 2;
            return TypeDeviceMng.Save(objTypeDevice);
        }

        public bool KiemTraMaLoaiTB(int id)
        {
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjTypeDevice>("Type_Device"); //truy cập collection
            var query = Builders<Object.ObjTypeDevice>.Filter.Eq("Id_Type", id);
            var result = collection.Find(query).ToList();
            if (result.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool KiemTraTenLoaiTB(string name)
        {
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjTypeDevice>("Type_Device"); //truy cập collection
            var query = Builders<Object.ObjTypeDevice>.Filter.Eq("Name_Type", name);
            var result = collection.Find(query).ToList();
            if (result.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Xoa(int id)
        {
            return TypeDeviceMng.Xoa(id);
        }

        public void HienThiNguoiDung(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = TypeDeviceMng.getListCustomerDetail(tukhoa, tieuchi).DataSource;
        }
    }
}
