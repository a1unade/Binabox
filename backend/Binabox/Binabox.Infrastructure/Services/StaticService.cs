using Binabox.Application.Common.Enums;
using Binabox.Application.Common.Exceptions;
using Binabox.Application.Common.Messages.Error;
using Binabox.Application.Common.Responses;
using Binabox.Application.Interfaces.Repositories;
using Binabox.Application.Interfaces.Services;
using Binabox.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Binabox.Infrastructure.Services;

public class StaticService(IStaticRepository staticRepository, IWebHostEnvironment webHostEnvironment): IStaticService
{
    public async Task<Banner> GetBannerDataAsync(string language)
    {
        try
        {
            return await staticRepository.GetBannerDataByLanguageAsync(language);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticService/GetBannerDataAsync: " + ex.Message);
            Console.ResetColor();

            return new Banner();
        }
    }

    public async Task<Work[]> GetHowSiteWorksInfoAsync(string language)
    {
        try
        {
            return await staticRepository.GetHowItWorksInfoByLanguageAsync(language);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticService/GetHowSiteWorksInfoAsync: " + ex.Message);
            Console.ResetColor();

            return [];
        }
    }

    public async Task<AboutResponse> GetAboutUsInfoAsync(string language)
    {
        try
        {
            var about = await staticRepository.GetAboutUsInfoByLanguageAsync(language);
            List<AboutCounter> aboutCounters = new List<AboutCounter>();
            List<AboutStat> aboutStats = new List<AboutStat>();

            foreach (var counter in about.AboutCounters)
            {
                aboutCounters.Add(
                new AboutCounter
                {
                    Id = counter.Id,
                    Title = counter.Title,
                    Number = counter.Number
                });
            }

            foreach (var stat in about.AboutStats)
            {
                aboutStats.Add(new AboutStat
                {
                    Id = stat.Id,
                    Title = stat.Title,
                    Text = stat.Text
                });   
            }

            return new AboutResponse
            {
                ResponseType = ResponseTypes.Success,
                Title = about.Title,
                Description = about.Description,
                AboutCounters = aboutCounters,
                AboutStats = aboutStats
            };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticService/GetAboutUsInfoAsync: " + ex.Message);
            Console.ResetColor();

            return new AboutResponse {ResponseType = ResponseTypes.Error, Errors = new List<string> {ex.Message}};
        }
    }
    
    public async Task<Team[]> GetOurTeamInfoAsync(string language)
    {
        try
        {
            return await staticRepository.GetTeamInfoByLanguageAsync(language);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticService/GetOurTeamInfoAsync: " + ex.Message);
            Console.ResetColor();

            return [];
        }
    }
    
    public async Task<Contact[]> GetContactUsInfoAsync(string language)
    {
        try
        {
            return await staticRepository.GetContactsInfoByLanguageAsync(language);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticService/GetContactUsInfoAsync: " + ex.Message);
            Console.ResetColor();

            return [];
        }
    }

    public async Task<ReviewResponse> GetReviewsInfoAsync(string language)
    {
        try
        {
            var review = await staticRepository.GetReviewsInfoByLanguageAsync(language);
            List<ReviewListResponse> reviewListResponses = new List<ReviewListResponse>();

            foreach (var r in review.Reviews)
            {
                reviewListResponses.Add(new ReviewListResponse
                {
                    Id = r.Id,
                    Name = r.Name,
                    Text = r.Text,
                    Avatar = r.Avatar
                });
            }

            return new ReviewResponse
            {
                ResponseType = ResponseTypes.Success,
                Id = review.Id,
                Title = review.Title,
                Description = review.Description,
                Reviews = reviewListResponses
            };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticService/GetFaqsInfoAsync: " + ex.Message);
            Console.ResetColor();

            return new ReviewResponse {ResponseType = ResponseTypes.Error, Errors = new List<string> {ex.Message}};
        }
    }

    public async Task<Faq[]> GetFaqsInfoAsync(string language)
    {
        try
        {
            return await staticRepository.GetFaqsInfoByLanguageAsync(language);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticService/GetFaqsInfoAsync: " + ex.Message);
            Console.ResetColor();

            return [];
        }
    }

