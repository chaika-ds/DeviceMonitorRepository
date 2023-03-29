namespace DevicesMonitor.Controllers;

/// <summary>
/// Device monitoring
/// </summary>
internal static class MonitorClient
{
    /// <summary>
    /// Get last measurements for device id
    /// </summary>
    /// <param name="client">HttpClient</param>
    /// <param name="id">Device type Id</param>
    /// <returns></returns>
    internal static async Task<string> GetDeviceMeasurementAsync(HttpClient client, int id) =>
        await client.GetStringAsync($"/v1/device/{id}");

}