using Microsoft.EntityFrameworkCore;
using PMN.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMN.Data
{
    public class ProjectRepository
    {
        protected PMNContext FContext;

        public ProjectRepository(PMNContext AContext)
        {
            FContext = AContext;
        }

        public IEnumerable<Project> GetProjects()
        {
            return FContext.Projects;
        }

        public async Task<Project> GetProject(int ANidProject)
        {
            return await FContext.Projects.FindAsync(ANidProject);
        }

        public void CreateProject(Project AProject)
        {
            FContext.Projects.Add(AProject);
        }

        public void EditProject(Project AProject)
        {
            FContext.Entry(AProject).State = EntityState.Modified;
        }

        public async Task DeleteProject(int ANidProject)
        {
            FContext.Projects.Remove(await FContext.Projects.FindAsync(ANidProject));
        }

        public async Task<int> SaveChanges()
        {
            return await FContext.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await FContext.DisposeAsync();
        }
    }
}
