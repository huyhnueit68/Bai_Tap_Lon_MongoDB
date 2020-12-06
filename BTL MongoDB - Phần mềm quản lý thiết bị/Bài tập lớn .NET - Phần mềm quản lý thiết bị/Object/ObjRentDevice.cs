using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Object
{
    class ObjRentDevice
    {
        public ObjectId _id { get; set; }

        private double _idRent;

        public double Id_Rent
        {
            get { return _idRent; }
            set { _idRent = value; }
        }

        private DateTime _dayRent;

        public DateTime Date_Rent
        {
            get { return _dayRent; }
            set { _dayRent = value; }
        }

        private DateTime _dayPay;

        public DateTime Date_Pay
        {
            get { return _dayPay; }
            set { _dayPay = value; }
        }

        private double _idDevice;

        public double Id_Device
        {
            get { return _idDevice; }
            set { _idDevice = value; }
        }

        public string Name_Device { get; set; }
        public string Room { get; set; }
        public double Id_Type { get; set; }
        public string Status_Device { get; set; }
        public double Id_Customer { get; set; }
        public string Name_Customer { get; set; }
        public double Id_Group { get; set; }
    }
}
