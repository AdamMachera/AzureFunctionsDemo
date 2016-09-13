#r "Newtonsoft.Json"
#r "..\Shared\Logic.Abstraction.dll"
#r "..\Shared\Infrastructure.dll"
#r "..\Shared\Microsoft.ApplicationInsights.dll"

using System;
using Newtonsoft.Json;
using Logic.Abstraction;
using Infrastructure;

public static void Run(Message message, out string result, TraceWriter log)
{
    log.Info($"C# Queue trigger function processed: {message}");
    TelemetryManager.Client.TrackEvent(message.ToString());
    result = JsonConvert.SerializeObject(message);
}