using Microsoft.EntityFrameworkCore;
using Survey.Data;
using Survey.Models;
using Survey.ViewModels;

namespace Survey.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly ApplicationDbContext _context;

        public SurveyService(ApplicationDbContext context) => _context = context;

        public async Task AddSurveyAsync(SurveyViewModel model)
        {
            var survey = new UserSurvey
            {
                FullName = model.FullName,
                Email = model.Email,
                DateOfBirth = model.DateOfBirth,
                LikesPizza = model.LikesPizza,
                LikesPasta = model.LikesPasta,
                LikesPapAndWors = model.LikesPapAndWors,
                LikesOther = model.LikesOther,
                EatOutRating = model.EatOutRating ?? 0,
                WatchMoviesRating = model.WatchMoviesRating ?? 0,
                WatchTVRating = model.WatchTVRating ?? 0,
                ListenToRadioRating = model.ListenToRadioRating ?? 0
            };

            _context.Surveys.Add(survey);
            await _context.SaveChangesAsync();
        }

        public async Task<List<UserSurvey>> GetAllSurveysAsync()
        {
            return await _context.Surveys.ToListAsync();
        }
    }
}