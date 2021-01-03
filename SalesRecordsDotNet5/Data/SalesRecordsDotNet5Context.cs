using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesRecordsDotNet5.Models;

namespace SalesRecordsDotNet5.Data
{
    public class SalesRecordsDotNet5Context : DbContext
    {
        public SalesRecordsDotNet5Context (DbContextOptions<SalesRecordsDotNet5Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
    }
}
