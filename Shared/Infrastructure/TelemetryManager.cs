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
            Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration.Active.InstrumentationKey = ConfigurationManager.AppSettings["InstrumentationKey"];
            return new Microsoft.ApplicationInsights.TelemetryClient();
        });

        public static Microsoft.ApplicationInsights.TelemetryClient Client
        {
            get { return tc.Value; }
        }
    }
}
