using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class WorkoutLogger
    {
        public List<Workout> WorkoutList { get; private set; } = new List<Workout>();

        // Method to Log a Workout
        public void LogWorkout(Workout workout)
        {
            if (workout == null)
                throw new ArgumentNullException(nameof(workout), "Workout cannot be null.");

            WorkoutList.Add(workout);
            Console.WriteLine($"Workout logged: {workout.GetType().Name}, Duration: {workout.Duration} minutes, Calories Burned: {workout.CaloriesBurned}");
        }

        // Method to Get All Workouts
        public List<Workout> GetWorkouts()
        {
            return WorkoutList;
        }

        // Method to Display Workouts
        public void DisplayWorkouts()
        {
            Console.WriteLine("Logged Workouts:");
            foreach (var workout in WorkoutList)
            {
                Console.WriteLine($"Type: {workout.GetType().Name}, Duration: {workout.Duration} minutes, Calories: {workout.CaloriesBurned}, Date: {workout.Date.ToShortDateString()}");
            }
        }
    }
}
