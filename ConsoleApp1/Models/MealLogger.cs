using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class MealLogger
    {
        public List<Meal> MealList { get; private set; } = new List<Meal>();

        // Method to Log a Meal
        public void LogMeal(Meal meal)
        {
            if (meal == null)
                throw new ArgumentNullException(nameof(meal), "Meal cannot be null.");

            MealList.Add(meal);
            Console.WriteLine($"Meal logged: {meal.FoodName}, Calories: {meal.Calories}, Type: {meal.MealType}, Date: {meal.Date.ToShortDateString()}");
        }

        // Method to Get All Meals
        public List<Meal> GetMeals()
        {
            return MealList;
        }

        // Method to Display Meals
        public void DisplayMeals()
        {
            Console.WriteLine("Logged Meals:");
            foreach (var meal in MealList)
            {
                Console.WriteLine($"Food: {meal.FoodName}, Calories: {meal.Calories}, Type: {meal.MealType}, Date: {meal.Date.ToShortDateString()}");
            }
        }
    }
}
