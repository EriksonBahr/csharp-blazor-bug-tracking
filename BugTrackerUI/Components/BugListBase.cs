using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI.Components
{
    public class BugListBase: ComponentBase
    {
        [Inject]
        public IBugService BugService { get; set; }
        public List<Bug> Bugs { get; set; }
        protected override void OnInitialized()
        {
            Bugs = BugService.GetBugs().OrderByDescending(x => x.Priority).ToList();
        }
    }
}
