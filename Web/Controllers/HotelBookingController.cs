using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;
using System.Reflection;
using Web.Models;
namespace Web.Controllers;

public class HotelBookingController : Controller
{
    private static List<HotelBooking> D = new List<HotelBooking>();
    private static int i=0;
    public IActionResult Index()   
    {
        return View(D);
        //return View();// return a view that has same name with controller
    }
    public IActionResult Create()
    {
        var DV = new HotelBooking();
        return View(DV);// return a view that has same name with controller
    } 
    public IActionResult CreateDetail(HotelBooking ViewModel)
    {
        ++i;
        ViewModel.APP_ID = i;
        //return View("Index");// return a view that has same name with controller
        D.Add(ViewModel);
        return RedirectToAction(nameof(Index));
    }
}
