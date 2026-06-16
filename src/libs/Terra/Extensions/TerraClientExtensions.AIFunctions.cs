#nullable enable

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

        return [];
    }
}
