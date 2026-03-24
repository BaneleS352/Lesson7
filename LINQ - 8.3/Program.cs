using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace MiniExercise3_ActiveUserCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mini Exercise 3: Active User Count");
            Console.WriteLine("----------------------------------");

            Mini_ActiveUserCount();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

       
        static void Mini_ActiveUserCount()
        {

            // TODO:
            // 1. Create a list of 5 users.
            var users = new List<User>
            {
            // TODO: add 5 users here
            // 2. Give some users IsActive = true and some false.
            new User { Email = "user1@gmail.com", IsActive = true },
            new User {Email = "user2@gmail.com", IsActive = false},
            new User {Email = "user3@gmail.com", IsActive=true},
            new User {Email = "user4@gmail.com", IsActive = false}

            };
            // 3. Print each user.
            Console.WriteLine("Users:");
            foreach (var u in users)
            {
                Console.WriteLine($"- {u.Email} (Active: {u.IsActive})");
            }
            // 4. Use Count to calculate how many are active.
            int activeCount = users.Count(u => u.IsActive);

            // 5. Print the active user count.
            Console.WriteLine($"Active user count: {activeCount}");


        }

        public class User
        {
            public string Email { get; set; } = "";
            public bool IsActive { get; set; }
        }
    }
}