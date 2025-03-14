using MudCowV2.Helper;
using MudCowV2.Models.Entities;
using MudCowV2.Models.ViewModels;

namespace MudCow.Helper
{
    public class MadCowWorkoutCalculator
    {
        private Dictionary<string, double> workoutWeight = new Dictionary<string, double>();

        private string workoutLoad;


        public MadCowWorkoutCalculator()
        {

        }


        public Dictionary<string, double> NextWorkoutWeights(List<NextWorkoutViewModel> nextWeights)
        {
            Dictionary<string, double> exerciseWeights = new Dictionary<string, double>();

            if (nextWeights.Any(x => x.isNew))
            {
                bool lightLoad = nextWeights.Any(x => x.workoutLoad == "light");

                foreach (var pair in nextWeights)
                {
                    if (lightLoad)
                    {
                        switch (pair.exerciseName.ToLower())
                        {
                            case "squat":
                                exerciseWeights.Add(pair.exerciseName, pair.weight);
                                break;
                            case "overhead press":
                                exerciseWeights.Add(pair.exerciseName, pair.weight);
                                break;
                            case "deadlift":
                                exerciseWeights.Add(pair.exerciseName, pair.weight);
                                break;
                        }
                    }
                    else
                    {
                        switch (pair.exerciseName.ToLower())
                        {
                            case "squat":
                                exerciseWeights.Add(pair.exerciseName, pair.weight);
                                break;
                            case "bench press":
                                exerciseWeights.Add(pair.exerciseName, pair.weight);
                                break;
                            case "barbell row":
                                exerciseWeights.Add(pair.exerciseName, pair.weight);
                                break;
                        }
                    }

                }
            }
            else if (!nextWeights.Any(x => x.isNew))
            {
                var load = nextWeights[0];
                int failureInRow = load.failureInRow;


                switch (load.workoutLoad)
                {
                    case "light":
                        foreach (var pair in nextWeights)
                        {
                            if (!exerciseWeights.ContainsKey(pair.exerciseName))
                            {
                                switch (pair.exerciseName.ToLower())
                                {
                                    case "squat":
                                        if (pair.failureInRow == 2)
                                        {
                                            exerciseWeights.Add(pair.exerciseName, pair.weight - (pair.weight * 0.10));
                                        }
                                        else
                                        {
                                            exerciseWeights.Add(pair.exerciseName, pair.weight);
                                        }
                                        break;
                                    case "overhead press":
                                        switch (pair.failureInRow)
                                        {
                                            case 1:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight);
                                                break;
                                            case 2:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight - (pair.weight * 0.10));
                                                break;
                                            default:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight + 2.5);
                                                break;
                                        }
                                        break;
                                    case "deadlift":
                                        switch (pair.failureInRow)
                                        {
                                            case 1:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight);
                                                break;
                                            case 2:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight - (pair.weight * 0.10));
                                                break;
                                            default:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight + 5.0);
                                                break;
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                    case "medium":
                        foreach (var pair in nextWeights)
                        {
                            if (!exerciseWeights.ContainsKey(pair.exerciseName))
                            {
                                switch (pair.exerciseName.ToLower())
                                {
                                    case "squat":
                                        switch (pair.failureInRow)
                                        {
                                            case 1:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight);
                                                break;
                                            case 2:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight - (pair.weight * 0.10));
                                                break;
                                            default:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight + 2.5);
                                                break;
                                        }
                                        break;
                                    case "bench press":
                                        switch (pair.failureInRow)
                                        {
                                            case 1:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight);
                                                break;
                                            case 2:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight - (pair.weight * 0.10));
                                                break;
                                            default:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight + 2.5);
                                                break;
                                        }
                                        break;
                                    case "barbell row":
                                        switch (pair.failureInRow)
                                        {
                                            case 1:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight);
                                                break;
                                            case 2:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight - (pair.weight * 0.10));
                                                break;
                                            default:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight + 2.5);
                                                break;
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                    case "heavy":
                        foreach (var pair in nextWeights)
                        {
                            if (!exerciseWeights.ContainsKey(pair.exerciseName))
                            {
                                switch (pair.exerciseName.ToLower())
                                {
                                    case "squat":
                                        switch (pair.failureInRow)
                                        {
                                            case 2:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight - (pair.weight * 0.10));
                                                break;
                                            default:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight);
                                                break;
                                        }
                                        break;
                                    case "bench press":
                                        switch (pair.failureInRow)
                                        {
                                            case 2:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight - (pair.weight * 0.10));
                                                break;
                                            default:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight);
                                                break;
                                        }
                                        break;
                                    case "barbell row":
                                        switch (pair.failureInRow)
                                        {
                                            case 2:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight - (pair.weight * 0.10));
                                                break;
                                            default:
                                                exerciseWeights.Add(pair.exerciseName, pair.weight);
                                                break;
                                        }
                                        break;
                                }
                            }

                        }
                        break;
                }

            }
            return exerciseWeights;
        }


        public List<ActiveExercise> CalculateExercise(string exerciseName, double maxWeight, string loadType)
        {
            ActiveExercise activeExercise = new ActiveExercise();

            List<ActiveExercise> workingSetsRepsWeights = new List<ActiveExercise>();
            List<ActiveExercise> warmUpSetsRepsWeights = new List<ActiveExercise>();

            List<ActiveExercise> totalSetRepWeight = new List<ActiveExercise>();

            activeExercise.ExerciseName = exerciseName.ToLower();

            switch (activeExercise.ExerciseName)
            {
                case "squat":
                    workingSetsRepsWeights = CalculateWorkingSetWeights(exerciseName, loadType, maxWeight);
                    totalSetRepWeight.AddRange(workingSetsRepsWeights);

                    if (workingSetsRepsWeights.First(x => x.SetNumber == 1).SetWeight > 40)
                    {
                        double minimumWeight = workingSetsRepsWeights.First(x => x.SetNumber == 1).SetWeight;
                        warmUpSetsRepsWeights = CalculateWarmUpWeights(minimumWeight);
                    }
                    if (warmUpSetsRepsWeights.Count > 0)
                    {
                        totalSetRepWeight.AddRange(warmUpSetsRepsWeights);
                    }

                    break;
                case "deadlift":
                    workingSetsRepsWeights = CalculateWorkingSetWeights(exerciseName, loadType, maxWeight);
                    totalSetRepWeight.AddRange(workingSetsRepsWeights);

                    if (workingSetsRepsWeights.First(x => x.SetNumber == 1).SetWeight > 40)
                    {
                        double minimumWeight = workingSetsRepsWeights.First(x => x.SetNumber == 1).SetWeight;
                        warmUpSetsRepsWeights = CalculateWarmUpWeights(minimumWeight);
                    }
                    if (warmUpSetsRepsWeights.Count > 0)
                    {
                        totalSetRepWeight.AddRange(warmUpSetsRepsWeights);
                    }
                    break;
                case "bench press":
                    workingSetsRepsWeights = CalculateWorkingSetWeights(exerciseName, loadType, maxWeight);
                    totalSetRepWeight.AddRange(workingSetsRepsWeights);

                    if (workingSetsRepsWeights.First(x => x.SetNumber == 1).SetWeight > 40)
                    {
                        double minimumWeight = workingSetsRepsWeights.First(x => x.SetNumber == 1).SetWeight;
                        warmUpSetsRepsWeights = CalculateWarmUpWeights(minimumWeight);
                    }
                    if (warmUpSetsRepsWeights.Count > 0)
                    {
                        totalSetRepWeight.AddRange(warmUpSetsRepsWeights);
                    }
                    break;
                case "overhead press":
                    workingSetsRepsWeights = CalculateWorkingSetWeights(exerciseName, loadType, maxWeight);
                    totalSetRepWeight.AddRange(workingSetsRepsWeights);

                    if (workingSetsRepsWeights.First(x => x.SetNumber == 1).SetWeight > 40)
                    {
                        double minimumWeight = workingSetsRepsWeights.First(x => x.SetNumber == 1).SetWeight;
                        warmUpSetsRepsWeights = CalculateWarmUpWeights(minimumWeight);
                    }
                    if (warmUpSetsRepsWeights.Count > 0)
                    {
                        totalSetRepWeight.AddRange(warmUpSetsRepsWeights);
                    }
                    break;
                case "barbell row":
                    workingSetsRepsWeights = CalculateWorkingSetWeights(exerciseName, loadType, maxWeight);
                    totalSetRepWeight.AddRange(workingSetsRepsWeights);

                    if (workingSetsRepsWeights.First(x => x.SetNumber == 1).SetWeight > 40)
                    {
                        double minimumWeight = workingSetsRepsWeights.First(x => x.SetNumber == 1).SetWeight;
                        warmUpSetsRepsWeights = CalculateWarmUpWeights(minimumWeight);
                    }
                    if (warmUpSetsRepsWeights.Count > 0)
                    {
                        totalSetRepWeight.AddRange(warmUpSetsRepsWeights);
                    }
                    break;
            }

            return totalSetRepWeight;
        }

        public List<ActiveExercise> CalculateWarmUpWeights(double minimumWeight)
        {
            List<ActiveExercise> warmUpSets = new List<ActiveExercise>();
            ActiveExercise lastSet = new ActiveExercise();

            double setHeavy = Math.Round((minimumWeight * 0.7), 2);
            double setLight = Math.Round((setHeavy * 0.5), 2);

            for (int i = 0; i <= 1; i++)
            {
                ActiveExercise tempSet = new ActiveExercise();
                tempSet.SetNumber = i + 1;
                tempSet.SetType = "warmup";
                tempSet.SetWeight = setLight;
                tempSet.SetReps = 5;

                warmUpSets.Add(tempSet);
            }

            lastSet.SetNumber = 3;
            lastSet.SetType = "warmup";
            lastSet.SetWeight = setHeavy;
            lastSet.SetReps = 5;
            warmUpSets.Add(lastSet);

            return warmUpSets;
        }


        private List<ActiveExercise> CalculateWorkingSetWeights(string exerciseName, string loadType, double maxWeight)
        {
            List<ActiveExercise> workingSet = new List<ActiveExercise>();
            ActiveExercise set = new ActiveExercise();

            switch (loadType.ToLower())
            {
                case "heavy":

                    for (int i = 0; i <= 3; i++)
                    {
                        workingSet.Add(new ActiveExercise
                        {
                            ExerciseName = exerciseName,
                            SetNumber = i + 1,
                            SetType = "working",
                            SetWeight = maxWeight - ((maxWeight * 0.125) * (3 - (i))),
                            SetReps = 5
                        });
                    }

                    workingSet.Add(new ActiveExercise
                    {
                        ExerciseName = exerciseName,
                        SetNumber = 5,
                        SetType = "working",
                        SetWeight = maxWeight,
                        SetReps = 3
                    });

                    workingSet.Add(new ActiveExercise
                    {
                        ExerciseName = exerciseName,
                        SetNumber = 6,
                        SetType = "working",
                        SetWeight = workingSet.First(x => x.SetNumber == 3).SetWeight,
                        SetReps = 8
                    });
                    break;
                case "medium":

                    for (int i = 0; i <= 4; i++)
                    {
                        workingSet.Add(new ActiveExercise
                        {
                            ExerciseName = exerciseName,
                            SetNumber = i + 1,
                            SetType = "working",
                            SetWeight = maxWeight - ((maxWeight * 0.125) * (4 - (i))),
                            SetReps = 5
                        });
                    }
                    break;

                case "light":
                    for (int i = 0; i <= 3; i++)
                    {
                        workingSet.Add(new ActiveExercise
                        {
                            ExerciseName = exerciseName,
                            SetNumber = i + 1,
                            SetType = "working",
                            SetWeight = maxWeight - ((maxWeight * 0.125) * (3 - (i))),
                            SetReps = 5
                        });

                    }
                    break;
            }
            return workingSet;
        }

        //public Dictionary<string, double> CalculateFromPreviousWeight() { }

        public Dictionary<string, double> CalculateFromStartingWeight(List<Starting_Weights> suppliedWeights, string load)
        {
            Dictionary<string, double> exerciseMaxWeights = new Dictionary<string, double>();

            switch (load)
            {
                case "light":
                    foreach (var pair in suppliedWeights)
                    {
                        switch (pair.ExerciseId)
                        {
                            case 1:
                                exerciseMaxWeights.Add("Squat", pair.Weight);
                                break;
                            case 4:
                                exerciseMaxWeights.Add("Overhead Press", pair.Weight);
                                break;
                            case 2:
                                exerciseMaxWeights.Add("Deadlift", pair.Weight);
                                break;
                        }
                    }
                    break;
                default:
                    foreach (var pair in suppliedWeights)
                    {
                        switch (pair.ExerciseId)
                        {
                            case 1:
                                exerciseMaxWeights.Add("Squat", pair.Weight);
                                break;
                            case 3:
                                exerciseMaxWeights.Add("Bench Press", pair.Weight);
                                break;
                            case 5:
                                exerciseMaxWeights.Add("Barbell Row", pair.Weight);
                                break;
                        }
                    }
                    break;
            }


            return exerciseMaxWeights;
        }

        public Dictionary<string, double> CalculateFromPreviousWeight(List<ActiveExercise> suppliedWeights)
        {
            Dictionary<string, double> exerciseMaxWeights = new Dictionary<string, double>();

            foreach (var pair in suppliedWeights)
            {
                switch (pair.Load.ToLower())
                {
                    case "light":
                        if (pair.ExerciseName.ToLower() != "bench press" || pair.ExerciseName.ToLower() != "barbell row")
                        {
                            if (pair.ExerciseName.ToLower() != "squat")
                            {
                                if (pair.FailInRow == 2 || pair.isDeload)
                                {
                                    exerciseMaxWeights.Add(pair.ExerciseName, pair.SetWeight - (pair.SetWeight * 0.10));
                                }
                                else
                                {
                                    switch (pair.ExerciseName.ToLower())
                                    {
                                        case "overhead press":
                                            exerciseMaxWeights.Add(pair.ExerciseName, pair.SetWeight + 1.25);
                                            break;
                                        case "deadlift":
                                            exerciseMaxWeights.Add(pair.ExerciseName, pair.SetWeight + 5);
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                exerciseMaxWeights.Add(pair.ExerciseName, pair.SetWeight);
                            }
                        }
                        break;
                    case "medium":
                        if (pair.ExerciseName.ToLower() != "deadlift" || pair.ExerciseName.ToLower() != "overhead press")
                        {
                            exerciseMaxWeights.Add(pair.ExerciseName, pair.SetWeight + 2.5);
                        }
                        break;
                    case "heavy":
                        if (pair.ExerciseName.ToLower() != "deadlift" || pair.ExerciseName.ToLower() != "overhead press")
                        {
                            if (pair.FailInRow == 2 || pair.isDeload)
                            {
                                exerciseMaxWeights.Add(pair.ExerciseName, pair.SetWeight - (pair.SetWeight * 0.10));
                            }
                            exerciseMaxWeights.Add(pair.ExerciseName, pair.SetWeight);
                        }
                        break;
                }
            }


            return exerciseMaxWeights;
        }
    }
}
