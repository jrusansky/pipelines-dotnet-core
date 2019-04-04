using System;

namespace pipelines_dotnet_core.Models
{
    public class ErrorViewModel
    {
        //Test add a comment to build the pipeline
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
