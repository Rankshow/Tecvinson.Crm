using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Tecvinson.Crm.Features.CourseGroups.Interface;
using Tecvinson.Crm.Features.CourseGroups.Services;
using Tecvinson.Crm.Features.Mentors.Interfaces;
using Tecvinson.Crm.Features.Mentors.Services;

namespace Tecvinson.Crm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IMentorService, MentorService>();
            builder.Services.AddScoped<ICourseGroupService, CourseGroupService>();

            await builder.Build().RunAsync();
        }
    }
}
