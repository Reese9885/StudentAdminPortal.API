using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentsController(IStudentRepository _studentRepository, IMapper _mapper)
        {
            studentRepository = _studentRepository;
            mapper = _mapper;
            
        }


        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudent()
        {
            var students = await studentRepository.GetStudents();
            return Ok(mapper.Map<List<Student>>(students));
            
        }
    }
}
