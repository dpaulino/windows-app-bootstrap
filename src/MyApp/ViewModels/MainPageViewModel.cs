using Microsoft.Toolkit.Diagnostics;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using MyApp.Constants;
using MyApp.Services;

namespace MyApp.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        private readonly ITelemetry _telemetry;

        public MainPageViewModel(ITelemetry telemetry)
        {
            Guard.IsNotNull(telemetry, nameof(telemetry));
            _telemetry = telemetry;

            TestCommand = new RelayCommand(Test);
        }

        /// <summary>
        /// The test command.
        /// </summary>
        public IRelayCommand TestCommand { get; }

        private void Test()
        {
            _telemetry.TrackEvent(TelemetryConstants.MainPage);
        }
    }
}
