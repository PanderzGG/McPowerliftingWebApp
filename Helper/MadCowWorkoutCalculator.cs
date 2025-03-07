using MCPowerlifting.Models.Entities;
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


        public ActiveExercise CalculateExercise(string exerciseName, double maxWeight, string loadType)
        {
            ActiveExercise activeExercise = new ActiveExercise();
            
            Dictionary<int, double> warmUpRepWeight = new Dictionary<int, double>();
            Dictionary<int, double> workSetRepWeight = new Dictionary<int, double>();

            activeExercise.ExerciseName = exerciseName.ToLower();

            switch (activeExercise.ExerciseName)
            {
                case "squat":
                    workSetRepWeight = CalculateWorkingSetWeights(loadType, maxWeight);
                    if (workSetRepWeight[1] > 40)
                    {
                        double minimumWeight = workSetRepWeight[1];
                        warmUpRepWeight = CalculateWarmUpWeights(minimumWeight);
                    }

                    activeExercise.WarmUpRepWeight = warmUpRepWeight;
                    activeExercise.WorkSetRepWeight = workSetRepWeight;

                    break;
                case "deadlift":
                    workSetRepWeight = CalculateWorkingSetWeights(loadType, maxWeight);
                    if (workSetRepWeight[1] > 40)
                    {
                        double minimumWeight = workSetRepWeight[1];
                        warmUpRepWeight = CalculateWarmUpWeights(minimumWeight);
                    }

                    activeExercise.WarmUpRepWeight = warmUpRepWeight;
                    activeExercise.WorkSetRepWeight = workSetRepWeight;
                    break;
                case "bench press":
                    workSetRepWeight = CalculateWorkingSetWeights(loadType, maxWeight);
                    if (workSetRepWeight[1] > 40)
                    {
                        double minimumWeight = workSetRepWeight[1];
                        warmUpRepWeight = CalculateWarmUpWeights(minimumWeight);
                    }

                    activeExercise.WarmUpRepWeight = warmUpRepWeight;
                    activeExercise.WorkSetRepWeight = workSetRepWeight;
                    break;
                case "overhead press":
                    workSetRepWeight = CalculateWorkingSetWeights(loadType, maxWeight);
                    if (workSetRepWeight[1] > 40)
                    {
                        double minimumWeight = workSetRepWeight[1];
                        warmUpRepWeight = CalculateWarmUpWeights(minimumWeight);
                    }

                    activeExercise.WarmUpRepWeight = warmUpRepWeight;
                    activeExercise.WorkSetRepWeight = workSetRepWeight;
                    break;
                case "barbell row":
                    workSetRepWeight = CalculateWorkingSetWeights(loadType, maxWeight);
                    if (workSetRepWeight[1] > 40)
                    {
                        double minimumWeight = workSetRepWeight[1];
                        warmUpRepWeight = CalculateWarmUpWeights(minimumWeight);
                    }

                    activeExercise.WarmUpRepWeight = warmUpRepWeight;
                    activeExercise.WorkSetRepWeight = workSetRepWeight;
                    break;
            }

            return activeExercise;
        }
        
        public Dictionary<int, double> CalculateWarmUpWeights(double minimumWeight)
        {
            Dictionary<int, double> warmpUpSetWeights = new Dictionary<int, double>();

            int setNr;
            double setHeavy = Math.Round((minimumWeight * 0.7), 2);
            double setLight = Math.Round((setHeavy * 0.5), 2);

            for (int i = 0; i <= 1; i++)
            {
                setNr = i + 1;
                warmpUpSetWeights.Add(setNr, setLight);

            }

            setNr = 3;
            warmpUpSetWeights.Add(setNr, setHeavy);

            return warmpUpSetWeights;
        }


        private Dictionary<int, double> CalculateWorkingSetWeights(string loadType, double maxWeight)
        {
            Dictionary<int, double> workingSetWeights = new Dictionary<int, double>();

            int setNr;
            double setWeight;

            switch (loadType.ToLower())
            {
                case "heavy":
                    for (int i = 0; i <= 4; i++)
                    {
                        setNr = i + 1;
                        setWeight = maxWeight - ((maxWeight * 0.125) * (5 - setNr));
                        workingSetWeights.Add(setNr, setWeight);
                    }

                    setNr = 6;
                    setWeight = workingSetWeights[3];
                    workingSetWeights.Add(setNr, setWeight);
                    break;
                case "medium":
                    
                    break;
                case "light":
                    
                    break;
            }

            return workingSetWeights;
        }

        public Dictionary<string, double> CalculateFromStartingWeight(List<Starting_Weights> suppliedWeights)
        {
            Dictionary<string, double> exerciseMaxWeights = new Dictionary<string, double>();
            
            foreach (var pair in suppliedWeights)
                {
                    switch (pair.ExerciseId) 
                    {
                        case 1 :
                            exerciseMaxWeights.Add("Squat", pair.Weight);
                            break;
                        case 3:
                            exerciseMaxWeights.Add("Bench Press", pair.Weight);
                            break;
                        case 4:
                            exerciseMaxWeights.Add("Barbell Row", pair.Weight);
                            break;
                    }
                }

            return exerciseMaxWeights;
        }
    }
}
