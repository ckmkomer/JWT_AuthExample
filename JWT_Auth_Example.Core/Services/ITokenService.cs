using JWT_Auth_Example.Core.Configuration;
using JWT_Auth_Example.Core.Dtos;

namespace JWT_Auth_Example.Core.Services
{
	internal interface ITokenService
	{
		TokenDto CreateToken(UserAppDto userAppDto);
		ClientTokenDto CreateClientToken(Client client);
	}
}
