using WorkflowEngineSimulation;

var workflowEngine = new WorkflowEngine();
workflowEngine.RegisterWorkflowChannel(new VideoUpload());
workflowEngine.RegisterWorkflowChannel(new TrackUpload());

workflowEngine.Run(new Workflow());