using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{ 
    public enum MealType
{
    Breakfast,
    Lunch,
    Dinner,
    Snack
}

    internal class Meal
    {
    public string FoodName { get; set; }
    public double Calories { get; set; }
    public MealType MealType { get; set; }
    public DateTime Date { get; set; }

    // Constructor
    public Meal(string foodName, double calories, MealType mealType, DateTime date)
    {
        FoodName = foodName;
        Calories = calories;
        MealType = mealType;
        Date = date;
    }

    // Method to Log Meal
    public string LogMeal()
    {
        return $"Meal: {FoodName}, Calories: {Calories}, Type: {MealType}, Date: {Date.ToShortDateString()}";
    }
}
}
