using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Auth_Example.Service.Mapper
{
	public static class ObjectMapper
	{
		public static Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
		{
			var config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<MappProfile>();
			});
			return config.CreateMapper();
		});

		public static IMapper Mapper => lazy.Value;
	}
}
