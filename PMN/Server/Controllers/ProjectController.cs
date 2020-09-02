using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PMN.Core;
using PMN.Models;
using PMN.ViewModels;

namespace PMN.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        public ProjectCore FCore;

        public ProjectController(ProjectCore ACore)
        {
            FCore = ACore;
        }

        [HttpGet]
        public IEnumerable<ProjectViewModel> GetProjects()
        {
            return FCore.GetProjects().Select(a => FCore.MapToViewModel(a));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Project LProject = await FCore.GetProject(id);

            if (LProject == null)
            {
                return NotFound();
            }

            return Ok(FCore.MapToViewModel(LProject));
        }

        [HttpPost]
        public async Task<IActionResult> PostProject([FromBody] ProjectViewModel project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Project LProject = FCore.MapToModel(project);
            FCore.CreateProject(LProject);
            await FCore.SaveChanges();

            return CreatedAtAction("GetProject", new { id = LProject.NidProject }, LProject);
        }

        [HttpPut]
        public async Task<IActionResult> PutProject([FromBody] ProjectViewModel project)
        {
            Project LProject = new Project()
            {
                NidProject = project.NidProject,
                TidProject = project.TidProject,
                DesProject = project.DesProject,
                DatProjectStart = project.DatProjectStart,
                DatProjectEnd = project.DatProjectEnd
            };

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                FCore.EditProject(LProject);
                await FCore.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            FCore.DeleteProject(id);
            await FCore.SaveChanges();

            return Ok();
        }
    }
}
