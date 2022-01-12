using EFMVC.Context;
using EFMVC.Models;
using EFMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EFMVC.Controllers
{
    public class SubjectController : Controller
    {
        ISubjectServices iss;
        public SubjectController(ISubjectServices _iss)
        {
            iss = _iss;
        }
        public IActionResult Index()
        {
           
            return View(iss.GetAllSubjects());
        }
        public IActionResult Delete(int id )
        {
            iss.DeleteASubject(id);
            return RedirectToAction("Index");
        }
       
        public IActionResult Details(int id)
        {
            return View(iss.GetSingleSubject(   id)); 
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(iss.GetSingleSubject(id));
        }

        [HttpPost]
        public IActionResult Edit(Subject subject)
        {
            iss.UpdateSubject(subject);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Subject()); 

        }
        [HttpPost]
        public IActionResult Create(Subject subject)
        {
            iss.CreateSubject(subject);
            return RedirectToAction("Index"); 
        }
    }
}
