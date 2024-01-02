using WorkFlowEngine;

Workflow workflow = new Workflow();
workflow.addActivity(new VideoUploaderActivity());
workflow.addActivity(new VideoEncoderActivity());
workflow.addActivity(new VideoNotificationActivity());
workflow.addActivity(new VideoDatabaseActivity());
WorkflowEngine workflowEngine = new WorkflowEngine();
workflowEngine.Run(workflow);