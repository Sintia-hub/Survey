using System.ComponentModel.DataAnnotations;

namespace Survey.Models
{
    public class UserSurvey
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; } = "";

        [Required]
        public string Email { get; set; } = "";

        [Required]
        [Phone]
        public string ContactNumber { get; set; } = "";

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        // Favorite food options
        public bool LikesPizza { get; set; }
        public bool LikesPasta { get; set; }
        public bool LikesPapAndWors { get; set; }

        public bool LikesOther { get; set; }

        // Ratings (1 to 5)
        [Range(1, 5)]
        public int EatOutRating { get; set; }

        [Range(1, 5)]
        public int WatchMoviesRating { get; set; }

        [Range(1, 5)]
        public int WatchTVRating { get; set; }

        [Range(1, 5)]
        public int ListenToRadioRating { get; set; }
    }
}
