// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class FilterControlStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.FilterControl";

        /// <summary>
        /// "Star Rating"
        /// </summary>
        public static LocalisableString StarRating => new TranslatableString(getKey(@"star_rating"), @"Star Rating");

        /// <summary>
        /// "Sort"
        /// </summary>
        public static LocalisableString Sort => new TranslatableString(getKey(@"sort"), @"Sort");

        /// <summary>
        /// "Group"
        /// </summary>
        public static LocalisableString Group => new TranslatableString(getKey(@"group"), @"Group");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}