// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class TimingSectionStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.TimingSection";

        /// <summary>
        /// "Time Signature"
        /// </summary>
        public static LocalisableString TimeSignature => new TranslatableString(getKey(@"time_signature"), @"Time Signature");

        /// <summary>
        /// "Skip Bar Line"
        /// </summary>
        public static LocalisableString SkipBarLine => new TranslatableString(getKey(@"skip_bar_line"), @"Skip Bar Line");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}