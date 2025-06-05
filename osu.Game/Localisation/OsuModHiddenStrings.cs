// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuModHiddenStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuModHidden";

        /// <summary>
        /// "Only fade approach circles"
        /// </summary>
        public static LocalisableString OnlyFadeApproachCircles => new TranslatableString(getKey(@"only_fade_approach_circles"), @"Only fade approach circles");

        /// <summary>
        /// "The main object body will not fade when enabled."
        /// </summary>
        public static LocalisableString TheMainObjectBodyWill => new TranslatableString(getKey(@"the_main_object_body_will"), @"The main object body will not fade when enabled.");

        /// <summary>
        /// "Play with no approach circles and fading circles/sliders."
        /// </summary>
        public static LocalisableString PlayWithNoApproachCircles => new TranslatableString(getKey(@"play_with_no_approach_circles"), @"Play with no approach circles and fading circles/sliders.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}