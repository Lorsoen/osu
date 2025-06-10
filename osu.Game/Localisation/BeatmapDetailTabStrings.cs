
// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class BeatmapDetailTabStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.BeatmapDetailTab";

        /// <summary>
        /// "Details"
        /// </summary>
        public static LocalisableString Details => new TranslatableString(getKey(@"details"), @"Details");

        /// <summary>
        /// "Local"
        /// </summary>
        public static LocalisableString Local => new TranslatableString(getKey(@"local"), @"Local");

        /// <summary>
        /// "Country"
        /// </summary>
        public static LocalisableString Country => new TranslatableString(getKey(@"country"), @"Country");

        /// <summary>
        /// "Global"
        /// </summary>
        public static LocalisableString Global => new TranslatableString(getKey(@"global"), @"Global");

        /// <summary>
        /// "Friends"
        /// </summary>
        public static LocalisableString Friends => new TranslatableString(getKey(@"friends"), @"Friends");

        /// <summary>
        /// "Team"
        /// </summary>
        public static LocalisableString Team => new TranslatableString(getKey(@"team"), @"Team");
        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
