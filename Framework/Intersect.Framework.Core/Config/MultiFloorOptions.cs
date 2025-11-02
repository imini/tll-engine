namespace Intersect.Config;

public partial class MultiFloorOptions
{
    public bool Enabled { get; set; }

    public sbyte VisibleFloorsAbove { get; set; }

    public sbyte VisibleFloorsBelow { get; set; }

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
    }
}
