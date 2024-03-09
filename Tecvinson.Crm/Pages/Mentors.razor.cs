using Microsoft.AspNetCore.Components;
using Tecvinson.Crm.Features.Mentors.Models;

namespace Tecvinson.Crm.Pages
{
    public partial class Mentors
    {
        [Parameter]
        public List<Mentor>? ListMentors { get; set; }
    }
}
