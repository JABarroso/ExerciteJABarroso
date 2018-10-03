using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RESTExercise.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
           : base("name=MyDbContext")
        {
        }


        public virtual DbSet<Users> Users { get; set; }
    }
}