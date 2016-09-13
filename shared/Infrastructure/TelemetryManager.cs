using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class TelemetryManager
    {
        private static Lazy<Microsoft.ApplicationInsights.TelemetryClient> tc = new Lazy<Microsoft.ApplicationInsights.TelemetryClient>(() =>
        {
            Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration.Active.InstrumentationKey = "8c0a6e9d-3a53-48bd-a036-1c0cc7e2d524";
            return new Microsoft.ApplicationInsights.TelemetryClient();
        });

        public static Microsoft.ApplicationInsights.TelemetryClient Client
        {
            get { return tc.Value; }
        }
    }
}
