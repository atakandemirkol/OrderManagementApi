using Microsoft.EntityFrameworkCore;
using OrderManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.DataAccess
{
    public class OrderDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-K308UHP\\SQLEXPRESS; Database=OrderManagementDB;uid=sa;pwd=123456;");
        }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

    }
}

