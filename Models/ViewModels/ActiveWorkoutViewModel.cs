namespace MCPowerlifting.Models.ViewModels
{
    public class ActiveWorkoutViewModel
    {
        public int UserId { get; set; }
        public int ExerciseId { get; set; }
        public int WorkoutId { get; set; }
        public int Actual_weight { get; set; }
        public string ExerciseName { get; set; }
        public double Weight { get; set; }
        public string WorkoutLoad { get; set; }
        public bool IsSuccessful { get; set; }
        public DateTime WorkoutDate { get; set; }
        public bool IsNewProgram { get; set; }
        public enum LoadType
        {
            Heavy,
            Medium,
            Light
        }
    }
}
