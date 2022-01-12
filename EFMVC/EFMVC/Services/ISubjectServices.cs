using EFMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFMVC.Services
{
    public interface ISubjectServices
    {
        public IEnumerable<Subject> GetAllSubjects();
        public void DeleteASubject(int id);
        public Subject GetSingleSubject(int id);
        
        public void UpdateSubject(Subject subject);

        public void CreateSubject(Subject subject);

    }
}
