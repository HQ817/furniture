using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Internet.Models;
using Microsoft.EntityFrameworkCore;
using Internet.Data;

namespace Internet.Controllers;

public class HomeController : Controller
{
    // private readonly ILogger<HomeController> _logger;

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }

    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
        
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Services()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    public async Task<IActionResult> Shop(string type = null)
    {
        if (string.IsNullOrWhiteSpace(type))
        {
            var allProducts = await _context.Furnitures.ToListAsync();
            return View(allProducts);
        }
        else
        {
            var filteredProducts = await _context.Furnitures
                                                .Where(p => p.Type.ToLower() == type.ToLower())
                                                .ToListAsync();
            return View(filteredProducts);
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }



}
