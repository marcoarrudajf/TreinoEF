using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoEF.Domain.Entities
{
    public class SchoolEntity
    {
        [Key]
        public int SchoolId { get; set; }   
        public string? SchoolName { get; set; }
        public string? Description { get; set; }

        public virtual DirectorEntity Director { get; set; }

        public virtual StudentEntity Student { get; set; }

    }
}
