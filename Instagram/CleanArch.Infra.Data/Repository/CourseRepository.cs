using System.Collections.Generic;
using CleanArch.Domin.Interfaces;
using CleanArch.Domin.Modals;
using CleanArch.Infra.Data.Context;

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
    }
}