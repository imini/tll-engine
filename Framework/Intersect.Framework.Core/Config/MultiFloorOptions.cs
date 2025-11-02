namespace Intersect.Config;

public partial class MultiFloorOptions
{
    /// <summary>
    /// Enables the multi-floor rendering pipeline.
    /// </summary>
    public bool Enabled { get; set; }

    /// <summary>
    /// How many floors above the viewer should remain visible.
    /// Defaults to zero so anything above the current floor is hidden like Tibia.
    /// </summary>
    public sbyte VisibleFloorsAbove { get; set; } = 0;

    /// <summary>
    /// How many floors below the viewer should remain visible.
    /// Defaults to two so mappers can see a small slice of the world beneath them.
    /// </summary>
    public sbyte VisibleFloorsBelow { get; set; } = 2;

    /// <summary>
    /// Validates the configured ranges so we never propagate invalid visibility bands.
    /// </summary>
    public void Validate()
    {
        if (VisibleFloorsAbove < 0)
        {
            VisibleFloorsAbove = 0;
        }

        if (VisibleFloorsBelow < 0)
        {
            VisibleFloorsBelow = 0;
        }

        if (VisibleFloorsAbove > sbyte.MaxValue)
        {
            VisibleFloorsAbove = sbyte.MaxValue;
        }

        if (VisibleFloorsBelow > sbyte.MaxValue)
        {
            VisibleFloorsBelow = sbyte.MaxValue;
        }
    }
}
