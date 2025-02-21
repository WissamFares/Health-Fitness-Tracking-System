using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Weight { get; set; }

        // Constructor Overloading
        public User(string name, string email)
        {
            Name = name;
            Email = email;
            Weight = 0; // Default weight
        }

        public User(string name, string email, double weight)
        {
            Name = name;
            Email = email;
            Weight = weight;
        }

        // Methods
        public void SetProfile(string name, string email, double weight)
        {
            Name = name;
            Email = email;
            Weight = weight;
        }

        public string ViewProfile()
        {
            return $"Name: {Name}, Email: {Email}, Weight: {Weight} kg";
        }
    }
}
