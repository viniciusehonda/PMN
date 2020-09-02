using PMN.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PMN.Client.Services
{
    public class ProjectService
    {
        private readonly HttpClient httpClient;

        public ProjectService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<ProjectViewModel[]> GetProjects()
        {
            return await httpClient.GetFromJsonAsync<ProjectViewModel[]>("Project");
        }

        public async Task<ProjectViewModel> GetProject(int NidProject)
        {
            return await httpClient.GetFromJsonAsync<ProjectViewModel>($"Project/{NidProject}");
        }

        public async Task CreateProject(ProjectViewModel project)
        {
            await httpClient.PostAsJsonAsync<ProjectViewModel>("Project", project);
        }

        public async Task EditProject(ProjectViewModel project)
        {
            await httpClient.PutAsJsonAsync<ProjectViewModel>("Project", project);
        }

        public async Task DeleteProject(int NidProject)
        {
            await httpClient.DeleteAsync($"Project/{NidProject}");
        }
    }
}
