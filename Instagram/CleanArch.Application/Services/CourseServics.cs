using System.Collections.Generic;
using System.Linq;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModel;
using CleanArch.Domin.Interfaces;
using CleanArch.Domin.Modals;

namespace CleanArch.Application.Services
{
    public class CourseServics : ICourseServices
    {
        private ICourseRepository courseRepository;

        public CourseServics(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public CourseViewModel GetCourse()
        {
            return new CourseViewModel()
            {
                Courses = courseRepository.GetCourses()
            };
        }

        public  Course GetCourseForShow(int courseId)
        {
            return courseRepository.GetAllCourse().SingleOrDefault(u => u.CourseId == courseId);
        }
    }
}