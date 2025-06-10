// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;
using osu.Game.Localisation;

namespace osu.Game.Screens.Select.Filter
{
    public enum GroupMode
    {
        [LocalisableDescription(typeof(GroupModeStrings), nameof(GroupModeStrings.None))]
        None,

        [LocalisableDescription(typeof(GroupModeStrings), nameof(GroupModeStrings.Artist))]
        Artist,

        [LocalisableDescription(typeof(GroupModeStrings), nameof(GroupModeStrings.Author))]
        Author,

        [LocalisableDescription(typeof(GroupModeStrings), nameof(GroupModeStrings.BPM))]
        BPM,

        // [Description("Collections")]
        // Collections,

        [LocalisableDescription(typeof(GroupModeStrings), nameof(GroupModeStrings.DateAdded))]
        DateAdded,

        [LocalisableDescription(typeof(GroupModeStrings), nameof(GroupModeStrings.DateRanked))]
        DateRanked,

        [LocalisableDescription(typeof(GroupModeStrings), nameof(GroupModeStrings.Difficulty))]
        Difficulty,

        // [Description("Favourites")]
        // Favourites,

        [LocalisableDescription(typeof(GroupModeStrings), nameof(GroupModeStrings.Length))]
        Length,

        // [Description("My Maps")]
        // MyMaps,

        // [Description("Rank Achieved")]
        // RankAchieved,

        [LocalisableDescription(typeof(GroupModeStrings), nameof(GroupModeStrings.RankedStatus))]
        RankedStatus,

        [LocalisableDescription(typeof(GroupModeStrings), nameof(GroupModeStrings.LastPlayed))]
        LastPlayed,

        [LocalisableDescription(typeof(GroupModeStrings), nameof(GroupModeStrings.Title))]
        Title,
    }
}
