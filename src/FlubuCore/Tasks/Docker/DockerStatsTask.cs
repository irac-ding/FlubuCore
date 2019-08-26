
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerStatsTask : ExternalProcessTaskBase<int, DockerStatsTask>
     {
        private string[] _container;

        
        public DockerStatsTask(params string[] container)
        {
            ExecutablePath = "docker";
            WithArgumentsKeyFromAttribute();
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Show all containers (default shows just running)
        /// </summary>
        [ArgKey("all")]
        public DockerStatsTask All()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Pretty-print images using a Go template
        /// </summary>
        [ArgKey("format")]
        public DockerStatsTask Format(string format)
        {
            WithArgumentsKeyFromAttribute(format.ToString());
            return this;
        }

        /// <summary>
        /// Disable streaming stats and only pull the first result
        /// </summary>
        [ArgKey("no-stream")]
        public DockerStatsTask NoStream()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Do not truncate output
        /// </summary>
        [ArgKey("no-trunc")]
        public DockerStatsTask NoTrunc()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}