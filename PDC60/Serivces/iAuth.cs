using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDC60
{
    public interface iAuth
    {
        Task<string> LoginWithEmailAndPassowrd(string email, string password);
        Task<string> SignUpWithEmailAndPassowrd(string email, string password);

        bool SignOut();
        bool IsSignIn();
    }
}