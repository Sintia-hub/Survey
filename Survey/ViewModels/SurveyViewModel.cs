using System.ComponentModel.DataAnnotations;

namespace Survey.ViewModels
{
    public class SurveyViewModel
    {
        [Required]
        [Display(Name ="Full Names")]
        public string FullName { get; set; } = "";
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; } = "";
        [Required]
        [Range(5, 120)] 
        public int Age { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        public bool LikesPizza { get; set; }
        public bool LikesPasta { get; set; }
        public bool LikesPapAndWors { get; set; }
        public bool LikesChickenStirFry { get; set; }
        public bool LikesBeefStirFry { get; set; }
        public bool LikesOther { get; set; }

        [Required]
        [Range(1, 5)] 
        public int EatOutRating { get; set; }
        [Required]
        [Range(1, 5)] 
        public int WatchMoviesRating { get; set; }
        [Required]
        [Range(1, 5)]
        public int WatchTVRating { get; set; }
        [Required]
        [Range(1, 5)]
        public int ListenToRadioRating { get; set; }
    }
}
