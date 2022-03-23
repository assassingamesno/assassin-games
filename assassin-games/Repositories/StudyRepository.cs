using assassingames_backend.DbContexts;
using assassingames_backend.Models;
using assassingames_backend.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Repositories
{
    public class StudyRepository : IStudyRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public StudyRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void DeleteStudy(Guid studyId)
        {
            Study study = _applicationDbContext.Studies.Find(studyId);
            _applicationDbContext.Studies.Remove(study);
            _applicationDbContext.SaveChanges();
        }

        public Study GetStudy(Guid studyId)
        {
            return _applicationDbContext.Studies.Find(studyId);
        }

        public IEnumerable<Study> GetStudies()
        {
            return _applicationDbContext.Studies;
        }

        public void InsertStudy(Study study)
        {
            _applicationDbContext.Studies.Add(study);
            _applicationDbContext.SaveChanges();
        }

        public void UpdateStudy(Study study)
        {
            _applicationDbContext.Studies.Update(study);
            _applicationDbContext.SaveChanges();
        }
    }
}
