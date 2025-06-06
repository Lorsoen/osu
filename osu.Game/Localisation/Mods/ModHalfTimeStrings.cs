// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ModHalfTimeStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ModHalfTime";

        /// <summary>
        /// "Less zoom..."
        /// </summary>
        public static LocalisableString HalfTimeDescription => new TranslatableString(getKey(@"less_zoom"), @"Less zoom...");

        /// <summary>
        /// "Speed decrease"
        /// </summary>
        public static LocalisableString SpeedDecrease => new TranslatableString(getKey(@"speed_decrease"), @"Speed decrease");

        /// <summary>
        /// "The actual decrease to apply"
        /// </summary>
        public static LocalisableString SpeedDecreaseDescription => new TranslatableString(getKey(@"the_actual_decrease_to_apply"), @"The actual decrease to apply");

        /// <summary>
        /// "Adjust pitch"
        /// </summary>
        public static LocalisableString AdjustPitch => new TranslatableString(getKey(@"adjust_pitch"), @"Adjust pitch");

        /// <summary>
        /// "Should pitch be adjusted with speed"
        /// </summary>
        public static LocalisableString AdjustPitchDescription => new TranslatableString(getKey(@"should_pitch_be_adjusted_with"), @"Should pitch be adjusted with speed");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
