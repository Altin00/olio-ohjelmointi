using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_26_wpf
{
    internal class WordTask_luokka
    {
    }
}
namespace TaskManagerApp.Models
{
    public class WorkTask : Task
    {
        public string ProjectName { get; set; }

        public WorkTask(string title, string description, DateTime dueDate, string projectName)
            : base(title, description, dueDate)
        {
            ProjectName = projectName;
        }

        public override string ToString()
        {
            return base.ToString() + " [Project: {ProjectName}]";
        }
    }
}
