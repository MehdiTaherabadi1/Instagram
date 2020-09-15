using CleanArch.Domin.Modals;
using System.Collections.Generic;

namespace CleanArch.Application.ViewModel
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}