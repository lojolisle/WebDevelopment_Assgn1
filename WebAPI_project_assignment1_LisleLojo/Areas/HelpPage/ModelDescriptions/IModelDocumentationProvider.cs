using System;
using System.Reflection;

namespace WebAPI_project_assignment1_LisleLojo.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}