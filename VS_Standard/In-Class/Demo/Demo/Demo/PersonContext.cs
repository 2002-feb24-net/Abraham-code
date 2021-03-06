﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    // This context class represents the whole database
    class PersonContext : DbContext
    {
        // You need DBSet properties, one per table (one per type of data
        // you want to store)
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        // in order to connect to any database (or many other kinds of data source)
        // we need a "connection string".

        // we need to give each DBContext instance a connection string...
        // one clumsy hardcoded easy one is OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectionString = "Data Source=../../../persons.db";
            //optionsBuilder.UseSqlite(connectionString);

            optionsBuilder.UseSqlServer(SecretConfig.ConnectionString);
        }
    }
}
