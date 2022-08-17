using BusinessDomain.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Database
{
    public class SeedingDataBase<T> : IDatabaseInitializer<BookingDBContext>
    {

        public void InitializeDatabase(BookingDBContext context)
        {
            context = new BookingDBContext();
            var directorates = new List<Directorate>

        {
            new Directorate { Id=1, Name = "Abhimanyu K Vatsa",},
            new Directorate { Id=2, Name = "Deepak Kumar Gupta" },
            new Directorate {  Id=3,Name = "Manish Kumar" },
            new Directorate { Id=4, Name = "Rohit Ranjan" },
            new Directorate { Id=5, Name = "Shivam" }
        };

            context.Directorates.AddRange(directorates);
            context.SaveChanges();



        }
    }
}
