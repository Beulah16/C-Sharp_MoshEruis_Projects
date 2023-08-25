using System;
namespace Intermediate
{
    class UsingWorkflowEngine
    {
        static void Main(string[]args)
        {
            var workflowEngine = new WorkflowEngine();
            workflowEngine.Add(new Upload());
            workflowEngine.Add(new Call());
            workflowEngine.Add(new Send());
            workflowEngine.Add(new Change());
            workflowEngine.Run();
        }
    }
}
