using System.ComponentModel.DataAnnotations;

namespace Survey.ViewModels
{
    public class SurveyViewModel
    {
        [Required(ErrorMessage = "Full Name is required")]
        [Display(Name = "Full Names")]
        public string FullName { get; set; } = "";
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Contact Number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; } = "";
        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        public bool LikesPizza { get; set; }
        public bool LikesPasta { get; set; }
        public bool LikesPapAndWors { get; set; }

        public bool LikesOther { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Please rate how much you like to eat out")]
        [Display(Name = "Eat Out Rating")]
        public int? EatOutRating { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Please rate how much you like to watch movies")]
        [Display(Name = "Watch Movies Rating")]
        public int? WatchMoviesRating { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Please rate how much you like to watch TV")]
        [Display(Name = "Watch TV Rating")]
        public int? WatchTVRating { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Please rate how much you like to listen to radio")]
        [Display(Name = "Listen To Radio Rating")]
        public int? ListenToRadioRating { get; set; }
    }
}
