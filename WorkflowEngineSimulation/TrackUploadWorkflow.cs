using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineSimulation
{
    internal class TrackUpload : IWorkflowChannel
    {
        public void Execute()
        {
            Console.WriteLine("Upload track to cloud storage");
            Console.WriteLine("Send notification for track ready for encoding");
            Console.WriteLine("Send owner a confirmation that track has started processing");
            Console.WriteLine("Update track record in database to 'Processing'");
        }
    }
}
