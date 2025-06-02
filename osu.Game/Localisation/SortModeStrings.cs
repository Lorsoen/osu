// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class SortModeStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.SortMode";

        /// <summary>
        /// "Author"
        /// </summary>
        public static LocalisableString Author => new TranslatableString(getKey(@"author"), @"Author");

        /// <summary>
        /// "Date Submitted"
        /// </summary>
        public static LocalisableString DateSubmitted => new TranslatableString(getKey(@"date_submitted"), @"Date Submitted");

        /// <summary>
        /// "Date Added"
        /// </summary>
        public static LocalisableString DateAdded => new TranslatableString(getKey(@"date_added"), @"Date Added");

        /// <summary>
        /// "Date Ranked"
        /// </summary>
        public static LocalisableString DateRanked => new TranslatableString(getKey(@"date_ranked"), @"Date Ranked");

        /// <summary>
        /// "Last Played"
        /// </summary>
        public static LocalisableString LastPlayed => new TranslatableString(getKey(@"last_played"), @"Last Played");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
