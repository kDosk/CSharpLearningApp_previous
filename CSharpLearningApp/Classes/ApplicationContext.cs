﻿using CSharpLearningApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Classes
{
	internal class ApplicationContext : DbContext
	{
		public DbSet<Answer> Answers { get; set; } = null!;
		public DbSet<Test> Tests { get; set; } = null!;
		public DbSet<TestList> TestLists { get; set; } = null!;
		public DbSet<User> Users { get; set; } = null!;

		public ApplicationContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=testdb.db");
		}
	}
}