using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWork.Models;
using MyWork.Models.Products;

namespace MyWork.Controllers
{
  public class ProductsController : Controller
  {

    ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
      if (!ModelState.IsValid)
      {
          return View("Index");
          // return RedirectToAction("Index");
      }
      
      return View();
    }

    [HttpPost]
    public IActionResult Info(IndexViewModel model)
    { 

      return View(model);

    }

    public IActionResult ViewProducts()
    {
      var data = new  Product();
      data.Name = "Book";
      data.Detail = "MVC";
      data.Price = 150.50;

      return View(data);
    }
  }
}