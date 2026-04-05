#nullable enable

using System.ComponentModel;
using System.Globalization;
using Microsoft.Extensions.AI;

namespace Terra;

/// <summary>
/// MEAI AIFunction tool extensions for TerraClient.
/// </summary>
public static partial class TerraClientExtensions
{
    /// <summary>
    /// Returns all AIFunction tools for the Terra client.
    /// </summary>
    /// <param name="client">The Terra client to use.</param>
    /// <returns>A list of AIFunction tools.</returns>
    [CLSCompliant(false)]
    public static IList<AIFunction> AsTools(this TerraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return
        [
            client.AsGetActivityTool(),
            client.AsGetSleepTool(),
            client.AsGetBodyTool(),
            client.AsGetDailyTool(),
        ];
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that fetches activity data for a user,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Terra client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetActivityTool(this TerraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("The Terra user ID to fetch activity data for")] string userId,
                   [Description("Start date in YYYY-MM-DD format")] string startDate,
                   [Description("End date in YYYY-MM-DD format (optional)")] string? endDate = null,
                   [Description("Whether to include detailed samples")] bool? withSamples = null,
                   CancellationToken cancellationToken = default) =>
            {
                var start = DateTime.Parse(startDate, CultureInfo.InvariantCulture);
                OneOf<int?, DateTime?> startParam = (DateTime?)start;
                OneOf<int?, DateTime?>? endParam = endDate is { Length: > 0 }
                    ? (DateTime?)DateTime.Parse(endDate, CultureInfo.InvariantCulture)
                    : null;

                var response = await client.Activity.ActivityFetchAsync(
                    userId: userId,
                    startDate: startParam,
                    endDate: endParam,
                    withSamples: withSamples,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "TerraGetActivity",
            description: "Fetches activity and workout data for a Terra user within a date range. Returns exercise sessions, steps, calories burned, distances, heart rate zones, and other activity metrics from connected wearable devices.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that fetches sleep data for a user,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Terra client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetSleepTool(this TerraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("The Terra user ID to fetch sleep data for")] string userId,
                   [Description("Start date in YYYY-MM-DD format")] string startDate,
                   [Description("End date in YYYY-MM-DD format (optional)")] string? endDate = null,
                   [Description("Whether to include detailed samples")] bool? withSamples = null,
                   CancellationToken cancellationToken = default) =>
            {
                var start = DateTime.Parse(startDate, CultureInfo.InvariantCulture);
                OneOf<int?, DateTime?> startParam = (DateTime?)start;
                OneOf<int?, DateTime?>? endParam = endDate is { Length: > 0 }
                    ? (DateTime?)DateTime.Parse(endDate, CultureInfo.InvariantCulture)
                    : null;

                var response = await client.Sleep.SleepFetchAsync(
                    userId: userId,
                    startDate: startParam,
                    endDate: endParam,
                    withSamples: withSamples,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "TerraGetSleep",
            description: "Fetches sleep data for a Terra user within a date range. Returns sleep stages (deep, light, REM, awake), sleep duration, sleep efficiency, heart rate during sleep, respiratory rate, and SpO2 data from connected wearable devices.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that fetches body metrics for a user,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Terra client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetBodyTool(this TerraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("The Terra user ID to fetch body data for")] string userId,
                   [Description("Start date in YYYY-MM-DD format")] string startDate,
                   [Description("End date in YYYY-MM-DD format (optional)")] string? endDate = null,
                   [Description("Whether to include detailed samples")] bool? withSamples = null,
                   CancellationToken cancellationToken = default) =>
            {
                var start = DateTime.Parse(startDate, CultureInfo.InvariantCulture);
                OneOf<int?, DateTime?> startParam = (DateTime?)start;
                OneOf<int?, DateTime?>? endParam = endDate is { Length: > 0 }
                    ? (DateTime?)DateTime.Parse(endDate, CultureInfo.InvariantCulture)
                    : null;

                var response = await client.Body.BodyFetchAsync(
                    userId: userId,
                    startDate: startParam,
                    endDate: endParam,
                    withSamples: withSamples,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "TerraGetBody",
            description: "Fetches body metrics for a Terra user within a date range. Returns weight, BMI, body fat percentage, blood glucose, blood pressure, temperature, oxygen saturation, and other biometric data from connected wearable devices.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that fetches daily summary data for a user,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Terra client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetDailyTool(this TerraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("The Terra user ID to fetch daily summary for")] string userId,
                   [Description("Start date in YYYY-MM-DD format")] string startDate,
                   [Description("End date in YYYY-MM-DD format (optional)")] string? endDate = null,
                   [Description("Whether to include detailed samples")] bool? withSamples = null,
                   CancellationToken cancellationToken = default) =>
            {
                var start = DateTime.Parse(startDate, CultureInfo.InvariantCulture);
                OneOf<int?, DateTime?> startParam = (DateTime?)start;
                OneOf<int?, DateTime?>? endParam = endDate is { Length: > 0 }
                    ? (DateTime?)DateTime.Parse(endDate, CultureInfo.InvariantCulture)
                    : null;

                var response = await client.Daily.DailyFetchAsync(
                    userId: userId,
                    startDate: startParam,
                    endDate: endParam,
                    withSamples: withSamples,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "TerraGetDaily",
            description: "Fetches daily summary data for a Terra user within a date range. Returns aggregated daily totals including steps, active minutes, calories, distances, heart rate stats, stress scores, and readiness scores from connected wearable devices.");
    }
}
