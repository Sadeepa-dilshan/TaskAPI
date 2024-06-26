﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskApi.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-L3CK2DB\\SQLEXPRESS;Database=TodoApi;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author{Id=1,FullName="Mgs dilshan",AddressNo = "45",Street="Street 1",City="Colomboo 1",JobRole = "Developer"},
                new Author{Id=2,FullName="Sunil Bandara",AddressNo = "123",Street = "Main Street",City = "Cityville",JobRole = "QA"},
                new Author{Id=3,FullName="Chaminda Bandara",AddressNo = "456",Street = "Oak Avenue", City = "Townsville",JobRole = "PM"},
                new Author{Id=4,FullName="Hansi Gamage",AddressNo = "789",Street = "Pine Street",City = "Villageville" ,JobRole = "SE"}
            });
            modelBuilder.Entity<Todo>().HasData(new Todo[] {
                new Todo{
                    Id = 1,
                    Title = "Get books for school - DB",
                    Description = "Get some text books for school",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId=1
                },
                new Todo{
                    Id = 2,
                    Title = "Need some grocceries",
                    Description = "Go to supermarket and buy some stuff",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId=1
                },new Todo{
                    Id = 3,
                    Title = "Purchase camera",
                    Description = "Buy new camera",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId=2
                },
            });
        }

    }
}
