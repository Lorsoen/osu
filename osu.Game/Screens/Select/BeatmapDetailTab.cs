
// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;
using osu.Game.Localisation;

namespace osu.Game.Screens.Select
{
    public enum BeatmapDetailTab
    {
        /// <summary>
        /// Beatmap details.
        /// </summary>
        [LocalisableDescription(typeof(BeatmapDetailTabStrings), nameof(BeatmapDetailTabStrings.Details))]
        Details,

        /// <summary>
        /// Local leaderboards.
        /// </summary>
        [LocalisableDescription(typeof(BeatmapDetailTabStrings), nameof(BeatmapDetailTabStrings.Local))]
        Local,

        /// <summary>
        /// Country leaderboards.
        /// </summary>
        [LocalisableDescription(typeof(BeatmapDetailTabStrings), nameof(BeatmapDetailTabStrings.Country))]
        Country,

        /// <summary>
        /// Global leaderboards.
        /// </summary>
        [LocalisableDescription(typeof(BeatmapDetailTabStrings), nameof(BeatmapDetailTabStrings.Global))]
        Global,

        /// <summary>
        /// Friend leaderboards.
        /// </summary>
        [LocalisableDescription(typeof(BeatmapDetailTabStrings), nameof(BeatmapDetailTabStrings.Friends))]
        Friends,

        /// <summary>
        /// Team leaderboards.
        /// </summary>
        [LocalisableDescription(typeof(BeatmapDetailTabStrings), nameof(BeatmapDetailTabStrings.Team))]
        Team
    }
}
