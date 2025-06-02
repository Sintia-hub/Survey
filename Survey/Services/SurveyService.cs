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
                Age = model.Age,
                DateOfBirth = model.DateOfBirth,
                LikesPizza = model.LikesPizza,
                LikesPasta = model.LikesPasta,
                LikesPapAndWors = model.LikesPapAndWors,
                LikesOther = model.LikesOther,
                EatOutRating = model.EatOutRating,
                WatchMoviesRating = model.WatchMoviesRating,
                WatchTVRating = model.WatchTVRating,
                ListenToRadioRating = model.ListenToRadioRating
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