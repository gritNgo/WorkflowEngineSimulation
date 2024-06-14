using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineSimulation
{
    internal class WorkflowEngine
    {
        private readonly IList<IWorkflowChannel> _workflowChannels= new List<IWorkflowChannel>();


        public void Run(Workflow workflow)
        {
            foreach (var channel in _workflowChannels)
            {
                channel.Execute();
            }
        }

        public void RegisterWorkflowChannel(IWorkflowChannel workflowChannel)
        {
            _workflowChannels.Add(workflowChannel);
        }
    }
}
