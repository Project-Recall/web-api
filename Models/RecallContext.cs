using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace recall_web.Models
{
    public class RecallContext : DbContext
    {
        public RecallContext(DbContextOptions<RecallContext> options) : base(options) 
        { }

        public DbSet<User> Users { get; set; }
    }
}