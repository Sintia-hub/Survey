using Survey.Models;
using Survey.ViewModels;

namespace Survey.Services
{
    public interface ISurveyService
    {
        Task AddSurveyAsync(SurveyViewModel model);
        Task<List<UserSurvey>> GetAllSurveysAsync();
    }
}
