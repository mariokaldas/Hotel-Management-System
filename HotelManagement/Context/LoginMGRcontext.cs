using HotelManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.Context
{
    internal class LoginMGRcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer
            ("Data Source=.;Initial Catalog=BackEnd_LoginMGRDB;Integrated Security=true;Encrypt=false;");

        public virtual DbSet<Entities.Kitchen> Kitchen { get; set; }
        public virtual DbSet<Entities.Frontend> Frontend { get; set; }
    }
    
    
}
