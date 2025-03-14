namespace MudCowV2.Models.ViewModels
{
    public class CreateStartingWeights
    {
        public int ExerciseId { get; set; }
        public int UserId { get; set; }
        public string? ExerciseName { get; set; }
        public double Weight { get; set; }
    }
}
