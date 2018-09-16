﻿using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context.FluentInterface.Interfaces;
using FlubuCore.Tasks.Docker;

namespace FlubuCore.Context.FluentInterface
{
    public class DockerFluentInterface : IDockerFluentInterface
    {
        public TaskContext Context { get; set; }

        public DockerBuildTask Build(string pathOrUrl)
        {
            return Context.CreateTask<DockerBuildTask>(pathOrUrl);
        }

        public DockerRunTask Run(string image, string command, params string[] imageArgs)
        {
            return Context.CreateTask<DockerRunTask>(image, command, imageArgs);
        }
    }
}
