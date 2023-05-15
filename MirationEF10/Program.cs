using MirationEF10.Data;

namespace MirationEF10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using (var context = new AppDbContext())
            {
                foreach (var item in context.Courses)
                {
                    Console.WriteLine(item.CourseName);
                }
            }
        }
    }
}