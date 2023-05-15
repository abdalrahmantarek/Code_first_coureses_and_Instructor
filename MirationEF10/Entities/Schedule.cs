using MirationEF10.Entities;

namespace MirationEF10.Data.Config
{
    public class Schedule
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public bool SUN { get; set; }

        public bool MON { get; set; }

        public bool TUS { get; set; }

        public bool WEN { get; set; }

        public bool THU { get; set; }

        public bool FRI { get; set; }

        public bool SAT { get; set; }
        public ICollection<Section> Sections { get; set;}=new List<Section>();
        public ICollection<SectionSchedule> SectionSchedules { get; set; } = new List<SectionSchedule>();

    }
    
}
