using Tecvinson.Crm.Features.CourseGroups.Interface;
using Tecvinson.Crm.Features.CourseGroups.Model;

namespace Tecvinson.Crm.Features.CourseGroups.Services
{
    public class CourseGroupService : ICourseGroupService
    {
        private static readonly List<CourseGroup> _courseGroups = new()
        {
            new CourseGroup()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Group 1"
            },
            new CourseGroup()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Group 2"
            },
            new CourseGroup()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Group 3"
            },
        };

        public IEnumerable<CourseGroup> GetCourseGroups()
        {
            return _courseGroups;
        }
    }
}
