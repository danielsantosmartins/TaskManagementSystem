using System;
using System.Collections.Generic;
using System.Text;
using TaskManagementSystem.Entities.Enums;

namespace TaskManagementSystem.Entities
{
    class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }

        public Task(string title, string description, Status status)
        {
            Title = title;
            Description = description;
            Status = status;
        }

        public override string ToString()
        {
            return "Title:"
                + Title
                + "\n"
                + "Description: "
                + Description
                +"\n"
                + "Status: "
                + Status;
        }
    }
}
