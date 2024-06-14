using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineSimulation
{
    internal class VideoUpload : IWorkflowChannel
    {
        public void Execute()
        {
            Console.WriteLine("Upload video to cloud storage");
            Console.WriteLine("Send notification for video ready for encoding");
            Console.WriteLine("Send owner a confirmation that video has started processing");
            Console.WriteLine("Update video record in database to 'Processing'");
        }
    }
}
