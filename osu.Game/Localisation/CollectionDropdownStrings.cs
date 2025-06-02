// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class CollectionDropdownStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.CollectionDropdown";

        /// <summary>
        /// "Collection"
        /// </summary>
        public static LocalisableString Collection => new TranslatableString(getKey(@"collection"), @"Collection");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}