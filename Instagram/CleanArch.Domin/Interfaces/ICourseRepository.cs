using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domin.Modals;

namespace CleanArch.Domin.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        IQueryable<Course> GetAllCourse();
    }
}