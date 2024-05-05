using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Auth_Example.Core.Model
{
	public class UserRefreshToken
	{
        public string UserId { get; set; }

        public string Code { get; set; }
        public DateTime Expiration { get; set; }
    }
}
