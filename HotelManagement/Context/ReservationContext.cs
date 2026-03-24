using HotelManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelManagement.Context
{
    internal class ReservationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseSqlServer
            ("Data Source=.;Initial Catalog=FrontEnd_ReservationDB;Integrated Security=true;Encrypt=false;");

        public virtual DbSet<Reservation> Reservations { get; set; }
    }
}

