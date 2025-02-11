using Kreata.Backend.Controllers.Base;
using Kreata.Backend.Repos;
using Kreta.Shared.Assemblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    public partial class StudentController : BaseController<Student, StudentDto>
    {
        private IStudentRepo _studentRepo;
        public StudentController(StudentAssembler? assambler, IStudentRepo? repo) : base(assambler, repo)
        {
            _studentRepo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        [HttpGet("getstudentbyfullname")]
        public async Task<IActionResult> GetStudentByFullName([FromQuery] FullNameQueryDto fullNameDto)
        {
            return Ok(await _studentRepo.GetByNameAsync(fullNameDto.FirstName, fullNameDto.LastName));
        }

        [HttpGet("NumberOfStudnet")]
        public async Task<IActionResult> GetNumberOfStudentAsync()
        {
            return Ok(await _studentRepo.GetNumberOfStudnetAsync());
        }

        [HttpGet("NumberOfWoman")]
        public async Task<IActionResult> GetNumberOfWomanAsync()
        {
            return Ok(await _studentRepo.GetNumberOfWomanAsync());
        }

        [HttpGet("NumberOfMan")]
        public async Task<IActionResult> GetNumberIfManAsync()
        {
            return Ok(await _studentRepo.GetNumberOfManAsync());
        }

        [HttpGet("BornIn2021")]
        public async Task<IActionResult> GetNumberOfStudnetsBornIn2021Async()
        {
            return Ok(await _studentRepo.GetNumberOfStudnetsBornIn2021Async());
        }

        [HttpGet("BornInApril")]
        public async Task<IActionResult> GetNumberOfStudnetsBornInAprilAsync()
        {
            return Ok(await _studentRepo.GetNumberOfStudnetsBornInAprilAsync());
        }

        // A paraméterben kapott évszám évben született diákok száma
        [HttpGet("NumberOfStudentByYear/{year}")]
        public async Task<IActionResult> GetNumberOfStudentByYearAsync(int year)
        {
            return Ok(await _studentRepo.GetNumberOfStudentByYearAsync(year));
        }
    }
}
