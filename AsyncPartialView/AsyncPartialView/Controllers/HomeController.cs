using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsyncPartialView.Controllers
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class Course
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }

    public class Dashboard
    {
        public List<User> Users { get; set; }
        public List<Course> Courses { get; set; }
        // something more
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // get dashboard data model
            var dashBoardModel = new Dashboard();
            //dashBoardModel.Users = GetUsers();
            //dashBoardModel.Courses = GetCourses();

            // return dashboard page with data model
            return View("IndexAsync", dashBoardModel);
        }

        public ActionResult _GetCourses()
        {
            var courses = GetCourses();
            return PartialView("_GetCourses", courses);
        }

        public ActionResult _GetUsers()
        {
            var courses = GetUsers();
            return PartialView("_GetUsers", courses);
        }

        private List<Course> GetCourses()
        {
            System.Threading.Thread.Sleep(2000);
            return new List<Course>()
            {
                new Course { Id = Guid.NewGuid().ToString(), Title = "Chemistry"},
                new Course { Id = Guid.NewGuid().ToString(), Title = "Math"},
            };
        }

        private List<User> GetUsers()
        {
            System.Threading.Thread.Sleep(2000);
            return new List<User>()
            {
                new User { Id = Guid.NewGuid().ToString(), Name = "Chu Hong Kien" },
                new User { Id = Guid.NewGuid().ToString(), Name = "Bill Gates" },
            };
        }
    }
}