using System.Collections.Generic;
using Vueling.Domain.Entities;
using Vueling.Infraestructure.Repository.Contracts;

namespace Vueling.Infraestructure.Repository.Implementations
{
    public class StudentRepository : IRepository<Student>
    {
        public Student Create(Student model)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Student> ReadAll()
        {
            throw new System.NotImplementedException();
        }

        public Student Update(Student model)
        {
            throw new System.NotImplementedException();
        }
    }
}
