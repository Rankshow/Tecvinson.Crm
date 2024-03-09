using Tecvinson.Crm.Features.CourseGroups.Model;

namespace Tecvinson.Crm.Features.CourseGroups.Interface
{
    public interface ICourseGroupService
    {
        IEnumerable<CourseGroup> GetCourseGroups();
    }
}
