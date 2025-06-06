// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class OsuModClassicStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.OsuModClassic";

        /// <summary>
        /// "No slider head accuracy requirement"
        /// </summary>
        public static LocalisableString NoSliderHeadAccuracyRequirement => new TranslatableString(getKey(@"no_slider_head_accuracy_requirement"), @"No slider head accuracy requirement");

        /// <summary>
        /// "Scores sliders proportionally to the number of ticks hit."
        /// </summary>
        public static LocalisableString ScoresSlidersProportionallyToThe => new TranslatableString(getKey(@"scores_sliders_proportionally_to_the"), @"Scores sliders proportionally to the number of ticks hit.");

        /// <summary>
        /// "Apply classic note lock"
        /// </summary>
        public static LocalisableString ApplyClassicNoteLock => new TranslatableString(getKey(@"apply_classic_note_lock"), @"Apply classic note lock");

        /// <summary>
        /// "Applies note lock to the full hit window."
        /// </summary>
        public static LocalisableString AppliesNoteLockToThe => new TranslatableString(getKey(@"applies_note_lock_to_the"), @"Applies note lock to the full hit window.");

        /// <summary>
        /// "Always play a slider&#39;s tail sample"
        /// </summary>
        public static LocalisableString AlwaysPlayASlidersTail => new TranslatableString(getKey(@"always_play_asliders_tail"), @"Always play a slider's tail sample");

        /// <summary>
        /// "Always plays a slider&#39;s tail sample regardless of whether it was hit or not."
        /// </summary>
        public static LocalisableString AlwaysPlaysASlidersTail => new TranslatableString(getKey(@"always_plays_asliders_tail"), @"Always plays a slider's tail sample regardless of whether it was hit or not.");

        /// <summary>
        /// "Fade out hit circles earlier"
        /// </summary>
        public static LocalisableString FadeOutHitCirclesEarlier => new TranslatableString(getKey(@"fade_out_hit_circles_earlier"), @"Fade out hit circles earlier");

        /// <summary>
        /// "Make hit circles fade out into a miss, rather than after it."
        /// </summary>
        public static LocalisableString MakeHitCirclesFadeOut => new TranslatableString(getKey(@"make_hit_circles_fade_out"), @"Make hit circles fade out into a miss, rather than after it.");

        /// <summary>
        /// "Classic health"
        /// </summary>
        public static LocalisableString ClassicHealth => new TranslatableString(getKey(@"classic_health"), @"Classic health");

        /// <summary>
        /// "More closely resembles the original HP drain mechanics."
        /// </summary>
        public static LocalisableString MoreCloselyResemblesTheOriginal => new TranslatableString(getKey(@"more_closely_resembles_the_original"), @"More closely resembles the original HP drain mechanics.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
