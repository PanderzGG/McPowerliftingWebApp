namespace MCPowerlifting.Models.ViewModels
{
    public class ActiveWorkoutViewModel
    {
        public int userId { get; set; }
        public int exerciseId { get; set; }
        public string exerciseName { get; set; }
        public double weight { get; set; }
        public string workoutLoad { get; set; }
        
    }
}
