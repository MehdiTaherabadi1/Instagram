using System.Collections.Generic;
using CleanArch.Application.ViewModel;
using CleanArch.Domin.Modals;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseServices
    {
        CourseViewModel GetCourse();
    }
}