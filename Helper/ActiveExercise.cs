namespace MCPowerlifting.Helper
{
    public class ActiveExercise
    {
        public string ExerciseName { get; set; }
        public Dictionary<int , double> WarmUpRepWeight { get; set; }

        public Dictionary<int, double> WorkSetRepWeight { get; set; }

    }
}
