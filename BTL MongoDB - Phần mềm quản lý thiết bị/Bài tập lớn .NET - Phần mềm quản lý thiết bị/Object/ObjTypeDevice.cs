﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Object
{
    class ObjTypeDevice
    {
        public ObjectId _id { get; set; }
        public double Id_Type { get; set; }
        public string Name_Type { get; set; }
    }
}
