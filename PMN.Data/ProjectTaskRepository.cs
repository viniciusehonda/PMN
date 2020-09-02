using System;
using System.Collections.Generic;
using System.Text;

namespace PMN.Data
{
    public class ProjectTaskRepository
    {
        protected PMNContext FContext;

        public ProjectTaskRepository(PMNContext AContext)
        {
            FContext = AContext;
        }
    }
}
