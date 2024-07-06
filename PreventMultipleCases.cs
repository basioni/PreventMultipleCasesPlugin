// using System;
using Microsoft.Xrm.Sdk;

namespace PreventMultipleCasesPlugin
{
    public class PreventMultipleCases : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
    {
        // Check if serviceProvider is null (unlikely, but good to check)
        if (serviceProvider == null)
        {
            throw new InvalidPluginExecutionException("Service provider is null.");
        }

        // Retrieve tracing service
        ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
        if (tracingService == null)
        {
            throw new InvalidPluginExecutionException("Failed to retrieve tracing service.");
        }

        // Use tracingService for logging
        tracingService.Trace("Plugin execution started.");

        // Your plugin logic here
    }
}
}

