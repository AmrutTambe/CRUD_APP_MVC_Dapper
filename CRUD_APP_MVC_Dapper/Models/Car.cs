using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_APP_MVC_Dapper.Models
{
    public class Car
    {
        public int ID {get;set;}
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }

    }
}