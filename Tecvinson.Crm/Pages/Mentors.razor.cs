using Microsoft.AspNetCore.Components;
using Tecvinson.Crm.Features.Mentors.Models;

namespace Tecvinson.Crm.Pages
{
    public partial class Mentors
    {
        [Parameter]
        public List<Mentor>? ListMentors { get; set; }
        [Parameter]
        public EventCallback<string> OnEditMentor { get; set; } 

        //Generate an Event but in different way.
        public void EditMentor(string mentorId)
        {
            OnEditMentor.InvokeAsync(mentorId);
        }
    }
}
