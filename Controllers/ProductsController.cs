using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Entities;
using MVC.Models.Products;
using MyWork.Models;

namespace MVC.Controllers
{
    public class ProductsController : Controller
    {

        ILogger<ProductsController> _logger;
        CustomerContext _customerContext;
        public ProductsController(ILogger<ProductsController> logger, CustomerContext customerContext)
        {
          
            _logger = logger;
            _customerContext = customerContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Info(IndexViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
                // return RedirectToAction("Index");
            }
          
            var customer = new Customer();
            customer.FirstName = model.FirstName;
            customer.LastName = model.LastName;
            customer.Age = model.Age;
            customer.Address = model.Address;
            customer.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            _customerContext.Customers.Add(customer);
            _customerContext.SaveChanges();

            return View(model);
        }

        public IActionResult ViewProducts()
        {
            var data = new Product();
            data.Name = "Book";
            data.Detail = "MVC";
            data.Price = 150.50;

            return View(data);
        }
    }
}