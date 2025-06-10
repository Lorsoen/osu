// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.ComponentModel;
using osu.Framework.Localisation;
using osu.Game.Resources.Localisation;

namespace osu.Game.Screens.Select.Leaderboards
{
    public enum BeatmapLeaderboardScopeShort
    {
        [LocalisableDescription(typeof(BeatmapLeaderboardScopeShortStrings), nameof(BeatmapLeaderboardScopeShortStrings.Local))]
        Local,

        [LocalisableDescription(typeof(BeatmapLeaderboardScopeShortStrings), nameof(BeatmapLeaderboardScopeShortStrings.Global))]
        Global,

        [LocalisableDescription(typeof(BeatmapLeaderboardScopeShortStrings), nameof(BeatmapLeaderboardScopeShortStrings.Country))]
        Country,

        [LocalisableDescription(typeof(BeatmapLeaderboardScopeShortStrings), nameof(BeatmapLeaderboardScopeShortStrings.Friend))]
        Friend,

        [LocalisableDescription(typeof(BeatmapLeaderboardScopeShortStrings), nameof(BeatmapLeaderboardScopeShortStrings.Team))]
        Team,
    }
}
