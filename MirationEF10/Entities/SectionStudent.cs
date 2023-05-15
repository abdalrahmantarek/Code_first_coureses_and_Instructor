using MirationEF10.Entities;

namespace MirationEF10.Data.Config
{
    public class SectionStudent
    {
        
        public int SectionId { get; set; }

        public int StudentId { get; set; }

        public Section Section { get; set; } = null!;

        public Student Student { get; set; } = null!;
    }

}
