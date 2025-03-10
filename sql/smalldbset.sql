INSERT INTO exercises (exercise_name, category) VALUES
    ('Squat', 'Legs'),
    ('Deadlift', 'Back'),
    ('Bench Press', 'Chest'),
    ('Overhead Press', 'Shoulders'),
    ('Barbell Row', 'Back');

-- User 1
-- Medium Workout (2025-03-05)
INSERT INTO `workouts`(`user_id`, `date`, `notes`, `load`) VALUES ('1','2025-02-28','Test Medium Workout','medium');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (1,'1','100','1','squat','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (1,'3','80','1','benchpress','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (1,'5','70','1','barbell row','0');

-- Light Workout (2025-03-06)
INSERT INTO `workouts`(`user_id`, `date`, `notes`, `load`) VALUES ('1','2025-03-01','Test Light Workout','light');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (2,'1','90','1','squat','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (2,'4','60','1','overhead press','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (2,'2','110','1','deadlift','0');

-- Heavy Workout (2025-03-07)
INSERT INTO `workouts`(`user_id`, `date`, `notes`, `load`) VALUES ('1','2025-03-03','Test Heavy Workout','heavy');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (3,'1','120','1','squat','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (3,'3','100','1','benchpress','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (3,'5','90','1','barbell row','0');

-- Medium Workout (2025-03-05)
INSERT INTO `workouts`(`user_id`, `date`, `notes`, `load`) VALUES ('1','2025-03-05','Test Medium Workout','medium');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (4,'1','100','1','squat','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (4,'3','80','1','benchpress','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (4,'5','70','1','barbell row','0');

-- Light Workout (2025-03-06)
INSERT INTO `workouts`(`user_id`, `date`, `notes`, `load`) VALUES ('1','2025-03-07','Test Light Workout','light');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (5,'1','90','1','squat','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (5,'4','60','1','overhead press','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (5,'2','110','1','deadlift','0');

-- User 2
-- Medium Workout (2025-03-05)
INSERT INTO `workouts`(`user_id`, `date`, `notes`, `load`) VALUES ('2','2025-03-05','Test Medium Workout','medium');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (4,'1','100','1','squat','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (4,'3','80','1','benchpress','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (4,'5','70','1','barbell row','0');

-- Light Workout (2025-03-06)
INSERT INTO `workouts`(`user_id`, `date`, `notes`, `load`) VALUES ('2','2025-03-06','Test Light Workout','light');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (5,'1','90','1','squat','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (5,'4','60','1','overhead press','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (5,'2','110','1','deadlift','0');

-- Heavy Workout (2025-03-07)
INSERT INTO `workouts`(`user_id`, `date`, `notes`, `load`) VALUES ('2','2025-03-07','Test Heavy Workout','heavy');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (6,'1','120','1','squat','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (6,'3','100','1','benchpress','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (6,'5','90','1','barbell row','0');

-- User 3
-- Medium Workout (2025-03-05)
INSERT INTO `workouts`(`user_id`, `date`, `notes`, `load`) VALUES ('3','2025-03-05','Test Medium Workout','medium');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (7,'1','100','1','squat','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (7,'3','80','1','benchpress','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (7,'5','70','1','barbell row','0');

-- Light Workout (2025-03-06)
INSERT INTO `workouts`(`user_id`, `date`, `notes`, `load`) VALUES ('3','2025-03-06','Test Light Workout','light');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (8,'1','90','1','squat','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (8,'4','60','1','overhead press','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (8,'2','110','1','deadlift','0');

-- Heavy Workout (2025-03-07)
INSERT INTO `workouts`(`user_id`, `date`, `notes`, `load`) VALUES ('3','2025-03-07','Test Heavy Workout','heavy');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (9,'1','120','1','squat','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (9,'3','100','1','benchpress','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (9,'5','90','1','barbell row','0');

-- User 4
-- Medium Workout (2025-03-05)
INSERT INTO `workouts`(`user_id`, `date`, `notes`, `load`) VALUES ('4','2025-03-05','Test Medium Workout','medium');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (10,'1','100','1','squat','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (10,'3','80','1','benchpress','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (10,'5','70','1','barbell row','0');

-- Light Workout (2025-03-06)
INSERT INTO `workouts`(`user_id`, `date`, `notes`, `load`) VALUES ('4','2025-03-06','Test Light Workout','light');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (11,'1','90','1','squat','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (11,'4','60','1','overhead press','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (11,'2','110','1','deadlift','0');

-- Heavy Workout (2025-03-07)
INSERT INTO `workouts`(`user_id`, `date`, `notes`, `load`) VALUES ('4','2025-03-07','Test Heavy Workout','heavy');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (12,'1','120','1','squat','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (12,'3','100','1','benchpress','0');
INSERT INTO `workoutexercises`(`workout_id`, `exercise_id`, `actual_weight`, `is_successful`, `notes`, `failure_in_row`) VALUES (12,'5','90','1','barbell row','0');