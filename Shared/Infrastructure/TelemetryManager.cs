using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Infrastructure
{
    public class TelemetryManager
    {
        private static Lazy<Microsoft.ApplicationInsights.TelemetryClient> tc = new Lazy<Microsoft.ApplicationInsights.TelemetryClient>(() =>
        {
            string key = ConfigurationManager.AppSettings["InstrumentationKey"];
            if (string.IsNullOrEmpty(key))
            {
                key = System.Environment.GetEnvironmentVariable("InstrumentationKey", EnvironmentVariableTarget.User);
            }
            Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration.Active.InstrumentationKey = key;
            return new Microsoft.ApplicationInsights.TelemetryClient();
        });

        public static Microsoft.ApplicationInsights.TelemetryClient Client
        {
            get { return tc.Value; }
        }
    }
}
