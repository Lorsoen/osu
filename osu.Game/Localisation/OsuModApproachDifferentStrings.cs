// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuModApproachDifferentStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuModApproachDifferent";

        /// <summary>
        /// "Never trust the approach circles..."
        /// </summary>
        public static LocalisableString NeverTrustTheApproachCircles => new TranslatableString(getKey(@"never_trust_the_approach_circles"), @"Never trust the approach circles...");

        /// <summary>
        /// "Initial size"
        /// </summary>
        public static LocalisableString InitialSize => new TranslatableString(getKey(@"initial_size"), @"Initial size");

        /// <summary>
        /// "Change the initial size of the approach circle, relative to hit circles."
        /// </summary>
        public static LocalisableString ChangeTheInitialSizeOf => new TranslatableString(getKey(@"change_the_initial_size_of"), @"Change the initial size of the approach circle, relative to hit circles.");

        /// <summary>
        /// "Style"
        /// </summary>
        public static LocalisableString Style => new TranslatableString(getKey(@"style"), @"Style");

        /// <summary>
        /// "Change the animation style of the approach circles."
        /// </summary>
        public static LocalisableString ChangeTheAnimationStyleOf => new TranslatableString(getKey(@"change_the_animation_style_of"), @"Change the animation style of the approach circles.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}