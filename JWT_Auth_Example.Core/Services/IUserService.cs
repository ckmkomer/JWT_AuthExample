using Azure;
using JWT_Auth_Example.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Auth_Example.Core.Services
{
	public interface IUserService
	{
		Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);
		Task<Response<UserAppDto>> GetUserByNameAsync(string userName);
	}
}
