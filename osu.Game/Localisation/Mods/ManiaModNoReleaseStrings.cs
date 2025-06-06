// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ManiaModNoReleaseStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ManiaModNoRelease";

        /// <summary>
        /// "No more timing the end of hold notes."
        /// </summary>
        public static LocalisableString NoMoreTimingTheEnd => new TranslatableString(getKey(@"no_more_timing_the_end"), @"No more timing the end of hold notes.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
