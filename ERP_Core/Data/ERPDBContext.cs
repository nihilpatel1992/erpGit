using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ERP_Core.Models;

namespace ERP_Core.Models
{
    public class ERPDBContext : DbContext
    {
        public ERPDBContext (DbContextOptions<ERPDBContext> options)
            : base(options)
        {
        }

        public DbSet<ERP_Core.Models.Department> Department { get; set; }

        public DbSet<ERP_Core.Models.Employee> Employee { get; set; }
    }
}
