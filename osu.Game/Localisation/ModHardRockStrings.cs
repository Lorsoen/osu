// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModHardRockStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModHardRock";

        /// <summary>
        /// "Everything just got a bit harder..."
        /// </summary>
        public static LocalisableString EverythingJustGotABit => new TranslatableString(getKey(@"everything_just_got_abit"), @"Everything just got a bit harder...");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}