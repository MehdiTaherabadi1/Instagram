using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Instargram.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseServices courseServices;

        public CourseController(ICourseServices courseServices)
        {
            this.courseServices = courseServices;
        }

        public IActionResult Index()
        {
            CourseViewModel model =  courseServices.GetCourse();
            return View(model);
        }

        [Route("ShowCourse/{id}")]
        public IActionResult ShowCourse(int id)
        {
            var course = courseServices.GetCourseForShow(id);

            return View(course);
        }
    }
}
