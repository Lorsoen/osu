// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuModSuddenDeathStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuModSuddenDeath";

        /// <summary>
        /// "Also fail when missing a slider tail"
        /// </summary>
        public static LocalisableString AlsoFailWhenMissingA => new TranslatableString(getKey(@"also_fail_when_missing_a"), @"Also fail when missing a slider tail");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}