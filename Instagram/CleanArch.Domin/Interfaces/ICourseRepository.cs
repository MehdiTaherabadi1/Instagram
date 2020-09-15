using System.Collections.Generic;
using CleanArch.Domin.Modals;

namespace CleanArch.Domin.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}