// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModDoubleTimeStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModDoubleTime";

        /// <summary>
        /// "Zoooooooooom..."
        /// </summary>
        public static LocalisableString Zoooooooooom => new TranslatableString(getKey(@"zoooooooooom"), @"Zoooooooooom...");

        /// <summary>
        /// "Speed increase"
        /// </summary>
        public static LocalisableString SpeedIncrease => new TranslatableString(getKey(@"speed_increase"), @"Speed increase");

        /// <summary>
        /// "The actual increase to apply"
        /// </summary>
        public static LocalisableString TheActualIncreaseToApply => new TranslatableString(getKey(@"the_actual_increase_to_apply"), @"The actual increase to apply");

        /// <summary>
        /// "Adjust pitch"
        /// </summary>
        public static LocalisableString AdjustPitch => new TranslatableString(getKey(@"adjust_pitch"), @"Adjust pitch");

        /// <summary>
        /// "Should pitch be adjusted with speed"
        /// </summary>
        public static LocalisableString ShouldPitchBeAdjustedWith => new TranslatableString(getKey(@"should_pitch_be_adjusted_with"), @"Should pitch be adjusted with speed");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}