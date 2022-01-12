using EFMFC_Basic.Context;
using EFMFC_Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFMFC_Basic.Controllers
{
    public class SubjectController : Controller
    {
        MVCContext db;
        public SubjectController(MVCContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            IEnumerable<Subject> subjects = db.Subjects.Select(s => s).ToList(); 
            return View(subjects);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Subject()); 
        }
        [HttpPost]
        public IActionResult Create(Subject subject)
        {
            db.Attach(subject);
            db.Entry(subject).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Index"); 
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(db.Subjects.Where(s=> s.SubjectId == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult Edit(Subject subject)
        {
            db.Attach(subject);
            db.Entry(subject).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            return View(db.Subjects.Where(s => s.SubjectId == id).FirstOrDefault());
        }
        public IActionResult Delete(int id)
        {
            Subject subject = db.Subjects.FirstOrDefault(s => s.SubjectId == id);
            if(subject != null)
            {
                db.Remove(subject);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
