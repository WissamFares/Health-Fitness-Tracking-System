using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Report
    {
        public string GenerateWorkoutReport(List<Workout> workouts)
        {
            if (workouts == null || workouts.Count == 0)
            {
                return "No workouts logged.";
            }

            double totalDuration = 0;
            double totalCalories = 0;

            foreach (var workout in workouts)
            {
                totalDuration += workout.Duration;
                totalCalories += workout.CaloriesBurned;
            }

            return $"Total Workouts: {workouts.Count}, Total Duration: {totalDuration} minutes, Total Calories Burned: {totalCalories} calories.";
        }

        // Method to Generate Meal Report
        public string GenerateMealReport(List<Meal> meals)
        {
            if (meals == null || meals.Count == 0)
            {
                return "No meals logged.";
            }

            double totalCalories = 0;

            foreach (var meal in meals)
            {
                totalCalories += meal.Calories;
            }

            return $"Total Meals: {meals.Count}, Total Calories Consumed: {totalCalories} calories.";
        }
    }
}
