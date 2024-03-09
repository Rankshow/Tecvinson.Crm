using Tecvinson.Crm.Features.Mentors.Models;

namespace Tecvinson.Crm.Features.Mentors.Interfaces
{
    public interface IMentorService
    {
        bool AddMentor(Mentor mentor);
        bool UpdateMentor(Mentor mentor);
        bool DeleteMentor(string id);
        Mentor GetMentor(string id);
        IEnumerable<Mentor> GetAllMentors();
    }
}
