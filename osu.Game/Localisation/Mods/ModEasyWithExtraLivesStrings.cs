// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ModEasyWithExtraLivesStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ModEasyWithExtraLives";

        /// <summary>
        /// "Extra Lives"
        /// </summary>
        public static LocalisableString ExtraLives => new TranslatableString(getKey(@"extra_lives"), @"Extra Lives");

        /// <summary>
        /// "Number of extra lives"
        /// </summary>
        public static LocalisableString NumberOfExtraLives => new TranslatableString(getKey(@"number_of_extra_lives"), @"Number of extra lives");

        /// <summary>
        /// "Extra lives"
        /// </summary>
        public static LocalisableString Extralives => new TranslatableString(getKey(@"extra_lives1"), @"Extra lives");

        /// <summary>
        /// "lives"
        /// </summary>
        public static LocalisableString Lives => new TranslatableString(getKey(@"lives"), @"lives");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
