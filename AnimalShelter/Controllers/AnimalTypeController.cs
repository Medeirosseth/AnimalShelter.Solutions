using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Linq;


namespace AnimalShelter.Controllers
{
  public class AnimalTypeController : Controller 
  {

    private readonly AnimalShelterContext _db;
    public AnimalTypeController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<AnimalType> model = _db.Type.ToList();
      return View(model);
    }


    [HttpGet("/animal/new")]
    public ActionResult New()
    {
      return View();
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(AnimalType animaltype)
    {
      _db.Type.Add(animaltype);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
  


  }
}