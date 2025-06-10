using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarminhaFrufruOps.Models;

namespace CarminhaFrufruOps.Data
{
    public class CarminhaFrufruOpsContext : DbContext
    {
        public CarminhaFrufruOpsContext (DbContextOptions<CarminhaFrufruOpsContext> options)
            : base(options)
        {
        }

        public DbSet<CarminhaFrufruOps.Models.Produtos> Produtos { get; set; } = default!;
    }
}
