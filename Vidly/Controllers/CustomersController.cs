using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }
        public ActionResult Details(int id)
        {
            
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerIndividualViewModel
            {
                OneCustomer = customer           
            };

            return View("CustomerIndividual", viewModel);

        }

        

        
    }
}








// GET: Customers
//            public ActionResult CustomersView()
//            {
//                public List<Customer> Customers { get; set; }

//            var customers = new List<Customer>
//                {
//                    new Customer {Name = "John Smith", Id = "1"},
//                    new Customer {Name = "Mary Williams", Id = "2"}

//            };
//            return View();
//            }
            
            
//        }

//}
