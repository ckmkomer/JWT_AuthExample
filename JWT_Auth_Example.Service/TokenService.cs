using JWT_Auth_Example.Core.Configuration;
using JWT_Auth_Example.Core.Dtos;
using JWT_Auth_Example.Core.Model;
using JWT_Auth_Example.Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SharedLibrary.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Auth_Example.Service
{
	public class TokenService : ITokenService
	{
		private readonly UserManager<UserApp> _userManager;
		private readonly CustomTokenOption _customTokenOption;

		public TokenService(UserManager<UserApp> userManager, IOptions<CustomTokenOption> options)//Ioption genercii üzerinden geçiyoruz.
		{
			_userManager = userManager;
			_customTokenOption = options.Value;
		}

		private string CreateRefreshToken(string refreshToken) 
		{
			var numberByte = new Byte[32];
			using var rnd =RandomNumberGenerator.Create();
			rnd.GetBytes(numberByte);

			return Convert.ToBase64String(numberByte);
		}
	
		public ClientTokenDto CreateClientToken(Client client)
		{
			throw new NotImplementedException();
		}

		public TokenDto CreateToken(UserAppDto userAppDto)
		{
			throw new NotImplementedException();
		}
	}
}
