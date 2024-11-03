using Microsoft.AspNetCore.Mvc.Razor;

namespace MentorProjectWebApp.Configurations
{
    public class ViewComponentLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var customLocations = new[]
            {
            "/Views/Shared/Components/{1}/Default.cshtml"
        };

            return customLocations.Concat(viewLocations);
        }

        public void PopulateValues(ViewLocationExpanderContext context) { }
    }
}
