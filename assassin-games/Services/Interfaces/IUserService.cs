using assassingames_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Services.Interfaces
{
    public interface IStudyService
    {
        public Study GetStudy(Guid studyId);
        public IEnumerable<Study> GetStudies();
        public void InsertStudy(Study study);
        public void UpdateStudy(Study study);
        public void DeleteStudy(Guid studyId);
    }
}
