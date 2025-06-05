// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuModDifficultyAdjustStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuModDifficultyAdjust";

        /// <summary>
        /// "Circle Size"
        /// </summary>
        public static LocalisableString CircleSize => new TranslatableString(getKey(@"circle_size"), @"Circle Size");

        /// <summary>
        /// "Override a beatmap&#39;s set CS."
        /// </summary>
        public static LocalisableString OverrideABeatmapsSetCS => new TranslatableString(getKey(@"override_abeatmaps_set_cs"), @"Override a beatmap's set CS.");

        /// <summary>
        /// "Approach Rate"
        /// </summary>
        public static LocalisableString ApproachRate => new TranslatableString(getKey(@"approach_rate"), @"Approach Rate");

        /// <summary>
        /// "Override a beatmap&#39;s set AR."
        /// </summary>
        public static LocalisableString OverrideABeatmapsSetAR => new TranslatableString(getKey(@"override_abeatmaps_set_ar"), @"Override a beatmap's set AR.");

        /// <summary>
        /// "Circle size"
        /// </summary>
        public static LocalisableString Circlesize => new TranslatableString(getKey(@"circle_size1"), @"Circle size");

        /// <summary>
        /// "Approach rate"
        /// </summary>
        public static LocalisableString Approachrate => new TranslatableString(getKey(@"approach_rate1"), @"Approach rate");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
