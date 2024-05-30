using Binabox.Application.Common.Enums;
using Binabox.Application.Common.Exceptions;
using Binabox.Application.Common.Messages.Error;
using Binabox.Application.Common.Responses;
using Binabox.Application.Interfaces.Repositories;
using Binabox.Domain.Common.Enums;
using Binabox.Domain.Entities;
using Binabox.Persistence.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Binabox.Persistence.Repositories;

public class UserRepository(UserManager<User> userManager, ApplicationDbContext applicationDbContext): IUserRepository
{
    public async Task<User> GetUserByEmailAsync(string email)
    {
        try
        {
            User? user = await userManager.Users.AsNoTracking()
                .Include(u => u.UserInfo)
                .FirstOrDefaultAsync(u => u.Email == email);

            if (user == null)
                throw new NotFoundException(UserErrorMessages.UserNotFound);

            return user;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserRepository/GetUserByEmailAsync: " + ex.Message);
            Console.ResetColor();

            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<User> GetUserByIdAsync(string id)
    {
        try
        {
            User? user = await userManager.Users.AsNoTracking()
                .Include(u => u.UserInfo)
                .FirstOrDefaultAsync(u => u.Id == Guid.Parse(id));

            if (user == null)
                throw new NotFoundException(UserErrorMessages.UserNotFound);

            return user;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserRepository/GetUserByIdAsync: " + ex.Message);
            Console.ResetColor();

            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<List<User>> GetUsersListAsync() => 
        await userManager.Users.AsNoTracking().ToListAsync();

    public async Task<User> FindUserByIdAsync(string id)
    {
        User? user = await userManager.FindByIdAsync(id);
        
        if (user == null)
            throw new NotFoundException(UserErrorMessages.UserNotFound);

        return user;
    }
    
    public async Task<IdentityResult> ConfirmUserEmailAsync(User user, string token) => 
        await userManager.ConfirmEmailAsync(user, token);
    
    public async Task<IdentityResult> CreateUserAsync(User user, string password) =>
        await userManager.CreateAsync(user, password);
    
    public async Task<string> GenerateConfirmationTokenAsync(User user) => 
        await userManager.GenerateEmailConfirmationTokenAsync(user);

    public async Task<IdentityResult> DeleteUserAsync(User user) => 
        await userManager.DeleteAsync(user);

    public async Task<bool> CheckPasswordAsync(User user, string password) =>
        await userManager.CheckPasswordAsync(user, password);

    public async Task<User> FindUserByEmailAsync(string email)
    {
        User? user = await userManager.FindByEmailAsync(email);

        if (user == null)
            throw new NotFoundException(UserErrorMessages.UserNotFound);

        return user;
    }

    public async Task<BaseResponse> ChangeUserNicknameAsync(string nickname, string userId)
    {
        try
        {
            var userInfo = await applicationDbContext.UserInfos
                .FirstOrDefaultAsync(x => x.UserId.ToString() == userId);

            if (userInfo == null)
                throw new NotFoundException(AuthErrorMessages.UserNotFound);

            userInfo.Nickname = nickname;

            applicationDbContext.UserInfos.Update(userInfo);
            await applicationDbContext.SaveChangesAsync();

            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserRepository/ChangeUserNicknameAsync: " + ex.Message);
            Console.ResetColor();

            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<BaseResponse> ChangeUserAvatarAsync(string avatar, string userId)
    {
        try
        {
            var userInfo = await applicationDbContext.UserInfos
                .FirstOrDefaultAsync(x => x.UserId.ToString() == userId);

            if (userInfo == null)
                throw new NotFoundException(AuthErrorMessages.UserNotFound);

            userInfo.Avatar = avatar;

            applicationDbContext.UserInfos.Update(userInfo);
            await applicationDbContext.SaveChangesAsync();

            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserRepository/ChangeUserAvatarAsync: " + ex.Message);
            Console.ResetColor();

            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<BaseResponse> AddFundsToBalanceAsync(string userId, decimal value)
    {
        try
        {
            var user = await applicationDbContext.Users.Include(u => u.UserInfo)
                .Include(u => u.Transactions).FirstOrDefaultAsync(x => x.Id.ToString() == userId);

            if (user == null)
                throw new NotFoundException(AuthErrorMessages.UserNotFound);
            
            user.UserInfo.Balance += value;
            Transaction transaction = new Transaction { Name = "Add funds", Date = DateTime.Now, UserId = user.Id};

            applicationDbContext.Transactions.Add(transaction);
            applicationDbContext.UserInfos.Update(user.UserInfo);
            await applicationDbContext.SaveChangesAsync();

            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserRepository/AddFundsToBalanceAsync: " + ex.Message);
            Console.ResetColor();

            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<BaseResponse> RemoveFundsFromBalanceAsync(string userId, decimal value)
    {
        try
        {
            var user = await applicationDbContext.Users.Include(u => u.UserInfo)
                .Include(u => u.Transactions).FirstOrDefaultAsync(x => x.Id.ToString() == userId);

            if (user == null)
                throw new NotFoundException(AuthErrorMessages.UserNotFound);

            if (user.UserInfo.Balance < value)
                throw new ArgumentException("Невозможно списать сумму, т.к баланс кошелька меньше");
                
            user.UserInfo.Balance -= value;
            Transaction transaction = new Transaction { Name = "Remove funds", Date = DateTime.Now, UserId = user.Id};

            applicationDbContext.Transactions.Add(transaction);
            applicationDbContext.UserInfos.Update(user.UserInfo);
            await applicationDbContext.SaveChangesAsync();

            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserRepository/AddFundsToBalanceAsync: " + ex.Message);
            Console.ResetColor();

            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<Transaction[]> GetUserTransactionsAsync(string userId)
    {
        try
        {
            var transactions = await applicationDbContext.Transactions.AsNoTracking()
                .Select(x => x).Where(x => x.UserId.ToString() == userId).ToArrayAsync();

            if (transactions == null)
                throw new NotFoundException(UserErrorMessages.TransactionsNotFound);

            return transactions;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserRepository/GetUserTransactionsAsync: " + ex.Message);
            Console.ResetColor();

            throw new NotFoundException(ex.Message);
        }
    }
    
    public async Task<BaseResponse> BuySubscriptionAsync(string userId, decimal price, SubscriptionType subscriptionType)
    {
        try
        {
            var userInfo = await applicationDbContext.UserInfos
                .FirstOrDefaultAsync(x => x.UserId.ToString() == userId);

            if (userInfo == null)
                throw new NotFoundException(UserErrorMessages.UserNotFound);
            
            if (userInfo.Balance < price)
                throw new ArgumentException("Невозможно списать сумму, т.к баланс кошелька меньше");

            userInfo.Subscription = subscriptionType;
            userInfo.Balance -= price;
            await applicationDbContext.SaveChangesAsync();

            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserRepository/BuySubscriptionAsync: " + ex.Message);
            Console.ResetColor();

            throw new NotFoundException(ex.Message);
        }
    }
}