using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinoEF.Domain.Entities;
using TreinoEF.Infra.Repositories.Interfaces;

namespace TreinoEF.Infra.Repositories
{
    public class StudentRepository : BaseRepository<StudentEntity, IStudentRepository>
    {
        public StudentRepository(TreinoEFContext context) 
            : base(context)
        {             
        }
        public async Task<StudentEntity> LicensePlate(StudentEntity licensePlate)
        {
            return await Task.FromResult(licensePlate);
        }
    }
}
