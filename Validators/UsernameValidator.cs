using Microsoft.AspNetCore.Identity;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class UsernameValidator<TUser> : IUserValidator<TUser> where TUser : class
{
    public Task<IdentityResult> ValidateAsync(UserManager<TUser> manager, TUser user)
    {
        var userName = manager.GetUserNameAsync(user).Result;

        // Проверка дали потребителското име е валиден имейл
        var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        if (!emailRegex.IsMatch(userName))
        {
            return Task.FromResult(IdentityResult.Failed(
                new IdentityError { Description = "Username must be a valid email address." }
            ));
        }

        return Task.FromResult(IdentityResult.Success);
    }
}
