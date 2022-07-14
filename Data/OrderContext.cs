using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
        }
    }
}
