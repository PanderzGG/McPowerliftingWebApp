﻿using MCPowerlifting.Models.Entities;
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
            else if(!nextWeights.Any(x => x.isNew))
            {
                var load = nextWeights[0];

                switch (load.workoutLoad)
                {
                        case "light":
                            foreach (var pair in nextWeights)
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
                            break;
                        case "medium":
                            foreach (var pair in nextWeights)
                            {
                                switch (pair.exerciseName.ToLower())
                                {
                                    case "squat":
                                        exerciseWeights.Add(pair.exerciseName, pair.weight);
                                    break;
                                    case "overhead press":
                                        exerciseWeights.Add(pair.exerciseName, pair.weight);
                                    break;
                                    case "barbell row":
                                        exerciseWeights.Add(pair.exerciseName, pair.weight);
                                    break;
                                }
                            }
                        break;
                        case "heavy":
                            foreach (var pair in nextWeights)
                            {
                                switch (pair.exerciseName.ToLower())
                                {
                                    case "squat":
                                        exerciseWeights.Add(pair.exerciseName, pair.weight);
                                    break;
                                    case "overhead press":
                                        exerciseWeights.Add(pair.exerciseName, pair.weight);
                                    break;
                                    case "barbell row":
                                        exerciseWeights.Add(pair.exerciseName, pair.weight);
                                    break;
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
                    workingSetsRepsWeights = CalculateWorkingSetWeights(loadType, maxWeight);
                    totalSetRepWeight.AddRange(workingSetsRepsWeights);

                    if (workingSetsRepsWeights.First(x => x.SetNumber == 1).SetWeight > 40)
                    {
                        double minimumWeight = workingSetsRepsWeights.First(x => x.SetNumber == 1).SetWeight;
                        warmUpSetsRepsWeights = CalculateWarmUpWeights(minimumWeight);
                    }
                    if(warmUpSetsRepsWeights.Count > 0)
                    {
                        totalSetRepWeight.AddRange(warmUpSetsRepsWeights);
                    }

                    break;
                case "deadlift":
                    workingSetsRepsWeights = CalculateWorkingSetWeights(loadType, maxWeight);
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
                    workingSetsRepsWeights = CalculateWorkingSetWeights(loadType, maxWeight);
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
                    workingSetsRepsWeights = CalculateWorkingSetWeights(loadType, maxWeight);
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
                    workingSetsRepsWeights = CalculateWorkingSetWeights(loadType, maxWeight);
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
                ActiveExercise tempSet= new ActiveExercise();
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


        private List<ActiveExercise> CalculateWorkingSetWeights(string loadType, double maxWeight)
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
                            SetNumber = i + 1,
                            SetType = "working",
                            SetWeight = maxWeight - ((maxWeight * 0.125) * (3 - (i))),
                            SetReps = 5
                        });
                    }

                    workingSet.Add(new ActiveExercise
                    {
                        SetNumber = 5,
                        SetType = "working",
                        SetWeight = maxWeight,
                        SetReps = 3
                    });

                    workingSet.Add(new ActiveExercise
                    {
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
