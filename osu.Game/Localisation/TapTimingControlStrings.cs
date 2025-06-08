// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class TapTimingControlStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.TapTimingControl";

        /// <summary>
        /// "Offset"
        /// </summary>
        public static LocalisableString Offset => new TranslatableString(getKey(@"offset"), @"Offset");

        /// <summary>
        /// "BPM"
        /// </summary>
        public static LocalisableString BPM => new TranslatableString(getKey(@"bpm"), @"BPM");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}