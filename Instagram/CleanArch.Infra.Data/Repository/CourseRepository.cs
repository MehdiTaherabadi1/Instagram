using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domin.Interfaces;
using CleanArch.Domin.Modals;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository  : ICourseRepository
    {
        #region Constrcture

        private InstagramDBContext context;

        public CourseRepository(InstagramDBContext context)
        {
            this.context = context;
        }

        #endregion

        public IEnumerable<Course> GetCourses()
        {
            return context.Courses;
        }

        public IQueryable<Course> GetAllCourse()
        {
            return context.Courses.AsQueryable();
        }
    }
}