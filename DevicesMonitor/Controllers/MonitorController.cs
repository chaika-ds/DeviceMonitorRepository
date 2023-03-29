using DevicesMonitor.Enums;
using DevicesMonitor.Extensions;

namespace DevicesMonitor.Controllers;

/// <summary>
/// Controller for devoce monitorring
/// </summary>
public class MonitorController
{
    private readonly Uri _uri;

    public MonitorController()
    {
        _uri = new Uri("https://localhost:7047");
    }

    /// <summary>
    /// Monitor device
    /// </summary>
    /// <param name="connectTimes">Devices monitoring quantity</param>
    /// <returns></returns>
    public async Task MonitorDevice(int connectTimes)
    {
        try
        {
            using HttpClient client = new();
            client.AdjustHttpClient(_uri);

            foreach (var device in Enum.GetValues(typeof(DevicesType)))
            {
                var deviceId = device.GetHashCode();

                for (var i = 0; i < connectTimes; i++)
                {
                    var measurementData = await SendRequestToDevice(client, deviceId);
                    Console.WriteLine($"Device {device} send data: {measurementData}");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    /// <summary>
    /// Send request to device
    /// </summary>
    /// <param name="client">HttpClient</param>
    /// <param name="deviceId">Device type Id</param>
    /// <returns></returns>
    private async Task<string> SendRequestToDevice(HttpClient client, int deviceId)
        => await MonitorClient.GetDeviceMeasurementAsync(client, deviceId);

}