using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMN.Data
{
    public class DbInitializer
    {
        public static void Initialize(PMNContext AContext)
        {
            AContext.Database.Migrate();
        }
    }
}
