using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_26_wpf
{
    internal class Task_luokka
    {
    }
}


namespace TaskManagerApp.Models
{
    public abstract class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        public Task(string title, string description, DateTime dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
        }

        public override string ToString()
        {
            return "{Title} - {Description} (Due: {DueDate.ToShortDateString()})";
        }
    }
}
