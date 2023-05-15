using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MirationEF10.Data.Config
{
    public class SectionStudentConfig : IEntityTypeConfiguration<SectionStudent>
    {
        public void Configure(EntityTypeBuilder<SectionStudent> builder)
        {
            builder.HasKey(x => new {  x.SectionId, x.StudentId });
          builder.ToTable("SectionStudents");
            builder.HasData(LodData());

        }

        private static List<SectionStudent> LodData()
        {
            return new List<SectionStudent>()
            {
               
            };
        }
    }

}
