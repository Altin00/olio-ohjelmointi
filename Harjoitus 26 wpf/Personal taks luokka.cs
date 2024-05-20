using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_26_wpf
{
    internal class Personal_taks_luokka
    {
    }
}
namespace TaskManagerApp.Models
{
    public class PersonalTask : Task
    {
        public string Location { get; set; }

        public PersonalTask(string title, string description, DateTime dueDate, string location)
            : base(title, description, dueDate)
        {
            Location = location;
        }

        public override string ToString()
        {
            return base.ToString() + " [Location: {Location}]";
        }
    }
}
