using JWT_Auth_Example.Core.Configuration;
using JWT_Auth_Example.Core.Dtos;
using JWT_Auth_Example.Core.Model;
using JWT_Auth_Example.Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SharedLibrary.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
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
	
		private IEnumerable<Claim> GetClaim(UserApp userApp,List<String>audiences) 
		{
			var userList = new List<Claim> {
			new Claim(  ClaimTypes.NameIdentifier,userApp.Id),
				new Claim(JwtRegisteredClaimNames.Email,userApp.Email),
				new Claim(ClaimTypes.Name,userApp.UserName),
				new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
				};

			userList.AddRange(audiences.Select(x=>new Claim(JwtRegisteredClaimNames.Aud,x)));
			return userList;
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
