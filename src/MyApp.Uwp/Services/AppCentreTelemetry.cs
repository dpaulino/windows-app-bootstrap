using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using System.Collections.Generic;
using Windows.Globalization;

namespace MyApp.Services.Uwp
{
    /// <summary>
    /// Telemetry service for app centre.
    /// </summary>
    public class AppCentreTelemetry : ITelemetry
    {
        private const string AppSecret = "";  // Do not commit

        public AppCentreTelemetry()
        {
            AppCenter.SetCountryCode(new GeographicRegion().CodeTwoLetter);
            AppCenter.Start(AppSecret, typeof(Analytics));
        }

        /// <inheritdoc/>
        public void TrackEvent(string eventName, IDictionary<string, string> properties = null)
        {
            Analytics.TrackEvent(eventName, properties);
        }
    }
}
