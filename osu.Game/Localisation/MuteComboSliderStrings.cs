// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class MuteComboSliderStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.MuteComboSlider";

        /// <summary>
        /// "always muted"
        /// </summary>
        public static LocalisableString AlwaysMuted => new TranslatableString(getKey(@"always_muted"), @"always muted");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}