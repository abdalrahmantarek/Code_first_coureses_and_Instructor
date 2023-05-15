using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MirationEF10.Entities;


namespace MirationEF10.Data.Config
{
    public class InstructorConfg : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x=>x.FName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            builder.Property(x => x.LName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            builder.ToTable("Instructors");
            builder.HasOne(x => x.Office)
                .WithOne(e => e.Instructor)
                .HasForeignKey<Instructor>(x => x.OfficeId).IsRequired(false);
            builder.HasData(LoadData());


        }

        private List<Instructor> LoadData()
        {
            return new List<Instructor> {
            new Instructor { Id = 1,FName="Yassmin", LName="Abdullah",OfficeId=1},
            new Instructor { Id = 2,FName="YassminL",LName= "mohammed",OfficeId=2},
            new Instructor { Id = 3,FName="Khaled",LName= "Ahmed", OfficeId = 3},
            new Instructor { Id = 4,FName="Sayed", LName= "Mahros", OfficeId = 4},
            new Instructor { Id = 5,FName="Abdo", LName= "Tarek", OfficeId = 5},
            };

        }
    }
}
