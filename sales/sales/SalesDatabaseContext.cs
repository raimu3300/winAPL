using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace sales
{
    class SalesDatabaseContext : DbContext
    {
        public DbSet<Result> Results { get; set; }
    }
}
