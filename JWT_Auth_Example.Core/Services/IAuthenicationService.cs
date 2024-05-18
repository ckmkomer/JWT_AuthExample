using JWT_Auth_Example.Core.Configuration;
using JWT_Auth_Example.Core.Dtos;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Auth_Example.Core.Services
{
	public interface IAuthenicationService
	{
      Task <Response<TokenDto>>CreateTokenAsync (LoginDto  loginDto);

		Task<Response<TokenDto>> CreateTokenByRefreshToken(string refreshToken);

		Task<Response<TokenDto>> RevokeRefreshToken(string refreshToken); //

		Task<Response<ClientTokenDto>> CreateTokenByClient(ClientLoginDto clientLoginDto);
	}
}
