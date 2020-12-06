using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Object
{
    class ObjDevice
    {
        public ObjectId _id { get; set; }

        private double _idDevice;

        public double Id_Device
        {
            get { return _idDevice; }
            set { _idDevice = value; }
        }

        public string Name_Device { get; set; }

        private double _price;

        public double Price_Device
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _functionDevice;

        public string Function_Device
        {
            get { return _functionDevice; }
            set { _functionDevice = value; }
        }

        private double _idType;

        public double Id_Type
        {
            get { return _idType; }
            set { _idType = value; }
        }

        private string _nameType;

        public string Name_Type
        {
            get { return _nameType; }
            set { _nameType = value; }
        }

        private string _room;

        public string Room
        {
            get { return _room; }
            set { _room = value; }
        }


        private string _statusDevice;

        public string Status_Device
        {
            get { return _statusDevice; }
            set { _statusDevice = value; }
        }
    }
}
