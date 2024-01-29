using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final2023.Models;

namespace Final2023.Data
{
    public class Final2023Context : DbContext
    {
        public Final2023Context (DbContextOptions<Final2023Context> options)
            : base(options)
        {
        }

        public DbSet<Final2023.Models.Department> Department { get; set; } = default!;
        public DbSet<Final2023.Models.Employee> Employee { get; set; } = default!;
    }
}
