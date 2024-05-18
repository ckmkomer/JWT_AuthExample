using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Configuration
{
	public class CustomTokenOption
	{

		public List<string> Audience {  get; set; }
		public string Issuer {  get; set; }
        public int  AccessTokenExpiration { get; set; }
		public int RefreshTokenExpiration { get; set;}

		public string SecurityKey { get; set; }
    }
}

//appsetting de bulunan jwt kodlarına karşılık gelen sınıf
//appsettinde bulunan kodalar => "TokenOption": {
/*"Audience": [ "www.authserver.com", "www.miniapi1.com", "www.miniapi2.com" ],
    "Issuer": "www.authserver.com",
    "AccessTokenExpiration": 5,
    "RefreshTokenExpiration": 600,
    "SecurityKey": "mysecuritykeymysecuritykeymysecuritykeymysecuritykey"*/
//ve bunu program.cs de builder.Services.Configure<CustomTokenOption>(builder.Configuration.GetSection("TokenOption"));şeklinde eliştik.


// bu duruma options pattern ismi veriliyor.