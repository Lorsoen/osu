// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class GroupModeStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.GroupMode";

        /// <summary>
        /// "None"
        /// </summary>
        public static LocalisableString None => new TranslatableString(getKey(@"none"), @"None");

        /// <summary>
        /// "Artist"
        /// </summary>
        public static LocalisableString Artist => new TranslatableString(getKey(@"artist"), @"Artist");

        /// <summary>
        /// "Author"
        /// </summary>
        public static LocalisableString Author => new TranslatableString(getKey(@"author"), @"Author");

        /// <summary>
        /// "BPM"
        /// </summary>
        public static LocalisableString BPM => new TranslatableString(getKey(@"bpm"), @"BPM");

        /// <summary>
        /// "Date Added"
        /// </summary>
        public static LocalisableString DateAdded => new TranslatableString(getKey(@"date_added"), @"Date Added");

        /// <summary>
        /// "Date Ranked"
        /// </summary>
        public static LocalisableString DateRanked => new TranslatableString(getKey(@"date_ranked"), @"Date Ranked");

        /// <summary>
        /// "Difficulty"
        /// </summary>
        public static LocalisableString Difficulty => new TranslatableString(getKey(@"difficulty"), @"Difficulty");

        /// <summary>
        /// "Length"
        /// </summary>
        public static LocalisableString Length => new TranslatableString(getKey(@"length"), @"Length");

        /// <summary>
        /// "Ranked Status"
        /// </summary>
        public static LocalisableString RankedStatus => new TranslatableString(getKey(@"ranked_status"), @"Ranked Status");

        /// <summary>
        /// "Last Played"
        /// </summary>
        public static LocalisableString LastPlayed => new TranslatableString(getKey(@"last_played"), @"Last Played");

        /// <summary>
        /// "Title"
        /// </summary>
        public static LocalisableString Title => new TranslatableString(getKey(@"title"), @"Title");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}