    public async Task<RoadMapResponse[]> GetRoadMapInfoAsync(string language)
    {
        try
        {
            var roadMap = await staticRepository.GetRoadMapInfoByLanguageAsync(language);
            List<RoadMapResponse> roadMapResponse = new List<RoadMapResponse>();

            foreach (var rm in roadMap)
            {
                List<RoadMapListResponse> roadMapListResponse = new List<RoadMapListResponse>();
                foreach (var rmb in rm.RoadMapBenefits)
                {
                    roadMapListResponse.Add(new RoadMapListResponse
                    {
                        Id = rmb.Id,
                        Text = rmb.Text
                    });
                }
                
                roadMapResponse.Add(new RoadMapResponse
                {
                    Id = rm.Id,
                    Title = rm.Title,
                    Class = rm.Class,
                    List = roadMapListResponse
                });
            }

            return roadMapResponse.ToArray();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticService/GetFaqsInfoAsync: " + ex.Message);
            Console.ResetColor();

            return [];
        }
    }

    public async Task<PaymentsResponse> GetPaymentsInfoAsync(string language)
    {
        try
        {
            var payment = await staticRepository.GetPaymentsInfoByLanguageAsync(language);
            List<SubscriptionResponse> subscriptions = new List<SubscriptionResponse>();

            foreach (var sub in payment.Subscriptions)
            {
                List<SubsriptionPropertyResponse> properties = new List<SubsriptionPropertyResponse>();

                foreach (var prop in sub.SubscriptionProperties)
                {
                    properties.Add( new SubsriptionPropertyResponse
                    {
                        Id = prop.Id,
                        Text = prop.Text
                    });
                }
                
                subscriptions.Add(new SubscriptionResponse
                {
                    Id = sub.Id,
                    Title = sub.Title,
                    Price = sub.Price,
                    Image = sub.Image,
                    Properties = properties
                });
            }

            return new PaymentsResponse
            {
                ResponseType = ResponseTypes.Success,
                Title = payment.Title,
                Description = payment.Description,
                Subscriptions = subscriptions
            };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticService/GetPaymentsInfoAsync: " + ex.Message);
            Console.ResetColor();

            return new PaymentsResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> {ex.Message}};
        }
    }

    public async Task<BaseResponse> AddNewReviewAsync(string name, string avatar, string text, string language)
    {
        try
        {
            int reviewInfoId = 1;

            if (language.ToUpper() == "RU")
                reviewInfoId = 2;

            return await staticRepository.AddNewReviewAsync(name, avatar, text, reviewInfoId);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticService/AddNewReviewAsync: " + ex.Message);
            Console.ResetColor();

            return new BaseResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> { ex.Message } };
        }
    }

    public async Task<Avatar[]> GetAvatarsListAsync() => 
        await staticRepository.GetAvatarsListAsync();
    
    public async Task<SaveFileResponse> SaveFileAsync(IFormFile file)
    {
        if (file == null || file.Length == 0)
            throw new NotFoundException(StaticErrorMessages.FileNotFound);
    
        string directoryPath = Path.Combine(webHostEnvironment.WebRootPath, "product");
        
        string fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
        string filePath = Path.Combine(directoryPath, fileName);

        await using (var fileStream = new FileStream(filePath, FileMode.Create))
            await file.CopyToAsync(fileStream);

        return new SaveFileResponse
            { ResponseType = ResponseTypes.Success, Url = $"http://localhost:5112/static/product/{fileName}" };
    }

    public async Task<UserFeedback[]> GetUsersFeedbackAsync()
    {
        try
        {
            return await staticRepository.GetUsersFeedbackAsync();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticService/GetUsersFeedbackAsync: " + ex.Message);
            Console.ResetColor();

            return [];
        }
    }

    public async Task<BaseResponse> AddNewFeedbackAsync(string name, string email, string message)
    {
        try
        {
            return await staticRepository.AddNewFeedbackAsync(name, email, message);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticService/GetUsersFeedbackAsync: " + ex.Message);
            Console.ResetColor();

            return new BaseResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> { ex.Message } };
        }
    }

    public async Task<ReviewListResponse[]> GetAllReviewsAsync()
    {
        try
        {
            var reviews = await staticRepository.GetAllReviewsAsync();
            List<ReviewListResponse> response = new List<ReviewListResponse>();

            foreach (var r in reviews)
            {
                response.Add(new ReviewListResponse
                {
                    Id = r.Id,
                    Avatar = r.Avatar,
                    Name = r.Name,
                    Text = r.Text
                });
            }

            return response.ToArray();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticService/ReviewListResponse: " + ex.Message);
            Console.ResetColor();

            return [];
        }
    }

    public async Task<BaseResponse> DeleteReviewByIdAsync(int id)
    {
        try
        {
            await staticRepository.DeleteReviewByIdAsync(id);

            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StaticService/DeleteReviewByIdAsync: " + ex.Message);
            Console.ResetColor();

            return new BaseResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> { ex.Message } };
        }
    }
}