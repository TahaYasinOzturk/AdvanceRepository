using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AdvanceRepository.Models.Data
{
    public class Context : DbContext
    {
        // birden fazla ctor olursa base olan ctoru belirtmek icin " : base(op) " yapıyoruz default belirtiyoruz. yada birden fazla db varsada olur amac default ı belirtmek.
        public Context(DbContextOptions<Context> op) : base(op)
        {
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }

        //public Context(int a) gibi
        //{

        //}

    }
}
