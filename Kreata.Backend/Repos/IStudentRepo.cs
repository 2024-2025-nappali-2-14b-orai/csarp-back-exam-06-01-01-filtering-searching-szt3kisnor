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
        public Task<int> GetNumberOfStudnet();
    }
}
