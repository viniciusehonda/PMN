using System;
using System.Collections.Generic;
using System.Text;

namespace PMN.Models
{
    public class Project
    {
        public int NidProject { get; set; }
        public string TidProject { get; set; }
        public string DesProject { get; set; }

        public DateTime DatProjectStart { get; set; }
        public DateTime? DatProjectEnd { get; set; }

        public ICollection<ProjectTask> ProjectTasks { get; set; }

        public Project()
        {
            ProjectTasks = new List<ProjectTask>();
        }
    }
}
