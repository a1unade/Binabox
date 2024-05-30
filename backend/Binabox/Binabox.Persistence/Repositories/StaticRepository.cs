using Binabox.Application.Common.Enums;
using Binabox.Application.Common.Exceptions;
using Binabox.Application.Common.Messages.Error;
using Binabox.Application.Common.Responses;
using Binabox.Application.Interfaces.Repositories;
using Binabox.Domain.Entities;
using Binabox.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Binabox.Persistence.Repositories;

public class StaticRepository(ApplicationDbContext applicationDbContext): IStaticRepository
{
    public async Task<Banner> GetBannerDataByLanguageAsync(string language)
    {
        try
        {
            var banner = await applicationDbContext.Banners.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Language == language.ToUpper());

            if (banner == null)
                throw new NotFoundException(StaticErrorMessages.BannerNotFound);

            return banner;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticRepository/GetBannerDataByLanguageAsync: " + ex.Message);
            Console.ResetColor();
            
            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<Work[]> GetHowItWorksInfoByLanguageAsync(string language)
    {
        try
        {
            var works = await applicationDbContext.Works.AsNoTracking()
                .Select(x => x).Where(x => x.Language == language.ToUpper()).ToArrayAsync();

            if (works == null)
                throw new NotFoundException(StaticErrorMessages.WorksNotFound);

            return works;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticRepository/GetHowItWorksInfoByLanguageAsync: " + ex.Message);
            Console.ResetColor();
            
            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<About> GetAboutUsInfoByLanguageAsync(string language)
    {
        try
        {
            var abouts = await applicationDbContext.Abouts.AsNoTracking()
                .Include(x => x.AboutStats)
                .Include(x => x.AboutCounters)
                .FirstOrDefaultAsync(x => x.Language == language.ToUpper());

            if (abouts == null)
                throw new NotFoundException(StaticErrorMessages.AboutsNotFound);

            return abouts;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticRepository/GetAboutUsInfoByLanguageAsync: " + ex.Message);
            Console.ResetColor();
            
            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<Team[]> GetTeamInfoByLanguageAsync(string language)
    {
        try
        {
            var team = await applicationDbContext.Teams.AsNoTracking()
                .Select(x => x).Where(x => x.Language == language.ToUpper()).ToArrayAsync();

            if (team == null)
                throw new NotFoundException(StaticErrorMessages.TeamsNotFound);

            return team;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticRepository/GetTeamInfoByLanguageAsync: " + ex.Message);
            Console.ResetColor();
            
            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<Contact[]> GetContactsInfoByLanguageAsync(string language)
    {
        try
        {
            var contacts = await applicationDbContext.Contacts.AsNoTracking()
                .Select(x => x).Where(x => x.Language == language.ToUpper()).ToArrayAsync();

            if (contacts == null)
                throw new NotFoundException(StaticErrorMessages.ContactsNotFound);

            return contacts;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticRepository/GetContactsInfoByLanguageAsync: " + ex.Message);
            Console.ResetColor();
            
            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<ReviewInfo> GetReviewsInfoByLanguageAsync(string language)
    {
        try
        {
            var reviews = await applicationDbContext.ReviewInfos.AsNoTracking()
                .Include(x => x.Reviews)
                .FirstOrDefaultAsync(x => x.Language == language.ToUpper());

            if (reviews == null)
                throw new NotFoundException(StaticErrorMessages.ReviewsNotFound);

            return reviews;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticRepository/GetReviewsInfoByLanguageAsync: " + ex.Message);
            Console.ResetColor();
            
            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<Faq[]> GetFaqsInfoByLanguageAsync(string language)
    {
        try
        {
            var faqs = await applicationDbContext.Faqs.AsNoTracking()
                .Select(x => x).Where(x => x.Language == language.ToUpper()).ToArrayAsync();

            if (faqs == null)
                throw new NotFoundException(StaticErrorMessages.FaqsNotFound);

            return faqs;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticRepository/GetFaqsInfoByLanguageAsync: " + ex.Message);
            Console.ResetColor();
            
            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<RoadMap[]> GetRoadMapInfoByLanguageAsync(string language)
    {
        try
        {
            var roadMap = await applicationDbContext.RoadMaps.AsNoTracking()
                .Include(r => r.RoadMapBenefits)
                .Select(x => x).Where(x => x.Language == language.ToUpper()).ToArrayAsync();

            if (roadMap == null)
                throw new NotFoundException(StaticErrorMessages.RoadMapNotFound);

            return roadMap;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticRepository/GetRoadMapInfoByLanguageAsync: " + ex.Message);
            Console.ResetColor();
            
            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<Payment> GetPaymentsInfoByLanguageAsync(string language)
    {
        try
        {
            var payment = await applicationDbContext.Payments.AsNoTracking()
                .Include(x => x.Subscriptions).ThenInclude(x => x.SubscriptionProperties)
                .FirstOrDefaultAsync(x => x.Language == language.ToUpper());

            if (payment == null)
                throw new NotFoundException(StaticErrorMessages.PaymentNotFound);

            return payment;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticRepository/GetPaymentsInfoByLanguageAsync: " + ex.Message);
            Console.ResetColor();
            
            throw new NotFoundException(ex.Message);
        }
    }

    public async Task<BaseResponse> AddNewReviewAsync(string name, string avatar, string text, int reviewInfoId)
    {
        try
        {
            Review review = new Review { Name = name, Avatar = avatar, Text = text, ReviewInfoId = reviewInfoId };

            await applicationDbContext.Reviews.AddAsync(review);
            await applicationDbContext.SaveChangesAsync();

            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticRepository/AddNewReviewAsync: " + ex.Message);
            Console.ResetColor();

            return new BaseResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> {ex.Message} };
        }
    }

    public async Task<Avatar[]> GetAvatarsListAsync() =>
        await applicationDbContext.Avatars.AsNoTracking().ToArrayAsync();

    public async Task<UserFeedback[]> GetUsersFeedbackAsync()
    {
        try
        {
            return await applicationDbContext.UserFeedbacks.AsNoTracking().ToArrayAsync();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticRepository/GetUsersFeedbackAsync: " + ex.Message);
            Console.ResetColor();

            return [];
        }
    }

    public async Task<BaseResponse> AddNewFeedbackAsync(string name, string email, string message)
    {
        try
        {
            var feedback = new UserFeedback
            {
                Name = name,
                Email = email,
                Message = message
            };

            await applicationDbContext.UserFeedbacks.AddAsync(feedback);
            await applicationDbContext.SaveChangesAsync();

            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticRepository/AddNewFeedback: " + ex.Message);
            Console.ResetColor();

            return new BaseResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> {ex.Message} };
        }
    }

    public async Task<Review[]> GetAllReviewsAsync()
    {
        try
        {
            return await applicationDbContext.Reviews.AsNoTracking().ToArrayAsync();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticRepository/GetAllReviewsAsync: " + ex.Message);
            Console.ResetColor();

            return [];
        }
    }

    public async Task<BaseResponse> DeleteReviewByIdAsync(int id)
    {
        try
        {
            var review = await applicationDbContext.Reviews.FirstOrDefaultAsync(x => x.Id == id);

            if (review == null)
                throw new NotFoundException(StaticErrorMessages.ReviewsNotFound);

            applicationDbContext.Reviews.Remove(review);
            await applicationDbContext.SaveChangesAsync();

            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticRepository/DeleteReviewByIdAsync: " + ex.Message);
            Console.ResetColor();

            return new BaseResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> { ex.Message } };
        }
    }
}