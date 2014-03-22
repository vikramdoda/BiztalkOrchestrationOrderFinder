using System.ComponentModel;

namespace OrchestrationOrderFinder
{
    internal class OrchestrationModel
    {
        [DisplayName(@"Application")]
        public string ApplicationName { get; set; }

        [DisplayName(@"Assembly")]
        public string AssemblyName { get; set; }

        [DisplayName(@"Orchestration")]
        public string OrchestrationName { get; set; }
    }
}