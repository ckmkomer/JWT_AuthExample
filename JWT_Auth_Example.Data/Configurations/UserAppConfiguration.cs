using JWT_Auth_Example.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Auth_Example.Data.Configurations
{
	public class UserAppConfiguration : IEntityTypeConfiguration<UserApp>
	{
		public void Configure(EntityTypeBuilder<UserApp> builder)
		{
			builder.Property(x=>x.City).HasMaxLength(40);
		}
	}
}
