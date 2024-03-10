using Microsoft.AspNetCore.Components;
using Tecvinson.Crm.Features.Mentors.Interfaces;
using Tecvinson.Crm.Features.Mentors.Models;

namespace Tecvinson.Crm.Pages
{
    public partial class MentorsIndex
    {
        [Inject]
        private IMentorService? MentorService { get; set; }


        [Inject]
        private NavigationManager? NavigationManager { get; set; }

        public List<Mentor>? Mentors { get; set; }
         
        //This will reinitialize once the component is added to the list.
        protected override Task OnInitializedAsync()
        {
            Mentors = MentorService?.GetAllMentors().ToList();
            return Task.CompletedTask;  
        }

        public void Log(string value)
        {
            Console.WriteLine(value);
        }

        public void ModifyMentor(string mentorId)
        {
            NavigationManager?.NavigateTo($"/updateMentor/{mentorId}");
        }
    }
}
