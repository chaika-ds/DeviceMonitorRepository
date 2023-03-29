using System.Net.Http.Headers;

namespace DevicesMonitor.Extensions;

/// <summary>
/// Extensions for HttpClient
/// </summary>
internal static class HttpClientExtensions
{
    /// <summary>
    /// HttpClient addjustment
    /// </summary>
    /// <param name="client">HttpClient</param>
    /// <param name="uri">Uri</param>
    internal static void AdjustHttpClient(this HttpClient client, Uri uri)
    {
        client.BaseAddress = uri;
        client.DefaultRequestHeaders.Accept.Clear();

        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }

}