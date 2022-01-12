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
    }
}
