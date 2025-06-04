using Microsoft.AspNetCore.Mvc;
using Survey.Services;
using Survey.ViewModels;

namespace Survey.Controllers
{
    public class SurveyController : Controller
    {
        private readonly ISurveyService _surveyService;

        public SurveyController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        public IActionResult Create()
        {
            return View(new SurveyViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SurveyViewModel model)
        {
            if (ModelState.IsValid)
            {
                int age = CalculateAge(model.DateOfBirth);
                if (age < 5 || age > 120)
                {
                    ModelState.AddModelError("DateOfBirth", "Age must be between 5 and 120 years.");
                    return View(model);
                }

                await _surveyService.AddSurveyAsync(model);
                return RedirectToAction("Summary");
            }

            return View(model);
        }

        public async Task<IActionResult> Summary()
        {
            var surveys = await _surveyService.GetAllSurveysAsync();
            ViewBag.TotalSurveys = surveys.Count;

            if (!surveys.Any())
            {
                ViewBag.Message = "No Surveys Available.";
            }
            else
            {
                var ages = surveys.Select(s => CalculateAge(s.DateOfBirth)).ToList();
                ViewBag.AvgAge = ages.Average();
                ViewBag.Oldest = ages.Max();
                ViewBag.Youngest = ages.Min();

                ViewBag.PizzaPercentage = surveys.Count(s => s.LikesPizza) * 100.0 / surveys.Count;
                ViewBag.PastaPercentage = surveys.Count(s => s.LikesPasta) * 100.0 / surveys.Count;
                ViewBag.PapAndWorsPercentage = surveys.Count(s => s.LikesPapAndWors) * 100.0 / surveys.Count;

                ViewBag.AvgMovies = surveys.Average(s => s.WatchMoviesRating);
                ViewBag.AvgRadio = surveys.Average(s => s.ListenToRadioRating);
                ViewBag.AvgEatOut = surveys.Average(s => s.EatOutRating);
                ViewBag.AvgTV = surveys.Average(s => s.WatchTVRating);
            }

            return View(surveys);
        }
        private int CalculateAge(DateTime dob)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-age)) age--;
            return age;
        }

       

    }
}
