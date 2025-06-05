// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModAdaptiveSpeedStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModAdaptiveSpeed";

        /// <summary>
        /// "Let track speed adapt to you."
        /// </summary>
        public static LocalisableString LetTrackSpeedAdaptTo => new TranslatableString(getKey(@"let_track_speed_adapt_to"), @"Let track speed adapt to you.");

        /// <summary>
        /// "Initial rate"
        /// </summary>
        public static LocalisableString InitialRate => new TranslatableString(getKey(@"initial_rate"), @"Initial rate");

        /// <summary>
        /// "The starting speed of the track"
        /// </summary>
        public static LocalisableString TheStartingSpeedOfThe => new TranslatableString(getKey(@"the_starting_speed_of_the"), @"The starting speed of the track");

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