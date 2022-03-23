using assassingames_backend.DbContexts;
using assassingames_backend.Models;
using assassingames_backend.Repositories.Interfaces;
using assassingames_backend.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Services
{
    public class StudyService : IStudyService
    {
        private readonly IStudyRepository _studyRepository;
        public StudyService(IStudyRepository studyRepository)
        {
            _studyRepository = studyRepository;
        }
        public void DeleteStudy(Guid studyId)
        {
            _studyRepository.DeleteStudy(studyId);
        }

        public Study GetStudy(Guid studyId)
        {
            return _studyRepository.GetStudy(studyId);
        }

        public IEnumerable<Study> GetStudies()
        {
            return _studyRepository.GetStudies();
        }

        public void InsertStudy(Study study)
        {
            _studyRepository.InsertStudy(study);
        }

        public void UpdateStudy(Study study)
        {
            _studyRepository.UpdateStudy(study);
        }
    }
}
