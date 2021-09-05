using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using OnionApp.Domain.Core;

namespace NixTrenProperty.ViewModels
{
    public class CustomUserValidator : IUserValidator<User>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user)
        {
            List<IdentityError> errors = new List<IdentityError>();

            if (user.Email.ToLower().EndsWith(".ru"))
            {
                errors.Add(new IdentityError
                {
                    Description = "This email is not safe"
                });
            }           
            return Task.FromResult(errors.Count == 0 ?
                IdentityResult.Success : IdentityResult.Failed(errors.ToArray()));
        }
    }
}
