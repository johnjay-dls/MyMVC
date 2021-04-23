using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstMVC.Models;

namespace MyFirstMVC.Data
{
    public class MyFirstMVCContext : DbContext
    {
        public MyFirstMVCContext (DbContextOptions<MyFirstMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstMVC.Models.PersonModel> PersonModel { get; set; }
    }
}
