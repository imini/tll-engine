using System.ComponentModel;
using Intersect.Config;

namespace Intersect.Client.Maps;

[EditorBrowsable(EditorBrowsableState.Never)]
public partial class MapInstance
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static bool IsFloorVisibleForTesting(int viewerFloor, int floorLevel, MultiFloorOptions options) =>
        IsFloorVisible(viewerFloor, floorLevel, options);

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal int GetTileFloorLevelForTesting(int tileX, int tileY) => GetTileFloorLevel(tileX, tileY);

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal bool ShouldRenderTileForTesting(int tileX, int tileY) => ShouldRenderTile(tileX, tileY);
}
