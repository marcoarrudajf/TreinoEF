using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TreinoEF.Domain.Entities;

namespace TreinoEF.Infra.Mapper
{
    public class StudentMapper : IEntityTypeConfiguration<StudentEntity>
    {
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            builder
                 .ToTable("TB_STUDENT")
                 .HasKey(x => x.Id);
        }
    }
}
