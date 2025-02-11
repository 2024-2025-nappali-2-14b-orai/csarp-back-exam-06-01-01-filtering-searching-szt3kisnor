using Kreata.Backend.Repos.Base;
using Kreta.Shared.Enums;
using Kreta.Shared.Models;
using System.Security.Cryptography.X509Certificates;

namespace Kreata.Backend.Repos
{
    public interface IStudentRepo : IBaseRepo<Student>
    {
        public Task<Student> GetByNameAsync(string firstName, string lastName);
        public Task<List<Student>> GetStudentByClass(int schoolYear, SchoolClassType schoolClassType);
        public Task<int> GetNumberOfStudnetAsync();
        public Task<int> GetNumberOfWomanAsync();
        public Task<int> GetNumberOfManAsync();
        public Task<int> GetNumberOfStudnetsBornIn2021Async();
        public Task<int> GetNumberOfStudnetsBornInAprilAsync();
        public Task<int> GetNumberOfStudentByYearAsync(int year);
        public Task<int> GetNumberOfStudentByYearAndMonthAsync(int year, int month);
    }
}
