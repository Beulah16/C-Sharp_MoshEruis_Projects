using System.Collections.Generic;
namespace Intermediate
    {
        public class WorkflowEngine
        {
            private readonly List<IActivity> _activity;
            public WorkflowEngine() 
            {
               _activity = new List<IActivity>();
            }
            public void Add(IActivity activity)
            {
                _activity.Add(activity);
            }
            public void Remove(IActivity activity)
            {
                _activity.Remove(activity);
            }
            public void Run()
            {
                foreach(var item in _activity)
                {
                    item.Execute();
                }
            }
        }
    }