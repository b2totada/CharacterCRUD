using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    //Needed for EF to be able to connect the Models with the db
    public class DataContext : DbContext
    {
        //DbSet<Character> represents the Model and Characters represents the table in the db
        public DbSet<Character> Characters { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}