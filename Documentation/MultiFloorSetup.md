# Multi-Floor Mapping Setup

The editor and client only expose the new multi-floor UI when the server's
configuration enables the feature. Follow the steps below to turn it on and to
map content across multiple floors.

## 1. Enable multi-floor rendering on the server

1. Stop the server and the editor so they release the existing configuration
   file.
2. Open the server resource configuration file. In the default layout this file
   lives at `Intersect.Server/resources/config.json`. Published builds place the
   same file next to `Intersect Server.exe` inside the `resources` folder.
3. Locate the `Map` section and make sure the `MultiFloor` block contains the
   following keys:

   ```json
   "MultiFloor": {
     "Enabled": true,
     "VisibleFloorsAbove": 0,
     "VisibleFloorsBelow": 2
   }
   ```

   * `Enabled` toggles the feature on or off for the entire project.
   * `VisibleFloorsAbove` controls how many floors above the player stay visible.
     The default of `0` hides everything above the current floor, mimicking
     Tibia-style line of sight.【F:Framework/Intersect.Framework.Core/Config/MultiFloorOptions.cs†L6-L18】
   * `VisibleFloorsBelow` sets how many floors remain visible beneath the player.
     Keeping the default of `2` gives mappers some depth while still hiding very
     distant layers.【F:Framework/Intersect.Framework.Core/Config/MultiFloorOptions.cs†L6-L18】

4. Save the file and restart the server. The next time the editor or the client
   connects it will download the updated configuration automatically.

## 2. Use the new editor controls

Once the editor loads a configuration with `MultiFloor.Enabled` set to `true`
several tools become available:

* Floor controls appear in the upper-right corner of the map view. Use the
  `+`/`-` buttons or the `Page Up`/`Page Down` keys to move between floors, or
  enter a specific value in the numeric selector.【F:Intersect.Editor/Forms/DockingElements/frmMapEditor.cs†L90-L132】
* The `Z Dimension` attribute can now be painted while multi-floor is enabled so
  tiles know which floor they belong to.
* Only the currently visible floors can be edited or selected, matching what the
  player will see in-game.

If the server is still running with multi-floor disabled, the editor replaces
those controls with an inline reminder explaining how to enable the feature.
This makes it clear which configuration change is still required before you can
start mapping vertically.【F:Intersect.Editor/Forms/DockingElements/frmMapEditor.cs†L94-L121】【F:Intersect.Editor/Forms/DockingElements/frmMapEditor.Designer.cs†L48-L77】

With the configuration updated and the editor reconnected you can assign floor
levels to tiles, paint per-floor events, and test multi-floor gameplay just like
Tibia.
