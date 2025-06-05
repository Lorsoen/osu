// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModTimeRampStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModTimeRamp";

        /// <summary>
        /// "Initial rate"
        /// </summary>
        public static LocalisableString InitialRate => new TranslatableString(getKey(@"initial_rate"), @"Initial rate");

        /// <summary>
        /// "The starting speed of the track"
        /// </summary>
        public static LocalisableString TheStartingSpeedOfThe => new TranslatableString(getKey(@"the_starting_speed_of_the"), @"The starting speed of the track");

        /// <summary>
        /// "Final rate"
        /// </summary>
        public static LocalisableString FinalRate => new TranslatableString(getKey(@"final_rate"), @"Final rate");

        /// <summary>
        /// "The final speed to ramp to"
        /// </summary>
        public static LocalisableString TheFinalSpeedToRamp => new TranslatableString(getKey(@"the_final_speed_to_ramp"), @"The final speed to ramp to");

        /// <summary>
        /// "Adjust pitch"
        /// </summary>
        public static LocalisableString AdjustPitch => new TranslatableString(getKey(@"adjust_pitch"), @"Adjust pitch");

        /// <summary>
        /// "Should pitch be adjusted with speed"
        /// </summary>
        public static LocalisableString ShouldPitchBeAdjustedWith => new TranslatableString(getKey(@"should_pitch_be_adjusted_with"), @"Should pitch be adjusted with speed");

        /// <summary>
        /// "Speed change"
        /// </summary>
        public static LocalisableString SpeedChange => new TranslatableString(getKey(@"speed_change"), @"Speed change");

        /// <summary>
        /// "{0}x to {1}x"
        /// </summary>
        public static LocalisableString XToX(double arg0, double arg1) => new TranslatableString(getKey(@"xto_x"), @"{0}x to {1}x", arg0, arg1);

        /// <summary>
        /// "{0}x to {1}x"
        /// </summary>
        public static LocalisableString XToX1(double arg0, double arg1) => new TranslatableString(getKey(@"xto_x1"), @"{0}x to {1}x", arg0, arg1);

        /// <summary>
        /// "{0}x to {1}x"
        /// </summary>
        public static LocalisableString XToX2(double arg0, double arg1) => new TranslatableString(getKey(@"xto_x2"), @"{0}x to {1}x", arg0, arg1);

        /// <summary>
        /// "On"
        /// </summary>
        public static LocalisableString On => new TranslatableString(getKey(@"on"), @"On");

        /// <summary>
        /// "Off"
        /// </summary>
        public static LocalisableString Off => new TranslatableString(getKey(@"off"), @"Off");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}