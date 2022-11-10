using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Back_End_BD.Models
{
    public class ProfesorDbContext : DbContext
    {
        private const string ConnectionString = "DefaultConnection";
        public ProfesorDbContext() : base(ConnectionString)
        {

        }
        public DbSet<Profesor> Profesores { get; set; }
    }
}