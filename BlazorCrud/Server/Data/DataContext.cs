﻿using System;
using BlazorCrud.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Server.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "The Hitchhiker's Guide to the Galaxy",
                        Category = "Books",
                        Price = 9.99m
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Ready Player One",
                        Category = "Books",
                        Price = 12.99m
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Back to the Future",
                        Category = "Movies",
                        Price = 4.99m
                    },
                    new Product
                    {
                        Id = 4,
                        Title = "Toy Story",
                        Category = "Movies",
                        Price = 3.99m
                    });

        }

        public DbSet<Product> Products => Set<Product>();
    }
}

