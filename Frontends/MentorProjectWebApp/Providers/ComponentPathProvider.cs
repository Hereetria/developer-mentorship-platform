
namespace MentorProjectWebApp.Providers
{
    public static class ComponentPathProvider
    {
        public static string GetComponentPath(string componentName)
        {
            var basePath = "~/Views/Shared/Components";
            var defaultViewName = "Default.cshtml";
            var upperFolderName = GetUpperFolderName(componentName);
            return $"{basePath}/{upperFolderName}/{componentName}/{defaultViewName}";

        }

        private static string GetUpperFolderName(string componentName)
        {
            string projectPath = ProjectPathProvider.GetProjectPath();

            var baseComponents = Directory.GetFiles($"{projectPath}/Controllers", "*.cs")
                                           .Select(fileName => Path.GetFileNameWithoutExtension(fileName))
                                           .Select(name => name.EndsWith("Controller")
                                                           ? name.Substring(0, name.Length - "Controller".Length)
                                                           : name)
                                           .ToList();

            var matchingBaseComponents = new List<string>();

            foreach (var baseComponent in baseComponents)
            {
                if (componentName.Substring(1).StartsWith(baseComponent, StringComparison.OrdinalIgnoreCase))
                {
                    matchingBaseComponents.Add(baseComponent);
                }
            }

            if (matchingBaseComponents.Count > 0)
            {
                string resultBaseComponent = matchingBaseComponents
                                              .OrderByDescending(name => name.Length)
                                              .First();
                string result = $"{resultBaseComponent}ComponentPartials";
                return result;
            }

            throw new ArgumentNullException("Component has not found");
        }

    }
}
