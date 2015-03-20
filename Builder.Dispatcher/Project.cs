using NCalc;
using System;
using System.Collections.Generic;

namespace Builder.Dispatcher
{
    public class Project
    {
        public string Name { get; private set; }
        public Application application { get; private set; }
        public List<Project> ProjectsReferences { get; private set; }
        public string Guid { get; private set; }

        public Project(Application application, string name, string guid)
        {
            this.application = application;
            this.Name = name;
            this.ProjectsReferences = new List<Project>();
            this.Guid = "{" + guid.ToUpper() + "}";
        }

        public void AddReference(Project project)
        {
            this.ProjectsReferences.Add(project);
        }

        public void RemoveReference(Project project)
        {
            this.ProjectsReferences.RemoveAll(f => f.Name == project.Name);
        }

        /// <summary>
        /// Remover este m�todo, pq esse projeto n�o deveria conhecer a extens�o do arquivo
        /// Adicionado temporariamente 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public string GetRelativePathToProjectRef(Project project)
        {
            return "../" + project.Name + "/" + project.Name + ".csproj";
        }
    }
}
