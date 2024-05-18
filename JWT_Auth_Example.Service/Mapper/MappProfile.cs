using AutoMapper;
using JWT_Auth_Example.Core.Dtos;
using JWT_Auth_Example.Core.Model;

namespace JWT_Auth_Example.Service.Mapper
{
	public class MappProfile : Profile
	{
		public MappProfile()
		{
			CreateMap<Product,  ProductDto>().ReverseMap();
			CreateMap<UserApp, UserAppDto>().ReverseMap();
			CreateMap<RefreshTokenDto, RefreshTokenDto>().ReverseMap();

		}
	}
}
