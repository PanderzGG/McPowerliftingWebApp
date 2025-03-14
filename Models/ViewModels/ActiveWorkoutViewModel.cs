namespace MudCowV2.Models.ViewModels
{
    public class ActiveWorkoutViewModel
    {
        public int UserId { get; set; }
        public int ExerciseId { get; set; }
        public int WorkoutId { get; set; }
        public string ExerciseName { get; set; }
        public double Weight { get; set; }
        public string WorkoutLoad { get; set; }
        public bool IsSuccessful { get; set; }
        public int FailureInRow { get; set; }
        public DateTime WorkoutDate { get; set; }
    }
}
