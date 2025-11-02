using System;
using System.Numerics;
using Intersect;
using Intersect.Client.Entities;
using Intersect.Client.Maps;
using Intersect.Config;
using Intersect.Enums;
using Intersect.Framework.Core.GameObjects.Maps.Attributes;
using Intersect.Network.Packets.Server;
using Intersect.Client.General;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Intersect.Tests.Client.Maps;

[TestFixture]
public sealed class MapInstanceMultiFloorTests
{
    [SetUp]
    public void SetUp()
    {
        Options.LoadFromServer(JsonConvert.SerializeObject(new Options()));
        Globals.Me = null;
    }

    [TearDown]
    public void TearDown()
    {
        Globals.Me = null;
    }

    [Test]
    public void IsFloorVisibleHonorsConfiguredAboveAndBelow()
    {
        var options = Options.Instance.Map.MultiFloor;
        options.Enabled = true;
        options.VisibleFloorsAbove = 2;
        options.VisibleFloorsBelow = 1;

        Assert.Multiple(() =>
        {
            Assert.That(MapInstance.IsFloorVisibleForTesting(0, 2, options), Is.True);
            Assert.That(MapInstance.IsFloorVisibleForTesting(0, 3, options), Is.False);
            Assert.That(MapInstance.IsFloorVisibleForTesting(0, -1, options), Is.True);
            Assert.That(MapInstance.IsFloorVisibleForTesting(0, -2, options), Is.False);
        });
    }

    [Test]
    public void GetTileFloorLevelPrefersExplicitFloorOverBlockedLevel()
    {
        var map = new MapInstance(Guid.NewGuid());
        map.Attributes[1, 1] = new MapZDimensionAttribute { FloorLevel = 3 };
        map.Attributes[2, 2] = new MapZDimensionAttribute { BlockedLevel = 4 };

        Assert.Multiple(() =>
        {
            Assert.That(map.GetTileFloorLevelForTesting(1, 1), Is.EqualTo(3));
            Assert.That(map.GetTileFloorLevelForTesting(2, 2), Is.EqualTo(3));
            Assert.That(map.GetTileFloorLevelForTesting(0, 0), Is.EqualTo(0));
        });
    }

    [Test]
    public void ShouldRenderTileIgnoresFloorWhenFeatureDisabled()
    {
        var options = Options.Instance.Map.MultiFloor;
        options.Enabled = false;

        var map = new MapInstance(Guid.NewGuid());
        map.Attributes[5, 5] = new MapZDimensionAttribute { FloorLevel = 10 };

        Assert.That(map.ShouldRenderTileForTesting(5, 5), Is.True);
    }

    [Test]
    public void ShouldRenderTileHonorsVisibilityAroundPlayerFloor()
    {
        var options = Options.Instance.Map.MultiFloor;
        options.Enabled = true;
        options.VisibleFloorsAbove = 2;
        options.VisibleFloorsBelow = 1;

        var map = new MapInstance(Guid.NewGuid());
        map.Attributes[1, 1] = new MapZDimensionAttribute { FloorLevel = 2 };
        map.Attributes[2, 2] = new MapZDimensionAttribute { FloorLevel = 3 };
        map.Attributes[3, 3] = new MapZDimensionAttribute { FloorLevel = -1 };
        map.Attributes[4, 4] = new MapZDimensionAttribute { FloorLevel = -2 };

        Globals.Me = CreatePlayerAtFloor(0);

        Assert.Multiple(() =>
        {
            Assert.That(map.ShouldRenderTileForTesting(1, 1), Is.True);
            Assert.That(map.ShouldRenderTileForTesting(2, 2), Is.False);
            Assert.That(map.ShouldRenderTileForTesting(3, 3), Is.True);
            Assert.That(map.ShouldRenderTileForTesting(4, 4), Is.False);
        });
    }

    private static Player CreatePlayerAtFloor(int floorLevel)
    {
        var playerId = Guid.NewGuid();
        var packet = new PlayerEntityPacket
        {
            EntityId = playerId,
            MapId = Guid.Empty,
            Name = string.Empty,
            Sprite = string.Empty,
            Face = string.Empty,
            Level = 1,
            Position = new Vector3(0, 0, floorLevel),
            Dir = 0,
            Passable = true,
            HideName = false,
            HideEntity = false,
            Animations = Array.Empty<Guid>(),
            Vital = new long[Enum.GetValues<Vital>().Length],
            MaxVital = new long[Enum.GetValues<Vital>().Length],
            Stats = new int[Enum.GetValues<Stat>().Length],
            StatusEffects = Array.Empty<StatusPacket>(),
            IsSelf = true,
            NameColor = Color.White,
            HeaderLabel = new LabelPacket(string.Empty, Color.White),
            FooterLabel = new LabelPacket(string.Empty, Color.White),
            Color = Color.White,
            Equipment = new EquipmentPacket(playerId, Array.Empty<int>(), Array.Empty<Guid>()),
        };

        return new Player(playerId, packet);
    }
}
