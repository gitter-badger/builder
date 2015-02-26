﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Builder.Template.Template
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Junior\Projetos\GITHUB.COM\builder\Builder.Template\Template\XmlCsProjTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class XmlCsProjTemplate : XmlCsProjTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"<?xml version=""1.0"" encoding=""utf-8""?>
<Project ToolsVersion=""4.0"" DefaultTargets=""Build"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
  <Import Project=""$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props"" Condition=""Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')"" />
  <PropertyGroup>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>
    <ProjectGuid>");
            
            #line 16 "D:\Junior\Projetos\GITHUB.COM\builder\Builder.Template\Template\XmlCsProjTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_projectGuid));
            
            #line default
            #line hidden
            this.Write("</ProjectGuid>\r\n    <OutputType>Library</OutputType>\r\n    <AppDesignerFolder>Prop" +
                    "erties</AppDesignerFolder>\r\n    <RootNamespace>");
            
            #line 19 "D:\Junior\Projetos\GITHUB.COM\builder\Builder.Template\Template\XmlCsProjTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_rootNamespace));
            
            #line default
            #line hidden
            this.Write("</RootNamespace>\r\n    <AssemblyName>");
            
            #line 20 "D:\Junior\Projetos\GITHUB.COM\builder\Builder.Template\Template\XmlCsProjTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_assemblyName));
            
            #line default
            #line hidden
            this.Write("</AssemblyName>\r\n    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>\r\n    <" +
                    "FileAlignment>512</FileAlignment>\r\n  </PropertyGroup>\r\n  <PropertyGroup Conditio" +
                    "n=\" \'$(Configuration)|$(Platform)\' == \'Debug|AnyCPU\' \">\r\n    <DebugSymbols>true<" +
                    "/DebugSymbols>\r\n    <DebugType>full</DebugType>\r\n    <Optimize>false</Optimize>\r" +
                    "\n    <OutputPath>bin\\Debug\\</OutputPath>\r\n    <DefineConstants>DEBUG;TRACE</Defi" +
                    "neConstants>\r\n    <ErrorReport>prompt</ErrorReport>\r\n    <WarningLevel>4</Warnin" +
                    "gLevel>\r\n  </PropertyGroup>\r\n  <PropertyGroup Condition=\" \'$(Configuration)|$(Pl" +
                    "atform)\' == \'Release|AnyCPU\' \">\r\n    <DebugType>pdbonly</DebugType>\r\n    <Optimi" +
                    "ze>true</Optimize>\r\n    <OutputPath>bin\\Release\\</OutputPath>\r\n    <DefineConsta" +
                    "nts>TRACE</DefineConstants>\r\n    <ErrorReport>prompt</ErrorReport>\r\n    <Warning" +
                    "Level>4</WarningLevel>\r\n  </PropertyGroup>\r\n  <ItemGroup>\r\n    <Reference Includ" +
                    "e=\"System\" />\r\n    <Reference Include=\"System.Core\" />\r\n    <Reference Include=\"" +
                    "System.Xml.Linq\" />\r\n    <Reference Include=\"System.Data.DataSetExtensions\" />\r\n" +
                    "    <Reference Include=\"Microsoft.CSharp\" />\r\n    <Reference Include=\"System.Dat" +
                    "a\" />\r\n    <Reference Include=\"System.Xml\" />\r\n  </ItemGroup>\r\n  <ItemGroup>\r\n  " +
                    "  <Compile Include=\"Properties\\AssemblyInfo.cs\" />\r\n  </ItemGroup>\r\n  <Import Pr" +
                    "oject=\"$(MSBuildToolsPath)\\Microsoft.CSharp.targets\" />\r\n  <!-- To modify your b" +
                    "uild process, add your task inside one of the targets below and uncomment it. \r\n" +
                    "       Other similar extension points exist, see Microsoft.Common.targets.\r\n  <T" +
                    "arget Name=\"BeforeBuild\">\r\n  </Target>\r\n  <Target Name=\"AfterBuild\">\r\n  </Target" +
                    ">\r\n  -->\r\n</Project>");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "D:\Junior\Projetos\GITHUB.COM\builder\Builder.Template\Template\XmlCsProjTemplate.tt"

private string @__projectGuidField;

/// <summary>
/// Access the _projectGuid parameter of the template.
/// </summary>
private string _projectGuid
{
    get
    {
        return this.@__projectGuidField;
    }
}

private string @__rootNamespaceField;

/// <summary>
/// Access the _rootNamespace parameter of the template.
/// </summary>
private string _rootNamespace
{
    get
    {
        return this.@__rootNamespaceField;
    }
}

private string @__assemblyNameField;

/// <summary>
/// Access the _assemblyName parameter of the template.
/// </summary>
private string _assemblyName
{
    get
    {
        return this.@__assemblyNameField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool _projectGuidValueAcquired = false;
if (this.Session.ContainsKey("_projectGuid"))
{
    this.@__projectGuidField = ((string)(this.Session["_projectGuid"]));
    _projectGuidValueAcquired = true;
}
if ((_projectGuidValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("_projectGuid");
    if ((data != null))
    {
        this.@__projectGuidField = ((string)(data));
    }
}
bool _rootNamespaceValueAcquired = false;
if (this.Session.ContainsKey("_rootNamespace"))
{
    this.@__rootNamespaceField = ((string)(this.Session["_rootNamespace"]));
    _rootNamespaceValueAcquired = true;
}
if ((_rootNamespaceValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("_rootNamespace");
    if ((data != null))
    {
        this.@__rootNamespaceField = ((string)(data));
    }
}
bool _assemblyNameValueAcquired = false;
if (this.Session.ContainsKey("_assemblyName"))
{
    this.@__assemblyNameField = ((string)(this.Session["_assemblyName"]));
    _assemblyNameValueAcquired = true;
}
if ((_assemblyNameValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("_assemblyName");
    if ((data != null))
    {
        this.@__assemblyNameField = ((string)(data));
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class XmlCsProjTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
