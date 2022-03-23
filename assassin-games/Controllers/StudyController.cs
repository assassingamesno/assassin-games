using assassingames_backend.DTOs.Mappers;
using assassingames_backend.Models;
using assassingames_backend.Models.DTOs;
using assassingames_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Controllers
{
    [ApiController]
    [Route("api/Studies")]
    public class StudyController: Controller
    {
        private readonly IStudyService _studyService;
        public StudyController(IStudyService studyService)
        {
            _studyService = studyService;
        }
        [HttpGet]
        public IActionResult GetStudies()
        {
            IEnumerable<Study> studies = _studyService.GetStudies();
            return Ok(StudyMapper.GetStudies(studies));
        }
        [HttpGet("{studyId}")]
        public IActionResult GetStudy(Guid studyId)
        {
            Study study = _studyService.GetStudy(studyId);
            return study == null ? NotFound() : Ok(StudyMapper.GetStudy(study));
        }
        [HttpPost]
        public IActionResult InsertStudy([FromBody] Study study)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _studyService.InsertStudy(study);
            return Created("~api/Study/"+study.StudyId.ToString(), study);
        }
        [HttpPut]
        public IActionResult UpdateStudy([FromBody]Study study)
        {
            _studyService.UpdateStudy(study);
            return Ok();
        }
        [HttpDelete("{studyId}")]
        public IActionResult DeleteStudy(Guid studyId)
        {
            _studyService.DeleteStudy(studyId);
            return Ok();
        }
    }
}
