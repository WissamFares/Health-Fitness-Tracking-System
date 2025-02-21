using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class NotificationService
    {
        public void SendNotification(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Notification message cannot be empty.", nameof(message));
            }

            // Simulate sending a notification (e.g., display a console message)
            Console.WriteLine($"Notification: {message}");
        }
    }
}
