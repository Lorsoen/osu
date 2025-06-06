// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class TaikoModDifficultyAdjustStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.TaikoModDifficultyAdjust";

        /// <summary>
        /// "Scroll Speed"
        /// </summary>
        public static LocalisableString ScrollSpeed => new TranslatableString(getKey(@"scroll_speed"), @"Scroll Speed");

        /// <summary>
        /// "Adjust a beatmap&#39;s set scroll speed"
        /// </summary>
        public static LocalisableString AdjustABeatmapsSetScroll => new TranslatableString(getKey(@"adjust_abeatmaps_set_scroll"), @"Adjust a beatmap's set scroll speed");

        /// <summary>
        /// "Scroll speed"
        /// </summary>
        public static LocalisableString ScrollSpeed1 => new TranslatableString(getKey(@"scroll_speed1"), @"Scroll speed");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
