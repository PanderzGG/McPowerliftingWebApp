namespace MudCowV2.Helper
{
    public class ActiveExercise
    {
        public string ExerciseName { get; set; }
        public string SetType { get; set; }
        public int SetNumber { get; set; }
        public int SetReps { get; set; }
        public double SetWeight { get; set; }
        public bool? IsSuccessful { get; set; }
        public string Load { get; set; }
        public int FailInRow { get; set; }
        public bool isDeload { get; set; }

    }
}
