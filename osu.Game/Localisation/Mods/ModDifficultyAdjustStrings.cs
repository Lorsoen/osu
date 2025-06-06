// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ModDifficultyAdjustStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ModDifficultyAdjust";

        /// <summary>
        /// "Override a beatmap&#39;s difficulty settings."
        /// </summary>
        public static LocalisableString OverrideABeatmapsDifficultySettings => new TranslatableString(getKey(@"override_abeatmaps_difficulty_settings"), @"Override a beatmap's difficulty settings.");

        /// <summary>
        /// "HP Drain"
        /// </summary>
        public static LocalisableString HPDrain => new TranslatableString(getKey(@"hpdrain"), @"HP Drain");

        /// <summary>
        /// "Override a beatmap&#39;s set HP."
        /// </summary>
        public static LocalisableString OverrideABeatmapsSetHP => new TranslatableString(getKey(@"override_abeatmaps_set_hp"), @"Override a beatmap's set HP.");

        /// <summary>
        /// "Accuracy"
        /// </summary>
        public static LocalisableString Accuracy => new TranslatableString(getKey(@"accuracy"), @"Accuracy");

        /// <summary>
        /// "Override a beatmap&#39;s set OD."
        /// </summary>
        public static LocalisableString OverrideABeatmapsSetOD => new TranslatableString(getKey(@"override_abeatmaps_set_od"), @"Override a beatmap's set OD.");

        /// <summary>
        /// "Extended Limits"
        /// </summary>
        public static LocalisableString ExtendedLimits => new TranslatableString(getKey(@"extended_limits"), @"Extended Limits");

        /// <summary>
        /// "Adjust difficulty beyond sane limits."
        /// </summary>
        public static LocalisableString AdjustDifficultyBeyondSaneLimits => new TranslatableString(getKey(@"adjust_difficulty_beyond_sane_limits"), @"Adjust difficulty beyond sane limits.");

        /// <summary>
        /// "HP drain"
        /// </summary>
        public static LocalisableString HPDrain1 => new TranslatableString(getKey(@"hpdrain1"), @"HP drain");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
