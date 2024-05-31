using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinoEF.Domain.Entities;
using TreinoEF.Infra.Repositories.Interfaces;

namespace TreinoEF.Infra.Repositories
{
    public class SchoolRepository : BaseRepository<SchoolEntity, ISchoolRepository>
    {
        public SchoolRepository(TreinoEFContext context) 
            : base(context)
        {
        }

        public async Task<SchoolEntity> LicensePlate(SchoolEntity licensePlate)
        {
            return await Task.FromResult(licensePlate);
        }
    }
}
