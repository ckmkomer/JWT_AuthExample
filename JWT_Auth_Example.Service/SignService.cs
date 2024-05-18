using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Auth_Example.Service
{
	internal static class SignService
	{
		public static SecurityKey GetSymmentricScurityKey(string securityKe)
		{
			return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKe));
		}
	}
}


// Bu class JSON Web Token (JWT) ile ilgili işlemler için simetrik bir güvenlik anahtarı (symmetric security key) oluşturur. Bu, JWT'lerin imzalanması ve doğrulanması için kullanılır


//Bu class, JWT'ler için simetrik bir güvenlik anahtarı oluşturur. SignService sınıfı, bir string güvenlik anahtarını UTF8 byte dizisine dönüştürür ve bu byte dizisini kullanarak bir SymmetricSecurityKey nesnesi oluşturur. Bu güvenlik anahtarı, JWT'lerin imzalanması ve doğrulanması için kullanılabilir. Sınıfın internal ve static olması, yalnızca aynı derlemede kullanılabileceğini ve örneklenemeyeceğini gösterir.