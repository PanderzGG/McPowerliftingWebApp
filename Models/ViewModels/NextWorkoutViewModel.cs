namespace MCPowerlifting.Models.ViewModels
{
    public class NextWorkoutViewModel
    {
        public int userId { get; set; }
        public int exerciseId { get; set; }
        public string exerciseName { get; set; }
        public double weight { get; set; }
        public string workoutLoad { get; set; }
        public bool isNew { get; set; }
        public bool isSuccesful { get; set; }
        public int failureInRow { get; set; }

        public NextWorkoutViewModel()
        {
            isNew = false;
        }
    }
}
