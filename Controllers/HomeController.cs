using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMVC.Models;

namespace MyMVC.Controllers;
public class HomeController : Controller
{
    public IActionResult ProductList()
    {
        List<String> products = new()
        { 
            "iPhone 15 Pro Max", 
            "MacBook Air M3", 
            "Apple Watch Series 9", 
            "AirPods Pro 2" 
        };
        ViewBag.Products = products;
        return View();
    }
}
