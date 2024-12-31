using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class ProduktController : Controller
{
    static Dictionary<int, Produkt> _produkts = new Dictionary<int, Produkt>();
    
    public IActionResult Index()
    {
        return View(_produkts);
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Produkt model)
    {
        int id = _produkts.Keys.Count != 0 ? _produkts.Keys.Max() : 0;
        model.Id = id + 1;
        _produkts.Add(model.Id, model);
        return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
        if (_produkts.ContainsKey(id))
        {
            return View(_produkts[id]);
        }  
        return NotFound();
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        if (_produkts.ContainsKey(id))
        {
            return View(_produkts[id]);
        } 
        return NotFound();
    }

    [HttpPost]
    public IActionResult Edit(int id, Produkt model)
    {
        if (_produkts.ContainsKey(id))
        {
            _produkts[id] = model;
            return RedirectToAction("Index");
        }
        return NotFound();
    }

    public IActionResult Delete(int id)
    {
        if (_produkts.ContainsKey(id))
        {
            _produkts.Remove(id);
        }
        return RedirectToAction("Index");
    }
}