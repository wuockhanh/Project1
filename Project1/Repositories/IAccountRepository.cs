using Microsoft.AspNetCore.Identity;
using Project1.Models;

namespace Project1.Repositories
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel model);
        public Task<string> SignInAsync(SignInModel model);


    }
}
