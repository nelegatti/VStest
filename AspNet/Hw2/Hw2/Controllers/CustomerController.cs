using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hw2.Models;

namespace Hw2.Controllers
{
    public class CustomerController : Controller 
    {
        List<Customer> Customers = new List<Customer>();

        public CustomerController()
        {
            Customer obj1 = new Customer();
            obj1.nombre = " Martin";
            obj1.apellido = " Sansone";
            obj1.edad = 11;
            Customers.Add(obj1);

            Customer obj2 = new Customer();
            obj2.nombre = " Orlando";
            obj2.apellido = " Ramos";
            obj2.edad = 12;
            Customers.Add(obj2);
        }
        [HttpGet]
        public ViewResult DisplayCustomer(int edad)
        {
            Customer objCustomer = Customers[edad];
            return View("DisplayCustomer", objCustomer);
        }
        /*public ViewResult DisplayCustomer()
        {
            Customer cs = new Models.Customer();
            cs.nombre = "Ricardo";
            cs.apellido = "Herrera";
            cs.edad = 30;
            return View("DisplayCustomer", cs);
        }*/
        public ViewResult DisplayCustomer(Customer cs)
        {
            /*Customer cs = new Customer();
                            cs.nombre = Request.Form["nombre"].ToString();
                cs.apellido = Request.Form["apellido"].ToString();
                cs.edad = int.Parse(Request.Form["edad"].ToString());
                return View("DisplayCustomer", cs);
            }
            */
            return View(cs);
        }

        public ActionResult Index()
        {
            return View();
                 }
        public ActionResult FillCustomer()  
        {
            return View();
        }
    }
}