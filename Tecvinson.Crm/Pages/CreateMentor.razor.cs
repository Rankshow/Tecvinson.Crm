using Microsoft.AspNetCore.Components;
using Tecvinson.Crm.Features.CourseGroups.Interface;
using Tecvinson.Crm.Features.CourseGroups.Model;
using Tecvinson.Crm.Features.Mentors.Enums;
using Tecvinson.Crm.Features.Mentors.Interfaces;
using Tecvinson.Crm.Features.Mentors.Models;

namespace Tecvinson.Crm.Pages
{
    public partial class CreateMentor
    {
        public Mentor Mentor { get; set; } = new Mentor();

        public List<CourseGroup>? CourseGroups { get; set; }
        public List<Gender>? Genders { get; set; }      

        [Inject]
        private ICourseGroupService? CourseGroupService { get; set; }
        [Inject]
        private IMentorService? MentorService { get; set; }

        //This will reinitialize once th course is added to the list.  
        protected override Task OnInitializedAsync()
        {
            CourseGroups = CourseGroupService?.GetCourseGroups().ToList();
            Genders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            return Task.CompletedTask;
        }

        //Eventlistener
        public void AddMentorData()
        {
            MentorService?.AddMentor(Mentor);
        }
    }
}
