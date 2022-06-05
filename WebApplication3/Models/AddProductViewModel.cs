using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class AddProductViewModel
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int SupplierID { get; set; }

        public int CategoryID { get; set; }

        public string QuantiyPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitInStock { get; set; }

        public int UnitOnOrder { get; set; }

        public int ReoderLevel { get; set; }

        public bool DisContinue { get; set; }

        public List<SelectListItem> selectListItemsDataCatrgory { get; set; }


        public List<SelectListItem> selectListItemsDataSupplier { get; set; }
    }
}