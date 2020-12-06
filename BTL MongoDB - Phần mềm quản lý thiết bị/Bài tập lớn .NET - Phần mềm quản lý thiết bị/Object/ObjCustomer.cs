using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Object
{
    class ObjCustomer
    {
        
        public ObjectId _id { get; set; }

        private double _idCustomer;

        public double Id_Customer
        {
            get { return _idCustomer; }
            set { _idCustomer = value; }
        }

        private string _usernameCustomer;

        public string UserName_Customer
        {
            get { return _usernameCustomer; }
            set { _usernameCustomer = value; }
        }

        private string _passCustomer;

        public string PassWord_Customer
        {
            get { return _passCustomer; }
            set { _passCustomer = value; }
        }

        private string _nameCustomer;

        public string Name_Customer
        {
            get { return _nameCustomer; }
            set { _nameCustomer = value; }
        }

        private string _addressCustomer;

        public string Address_Customer
        {
            get { return _addressCustomer; }
            set { _addressCustomer = value; }
        }
        private string _grenderCustomer;

        public string Grender_Customer
        {
            get { return _grenderCustomer; }
            set { _grenderCustomer = value; }
        }
        private DateTime _birthdayCustomer;

        public DateTime Birthday_Customer
        {
            get { return _birthdayCustomer; }
            set { _birthdayCustomer = value; }
        }
        
        private double _idGroup;

        public double Id_Group
        {
            get { return _idGroup; }
            set { _idGroup = value; }
        }
    }
}
