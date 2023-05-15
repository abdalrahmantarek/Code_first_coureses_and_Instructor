using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MirationEF10.Entities;

namespace MirationEF10.Data.Config
{
    public class Officefig : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.OfficeName)
                .HasColumnType("VARCHAR").HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.OfficeLocation).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();

            builder.ToTable("Offices");

            builder.HasData(LoadData());

        }

        private List<Office> LoadData()
        {
            return new List<Office>()
            {
                new Office{ Id = 1, OfficeName = "CS",OfficeLocation = "Building A" },

                new Office { Id = 2, OfficeName = "IT",OfficeLocation = "Building B" },

                new Office { Id = 3, OfficeName = "SE",OfficeLocation = "Building C" },

                new Office { Id = 4, OfficeName = "IS",OfficeLocation = "Building D" },

                new Office { Id = 5, OfficeName = "IS",OfficeLocation = "Building E" },
            };
        }
    }
}
