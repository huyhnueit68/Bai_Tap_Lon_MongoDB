using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    public partial class QLNhomNguoiDung : Form
    {
        public QLNhomNguoiDung()
        {
            InitializeComponent();
        }

        private void QLNhomNguoiDung_Load(object sender, EventArgs e)
        {
            ShowDLNguoiDung();
        }

        private void ShowDLNguoiDung()
        {
            var client = new MongoClient("mongodb://127.0.0.1/27017"); // đường dẫn đến server
            var db = client.GetDatabase("QuanLyThietBi"); //truy cập vào database
            var collection = db.GetCollection<Object.ObjCustomerGroup>("Group_Customer"); //truy cập collection
            var result = collection.AsQueryable<Object.ObjCustomerGroup>().ToList();
            dgvDSThietBi.DataSource = result;
        }
    }
}
