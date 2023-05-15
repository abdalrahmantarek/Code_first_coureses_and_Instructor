using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MirationEF10.Entities;


namespace MirationEF10.Data.Config
{
    public class StudentConfg : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.FName).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();

            builder.Property(x => x.LName).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();

            builder.ToTable("Students");
         
            builder.HasData(LoadData());


        }

        private List<Student> LoadData()
        {
            return new List<Student> {
            new Student { Id = 1,FName="Yassmin", LName="Abdullah"},
            new Student { Id = 2,FName="YassminL",LName= "mohammed"},
            new Student { Id = 3,FName="Khaled",LName= "Ahmed"},
            new Student { Id = 4,FName="Sayed", LName= "Mahros"},
            new Student { Id = 5,FName="Abdo", LName= "Tarek"},
            };  

        }
    }
}
