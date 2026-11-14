// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace osu.Game.Online
{
    public class ProductionEndpointConfiguration : EndpointConfiguration
    {
        public ProductionEndpointConfiguration()
        {
            // TODO: point these at your own server. Placeholders never resolve, so the client runs offline.
            WebsiteUrl = APIUrl = @"https://api.insane-clicks.invalid";
            APIClientSecret = string.Empty;
            APIClientID = "0";
            SpectatorUrl = "https://spectator.insane-clicks.invalid/spectator";
            MultiplayerUrl = "https://spectator.insane-clicks.invalid/multiplayer";
            MetadataUrl = "https://spectator.insane-clicks.invalid/metadata";
            BeatmapSubmissionServiceUrl = "https://bss.insane-clicks.invalid";
        }
    }
}
