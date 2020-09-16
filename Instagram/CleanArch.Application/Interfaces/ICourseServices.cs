using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.ViewModel;
using CleanArch.Domin.Modals;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseServices
    {
        CourseViewModel GetCourse();
        Course GetCourseForShow(int courseId);
    }
}