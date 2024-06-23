using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    // Main program class
    class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // List to store tasks
            List<Task> tasks = new List<Task>();
            // Variable to control the application loop
            bool continueApp = true;

            // Main application loop
            while (continueApp)
            {
                // Clear the console
                Console.Clear();
                // Display menu options
                Console.WriteLine("To-Do List Application");
                Console.WriteLine("======================");
                Console.WriteLine("1. View Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Complete Task");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                // Read user choice
                string choice = Console.ReadLine();

                // Perform action based on user choice
                switch (choice)
                {
                    case "1":
                        ViewTasks(tasks);
                        break;
                    case "2":
                        AddTask(tasks);
                        break;
                    case "3":
                        CompleteTask(tasks);
                        break;
                    case "4":
                        continueApp = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

        // Method to view all tasks
        static void ViewTasks(List<Task> tasks)
        {
            // Clear the console
            Console.Clear();
            // Display header
            Console.WriteLine("To-Do List");
            Console.WriteLine("==========");

            // Check if there are no tasks
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                // Loop through tasks and display each one
                for (int i = 0; i < tasks.Count; i++)
                {
                    Task task = tasks[i];
                    // Display task number, completion status, and description
                    Console.WriteLine("{0}. [{1}] {2}", i + 1, task.IsComplete ? "X" : " ", task.Description);
                }
            }

            // Wait for user input before returning to the main menu
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }

        // Method to add a new task
        static void AddTask(List<Task> tasks)
        {
            // Clear the console
            Console.Clear();
            // Display header
            Console.WriteLine("Add a New Task");
            Console.WriteLine("==============");
            // Prompt user for task description
            Console.Write("Enter task description: ");
            string description = Console.ReadLine();
            // Add new task to the list
            tasks.Add(new Task { Description = description, IsComplete = false });
            Console.WriteLine("Task added successfully!");
            // Wait for user input before returning to the main menu
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }

        // Method to mark a task as complete
        static void CompleteTask(List<Task> tasks)
        {
            // Clear the console
            Console.Clear();
            // Display header
            Console.WriteLine("Complete a Task");
            Console.WriteLine("===============");

            // Check if there are no tasks
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                // Loop through tasks and display each one
                for (int i = 0; i < tasks.Count; i++)
                {
                    Task task = tasks[i];
                    // Display task number, completion status, and description
                    Console.WriteLine("{0}. [{1}] {2}", i + 1, task.IsComplete ? "X" : " ", task.Description);
                }
                // Prompt user for the task number to complete
                Console.Write("Enter the number of the task to complete: ");
                int taskNumber;
                // Validate user input
                if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber >= 1 && taskNumber <= tasks.Count)
                {
                    // Mark the selected task as complete
                    tasks[taskNumber - 1].IsComplete = true;
                    Console.WriteLine("Task marked as complete!");
                }
                else
                {
                    // Display error message for invalid input
                    Console.WriteLine("Invalid task number! Please try again.");
                }
            }

            // Wait for user input before returning to the main menu
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }

        // Class to represent a task
        class Task
        {
            // Task description
            public string Description { get; set; }
            // Task completion status
            public bool IsComplete { get; set; }
        }
    }
}
