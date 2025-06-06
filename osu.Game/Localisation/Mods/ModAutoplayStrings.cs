// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ModAutoplayStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ModAutoplay";

        /// <summary>
        /// "Watch a perfect automated play through the song."
        /// </summary>
        public static LocalisableString WatchAPerfectAutomatedPlay => new TranslatableString(getKey(@"watch_aperfect_automated_play"), @"Watch a perfect automated play through the song.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
