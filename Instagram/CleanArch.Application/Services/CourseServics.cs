using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModel;
using CleanArch.Domin.Interfaces;

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
    }
}