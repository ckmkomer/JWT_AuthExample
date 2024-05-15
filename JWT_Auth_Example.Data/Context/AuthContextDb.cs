using JWT_Auth_Example.Core.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Auth_Example.Data.Context
{
	public class AuthContextDb : IdentityDbContext
	{
		public AuthContextDb(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

	}
}
