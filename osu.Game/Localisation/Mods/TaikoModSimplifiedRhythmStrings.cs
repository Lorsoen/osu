// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class TaikoModSimplifiedRhythmStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.TaikoModSimplifiedRhythm";

        /// <summary>
        /// "Simplify tricky rhythms!"
        /// </summary>
        public static LocalisableString SimplifyTrickyRhythms => new TranslatableString(getKey(@"simplify_tricky_rhythms"), @"Simplify tricky rhythms!");

        /// <summary>
        /// "1/3 to 1/2 conversion"
        /// </summary>
        public static LocalisableString ToConversion => new TranslatableString(getKey(@"to_conversion"), @"1/3 to 1/2 conversion");

        /// <summary>
        /// "Converts 1/3 patterns to 1/2 rhythm."
        /// </summary>
        public static LocalisableString ConvertsPatternsToRhythm => new TranslatableString(getKey(@"converts_patterns_to_rhythm"), @"Converts 1/3 patterns to 1/2 rhythm.");

        /// <summary>
        /// "1/6 to 1/4 conversion"
        /// </summary>
        public static LocalisableString ToConversion1 => new TranslatableString(getKey(@"to_conversion1"), @"1/6 to 1/4 conversion");

        /// <summary>
        /// "Converts 1/6 patterns to 1/4 rhythm."
        /// </summary>
        public static LocalisableString ConvertsPatternsToRhythm1 => new TranslatableString(getKey(@"converts_patterns_to_rhythm1"), @"Converts 1/6 patterns to 1/4 rhythm.");

        /// <summary>
        /// "1/8 to 1/4 conversion"
        /// </summary>
        public static LocalisableString ToConversion2 => new TranslatableString(getKey(@"to_conversion2"), @"1/8 to 1/4 conversion");

        /// <summary>
        /// "Converts 1/8 patterns to 1/4 rhythm."
        /// </summary>
        public static LocalisableString ConvertsPatternsToRhythm2 => new TranslatableString(getKey(@"converts_patterns_to_rhythm2"), @"Converts 1/8 patterns to 1/4 rhythm.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
