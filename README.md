# Insane Clicks

A rhythm game client based on [osu!lazer](https://github.com/ppy/osu) by ppy Pty Ltd, modified and maintained independently.

**This is not the official osu! client and is not affiliated with or endorsed by ppy.** It does not connect to ppy's servers.

## Running

Requires the .NET SDK version listed in `global.json`.

```
dotnet run --project osu.Desktop
```

## Online features

Online endpoints are placeholders in `osu.Game/Online/ProductionEndpointConfiguration.cs` (`*.insane-clicks.invalid`). Point them at your own server to enable online features. Until then the game runs offline. Auto-update and Discord rich presence are disabled.

## Licence

MIT. See [LICENCE](LICENCE). The original osu! code is Copyright (c) ppy Pty Ltd and its licence notice must stay with all copies. The game assets (`osu-resources`) are licensed separately and more restrictively; replace them before distributing a public build. The "osu!" name and branding are ppy's trademarks.
