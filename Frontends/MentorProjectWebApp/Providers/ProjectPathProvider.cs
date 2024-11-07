namespace MentorProjectWebApp.Providers
{
    public static class ProjectPathProvider
    {
        public static string GetProjectPath()
        {
            var directoryPath = new DirectoryInfo(AppContext.BaseDirectory);

            return directoryPath.Parent?.Parent?.Parent?.FullName ??
                throw new InvalidOperationException("Project path has not found");
        }
    }
}
