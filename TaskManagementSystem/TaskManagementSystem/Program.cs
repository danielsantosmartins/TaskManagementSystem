using System;
using System.Collections.Generic;
using System.Linq;
using TaskManagementSystem.Entities;
using TaskManagementSystem.Entities.Enums;

namespace TaskManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, let's start your tasks!");
            Console.WriteLine("What do you want to do? (creat, delete, edit, exit) ");
            string response = Console.ReadLine();

            List<Task> list = new List<Task>();

            while (response != "exit")
            {
                if (response == "creat")
                {
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Description: ");
                    string description = Console.ReadLine();

                    list.Add(new Task(title, description, Status.Pending));
                }
                else if (response == "delete")
                {
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    list.RemoveAll(t => t.Title == title);
                }
                else
                {
                    Console.Write("Title: ");
                    string title = Console.ReadLine();

                    Console.Write("New Title: ");
                    string nTitle = Console.ReadLine();
                    Console.Write("New Description: ");
                    string nDescription = Console.ReadLine();
                    Console.Write("New Status (Pending, Running, Completed, Canceled): ");
                    Status nStatus = Enum.Parse<Status>(Console.ReadLine());
                    

                   var nlist = list.Where(t => t.Title == title);
                   
                    foreach(var i in nlist)
                    {
                        i.Title = nTitle;
                        i.Description = nDescription;
                        i.Status = nStatus;
                    }

                }

                Console.WriteLine();

                foreach(Task t in list)
                {
                    Console.WriteLine(t);
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("What do you want to do? (creat, delete, edit, exit) ");
                response = Console.ReadLine();
            }
        }
    }
}
