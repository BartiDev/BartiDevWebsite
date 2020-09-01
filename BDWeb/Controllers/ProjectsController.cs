using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDWeb.Controllers
{
    public class ProjectsController : Controller
    {
        public ViewResult GetAllProjectsCategories()
        {
            return View();
        }

        public string GetAllCSharpProjects()
        {
            return "c# projects";
        }

        public string GetAllDataScienceAndMLProjects()
        {
            return "data science and ML projects";
        }
    }
}
