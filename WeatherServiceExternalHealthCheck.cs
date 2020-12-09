using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;

namespace Dotnet5MicroService{
    public class WeatherServiceExternalHealthCheck : IHealthCheck
    {
        private readonly ServiceSettings _settings;
        public WeatherServiceExternalHealthCheck(IOptions<ServiceSettings> options)
        {
          _settings = options.Value;   
        }
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            Ping ping = new();
            var reply = await ping.SendPingAsync(_settings.OpenWeatherHost);

            if (reply.Status != IPStatus.Success)
            {
                return HealthCheckResult.Unhealthy();
            }

            return HealthCheckResult.Healthy();
        }
    }
}