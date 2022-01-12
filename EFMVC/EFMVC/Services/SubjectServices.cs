using EFMVC.Context;
using EFMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFMVC.Services
{
    public class SubjectServices : ISubjectServices
    {
        MVCContext db;
        public SubjectServices(MVCContext _db)
        {
            db = _db;
        }

        public void CreateSubject(Subject subject)
        {
            db.Attach(subject);
            db.Entry(subject).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            db.SaveChanges();
        }

        public void DeleteASubject(int id)
        {
            Subject subject = db.Subjects.FirstOrDefault(s => s.SubjectId == id);
            if (subject != null)
            {
                db.Remove(subject);
                db.SaveChanges();
            }
        }
 
        public IEnumerable<Subject> GetAllSubjects()
        {
            IEnumerable<Subject> subjects = db.Subjects.Select(s => s).ToList();
            return subjects;
        }
      
        public Subject GetSingleSubject(int id)
        {
            Subject subject = db.Subjects.Where(s => s.SubjectId == id).FirstOrDefault();
            return subject; 
        }
    
        public void UpdateSubject(Subject subject)
        {
            db.Attach(subject);
            db.Entry(subject).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges(); 
        }
    }
}
