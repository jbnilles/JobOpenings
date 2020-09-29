using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobOpeningsController : Controller
  {
    [HttpGet("/JobOpenings")]
    public ActionResult Index()
    {
      List<JobOpening> jobs = JobOpening.GetAll();
      return View(jobs);
    }

    [HttpGet("/JobOpenings/Form")]
    public ActionResult Form()
    {
      return View();
    }

    [HttpPost("/JobOpenings")]
    public ActionResult Create(string title, string description, string name, string email, string phoneNumber)
    {
      Contact contact = new Contact(name, email, phoneNumber);
      JobOpening job = new JobOpening(title, description, contact);

      return RedirectToAction("Index");
    }

    [HttpGet("/JobOpenings/Delete")]
    public ActionResult Delete()
    {
      JobOpening.ClearAll();

      return RedirectToAction("Index");
    }
  }
}