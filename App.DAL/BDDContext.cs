using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.DAL
{
    public class BDDContext : DbContext
    {
        public BDDContext(DbContextOptions<BDDContext> options) : base(options)
        {
            
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<TaskModel> Tasks { get; set; }
        public virtual DbSet<TaskUser> TaskUser { get; set; }
    }
}
