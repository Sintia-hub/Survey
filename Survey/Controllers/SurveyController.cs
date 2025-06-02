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
            if (!ModelState.IsValid)
                return View(model);

            await _surveyService.AddSurveyAsync(model);
            return RedirectToAction("Summary");
        }

        public async Task<IActionResult> Summary()
        {
            var surveys = await _surveyService.GetAllSurveysAsync();
            if (surveys.Count == 0)
                ViewBag.Message = "No Surveys Available.";

            ViewBag.TotalSurveys = surveys.Count;
            ViewBag.AvgAge = surveys.Average(s => s.Age);
            ViewBag.Oldest = surveys.Max(s => s.Age);
            ViewBag.Youngest = surveys.Min(s => s.Age);
            ViewBag.PizzaPercentage = surveys.Count(s => s.LikesPizza) * 100.0 / surveys.Count;
            ViewBag.AvgEatOut = surveys.Average(s => s.EatOutRating);

            return View(surveys);
        }
    }
}
