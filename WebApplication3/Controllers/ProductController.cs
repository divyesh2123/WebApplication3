using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<ProductViewModel> products = new List<ProductViewModel>();   
            using (NorthwindEntities1 northwind = new NorthwindEntities1())
            {

                products = northwind.Products.
                ToList().Select(y => new ProductViewModel
                {
                    ProductName = y.ProductName,
                    Stock = y.UnitsInStock.Value,
                    UnitPrice = y.UnitPrice.Value

                }).ToList() ;



            }
                return View(products);
        }

        public ActionResult CreateProduct()
        {
           AddProductViewModel product = new AddProductViewModel();

            using (NorthwindEntities1 northwind = new NorthwindEntities1())
            {

                product.selectListItemsDataCatrgory =
                 northwind.Categories.ToList().Select(y => new SelectListItem
                {
                    Text = y.CategoryName,
                    Value = y.CategoryID.ToString()


                }).ToList();


                product.selectListItemsDataSupplier = northwind.Suppliers.ToList().Select(
                        y => new SelectListItem
                        {
Text   = y.CompanyName,
Value = y.SupplierID.ToString()


                        }


                    ).ToList();


            }

                return View(product);
        }

        [HttpPost]
        public ActionResult CreateProduct(AddProductViewModel addProductViewModel)
        {
            Product product = new Product();
            using (NorthwindEntities1 northwind = new NorthwindEntities1())
            {
                product.SupplierID = addProductViewModel.SupplierID;
                product.ProductName = addProductViewModel.ProductName;
                product.CategoryID = addProductViewModel.CategoryID;
                product.QuantityPerUnit = addProductViewModel.QuantiyPerUnit;
                product.UnitPrice = addProductViewModel.UnitPrice;
                product.Discontinued = addProductViewModel.DisContinue;
                product.UnitsInStock = (short)addProductViewModel.UnitInStock;

                northwind.Products.Add(product);
                northwind.SaveChanges();


            }

                return RedirectToAction("Index");

        }
    }
}