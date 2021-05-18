using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;

namespace PierresBakeryMvc.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}