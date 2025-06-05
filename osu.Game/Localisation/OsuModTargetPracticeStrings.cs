// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuModTargetPracticeStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuModTargetPractice";

        /// <summary>
        /// "Seed"
        /// </summary>
        public static LocalisableString Seed => new TranslatableString(getKey(@"seed"), @"Seed");

        /// <summary>
        /// "Use a custom seed instead of a random one"
        /// </summary>
        public static LocalisableString UseACustomSeedInstead => new TranslatableString(getKey(@"use_acustom_seed_instead"), @"Use a custom seed instead of a random one");

        /// <summary>
        /// "Metronome ticks"
        /// </summary>
        public static LocalisableString MetronomeTicks => new TranslatableString(getKey(@"metronome_ticks"), @"Metronome ticks");

        /// <summary>
        /// "Whether a metronome beat should play in the background"
        /// </summary>
        public static LocalisableString WhetherAMetronomeBeatShould => new TranslatableString(getKey(@"whether_ametronome_beat_should"), @"Whether a metronome beat should play in the background");

        /// <summary>
        /// "Practice keeping up with the beat of the song."
        /// </summary>
        public static LocalisableString PracticeKeepingUpWithThe => new TranslatableString(getKey(@"practice_keeping_up_with_the"), @"Practice keeping up with the beat of the song.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}