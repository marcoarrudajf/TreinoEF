using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoEF.Domain.Entities
{
    public class DirectorEntity
    {
        [Key]
        public int DirectorId { get; set; }
        public string? DirectorName { get; set; }
        public string? TaxId { get; set; }
        public string? CellPhone{ get; set;}
        public virtual SchoolEntity School { get; set; }

    }
}
