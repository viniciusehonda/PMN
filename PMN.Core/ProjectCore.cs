using PMN.Data;
using PMN.Models;
using PMN.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMN.Core
{
    public class ProjectCore
    {
        ProjectRepository Repository;

        public ProjectCore(ProjectRepository ARepository)
        {
            Repository = ARepository;
        }

        public IEnumerable<Project> GetProjects()
        {
            return Repository.GetProjects();
        }

        public async Task<Project> GetProject(int ANidProject)
        {
            return await Repository.GetProject(ANidProject);
        }

        public void CreateProject(Project AProject)
        {
            Repository.CreateProject(AProject);
        }

        public void EditProject(Project AProject)
        {
            Repository.EditProject(AProject);
        }

        public void DeleteProject(int ANidProject)
        {
            Repository.DeleteProject(ANidProject);
        }

        public async Task<int> SaveChanges()
        {
            return await Repository.SaveChanges();
        }

        public void Dispose()
        {
            Repository.Dispose();
        }

        public ProjectViewModel MapToViewModel(Project AModel)
        {
            return new ProjectViewModel()
            {
                NidProject = AModel.NidProject,
                TidProject = AModel.TidProject,
                DesProject = AModel.DesProject,
                DatProjectStart = AModel.DatProjectStart,
                DatProjectEnd = AModel.DatProjectEnd
            };
        }

        public Project MapToModel(ProjectViewModel AViewModel)
        {
            return new Project()
            {
                NidProject = AViewModel.NidProject,
                TidProject = AViewModel.TidProject,
                DesProject = AViewModel.DesProject,
                DatProjectStart = AViewModel.DatProjectStart,
                DatProjectEnd = AViewModel.DatProjectEnd
            };
        }
    }
}
