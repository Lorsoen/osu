// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuModStrictTrackingStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuModStrictTracking";

        /// <summary>
        /// "Once you start a slider, follow precisely or get a miss."
        /// </summary>
        public static LocalisableString OnceYouStartASlider => new TranslatableString(getKey(@"once_you_start_aslider"), @"Once you start a slider, follow precisely or get a miss.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}