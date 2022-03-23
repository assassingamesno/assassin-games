using assassingames_backend.Models;
using assassingames_backend.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.DTOs.Mappers
{
    public static class StudyMapper
    {
        public static IEnumerable<StudyDTO> GetStudies(IEnumerable<Study> studies)
        {
            IEnumerable<StudyDTO> studyDTOs = studies.Select(study =>
            new StudyDTO()
            {
                StudyId = study.StudyId,
                StudyName = study.StudyName,
                Campus = study.Campus,
                University = study.University
            });
            return studyDTOs;
        }
        public static StudyDTO GetStudy(Study study)
        {
            StudyDTO studyDTO = new()
            {
                StudyId = study.StudyId,
                StudyName = study.StudyName,
                Campus = study.Campus,
                University = study.University
            };
            return studyDTO;
        }
    }
}
