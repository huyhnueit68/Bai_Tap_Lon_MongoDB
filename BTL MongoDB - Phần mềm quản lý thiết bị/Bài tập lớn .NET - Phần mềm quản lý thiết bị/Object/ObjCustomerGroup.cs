using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Object
{
    class ObjCustomerGroup
    {
        public ObjectId _id { get; set; }

        private double _idGroup;

        public double Id_Group
        {
            get { return _idGroup; }
            set { _idGroup = value; }
        }

        private string _name;

        public string Name_Group
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
