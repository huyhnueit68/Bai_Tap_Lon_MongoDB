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
    class RentDeviceCtrl
    {
        Model.RentDeviceManage rentDeviceMng = new Model.RentDeviceManage();
        HelperData.DataConfig helperData = new HelperData.DataConfig();

        public int Update(Object.ObjRentDevice rentDevice)
        {
            return rentDeviceMng.Update(rentDevice);
        }

        public int UpdatePay(Object.ObjRentDevice rentDevice)
        {
            return rentDeviceMng.UpdatePay(rentDevice);
        }

        //Hàm xử lý hiển thị thiết bị lên combox.
        public void HienThiCbbThietBi(ComboBox cbo)
        {
            cbo.DataSource = rentDeviceMng.LayDSThietBi().DataSource;
            cbo.DisplayMember = "Name_Device";
            cbo.ValueMember = "Id_Device";
        }

        public int Them(Object.ObjRentDevice rentDevice)
        {
            if (!KTMaThietBi(Convert.ToInt32(rentDevice.Id_Device)))
                return 3;
            if (!KTMaMuon(Convert.ToInt32(rentDevice.Id_Rent)))
                return 0;
            if (Login.resultLogin == 1)
            {
                if (!KTMaNguoiDung(Convert.ToInt32(rentDevice.Id_Customer)))
                    return 2;
            }
            return rentDeviceMng.Save(rentDevice);
        }

        public bool KTMaThietBi(int id)
        {
            try
            {
                var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
                var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
                var collection = db.GetCollection<Object.ObjDevice>("Device"); //truy cập collection
                var query = Builders<Object.ObjDevice>.Filter.Eq("Id_Device", id);
                var result = collection.Find(query).ToList();

                if (result.Count <= 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Mã thiết bị: " + e.Message);
                return false;
            }

        }

        public bool KTMaMuon(int id)
        {
            try
            {
                var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
                var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
                var collection = db.GetCollection<Object.ObjRentDevice>("Rent_Device"); //truy cập collection
                var query = Builders<Object.ObjRentDevice>.Filter.Eq("Id_Rent", id);
                var result = collection.Find(query).ToList();

                if (result.Count > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Mã thiết bị: " + e.Message);
                return false;
            }

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
                if (result.Count <= 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Mã người dùng: " + e.Message);
                return false;
            }
        }

        public void HienThiMuonTra(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = rentDeviceMng.getListRent(tukhoa, tieuchi).DataSource;
        }
    }
}
