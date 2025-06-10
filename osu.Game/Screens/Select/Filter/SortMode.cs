// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;
using osu.Game.Resources.Localisation.Web;
using osu.Game.Localisation;

namespace osu.Game.Screens.Select.Filter
{
    public enum SortMode
    {
        [LocalisableDescription(typeof(BeatmapsStrings), nameof(BeatmapsStrings.ListingSearchSortingArtist))]
        Artist,

        [LocalisableDescription(typeof(SortModeStrings), nameof(SortModeStrings.Author))]
        Author,

        [LocalisableDescription(typeof(SortStrings), nameof(SortStrings.ArtistTracksBpm))]
        BPM,

        [LocalisableDescription(typeof(SortModeStrings), nameof(SortModeStrings.DateSubmitted))]
        DateSubmitted,

        [LocalisableDescription(typeof(SortModeStrings), nameof(SortModeStrings.DateAdded))]
        DateAdded,

        [LocalisableDescription(typeof(SortModeStrings), nameof(SortModeStrings.DateRanked))]
        DateRanked,

        [LocalisableDescription(typeof(SortModeStrings), nameof(SortModeStrings.LastPlayed))]
        LastPlayed,

        [LocalisableDescription(typeof(BeatmapsStrings), nameof(BeatmapsStrings.ListingSearchSortingDifficulty))]
        Difficulty,

        [LocalisableDescription(typeof(SortStrings), nameof(SortStrings.ArtistTracksLength))]
        Length,

        // todo: pending support (https://github.com/ppy/osu/issues/4917)
        // [Description("Rank Achieved")]
        // RankAchieved,

        [LocalisableDescription(typeof(SortModeStrings), nameof(SortModeStrings.Source))]
        Source,

        [LocalisableDescription(typeof(BeatmapsStrings), nameof(BeatmapsStrings.ListingSearchSortingTitle))]
        Title,
    }
}
