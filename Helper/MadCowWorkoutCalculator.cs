using MCPowerlifting.Models.ViewModels;

namespace MCPowerlifting.Helper
{
    public class MadCowWorkoutCalculator
    {
        private double workoutWeight;

        private string workoutLoad;


        public MadCowWorkoutCalculator()
        {

        }

        public Dictionary<string, double> NextWorkoutWeights(List<NextWorkoutViewModel> nextWeights)
        {
            Dictionary<string, double> exerciseWeights = new Dictionary<string, double>();

            if (nextWeights.Any(x => x.isNew))
            {
                foreach (var pair in nextWeights)
                {
                    switch (pair.exerciseName.ToLower()) 
                    {
                        case "squat":
                            exerciseWeights.Add(pair.exerciseName, pair.weight);
                            break;
                        case "bench press":
                            exerciseWeights.Add(pair.exerciseName, pair.weight);
                            break;
                        case "overhead press":
                            exerciseWeights.Add(pair.exerciseName, pair.weight);
                            break;
                    }
                }
            }
            return exerciseWeights;
        }

    }
}
