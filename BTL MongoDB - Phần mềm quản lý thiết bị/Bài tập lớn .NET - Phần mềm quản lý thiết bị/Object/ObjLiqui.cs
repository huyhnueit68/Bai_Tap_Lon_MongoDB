using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Object
{
    class ObjLiqui
    {
        public ObjectId _id { get; set; }
        public double Id_Liqui { get; set; }
        public string Name_Liqui { get; set; }
        public DateTime Date_Liqui { get; set; }
        public double Id_Device { get; set; }
        public string Name_Device { get; set; }
        public string Room { get; set; }
        public double Id_Type { get; set; }
    }
}
