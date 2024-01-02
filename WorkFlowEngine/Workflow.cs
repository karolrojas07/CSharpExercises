using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    internal class Workflow
    {
        private readonly List<IActivity> activities;

        public Workflow()
        {
            activities = new List<IActivity>();
        }

        public void addActivity(IActivity activity)
        {
            if (activity == null) throw new InvalidOperationException();
            activities.Add(activity);
        }
        public void Run()
        {
            activities.ForEach(activity => { activity.Execute(); });
        }
    }
}
