
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Momias.Models
{
    //seed data just to test the website
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();
            if (context.People.Count() == 0)
            {
                context.People.AddRange(
                new Person
                {
                    FirstName = "Devan",
                    LastName = "Alder",
                    Profession = "Researcher"

                },
                new Person
                {
                    FirstName = "Salamander",
                    LastName = "Morachi",
                    Profession = "Homie"
                });
                context.SaveChanges();
            }
        }
    }
}
