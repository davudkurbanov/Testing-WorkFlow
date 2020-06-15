using System;

namespace WBA.PE2.KurbanovD.Domain.Services
{
    public class AuthenticationTokenGenerator
    {
        public static Guid GenerateAuthenticationToken()
        {
            return Guid.NewGuid();
        }
    }
}
