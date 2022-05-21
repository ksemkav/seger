using System;

namespace Seger.Http
{
    public class SignInException : Exception
    {
        public SignInException(string stringContent) : base(stringContent) { }
    }
}
