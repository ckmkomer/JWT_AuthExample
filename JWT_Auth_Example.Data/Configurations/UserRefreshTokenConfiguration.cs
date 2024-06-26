﻿using JWT_Auth_Example.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Auth_Example.Data.Configurations
{
	public class UserRefreshTokenConfiguration : IEntityTypeConfiguration<UserRefreshToken>
	{
		public void Configure(EntityTypeBuilder<UserRefreshToken> builder)
		{
			
			builder.HasKey(x=> x.UserId);
			builder.Property(x => x.Code).IsRequired().HasMaxLength(128);
		}
	}
}
