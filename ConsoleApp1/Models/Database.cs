using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppUser = ConsoleApp1.Models.User;

namespace ConsoleApp1.Models
{
    internal class Database
    {
        public List<User> Users { get; private set; } = new List<User>();
        public List<Workout> Workouts { get; private set; } = new List<Workout>();
        public List<Meal> Meals { get; private set; } = new List<Meal>();

        // Method to Save Data (Simulated)
        public void SaveData()
        {
            Console.WriteLine("Data has been saved successfully.");
            // In a real application, data would be written to a database or file system.
        }

        // Method to Load Data (Simulated)
        public void LoadData()
        {
            Console.WriteLine("Data has been loaded successfully.");
            // In a real application, data would be read from a database or file system.
        }
    }
}
