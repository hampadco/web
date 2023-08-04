using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using minimal.Models;

namespace minimal.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        
        return View();
    }

    public IActionResult Html()
    {
        // TODO: Your code here
        return View();
    }
    

    
}
