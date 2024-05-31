using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreinoEF.Domain.Entities
{
    public class StudentEntity
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentCellPhone { get; set;}

        [ForeignKey("School")]
        public int SchoolId { get;}
        public virtual SchoolEntity School { get; set; }
    }
}
