﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FlubuCore.Tasks.NetCore
{
    /// <summary>
    /// Publishes a .NET project for deployment (including the runtime).
    /// </summary>
    public class DotnetBuildTask : ExecuteDotnetTask
    {
        public DotnetBuildTask() : base(StandardDotnetCommands.Build)
        {
        }

        /// <summary>
        /// The MSBuild project file to build. If a project file is not specified, MSBuild searches the current working directory for a file that has a file extension that ends in `proj` and uses that file.
        /// </summary>
        /// <param name="projectName"></param>
        /// <returns></returns>
        public DotnetBuildTask Project(string projectName)
        {
            WithArguments(projectName);
            return this;
        }

        public DotnetBuildTask Framework(string framework)
        {
            WithArguments("-f", framework);
            return this;
        }

        /// <summary>
        /// Target runtime to build for. The default is to build a portable application.
        /// </summary>
        /// <param name="runtime"></param>
        /// <returns></returns>
        public DotnetBuildTask AddRuntime(string runtime)
        {
            WithArguments("-r", runtime);
            return this;
        }

        /// <summary>
        /// Configuration to use for building the project. Default for most projects is  "Debug".
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public DotnetBuildTask Configuration(string configuration)
        {
            WithArguments("-c", configuration);
            return this;
        }

        /// <summary>
        ///  Disables incremental build.
        /// </summary>
        /// <returns></returns>
        public DotnetBuildTask NoIncrementail()
        {
            WithArguments("--no-incremental");
            return this;
        }

        /// <summary>
        ///  Set this flag to ignore project to project references and only restore the root project
        /// </summary>
        /// <returns></returns>
        public DotnetBuildTask NoDependencies()
        {
            WithArguments("--no-dependencies");
            return this;
        }
    }
}