﻿using JWT_Auth_Example.Core.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JWT_Auth_Example.Data.Context
{
	public class AuthContextDb : IdentityDbContext<UserApp,IdentityRole,string  >
	{
		public AuthContextDb(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }


		protected override void OnModelCreating(ModelBuilder builder)
		{

			builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
			base.OnModelCreating(builder);

		}
		

	}
}
