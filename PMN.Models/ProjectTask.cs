using System;
using System.Collections.Generic;
using System.Text;

namespace PMN.Models
{
    public class ProjectTask
    {
        public int NidTask { get; set; }
        public int NidProject { get; set; }
        public Project Project { get; set; }
        public string TidTask { get; set; }
        public string DesTask { get; set; }
        public TimeSpan TimExpected { get; set; }
        public TimeSpan TimSpent { get; set; }
        public bool FlgTaskDone { get; set; }
    }
}
