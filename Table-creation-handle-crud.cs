#root/Models:
----------------
Project.cs:

/*
define table structure

*/

using System.ComponentModel.DataAnnotations;

namespace Portfalio.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public string Details { get; set; }

    }
}


#root/data:
---------------
ApplicationDbContext.cs:
-------------------------

/*
Create db table from modal

*/
using Microsoft.EntityFrameworkCore;
using Portfalio.Models;

namespace Portfalio.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Project { get; set; }
    }
}


#root/Service:
---------------

IMainService:
----------------

/*
create interface for db query
*/

using Portfalio.Models;

namespace Portfalio.Service
{
    public interface IMainService
    {
        public List<Project> GetAllProject();
        public void AddProject(Project project);  
        public Project GetProjectById(int id);
        public void UpdateProject(Project project);
        public void DeleteProject(Project project);
    }
}


#root/Service:
------------------
Mainservice.cs:
----------------------
/*implements interfaces and override query functions*/

using Portfalio.Data;
using Portfalio.Models;
using Portfalio.Service;

namespace Portfalio.Services
{
    public class MainService : IMainService
    {
        private readonly ApplicationDbContext db;

        public MainService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddProject(Project project)
        {
            db.Project.Add(project);
            db.SaveChanges();
        }

        public void DeleteProject(Project project)
        {
            db.Project.Remove(project);
            db.SaveChanges();
        }


        public List<Project> GetAllProject()
        {
            var projects = db.Project.ToList();

            return projects;
        }

        public Project GetProjectById(int id)
        {

            return db.Project.Find(id);
        }

        public void UpdateProject(Project project)
        {
            db.Project.Update(project);
            db.SaveChanges();
        }
    }
}

#root/Controller:
--------------------

ProjectsController.cs:
-----------------------

/*
create instance for interface for crud operations from controller
*/

using Microsoft.AspNetCore.Mvc;
using Portfalio.Models;
using Portfalio.Service;

namespace Portfalio.Controllers
{
    public class ProjectsController : Controller

    {
        private readonly IMainService mainService;

        public ProjectsController(IMainService mainService)
        {
            this.mainService = mainService;
        }

         
       

        public IActionResult Projects()
        { 
            var data = mainService.GetAllProject();
            if(data == null)
            {
                data = new List<Project>();
            }
             
            return View(data);
        }

        public IActionResult AddProject()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddProject(Project project)
        {
             mainService.AddProject(project);
            TempData["success"] = "New Project Added SuccessFully";
             return RedirectToAction(actionName: "Projects", controllerName: "Projects");
        }


        public IActionResult EditProject(int id)
        {
            var project = mainService.GetProjectById(id);
            return View(project);
        }

        [HttpPost]
        public IActionResult EditProject(Project project)
        {
            //mainService.AddProject(project);
            mainService.UpdateProject(project);
            TempData["success"] = "Project SuccessFully Edited";
            return RedirectToAction(actionName: "Projects", controllerName: "Projects");
        }


        public IActionResult DeleteProject(int id)
        {
            var project = mainService.GetProjectById(id);

            return View(project);
        }

        [HttpPost]
        public IActionResult DeleteProject(Project project)
        {
            //mainService.AddProject(project);
            mainService.DeleteProject(project);
            TempData["success"] = "Project Deleted!";
            return RedirectToAction(actionName: "Projects", controllerName: "Projects");
        }



    }
}


program.cs:
------------
/*include service inside program.cs*/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<Portfalio.Service.IMainService, Portfalio.Services.MainService>();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));

